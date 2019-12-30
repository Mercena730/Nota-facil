using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Nota_facil
{
    public partial class FrmCadastrodecliente : Form
    {
        Thread Frmmenu;
        public FrmCadastrodecliente()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmmenu = new Thread(frmmenu);
            Frmmenu.SetApartmentState(ApartmentState.MTA);
            Frmmenu.Start();
        }
        private void frmmenu()
        {
            Application.Run(new Frmmenu());
        }

        private void btnesqimg_Click(object sender, EventArgs e)
        {
            if (ofdl.ShowDialog() == DialogResult.OK)
            {
                pccliente.ImageLocation = ofdl.FileName;
            }
        }
    }
}
