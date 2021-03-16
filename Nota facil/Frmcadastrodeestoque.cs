using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace Nota_facil
{
    public partial class Frmcadastrodeestoque : Form
    {
        Thread Frmmenu;
        MySqlConnection con = new MySqlConnection("server=localhost:8080;DataBase=nota_facil;uid=root;pwd=;");
        MySqlDataReader ler;
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
            Subcategoria();
            Categoria();
        }
        private void Btncadastra_Click(object sender, EventArgs e)
        {
            Byte[] img = null;
            FileStream fsyrm = new FileStream(this.txtcaminho.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fsyrm);
            img = br.ReadBytes((int)fsyrm.Length);
            try
            {
                con.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO tb_produto(ID,Nome,categoria,subcategoria,preco, img,quantidade) VALUES(@ID,@Nome,@categoria,@subcategoria,@preco,@img,@quantidade)", con);
                sqlCommand.Parameters.Add(new MySqlParameter("@ID", txtid.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@Nome", txtdescricao.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@categoria", cmbcatecoria.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@subcategoria", cmbsubcategoria.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@preco", txtvalor.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@img", img));
                sqlCommand.Parameters.Add(new MySqlParameter("@quantidade", txtquan.Text));
                ler = sqlCommand.ExecuteReader();
                MessageBox.Show("produto cadastrado", "\n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                txtcaminho.Clear();
                txtdescricao.Clear();
                txtid.Clear();
                cmbcatecoria.Text = null;
                cmbsubcategoria.Text = null;
                pcbproduto.ImageLocation = null;
                txtvalor.Clear();

            }
        }

        private void Btnfoto_Click(object sender, EventArgs e)
        {
            if(ofdl.ShowDialog() == DialogResult.OK)
            {
                pcbproduto.ImageLocation = ofdl.FileName;
                txtcaminho.Text = ofdl.FileName;
            }
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            txtvalor.Clear();
            txtcaminho.Clear();
            txtdescricao.Clear();
            txtid.Clear();
            cmbcatecoria.Text = null;
            cmbsubcategoria.Text = null;
            pcbproduto.ImageLocation = null;
        }
        private void Subcategoria()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT subcategoria FROM categoria", con);
                con.Open();
                ler = comando.ExecuteReader();
                if(ler.HasRows)
                {
                    while(ler.Read())
                    {
                        cmbsubcategoria.Items.Add(ler[0].ToString());
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
        private void Categoria()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM categoria", con);
                con.Open();
                ler = comando.ExecuteReader();
                if(ler.HasRows)
                {
                    while(ler.Read())
                    {
                        cmbcatecoria.Items.Add(ler[1].ToString());
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
    }
}

