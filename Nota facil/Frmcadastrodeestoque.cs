using System;
using System.Threading;
using System.Windows.Forms;

namespace Nota_facil
{
    public partial class Frmcadastrodeestoque : Form
    {
        Thread Frmmenu;
        public Frmcadastrodeestoque()
        {
            InitializeComponent();
        }

        private void btnvolatr_Click(object sender, EventArgs e)
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

        private void Frmcadastrodeestoque_Load(object sender, EventArgs e)
        {

        }
    }
}
