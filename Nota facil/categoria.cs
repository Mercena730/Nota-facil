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
            MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO tb_produto(ID,Nome,categoria,subcategoria, preco, img) VALUES(@ID,@Nome,@categoria,@subcategoria,@preco,@img)", con);
            try
            {
                sqlCommand.Parameters.Add(new MySqlParameter("@ID", txtid.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@Nome", txtdescricao.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@categoria", cmbcatecoria.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@subcategoria", cmbsubcategoria.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@preco", txtvalor.Text));
                sqlCommand.Parameters.Add(new MySqlParameter("@img", img));
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
}
