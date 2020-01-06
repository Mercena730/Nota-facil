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
using MySql.Data.MySqlClient;
namespace Nota_facil
{
    public partial class FrmCadastrodecliente : Form
    {
        Thread Frmmenu;
        MySqlConnection con = new MySqlConnection("server=localhost;DataBase=nota_facil;uid=root;pwd=;");
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

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcep.Clear();
            txtcpf.Clear(); 
            txtestado.Clear(); 
            txtRua.Clear();
            txtid.Clear();
            txtcidade.Clear();
            txtbairro.Clear();
            txtnumero.Clear();
            txtnome.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtcep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== Convert.ToChar(Keys.Enter))
            {
                if(!String.IsNullOrEmpty(txtcep.Text))
                {
                    using (var ws = new Wscorreios.AtendeClienteClient())
                    {
                        try
                        {
                            var Endereco = ws.consultaCEP(txtcep.Text.Trim());
                            txtestado.Text = Endereco.uf;
                            txtcidade.Text = Endereco.cidade;
                            txtbairro.Text = Endereco.bairro;
                            txtRua.Text = Endereco.end;
                            
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message,this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Informe um cep valido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btncadastro_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand com = new MySqlCommand("INSERT INTO cliente(cpf, id, Rua, cep, Estado, Numero, cidade, Bairro, Nome) VALUES ('" + txtcpf.Text + "'," + txtid.Text + ",'" + txtRua.Text + "','" + txtcep.Text + "','" + txtestado.Text + "','" + txtnumero.Text + "','" + txtcidade.Text + "','" + txtbairro.Text+"','" + txtnome.Text + "')", con);
            com.ExecuteNonQuery();
            try
            {
                MessageBox.Show("Cliente cadastrado","\n",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            
        }
    }
}
