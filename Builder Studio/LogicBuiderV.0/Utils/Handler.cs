using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LogicBuiderV._0.Utils
{
    public class UpdateReceivedInfoEventArgs : EventArgs
    {
        public string receivedData { get; set; }
    }
    public class Handler
    {
        public event EventHandler ReceivedDataChanged;

        private System.Timers.Timer aTimer;
        static SerialPort serialPort = null;
        string comPort = null;
        string processedData = null;
        public static int processedId = 0;

        public Handler() { }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        public string GetConnectedComPort()
        {

            GetComPorts getComPorts = new GetComPorts();

            List<string> names = getComPorts.ComPortNames("10C4", "EA60");
            if (names.Count > 0)
            {
                foreach (String s in SerialPort.GetPortNames())
                {
                    if (names.Contains(s))
                    {
                        comPort = s;
                        return comPort;
                        //MessageBox.Show("My STM port is " + s);
                    }


                }
            }

            return comPort;
        }
        public void SendSerialData(string sendData)
        {
            try
            {
                SerialPort mySerialPort = new SerialPort();
                mySerialPort.PortName = comPort;/*"COM5";*/
                mySerialPort.BaudRate = 9600;  // Set your parameters;            
                mySerialPort.Open();
                byte[] data = Encoding.ASCII.GetBytes(sendData); // your byte data;
                mySerialPort.Write(data, 0, data.Length);
                mySerialPort.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SendAndReceiveData(string comPort, int baudRate, string command)
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = comPort;/*"COM5";*/
                serialPort.BaudRate = baudRate;  // Set your parameters;            
                serialPort.Open();
                char[] ch = new char[100];
                char[] receivedData = new char[100];
                int i = 0;

                byte[] data = Encoding.ASCII.GetBytes("\r"); //Send Enter character '\r';
                serialPort.Write(data, 0, data.Length);

                bool startbit = false;
                bool breakLoop = false;
                while (breakLoop == false)
                {
                    char c = (char)serialPort.ReadChar();
                    ch[i] = c;

                    if (ch[i] == ':')
                    {
                        data = Encoding.ASCII.GetBytes(command); //Send RQST_ID;
                        serialPort.Write(data, 0, data.Length);

                    }
                    if (ch[i] == '|' && startbit == true)       //Identify stop '|' bit;
                    {
                        ch[i] = '\0';
                        startbit = false;
                        breakLoop = true;
                        break;

                    }
                    if (ch[i] == '|' && startbit == false)      //Identify start '|' bit;
                    {
                        startbit = true;
                        i = 0;
                        Array.Clear(ch, 0, ch.Length);

                    }

                    else
                    {
                        i++;
                    }


                }

                processedData = new string(ch);

                int.TryParse(processedData, out processedId);

                if (processedId > 0)
                {
                    SetTimer();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //return processedData;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (processedId > 0)
            {
                string processedData = null;
                List<char> chp = new List<char>();
                char c = '\0';
                char[] receivedData = new char[100];
                int i = 0;
                bool startbit = false;
                bool breakDataLoop = false;


                string command = "#RQST_" + processedId + "_DATA\r";
                byte[] data = Encoding.ASCII.GetBytes("\r"); //Send Enter character '\r';
                serialPort.DiscardInBuffer();
                serialPort.Write(data, 0, data.Length);

                while (breakDataLoop == false)
                {
                    c = (char)serialPort.ReadChar();

                    chp.Add(c);
                    chp.ToArray();

                    if (chp[i] == ':')
                    {
                        serialPort.DiscardInBuffer();
                        data = Encoding.ASCII.GetBytes(command); //Send "#RQST_" + processedData + "_DATA";
                        serialPort.Write(data, 0, data.Length);

                    }
                    if ((chp[i] == '|') && (startbit == true))       //Identify stop '|' bit;
                    {
                        startbit = false;
                        breakDataLoop = true;
                        break;

                    }
                    if ((chp[i] == '|') && (startbit == false))      //Identify start '|' bit;
                    {
                        startbit = true;
                        i = 0;
                        chp.Clear();
                    }

                    else
                    {
                        i++;
                    }


                }

                processedData = string.Join("", chp.ToArray());
                processedData = processedData.TrimEnd(processedData[processedData.Length - 1]);
                UpdateReceivedInfoEventArgs arg = new UpdateReceivedInfoEventArgs() { receivedData = processedData.ToString() };
                ReceivedDataChanged(this, arg);
                Console.WriteLine(processedData);

            }
        }
        public void CloseSerialPort()
        {
            if (aTimer != null)
            {
                aTimer.Stop();
                aTimer.Dispose();
            }
            if (serialPort != null)
            {
                serialPort.Close();
            }


        }

    }
}
