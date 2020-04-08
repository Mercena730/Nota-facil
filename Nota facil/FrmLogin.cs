using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Nota_facil
{
    public partial class Frmlogin : Form
    {
        int count;
        Thread Frmmenu;
        int tempo = 180;
        int segundo = 0;
        int minutos = 0;
        MySqlConnection con = new MySqlConnection("server=localhost;DataBase=nota_facil;uid=root;pwd=;");
        MySqlDataReader logar;
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult fechar = MessageBox.Show("\n", "Você tem certeza quer sair?", MessageBoxButtons.YesNo);
            if(fechar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            count = count + 1;
            var user = "sara";
            var senha = "123";
           /* string senha1 = txtsenha.Text;
            string password = sha1(senha1);
            string query = "SELECT * FROM login where Usuario='" +txtusuario.Text+ "' && Senha ='" +senha1+ "'";
            MySqlCommand comando = new MySqlCommand(query, con);
            MySqlDataAdapter Data = new MySqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            Data.Fill(dt);
            if(dt.Rows.Count == 1)*/
            if(user == txtusuario.Text && senha ==txtsenha.Text)
            {

                MessageBox.Show("Bem vindo" + "\n" + txtusuario.Text);
                this.Close();
                Frmmenu = new Thread(frmmenu);
                Frmmenu.SetApartmentState(ApartmentState.MTA);
                Frmmenu.Start();
                con.Close();
            }
            else if(txtusuario.Text == "" && txtsenha.Text == "")
            {
                con.Close();
                MessageBox.Show("Preencha os campos vazio com dados pedidos");
            }
            else
            {
                con.Close();
                MessageBox.Show("Senha ou usuario Não exitem nos dados");
                if(count > 5)
                {
                    txtusuario.Enabled = false;
                    txtsenha.Enabled = false;
                    btnlogin.Enabled = false;
                    MessageBox.Show("Tentativas expiradas Sera desbloqueado assim que contador chegar 0;");
                    lbltmp.Visible = true;
                    if(tempo >= 60)
                    {
                        minutos = tempo / 60;
                        segundo = tempo % 60;
                    }
                    else
                    {
                        minutos = 0;
                        segundo = tempo;
                    }
                    lbltmp.Text = "0" + minutos + ":" + segundo;
                    TMtemp.Enabled = true;
                }
                if(count > 6)
                {
                    MessageBox.Show("Tentativas espirada");
                    Application.Exit();
                }
            }

        }
        private void frmmenu()
        {
            Application.Run(new Frmmenu());
        }

        private void TMtemp_Tick(object sender, EventArgs e)
        {
            segundo--;
            if(minutos > 0)
            {
                if(segundo < 0)
                {
                    segundo = 59;
                    minutos--;
                }
            }

            lbltmp.Text = "0" + minutos + ":" + segundo;
            if(minutos == 0 && segundo == 0)
            {
                TMtemp.Enabled = false;
                txtusuario.Enabled = true;
                txtsenha.Enabled = true;
                btnlogin.Enabled = true;
                lbltmp.Visible = false;
            }
        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                count = count + 1;

                MySqlCommand comando = new MySqlCommand("SELECT * FROM login where Usuario='" + txtusuario.Text + "' && Senha='" + txtsenha.Text +"'",con);
                con.Open();
                logar = comando.ExecuteReader();
                if(logar.HasRows)
                {

                    MessageBox.Show("Bem vindo" + "\n" + txtusuario.Text);
                    this.Close();
                    Frmmenu = new Thread(frmmenu);
                    Frmmenu.SetApartmentState(ApartmentState.MTA);
                    Frmmenu.Start();
                    con.Close();
                }
                else if(txtusuario.Text == "" && txtsenha.Text == "")
                {
                    con.Close();
                    MessageBox.Show("Preencha os campos vazio com dados pedidos");
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Senha ou usuario Não exitem nos dados");
                    if(count > 3)
                    {
                        txtusuario.Enabled = false;
                        txtsenha.Enabled = false;
                        btnlogin.Enabled = false;
                        MessageBox.Show("Tentativas expiradas Sera desbloqueado assim que contador chegar 0;");
                        lbltmp.Visible = true;
                        if(tempo >= 60)
                        {
                            minutos = tempo / 60;
                            segundo = tempo % 60;
                        }
                        else
                        {
                            minutos = 0;
                            segundo = tempo;
                        }
                        lbltmp.Text = "0" + minutos + ":" + segundo;
                        TMtemp.Enabled = true;
                    }
                }
            }
        }
    }
}

