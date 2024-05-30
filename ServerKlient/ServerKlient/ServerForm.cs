using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerKlient
{
    public partial class ServerForm : Form
    {
        TcpListener lyssnare;
        Dictionary<TcpClient, string> klientLista = new Dictionary<TcpClient, string>();
        int port = 12345;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            // Inget speciellt att göra vid laddning av formuläret för närvarande
        }

        private async void btnStarta_Click(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
                btnStarta.Enabled = false;
                await AcceptClients();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }

        private async Task AcceptClients()
        {
            while (true)
            {
                TcpClient klient = await lyssnare.AcceptTcpClientAsync();
                Task.Run(() => HandleClient(klient));
            }
        }

        private async void HandleClient(TcpClient klient)
        {
            byte[] buffert = new byte[1024];
            int n;

            try
            {
                NetworkStream stream = klient.GetStream();
                // Läser användarnamn
                n = await stream.ReadAsync(buffert, 0, buffert.Length);
                string användarnamn = Encoding.Unicode.GetString(buffert, 0, n);
                klientLista.Add(klient, användarnamn);
                BroadcastMessage($"{användarnamn} har anslutit.");

                while ((n = await stream.ReadAsync(buffert, 0, buffert.Length)) != 0)
                {
                    string meddelande = Encoding.Unicode.GetString(buffert, 0, n);
                    LoggaMeddelande(meddelande);
                    BroadcastMessage($"{användarnamn}: {meddelande}");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
            }
            finally
            {
                klientLista.Remove(klient);
                klient.Close();
            }
        }

        private void BroadcastMessage(string message)
        {
            byte[] buffert = Encoding.Unicode.GetBytes(message);
            List<TcpClient> disconnectedClients = new List<TcpClient>();

            foreach (var klient in klientLista.Keys)
            {
                try
                {
                    NetworkStream stream = klient.GetStream();
                    stream.Write(buffert, 0, buffert.Length);
                }
                catch
                {
                    disconnectedClients.Add(klient);
                }
            }

            foreach (var disconnectedClient in disconnectedClients)
            {
                klientLista.Remove(disconnectedClient);
            }
        }

        private void LoggaMeddelande(string meddelande)
        {
            if (tbxInkorg.InvokeRequired)
            {
                tbxInkorg.Invoke(new MethodInvoker(delegate { tbxInkorg.AppendText(meddelande + Environment.NewLine); }));
            }
            else
            {
                tbxInkorg.AppendText(meddelande + Environment.NewLine);
            }
        }
    }
}
