using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerKlient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerForm serverForm = new ServerForm();
            serverForm.Show(); // Öppnar ServerForm som ett separat fönster
        }
    }
}
