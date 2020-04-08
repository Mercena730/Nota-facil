using System;
using System.Threading;
using System.Windows.Forms;

namespace Nota_facil
{
    public partial class Frmmenu : Form
    {
        Thread frmcliente;
        Thread frmcadastrodecliente;
        Thread frmcaixa;
        Thread frmestoque;
        Thread frmcadastrodeestoque;
        Thread frmcategoria;
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult fechar = MessageBox.Show("\n", "Você tem certeza quer sair?", MessageBoxButtons.YesNo);
            if(fechar == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void pgcliente_Click(object sender, EventArgs e)
        {
            this.Close();
            frmcliente = new Thread(Frmcliente);
            frmcliente.SetApartmentState(ApartmentState.MTA);
            frmcliente.Start();

        }
        private void pgcadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            frmcadastrodecliente = new Thread(Frmcadastrodecliente);
            frmcadastrodecliente.SetApartmentState(ApartmentState.STA);
            frmcadastrodecliente.Start();
        }
        private void pgcaixa_Click(object sender, EventArgs e)
        {
            this.Close();
            frmcaixa = new Thread(Frmcaixa);
            frmcaixa.SetApartmentState(ApartmentState.MTA);
            frmcaixa.Start();

        }
        private void pgestoque_Click(object sender, EventArgs e)
        {
            this.Close();
            frmestoque = new Thread(Frmestoque);
            frmestoque.SetApartmentState(ApartmentState.MTA);
            frmestoque.Start();

        }
        private void pgcadestoque_Click(object sender, EventArgs e)
        {
            this.Close();
            frmcadastrodeestoque = new Thread(Frmcadastrodeestoque);
            frmcadastrodeestoque.SetApartmentState(ApartmentState.STA);
            frmcadastrodeestoque.Start();
        }
        private void Frmcliente()
        {
            Application.Run(new Frmcliente());
        }
        private void Frmcadastrodecliente()
        {
            Application.Run(new FrmCadastrodecliente());
        }
        private void Frmcaixa()
        {
            Application.Run(new Frmcaixa());
        }
        private void Frmestoque()
        {
            Application.Run(new FrmEstoque());
        }
        private void Frmcadastrodeestoque()
        {
            Application.Run(new Frmcadastrodeestoque());
        }
        private void Frmcategoria()
        {
            Application.Run(new FrmCategoria());
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmcadastrodecliente = new Thread(Frmcadastrodecliente);
            frmcadastrodecliente.SetApartmentState(ApartmentState.STA);
            frmcadastrodecliente.Start();
        }
        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmcadastrodeestoque = new Thread(Frmcadastrodeestoque);
            frmcadastrodeestoque.SetApartmentState(ApartmentState.STA);
            frmcadastrodeestoque.Start();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmcliente = new Thread(Frmcliente);
            frmcliente.SetApartmentState(ApartmentState.MTA);
            frmcliente.Start();
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmestoque = new Thread(Frmestoque);
            frmestoque.SetApartmentState(ApartmentState.MTA);
            frmestoque.Start();
        }
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmcategoria = new Thread(Frmcategoria);
            frmcategoria.SetApartmentState(ApartmentState.STA);
            frmcategoria.Start();
        }
    }
}
