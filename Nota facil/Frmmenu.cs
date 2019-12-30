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
    public partial class Frmmenu : Form
    {
        Thread frmcliente;
        Thread frmcadastrodecliente;
        Thread frmcaixa;
        Thread frmestoque;
        Thread frmcadastrodeestoque;
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            frmcadastrodecliente.SetApartmentState(ApartmentState.MTA);
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
            frmcadastrodeestoque.SetApartmentState(ApartmentState.MTA);
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
    }
}
