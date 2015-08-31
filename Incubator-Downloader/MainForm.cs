using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incubator_Downloader
{
    public partial class MainForm : Form
    {
        private const String FIRST_STATUS_MESSAGE = "Dupa ce ati conectat cablul de descarcare si ati selectat optiunea de descarcare din meniu, apasati butonul \"Descarca\" ";

        private string selectedPort = "";
        private bool dataSizeReceived = false;
        private List<DataItem> allData = new List<DataItem>();
        private int dataIndex = 0;
        ProgressForm progressBar;

        public MainForm()
        {
            InitializeComponent();
            lblStatus.Text = FIRST_STATUS_MESSAGE;
        }

        private void scanForPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            cbPorts.Items.Clear();

            foreach(string port in ports)
                cbPorts.Items.Add(port);
            if (ports.Length > 0)
                cbPorts.SelectedIndex = 0;
        }

        private void ExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void refreshButtonClicked(object sender, EventArgs e)
        {
            scanForPorts();
        }

        private void downloadButtonClicked(object sender, EventArgs e)
        {
            if (cbPorts.SelectedItem != null)
                serialPort.PortName = (string)cbPorts.SelectedItem;
            else
            {
                showUserMessage("Portul selectat este invalid");
                return;
            }

            try
            {
                serialPort.Open();
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.RetryCancel);
            }            

            progressBar = new ProgressForm();
            progressBar.Show();
            btnDownload.Enabled = false;
        }

        private void serialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting();
            lblStatus.Text = data;
            string[] lines = data.Split('\n');

            int i = 0;
            if (!dataSizeReceived)
                i = 1;

            if( !parseDataSize(lines[0]) )
                return;
            for (; i < lines.Length; i++ )
            {
                try
                {
                    allData.Add(new DataItem(dataIndex++, lines[i]));
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
            progressBar.Hide();
            lblStatus.Text = "Descarcare efectuata";

        }

        private bool parseDataSize(string firstLine)
        {
            if (!dataSizeReceived)
            {
                try
                {
                    int dataSize = Convert.ToInt32(firstLine);
                    dataSizeReceived = true;
                }
                catch (System.Exception ex)
                {
                    if (ex is System.FormatException || ex is System.OverflowException)
                    {
                        MessageBox.Show("Prima linie este eronata:\n" + ex.ToString(), "Eroare");
                        //TODO something here
                        return false;
                    }
                    throw;
                }
            }
            return true;
        }

        private void showUserMessage(string message)
        {
            MessageBox.Show(message, "Message");
        }

        private void viewPlotFormClicked(object sender, EventArgs e)
        {
            PlotDataForm pf = new PlotDataForm(allData);
            pf.Show();
        }
    }
}
