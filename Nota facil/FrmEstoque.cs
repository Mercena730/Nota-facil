using System;
using System.Threading;
using System.Windows.Forms;
namespace Nota_facil
{
    public partial class FrmEstoque : Form
    {
        Thread Frmmenu;
        public FrmEstoque()
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
    }
}
