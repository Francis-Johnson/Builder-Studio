using LogicBuiderV._0.Utils;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicBuiderV._0
{
    public partial class editorForm : MetroForm
    {
        string comPort = null;

        public editorForm()
        {
            InitializeComponent();
        }
        string pt = "";
        bool save_flag = false;
        int countss = 0;
        int fileCount = 0,editCount = 0;

        private void fileBtn_Click(object sender, EventArgs e)
        {
            fileCount++;
            if (fileCount % 2 != 0)
            {
                fileMenu.Show(fileBtn, 0, fileBtn.Height);
            }
            else
            {
                fileMenu.Close();
            }
            
        }

        private void findToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";
            saveFileDialog.DefaultExt = ".c";
            saveFileDialog.FileName = "*.c";
            saveFileDialog.Filter = "Text Files (*.c)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                pt = path;
                if (!File.Exists(path)) //if file does not exits
                {
                    // Create a file to write to. 
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        for (int i = 0; i < textArea.Lines.Length; i++)
                        {
                            sw.WriteLine(textArea.Lines[i]);
                            countss = countss + textArea.Lines[i].Length + 1;
                            save_flag = true;
                        }

                    }
                    countss = countss - 1;
                }
                else if (File.Exists(path))  //if file is exist
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        for (int i = 0; i < textArea.Lines.Length; i++)
                        {
                            sw.WriteLine(textArea.Lines[i]);
                            countss = countss + textArea.Lines[i].Length + 1;
                            save_flag = true;
                        }

                    }
                }
            }
            int pos = path.LastIndexOf("\\");
            string ss = path.Substring(pos + 1);
           // this.Text = "Notepad - " + ss;

        }

        private void textArea_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonInitiateCommand_Click(object sender, EventArgs e)
        {
            
            GetComPorts getComPorts = new GetComPorts();
            try
            {
                List<string> names = getComPorts.ComPortNames("10C4", "EA60");
                if (names.Count > 0)
                {
                    foreach (String s in SerialPort.GetPortNames())
                    {
                        if (names.Contains(s))
                        {
                            comPort = s;
                            metroTextComPortMessage.Text = comPort;
                            //MessageBox.Show("My STM port is " + s);
                        }
                        else
                            metroTextComPortMessage.Text = " is not available now";

                    }
                }
                else
                    metroTextComPortMessage.Text= " is not available now";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            }

        private void metroButtonTxCommand_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort mySerialPort = new SerialPort();
                mySerialPort.PortName = comPort;/*"COM5";*/
                mySerialPort.BaudRate = 9600;  // Set your parameters;            
                mySerialPort.Open();
                byte[] data = Encoding.ASCII.GetBytes(metroTextBoxTxCommand.Text); // your byte data;
                mySerialPort.Write(data, 0, data.Length);
                mySerialPort.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
 
        }

        private void liveBtn_Click(object sender, EventArgs e)
        {           

                DataMonitorWindow dataMonitorWindow = new DataMonitorWindow();
                dataMonitorWindow.ShowDialog();           

            
        }

        private void metroPanelCommOprtns_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabelCommOprtns_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editCount++;
            if (editCount % 2 != 0)
            {
                editMenu.Show(fileBtn, 0, fileBtn.Height);
            }
            else
            {            
                editMenu.Close();
            }
        }
    }
}
