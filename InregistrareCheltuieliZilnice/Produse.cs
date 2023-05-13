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
    public partial class Produse : Form
    {
        public Produse()
        {
            InitializeComponent();
        }

        private void Produse_Load(object sender, EventArgs e)
        {
       
            // TODO: This line of code loads data into the 'categorie._Categorie' table. You can move, or remove it, as needed.
            this.categorieTableAdapter.Fill(this.categorie._Categorie);
            // TODO: This line of code loads data into the 'produseDS.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.produseDS.Produse);
            A1();

        }

        private void A1()
        {

            //Umple cu date obiectele DataTable: Persoane, Localitati (din DataSet):
            produseTableAdapter.Fill(produseDS.Produse);

            //Configurare PB
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdPersoana
            txtIdP.ReadOnly = true;


            A3();
        }
        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            txtDenumireP.Focus();

            // Golire campuri
            golireCampuri();
        }

        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";

            //Çonfigurare(butoane)
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale
            legareControale(true);
        }
        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                txtDenumireP.Focus();
                refresh_grid(produseBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(produseBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A6()
        {
            if (lblOp.Text == "")
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSpPoza.Text = openFileDialog1.FileName;
                pb.ImageLocation = txtSpPoza.Text;
            }
        }
        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtDenumireP.Focus();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select IdProdus From CheltuieliContinut where IdProdus=" + txtIdP.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Produs referit in tabela Cheltuieli! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();

            cmd.CommandText = "Delete From Produse Where IdProdus = " + txtIdP.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(produseBindingSource.Position);

        }


        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }
        private void legareControale(bool v)
        {
            if (v)
            {
                txtDenumireP.DataBindings.Add("Text", produseBindingSource, "DenumireProdus");
                txtUM.DataBindings.Add("Text", produseBindingSource, "UM");
                txtPret.DataBindings.Add("Text", produseBindingSource, "Pret");
                txtSpPoza.DataBindings.Add("Text", produseBindingSource, "SpImagine");
                txtIdP.DataBindings.Add("Text", produseBindingSource, "IdProdus");
                cmbCategorie.DataBindings.Add("Text", produseBindingSource, "IdCategorie");
                pb.DataBindings.Add("ImageLocation", produseBindingSource, "SpImagine");

            }
            else
            {
                txtDenumireP.DataBindings.Clear();
                txtUM.DataBindings.Clear();
                txtPret.DataBindings.Clear();
                txtSpPoza.DataBindings.Clear();
                cmbCategorie.DataBindings.Clear();
                txtIdP.DataBindings.Clear();
                pb.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtDenumireP.ReadOnly = v;
            txtUM.ReadOnly = v;
            txtPret.ReadOnly = v;
            txtSpPoza.ReadOnly = v;   
        }
        private void golireCampuri()
        {
            txtDenumireP.Text = "";
            txtUM.Text = "";
            txtPret.Text = "";
            txtSpPoza.Text =  "";
            txtIdP.Text = "";
            cmbCategorie.SelectedIndex = -1;
            pb.ImageLocation = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campuri
            if (txtDenumireP.Text == "")
            {
                MessageBox.Show("Completati DenumireProdus !");
                txtDenumireP.Focus();
                return false;
            }
            if (txtUM.Text == "")
            {
                MessageBox.Show("Completati UM !");
                txtUM.Focus();
                return false;
            }
            if (txtPret.Text == "")
            {
                MessageBox.Show("Completati Pret !");
                txtPret.Focus();
                return false;
            }

            return true;
        }
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "DenumireProdus, UM, Pret, SpImagine, IdCategorie";
            listaValori = "'" + txtDenumireP.Text + "'" +
                          ",'" + txtUM.Text + "'" +
                          ",'" + txtPret.Text + "'" +
                          ",'" + txtSpPoza.Text + "'" +
                          ",'" + cmbCategorie.SelectedValue + "'";

            cmd.CommandText = "Insert into Produse(" + listaCampuri + ") " + "Select " +
                               listaValori;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void refresh_grid(int p)
        {
            produseTableAdapter.Fill(produseDS.Produse);
            produseBindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaSet = "DenumireProdus= '" + txtDenumireP.Text + "'," +
                       "UM = '" + txtUM.Text + "'," +
                       "Pret = '" + txtPret.Text + "'," +
                       "SpImagine = '" + txtSpPoza.Text + "'," +
                       "IdCategorie = '" + cmbCategorie.SelectedValue + "'";

            cmd.CommandText = "Update Produse Set " + listaSet + " Where IdProdus=" + txtIdP.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void txtSpPoza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            A6();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();

        }
    }
}
