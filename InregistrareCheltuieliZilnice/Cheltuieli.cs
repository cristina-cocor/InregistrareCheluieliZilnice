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
    public partial class Cheltuieli : Form
    {
        public Cheltuieli()
        {
            InitializeComponent();
        }

        private void Cheltuieli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'produseDS.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.produseDS.Produse);
            // TODO: This line of code loads data into the 'cheltuieliDS.CheltuieliContinut' table. You can move, or remove it, as needed.
            this.cheltuieliContinutTableAdapter.Fill(this.cheltuieliDS.CheltuieliContinut);
            // TODO: This line of code loads data into the 'cheltuieliDS.Cheltuieli' table. You can move, or remove it, as needed.
            this.cheltuieliTableAdapter.Fill(this.cheltuieliDS.Cheltuieli);
            refreshGrid();
            filtreazaDetaliu();

        }
        private void refreshGrid()
        {
            cheltuieliTableAdapter.Fill(cheltuieliDS.Cheltuieli);
            cheltuieliContinutTableAdapter.Fill(cheltuieliDS.CheltuieliContinut);
        }
        private void filtreazaDetaliu()
        {
            try
            {
                cheltuieliContinutBindingSource.Filter = "IdCheltuiala=" + txtIdCheltuiala.Text;
            }
            catch { }
        }

        private void cheltuieliBindingSource_PositionChanged(object sender, EventArgs e)
        {
            filtreazaDetaliu();
        }

        private void btnCNoua_Click(object sender, EventArgs e)
        {
            FCheltuieliAct f = new FCheltuieliAct();
            f.completeazaTitlu("ADAUGA CHELTUIALA");
            f.ShowDialog();
            refreshGrid();
        }

        private void btnCModif_Click(object sender, EventArgs e)
        {
            FCheltuieliAct f = new FCheltuieliAct();
            f.completeazaTitlu("MODIFICARE CHELTUIALA");
            f.bs1 = cheltuieliBindingSource;
            f.bs2 = cheltuieliContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
        }

        private void btnCStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = cheltuieliTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            //sterg continut cheltuiala
            cmd.CommandText = "Delete From CheltuieliContinut Where IdCheltuiala = " + txtIdCheltuiala.Text;


            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();
            //sterg cheltuiala
            cmd.CommandText = "Delete From Cheltuieli Where IdCheltuiala = " + txtIdCheltuiala.Text;
            //MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid();
            filtreazaDetaliu();

        }
    }
}
