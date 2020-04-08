using MySql.Data.MySqlClient;
using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
namespace Nota_facil
{
    public partial class FrmCadastrodecliente : Form
    {
        Thread Frmmenu;
        MySqlConnection con = new MySqlConnection("server=localhost;DataBase=nota_facil;uid=root;pwd=;");
        MySqlDataReader reader;
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
            if(ofdl.ShowDialog() == DialogResult.OK)
            {
                pccliente.ImageLocation = ofdl.FileName;
                txtcaminho.Text = ofdl.FileName;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcep.Clear();
            txtcpf.Clear();
            txtestado.Clear();
            txtRua.Clear();
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
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(!String.IsNullOrEmpty(txtcep.Text))
                {
                    using(var ws = new Wscorreios.AtendeClienteClient())
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
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Byte[] img = null;
            FileStream fsyrm = new FileStream(this.txtcaminho.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fsyrm);
            img = br.ReadBytes((int)fsyrm.Length);
            con.Open();
            MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO cliente(cpf, id, Rua, cep, Estado,Numero,cidade,Bairro,Nome,img) VALUES(@cpf,@id,@Rua,@cep,@Estado,@Numero,@cidade,@Bairro,@Nome,@img)",con);
            try
            {
                sqlCommand.Parameters.Add(new MySqlParameter("@cpf", txtcpf.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@id", txtid.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@Rua", txtRua.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@cep", txtcep.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@Estado", txtestado.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@Numero", txtnumero.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@cidade", txtcidade.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@Bairro", txtbairro.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@Nome", txtnome.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@img", img));
                reader = sqlCommand.ExecuteReader();
                MessageBox.Show("Cliente cadastrado", "\n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
              con.Close();
                txtcep.Clear();
                txtcpf.Clear();
                txtestado.Clear();
                txtRua.Clear();
                txtid.Clear();
                txtcidade.Clear();
                txtbairro.Clear();
                txtnumero.Clear();
                txtnome.Clear();
                txtcaminho.Clear();
                pccliente.Image = null;
                id();
            }
        }    
        private void id()
        {
            con.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM cliente", con);
            reader = comando.ExecuteReader();
            try
            {
                
                
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        int id2 = 1;
                        int id = Convert.ToInt32(reader[1].ToString());
                        int soma = id2 + id;
                        txtid.Text = Convert.ToString(soma);

                    }
                }
                
            }
            catch(Exception erro)
            {
                
                MessageBox.Show("erro" + erro);
            }
            finally
            {
                con.Close();
            }
        }

        private void FrmCadastrodecliente_Load(object sender, EventArgs e)
        {
            id();
        }
    }
}
