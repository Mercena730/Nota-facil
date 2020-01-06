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
    public partial class Frmcliente : Form
    {
        Thread Frmmenu;
        MySqlConnection con = new MySqlConnection("server=localhost;DataBase=nota_facil;uid=root;pwd=;");
        MySqlDataReader ler;
        public Frmcliente()
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
        private void Frmcliente_Load(object sender, EventArgs e)
        {
            cliente();
        }
        private void cliente()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT Nome FROM cliente", con);
                con.Open();
                ler = comando.ExecuteReader();
                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        listclient.Items.Add(ler[0].ToString());
                    }
                }
                con.Close();
            }
            catch(Exception erro)
            {
                con.Close();
                MessageBox.Show("erro"+erro);
            }
        }
    }
}
