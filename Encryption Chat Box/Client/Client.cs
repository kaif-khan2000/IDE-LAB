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
using SimpleTcp;

namespace Client
{
    public partial class Client : Form
    {
        SimpleTcpClient client;
        public Client()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = msgBox.Text;
            client.Send(msg);
            msgBox.Text = "";
            displayBox.Text += ("Client: " + msg + "\n");

        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1",9000);
            client.Events.Connected += Connected;
            client.Events.Disconnected += Disconnected;
            client.Events.DataReceived += DataReceived;
            client.Connect();

        }

        void Connected(object sender, EventArgs e) {
            Console.WriteLine("Server connected");
        }

        void Disconnected(object sender, EventArgs e) {
            Console.WriteLine("Server disconnected");
        }

        void DataReceived(object sender, DataReceivedEventArgs e) {
            displayBox.Invoke((MethodInvoker)(() => {
                displayBox.Text += ("Server: " + Encoding.UTF8.GetString(e.Data)+"\n");
            
            }));
        }
    }
}
 