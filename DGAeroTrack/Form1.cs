using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Plottables;
using System.IO;
using System.Threading;
using System.IO.Ports;

namespace DGAeroTrack
{
    enum PlayState
    {
        play,
        pause,
        stop
    }
    enum PortState
    {
        open,
        close
    }
    public partial class Form1 : Form
    {
        readonly FormsPlot FormsPlotXY = new FormsPlot() { Dock = DockStyle.Fill };
        readonly FormsPlot FormsPlotXZ = new FormsPlot() { Dock = DockStyle.Fill };
        readonly FormsPlot FormsPlotYZ = new FormsPlot() { Dock = DockStyle.Fill };

        private SerialPort serialPort;
        private List<double> xList = new List<double>();
        private List<double> yList = new List<double>();
        private List<double> zList = new List<double>();

        private double previousTimestamp = 0;
        private int memoryPointCount = 20;





        private PlayState playState;
        private PortState serialPortState;
        private Thread readThread;
        private object lockObject;  // Shared lock object for synchronization
        string filePath;

        public Form1()
        {
            InitializeComponent();

            lockObject = new object();
            playState = PlayState.stop;
            serialPortState = PortState.close;

            yxPanel.Controls.Add(FormsPlotXY);
            zxPanel.Controls.Add(FormsPlotXZ);
            zyPanel.Controls.Add(FormsPlotYZ);

            LoadSerialPortList();
            LoadBaudRateList();
        }

        private void LoadBaudRateList()
        {
            BaudRateCmb.DataSource = new List<string>
            {
                "110", "300", "600", "1200", "2400",
                "4800", "9600", "14400", "19200", "38400",
                "56000", "57600", "115200", "128000", "256000"
            };
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Open CSV File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    // Validate and read the CSV
                    if (!ValidateCSV(filePath))
                    {
                        MessageBox.Show("The selected CSV file does not contain the required columns.", "Invalid CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool ValidateCSV(string filePath)
        {
            string[] requiredColumns = { "ts", "x", "y", "z", "qx", "qy", "qz", "qw", "markers", "conf", "residual" };
            try
            {
                // Read the first line (header) of the CSV
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string headerLine = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(headerLine))
                        return false;

                    // Split the header into columns
                    string[] headers = headerLine.Split(',');

                    // Check if all required columns are present
                    return requiredColumns.All(column => headers.Contains(column));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void StartPlot_Click(object sender, EventArgs e)
        {
            switch (playState)
            {
                case PlayState.play:
                    // If playing, pause
                    playState = PlayState.pause;
                    StartPlot.Text = "Resume Plot";
                    break;
                case PlayState.pause:
                    // If paused, resume
                    playState = PlayState.play;
                    StartPlot.Text = "Pause Plot";
                    lock (lockObject)
                    {
                        Monitor.Pulse(lockObject);  // Resume the thread execution
                    }
                    break;
                case PlayState.stop:
                    if (File.Exists(filePath))
                    {
                        readThread = new Thread(() => ReadCSVAndUpdatePlot(filePath));
                        readThread.IsBackground = true;
                        readThread.Start();
                        playState = PlayState.play;
                        StartPlot.Text = "Pause Plot";
                    }
                    else
                    {
                        MessageBox.Show("File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
        private (double ts, double x, double y, double z) ParsAeroPosition(string row)
        {
            try
            {
                string[] fields = row.Split(',');
                double ts = Convert.ToDouble(fields[0]);
                double x = Convert.ToDouble(fields[1]);
                double y = Convert.ToDouble(fields[2]);
                double z = Convert.ToDouble(fields[3]);
                return (ts, x, y, z);
            }
            catch (Exception ex)
            {
                throw new FormatException("Error parsing CSV fields.", ex);
            }
        }
        private double UpdateLists(string row)
        {
            var (ts, x, y, z) = ParsAeroPosition(row);
       
            xList.Add(x);
            yList.Add(y);
            zList.Add(z);
            if (xList.Count() >= memoryPointCount)
            {
                xList.RemoveAt(0);
                yList.RemoveAt(0);
                zList.RemoveAt(0);
            }
            return ts;
        }
        private void ClearList()
        {
            xList.Clear();
            yList.Clear();
            zList.Clear();
            this.Invoke((MethodInvoker)delegate
            {
                XLbl.Text = "";
                YLbl.Text = "";
                ZLbl.Text = "";
            });
        }
        private void ReadCSVAndUpdatePlot(string filePath)
        {

            previousTimestamp = 0;
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Skip header
                    reader.ReadLine();

                    // clear lists to store the data 

                    ClearList();
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {

                        var ts = UpdateLists(line);

                        if (previousTimestamp > 0)
                        {
                            double timeDifference = ts - previousTimestamp;
                            Thread.Sleep((int)(timeDifference * 1000));
                        }


                        previousTimestamp = ts;

                        if (playState == PlayState.stop)
                        {
                            break;
                        }

                        UpdatePlots();

                        if (playState == PlayState.pause)
                        {
                            lock (lockObject)
                            {
                                while (playState == PlayState.pause) // Check condition to avoid spurious wakeups
                                {
                                    Monitor.Wait(lockObject);  // Wait for resume signal
                                }
                            }
                        }
                    }
                }

                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("CSV file read and plotted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"Error reading CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
            }
            finally
            {
                this.Invoke((MethodInvoker)delegate
                {
                    playState = PlayState.stop;
                    StartPlot.Text = "Play";
                });
            }
        }

        private void UpdatePlots()
        {

            this.Invoke((MethodInvoker)delegate
            {
                FormsPlotXY.Plot.Clear();
                FormsPlotXY.Plot.Add.Scatter(xList.ToArray(), yList.ToArray());
                FormsPlotXY.Plot.Add.Legend();
                FormsPlotXY.Plot.Title("XY Trajectory");
                FormsPlotXY.Plot.XLabel("X");
                FormsPlotXY.Plot.YLabel("Y");

                FormsPlotXZ.Plot.Clear();
                FormsPlotXZ.Plot.Add.Scatter(xList.ToArray(), zList.ToArray());
                FormsPlotXZ.Plot.Title("XZ Trajectory");
                FormsPlotXZ.Plot.XLabel("X");
                FormsPlotXZ.Plot.YLabel("Z");

                FormsPlotYZ.Plot.Clear();
                FormsPlotYZ.Plot.Add.Scatter(yList.ToArray(), zList.ToArray());
                FormsPlotYZ.Plot.Title("YZ Trajectory");
                FormsPlotYZ.Plot.XLabel("Y");
                FormsPlotYZ.Plot.YLabel("Z");

                XLbl.Text = xList.Last().ToString();
                YLbl.Text = yList.Last().ToString();
                ZLbl.Text = zList.Last().ToString();

                FormsPlotXY.Plot.Axes.AutoScale();  // Automatically adjusts the axis range for the XY plot
                FormsPlotXZ.Plot.Axes.AutoScale();  // Automatically adjusts the axis range for the XZ plot
                FormsPlotYZ.Plot.Axes.AutoScale();
                FormsPlotXY.Refresh();
                FormsPlotXZ.Refresh();
                FormsPlotYZ.Refresh();
            });
        }


        private void StopPlot_Click(object sender, EventArgs e)
        {
            if (playState == PlayState.play || playState == PlayState.pause)
            {



                StartPlot.Text = "Start Plot";
                playState = PlayState.stop;
                readThread?.Abort();

                StartPlot.Text = "Start Plot";
                this.Invoke((MethodInvoker)delegate
                {
                    FormsPlotXY.Plot.Clear();
                    FormsPlotXZ.Plot.Clear();
                    FormsPlotYZ.Plot.Clear();

                    FormsPlotXY.Refresh();
                    FormsPlotXZ.Refresh();
                    FormsPlotYZ.Refresh();
                });
            }
        }

        private void refreshDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSerialPortList();
        }

        private void LoadSerialPortList()
        {
            if (serialPort == null)
                return;

            if (!serialPort.IsOpen)
            {
                SerialPortCmb.DataSource = SerialPort.GetPortNames();
            }
        }

        private void SerialConnectBtn_Click(object sender, EventArgs e)
        {
            switch (serialPortState)
            {
                case PortState.open:
                    if (serialPort.IsOpen)
                        serialPort.Close();

                    ClearList();
                    serialPortState = PortState.close;
                    SerialConnectBtn.Text = "Connect";
                    break;

                case PortState.close:
                    ClearList();
                    serialPort = new SerialPort(SerialPortCmb.SelectedText);
                    serialPort.BaudRate = int.Parse(BaudRateCmb.SelectedText);
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;
                    serialPort.DataBits = 5;
                    serialPort.Handshake = Handshake.None;
                    serialPort.Open();
                    serialPort.DataReceived += SerialPortDataHandle;
                    serialPort.WriteLine("connected");
                    serialPortState = PortState.open;
                    SerialConnectBtn.Text = "Close";
                    break;
            }

        }

        private void SerialPortDataHandle(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting();

            var ts = UpdateLists(data);

            UpdatePlots();
        }
    }
}
