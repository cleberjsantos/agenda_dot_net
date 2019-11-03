using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='grud';username=root;password=");
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT `login`, `senha` FROM `usuarios` WHERE `login` = '" + txtUser.Text + "'AND `senha` = '" + txtPasswd.Text + "'", conn);
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                lblWarn.Text = "Usuário ou Senha Inválido";
            } else {
                this.Hide();
                Agenda frm = new Agenda();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }
            conn.Close();
        }
    }
}
