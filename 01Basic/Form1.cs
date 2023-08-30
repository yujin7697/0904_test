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

namespace _01Basic
{
    public partial class winform : Form
    {
        private SerialPort serialPort = new SerialPort();
        public winform()
        {
            InitializeComponent();
        }

        private void PortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void SerialPort_DataRecv(object sender, SerialDataReceivedEventArgs e)
        {
            String recvData = this.serialPort.ReadExisting();
            Console.WriteLine(recvData);
        }
        private void conn_btn_Click(object sender, EventArgs e)
        {
           
            
                this.serialPort.PortName = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString();
                this.serialPort.BaudRate = 9600;
                this.serialPort.DataBits = 8;
                this.serialPort.StopBits = System.IO.Ports.StopBits.One;
                this.serialPort.Parity = System.IO.Ports.Parity.None;
                Console.WriteLine(PortNumber.Items[this.PortNumber.SelectedIndex]+" CONN");
                this.serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataRecv);
            label2.Text = PortNumber.Items[this.PortNumber.SelectedIndex] + " CONN";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 ON CLICKED");
            label2.Text = "LED_01 ON SUCCESS";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 OFF CLICKED");
            label2.Text = "LED_01 OFF SUCCESS";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 ON CLICKED");
            label2.Text = "LED_02 ON SUCCESS";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 OFF CLICKED");
            label2.Text = "LED_02 OFF SUCCESS";
        }

        
    }
}
