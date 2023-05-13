using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InregistrareCheltuieliZilnice
{
    public partial class Login : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public Login()
        {
            InitializeComponent();
        }
        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            labelTitlu.Visible = !v;
            labelAutor.Visible = !v;
            labelParola.Visible = v;
            txtpassword.Visible = v;
            labelUsername.Visible = v;
            txtuser.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";
        }
        private Boolean Logare_OK()
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtuser.Focus();
                return false;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtpassword.Focus();
                return false;
            }

            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = C:\\Users\\Cris\\Documents\\Uni\\A3-S1\\TPA\\Proiect\\InregistrareCheltuieliZilnice\\DBProiect.accdb";
            cmd.Connection = con;
            cmd.CommandText = "Select IdUtilizator,Parola from Utilizatori " +
                              "where Nume='" + txtuser.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtpassword.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtpassword.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtuser.Focus();
                con.Close();
                return false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produse p1 = new Produse();
            p1.Show();
        }

        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorii c1 = new Categorii();
            c1.Show();
        }

        private void cheltuieliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cheltuieli c2 = new Cheltuieli();
            c2.Show();
        }
    }
}
