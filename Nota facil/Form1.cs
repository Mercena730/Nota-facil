using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nota_facil
{
    public partial class Frmin : Form
    {
        public Frmin()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 1;
            if(progressBar.Value>=100)
            {
                FrmLogin login = new FrmLogin();
                this.Hide();
                login.Show();
                timer.Enabled = true;
                progressBar.Visible = false;
                timer.Enabled = false;
            }
           
        }
    }
}
