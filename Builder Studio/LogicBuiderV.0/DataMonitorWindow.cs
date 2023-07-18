using LogicBuiderV._0.Utils;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LogicBuiderV._0
{
    public partial class DataMonitorWindow : MetroForm
    {
        static string receivedInfo = null;
        //static DataMonitorWindow dataMonitorWindowFormObj = new DataMonitorWindow();
        //Handler handler = new Handler(dataMonitorWindowFormObj);
        private Handler handler = null;
        string comPort = null;
        //SerialPort serialPort = null;
       // SerialPort mySerialPort = null;
        string bufferData = null;

        public DataMonitorWindow()
        {
            InitializeComponent();
        }      

        private void dataMonitorWindow_Load(object sender, EventArgs e)
        {
             handler = new Handler();
        }
        public void BeginDataTransaction() {

            int baudRate = 9600;
            comPort = handler.GetConnectedComPort();
            string command = "#RQST_ID\r";

            handler.ReceivedDataChanged += handler_ReceivedDataChanged;
            handler.SendAndReceiveData(comPort, baudRate, command);

        }
        void handler_ReceivedDataChanged(object sender, EventArgs e)
        {
            UpdateReceivedInfoEventArgs arg = e as UpdateReceivedInfoEventArgs;

            if (this.dMWindowDisplay.InvokeRequired)
            {
                this.dMWindowDisplay.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.dMWindowDisplay.Text = arg.receivedData;
                });
            }
            else
            {
                this.dMWindowDisplay.Text = arg.receivedData;
            }
        }
        private void dMWindowStartBtn_Click(object sender, EventArgs e)
        {

         
            //int baudRate = 9600;

            //comPort = handler.GetConnectedComPort();
            //string command = "#RQST_ID\r";
            //string command = "#RQST_8548_DATA\r";
            try
            {

                Thread t = new Thread(new ThreadStart(BeginDataTransaction));
                t.Start();
            }
            catch (Exception)
            {

                throw;
            }
         
        }


        private void dMWindowStopBtn_Click(object sender, EventArgs e)
        {
            handler.CloseSerialPort();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
