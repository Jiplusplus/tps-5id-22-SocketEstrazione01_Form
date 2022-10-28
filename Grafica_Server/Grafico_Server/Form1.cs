using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Grafico_Server
{
    public partial class Form1 : Form
    {
        byte[] bytes = new Byte[1024];
        byte[] msg;
        IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
        public string data = null;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void avvia_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(startListening));
            t.Start();
        }

        public void startListening()
        {
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    MessageBox.Show("Waiting for a connection...");
                    Socket handler = listener.Accept();
                    data = null;

                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        break;
                    }

                    Random r = new Random();
                    int n = r.Next(1, 10);
                    list_eventi.Items.Add("Numero generato : " + n.ToString());

                    if (n > Convert.ToInt32(data))
                    {
                        msg = Encoding.ASCII.GetBytes(n.ToString() + " e' il numero casuale");
                        handler.Send(msg);
                    }
                    else if (n == Convert.ToInt32(data))
                    {
                        msg = Encoding.ASCII.GetBytes(n.ToString() + " i numeri sono uguali");
                        handler.Send(msg);
                    }
                    else
                    {
                        msg = Encoding.ASCII.GetBytes(data.ToString() + " e' il numero inserito dall'utente");
                        handler.Send(msg);
                    }
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                list_eventi.Items.Add(e.ToString());
            }

        }
    }
}

