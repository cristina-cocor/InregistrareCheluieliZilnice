using InregistrareCheltuieliZilnice.ProduseDSTableAdapters;
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
    public partial class FCheltuieliAct : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;
        public FCheltuieliAct()
        {
            InitializeComponent();
        }

        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }
        private void completeazaCheltuiala()
        {
            DataRowView current = (DataRowView)bs1.Current;

            idCda = (int)current["IdCheltuiala"];

            cmbCategorie.Text = current["DenumireCategorie"].ToString();

            dateTimePicker1.Value = Convert.ToDateTime(current["Data"]);

            bs2.MoveFirst();

            cheltuieliDS.cheltuialaContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                CheltuieliDS.cheltuialaContinutManevraRow r = cheltuieliDS.cheltuialaContinutManevra.NewcheltuialaContinutManevraRow();
                r.DenumireProdus = Convert.ToString(current["DenumireProdus"]);
                r.UM = Convert.ToString(current["UM"]);
                r.Pret = Convert.ToDecimal(current["Pret"]);
                r.Cantitate = Convert.ToInt32(current["Cantitate"]);
                cheltuieliDS.cheltuialaContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }
        private void A1()
        {
            //Incarcare DataTable Produse
            produseTableAdapter.Fill(produseDS.Produse);
            //Incarcare DataTable Clienti
            categorieTableAdapter.Fill(categorie._Categorie);

            // Protectie la modificare
            txtNrC.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretDataGridViewTextBoxColumn.ReadOnly = true;
            cantitateDataGridViewTextBoxColumn.ReadOnly = true;


            if (lblOp.Text == "MODIFICARE COMANDA") completeazaCheltuiala();
            else if (lblOp.Text == "COMANDA NOUA") cmbCategorie.SelectedIndex = -1;

        }
        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE COMANDA")
            {
                modificaInregistrare();
                stergeContinut();
                // adaugaInregistrariComenziContinut();
                this.Close();
            }
            else if (lblOp.Text == "COMANDA NOUA")
            {
                // generez_nr_cda();
                adaugaInregistrareComenzi();
                cautaInregistrare();
                //  adaugaInregistrariComenziContinut();
                golireCampuri();
            }
        }
        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)cheltuialaContinutManevraBindingSource.Current;
            try { current["NrCheltuiala"] = cheltuialaContinutManevraBindingSource.Position + 1; }
            catch { }
        }
        /*  private void A4()
          {
              try
              {
                  if (dataGridView1.CurrentCell.ColumnIndex == 1)
                  {
                      DataRowView current = (DataRowView)produseDSBindingSource.Current;
                      dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                      dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                      calcTotal();
                  }
                  if (dataGridView1.CurrentCell.ColumnIndex == 4)
                  {
                      inscrieriContinutManevraBindingSource.EndEdit();
                      calcTotal();
                  }
              }
              catch { }
          } */


        private void adaugaInregistrariCheltuieliContinut()
        {
            string listaCampuri = "IdCheltuiala, NrCr, IdProdus, Cantitate, Pret";
            string listaValori;

            con.Open();
            foreach (DataRow r in cheltuieliDS.cheltuialaContinutManevra)
            {
                listaValori = idCda + "," + r["NrCr"] + "," + r["IdProdus"] + "," + r["Cantitate"] + "," + r["Pret"];

                cmd.CommandText = "Insert into ComenziContinut(" + listaCampuri + ") " + "Select " + listaValori;

                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbCategorie.Text == "")
            {
                MessageBox.Show("Completati Categoria !");
                cmbCategorie.Focus();
                return false;
            }
            // Validare completare continut
            if (cheltuialaContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut cheltuiala !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }
        private void adaugaInregistrareComenzi()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "Id, Data, IdCheltuiala"; //de corectat
            listaValori = txtNrC.Text +
                          ",#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                               + cmbCategorie.SelectedValue;

            cmd.CommandText = "Insert into Cheltuieli(" + listaCampuri + ") " +
                              "Select " + listaValori;

            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere cheltuiala";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT IdCheltuiala From Cheltuieli Where IdCategorie = " + txtNrC.Text;

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }
        private void golireCampuri()
        {
            txtNrC.Text = "";
            cmbCategorie.SelectedIndex = -1;
            cheltuieliDS.cheltuialaContinutManevra.Clear();
        }
        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdCheltuiala = " + idCda;

            string clauzaSet = "Set Data = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#,"
                               + "IdCheltuiala = " + cmbCategorie.SelectedValue;

            cmd.CommandText = "Update Categorii " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void stergeContinut()
        {
            cmd.CommandText = "Delete from CheltuieliContinut Where IdCheltuiala= " + idCda; // de verificat idCda

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void FCheltuieliAct_Load(object sender, EventArgs e)
        {

         
            // TODO: This line of code loads data into the 'categorie._Categorie' table. You can move, or remove it, as needed.
            this.categorieTableAdapter.Fill(this.categorie._Categorie);
            A1();
        }

        private void cheltuialaContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            calcTotal();
        }
        private void calcTotal()
        {
            decimal t = 0;
            foreach (DataRow r in cheltuieliDS.cheltuialaContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            // txtTotal.Text = Convert.ToString(t);
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }
    }
}
