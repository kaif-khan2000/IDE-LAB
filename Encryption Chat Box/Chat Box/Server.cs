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
using System.Threading;
using SimpleTcp;
namespace Chat_Box
{
    public partial class Server : Form
    {
        
        public Server()
        {
            InitializeComponent();
           
            
        }

        SimpleTcpServer server;
        static string clientAdress = "";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void Server_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer("127.0.0.1", 9000);
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;
            server.Start();
        }

        void ClientConnected(object sender, ClientConnectedEventArgs e) {
            clientAdress = e.IpPort;
            Console.WriteLine("client connected");
        }

        void ClientDisconnected(object sender, ClientDisconnectedEventArgs e) {
            Console.WriteLine("Client disconnected");
        }

        void DataReceived(object sender, DataReceivedEventArgs e) {
            displayBox.Invoke((MethodInvoker)(() =>
            {
                displayBox.Text += ("Client: " + Encoding.UTF8.GetString(e.Data) + "\n ");
            }));    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = msgBox.Text;
            server.Send(clientAdress, msg);
            msgBox.Text = "";
            displayBox.Text += ("Server: " + msg + "\n");
        }
    }
}
