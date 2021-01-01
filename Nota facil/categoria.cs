using MySql.Data.MySqlClient;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Nota_facil
{
    public partial class categoria : Form
    {
        Thread frmmenu;
        MySqlConnection con = new MySqlConnection("server=localhost;DataBase=nota_facil;uid=root;pwd=;");
        MySqlDataReader Reader;
        public categoria()
        {
            InitializeComponent();
        }
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmenu = new Thread(Frmmenu);
            frmmenu.SetApartmentState(ApartmentState.MTA);
            frmmenu.Start();
        }
        private void Frmmenu()
        {
            Application.Run(new Frmmenu());
        }

        private void btncadastra_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO categoria(categoria,subcategoria) VALUES(@categoria,@subcategoria)", con);
            try
            {
                sqlCommand.Parameters.Add(new MySqlParameter("@categoria", txtcategoria.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@subcategoria", txtsubcategoria.Text));
                Reader = sqlCommand.ExecuteReader();
                MessageBox.Show("produto cadastrado", "\n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                txtcategoria.Clear();
                txtsubcategoria.Clear();

            }
        }
    }
}

