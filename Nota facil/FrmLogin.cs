using MySql.Data.MySqlClient;
using System;
using System.Data;
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
        MySqlConnection conexao = new MySqlConnection("server=localhost; database=login; username=root; password=;");

        public Frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            count = count + 1;
            string query = "SELECT * FROM cadastro WHERE Usuario='" + txtusuario.Text + "' && Senha='" + txtsenha.Text + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            data.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                MessageBox.Show("Bem vindo" + "  " + txtusuario.Text);
                this.Close();
                Frmmenu = new Thread(frmmenu);
                Frmmenu.SetApartmentState(ApartmentState.MTA);
                Frmmenu.Start();

            }
            else
            {
                MessageBox.Show("Senha ou usuario Não exitem nos dados");
                if (count > 3)
                {
                    txtusuario.Enabled = false;
                    txtsenha.Enabled = false;
                    btnlogin.Enabled = false;
                    MessageBox.Show("Tentativas expiradas Sera desbloqueado assim que contador chegar 0;");
                    lbltmp.Visible = true;
                    if (tempo >= 60)
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

        private void frmmenu()
        {
            Application.Run(new Frmmenu());
        }

        private void TMtemp_Tick(object sender, EventArgs e)
        {
            segundo--;
            if (minutos > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                    minutos--;
                }
            }

            lbltmp.Text = "0" + minutos + ":" + segundo;
            if (minutos == 0 && segundo == 0)
            {
                TMtemp.Enabled = false;
                txtusuario.Enabled = true;
                txtsenha.Enabled = true;
                btnlogin.Enabled = true;
                lbltmp.Visible = false;
            }
        }
    }
}

