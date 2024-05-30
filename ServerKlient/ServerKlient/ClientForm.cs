using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerKlient
{
    public partial class ClientForm : Form
    {
        TcpClient klient;
        NetworkStream stream;
        int port = 12345;
        string användarnamn;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // Inget speciellt att göra vid laddning av formuläret för närvarande
        }

        private async void LäsMeddelanden()
        {
            byte[] buffert = new byte[1024];
            int n;

            try
            {
                while ((n = await stream.ReadAsync(buffert, 0, buffert.Length)) != 0)
                {
                    string meddelande = Encoding.Unicode.GetString(buffert, 0, n);
                    VisaMeddelande(meddelande);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
            }
        }

        private void VisaMeddelande(string meddelande)
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

        private async void btnAnslut_Click_1(object sender, EventArgs e)
        {
            användarnamn = tbxAnvändarnamn.Text;
            if (string.IsNullOrEmpty(användarnamn))
            {
                MessageBox.Show("Vänligen ange ett användarnamn.");
                return;
            }

            try
            {
                klient = new TcpClient();
                await klient.ConnectAsync("127.0.0.1", port);
                stream = klient.GetStream();
                byte[] användarnamnBuffert = Encoding.Unicode.GetBytes(användarnamn);
                await stream.WriteAsync(användarnamnBuffert, 0, användarnamnBuffert.Length);
                Task.Run(() => LäsMeddelanden());
                btnAnslut.Enabled = false;
                btnSkicka.Enabled = true;
                btnBifoga.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
            }
        }

        private async void btnSkicka_Click_1(object sender, EventArgs e)
        {
            if (klient != null && stream != null)
            {
                string meddelande = tbxMeddelande.Text;
                byte[] buffert = Encoding.Unicode.GetBytes(meddelande);
                await stream.WriteAsync(buffert, 0, buffert.Length);
                tbxMeddelande.Clear();
            }
        }

        private void btnBifoga_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filväg = openFileDialog.FileName;
                    byte[] filinnehåll = System.IO.File.ReadAllBytes(filväg);
                    byte[] filnamnBuffert = Encoding.Unicode.GetBytes(System.IO.Path.GetFileName(filväg));
                    byte[] meddelandeBuffert = Encoding.Unicode.GetBytes($"{användarnamn} bifogar en fil: ");
                    Task.Run(async () =>
                    {
                        await stream.WriteAsync(meddelandeBuffert, 0, meddelandeBuffert.Length);
                        await stream.WriteAsync(filnamnBuffert, 0, filnamnBuffert.Length);
                        await stream.WriteAsync(filinnehåll, 0, filinnehåll.Length);
                    });
                }
            }
        }

        private void tbxAnvändarnamn_TextChanged(object sender, EventArgs e)
        {
  
        }

        private async void btnLoggaUt_Click(object sender, EventArgs e)
        {
            try
            {
                if (klient != null && stream != null)
                {
                    byte[] buffert = Encoding.Unicode.GetBytes($"{användarnamn} har loggat ut.");
                    await stream.WriteAsync(buffert, 0, buffert.Length);
                    klient.Close();
                    btnAnslut.Enabled = true;
                    btnSkicka.Enabled = false;
                    btnBifoga.Enabled = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
            }
        }
    }
}
