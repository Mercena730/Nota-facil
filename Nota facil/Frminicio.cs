using System;
using System.Windows.Forms;

namespace Nota_facil
{
    public partial class Frminicio : Form
    {
        public Frminicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 1;
            if(progressBar.Value >= 100)
            {
                Frmlogin login = new Frmlogin();
                this.Hide();
                login.Show();
                timer.Enabled = true;
                progressBar.Visible = false;
                timer.Enabled = false;
            }

        }
    }
}
