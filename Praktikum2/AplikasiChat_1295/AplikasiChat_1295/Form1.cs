using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace AplikasiChat_1295
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string textsend;

        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress address in localIP)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtIpC.Text = address.ToString();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtPortS.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(txtIpC.Text), int.Parse(txtPortC.Text));

            try
            {
                client.Connect(IP_End);
                if (client.Connected)
                {
                    txtChat.AppendText("Connected To Server"+"\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtPesan.Text != "")
            {
                textsend = txtPesan.Text;
                backgroundWorker2.RunWorkerAsync();
                txtPesan.Text = "";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                if(client.Connected)
                {
                    STW.WriteLine(textsend);
                    this.txtChat.Invoke(new MethodInvoker(delegate (){ txtChat.AppendText("Saya : " + textsend + "\n"); }));
                    
                }else
                {
                    MessageBox.Show("Send Failed!");
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
                try
                {
                    receive = STR.ReadLine();
                    this.txtChat.Invoke(new MethodInvoker(delegate () { txtChat.AppendText("Anda : " + receive + "\n"); }));
                    receive = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            
        }
    }
}
