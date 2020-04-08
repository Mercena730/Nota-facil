using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.IO;
namespace Nota_facil
{
    public partial class Frmcliente : Form
    {
        Thread Frmmenu;
        MySqlConnection con = new MySqlConnection("server=localhost;DataBase=nota_facil;uid=root;pwd=;");
        MySqlDataReader ler;
        string Nome;
        public Frmcliente()
        {
            InitializeComponent();
        }
        private void frmmenu()
        {
            Application.Run(new Frmmenu());
        }
        private void cliente()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT Nome FROM cliente", con);
                con.Open();
                ler = comando.ExecuteReader();
                if(ler.HasRows)
                {
                    while(ler.Read())
                    {
                        listclient.Items.Add(ler[0].ToString());
                    }
                }
                con.Close();
            }
            catch(Exception erro)
            {
                con.Close();
                MessageBox.Show("erro" + erro);
            }
        }
        private void txtpesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                listclient.Items.Clear();
                txtpesquisa.Clear();
                cliente();
            }

        }
        private void listclient_MouseClick(object sender, MouseEventArgs e)
        {
            Nome = listclient.SelectedItem.ToString();
            try
            {
                MySqlCommand comando = new MySqlCommand("select * from cliente where Nome='" + Nome + "'", con);
                con.Open();
                ler = comando.ExecuteReader();
                if(ler.HasRows)
                {
                    while(ler.Read())
                    {
                        string dados ="cpf:"+ler.GetString("cpf")+"\n"+ler.GetString("Rua")+"\n"+"Cep:"+ler.GetString("cep")+"\n"+"Estado:"+ler.GetString("Estado")+"\n"+"Numero: "+ler.GetString("Numero")+"\n"+"cidade:"+ler.GetString("cidade")+"\n"+"bairro:"+ler.GetString("Bairro");
                        string stringComOCaracter=dados;
                        string stringTratada;
                        stringTratada = stringComOCaracter.Replace("\n", Environment.NewLine);
                        txtdadoscliente.Text =stringTratada;
                        Byte[] img = (Byte[])(ler["img"]);
                        if(img == null)
                        {
                            imgcliente.ImageLocation= "C:/git/Infor ramos/Nota facil/Nota facil/bin/Debug/Fotos/user.jpg";
                        }
                        else
                        {
                            MemoryStream memory = new MemoryStream(img);
                            imgcliente.Image = System.Drawing.Image.FromStream(memory);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cliente não encontrado na base de dados" + MessageBoxIcon.Error);
            }
            finally
            {
              con.Close();
            }
        }
        private void Frmcliente_Load(object sender, EventArgs e)
        {
            cliente();
        }
        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            listclient.Items.Clear();
            if(txtpesquisa.Text.Length > 0)
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand("select Nome from cliente where Nome='" + txtpesquisa.Text + "'", con);
                    con.Open();
                    ler = comando.ExecuteReader();
                    if(ler.HasRows)
                    {
                        while(ler.Read())
                        {
                            listclient.Items.Add(ler[0].ToString());
                        }
                    }
                    con.Close();
                }
                catch
                {
                    con.Close();
                    MessageBox.Show("Cliente não encontrado na base de dados" + MessageBoxIcon.Error);
                }
            }
            if(txtpesquisa.Text.Length >= 1)
            {
                listclient.Items.Clear();
                try
                {
                    MySqlCommand comando = new MySqlCommand("select Nome from cliente where Nome like'%" + txtpesquisa.Text + "%'", con);
                    con.Open();
                    ler = comando.ExecuteReader();
                    if(ler.HasRows)
                    {
                        while(ler.Read())
                        {
                            listclient.Items.Add(ler[0].ToString());
                        }
                    }
                    con.Close();
                    if(listclient.Items.Count == 0)
                    {
                        MessageBox.Show("Cliente nâo econtrado", "\n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cliente();
                    }
                }
                catch(Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex + "\n" + MessageBoxIcon.Error);
                }
            }

            else if(txtpesquisa.Text.Length == 0)
            {
                MessageBox.Show("Insira um nome no campo vazio");
                cliente();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmmenu = new Thread(frmmenu);
            Frmmenu.SetApartmentState(ApartmentState.MTA);
            Frmmenu.Start();
        }
    }
}

