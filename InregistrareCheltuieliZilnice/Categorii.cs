using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InregistrareCheltuieliZilnice
{
    public partial class Categorii : Form
    {
        //const int IdCategorie = 0;
        const int DenumireCategorie = 0;
        public Categorii()
        {
            InitializeComponent();
        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            //Protectie coloane
            dataGridView1.Columns[DenumireCategorie].ReadOnly = v;
           
            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }

        private void refresh()
        {
            categorieTableAdapter.Fill(categorie._Categorie);
            //pictureBox1.ImageLocation = txtSpPoza.Text;
        }
        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in categorie._Categorie)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DenumireCategorie"] == DBNull.Value)
                {
                    MessageBox.Show("Completati DenumireCategorie la linia cu Id " + r["IdCategorie"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }

        private void Categorii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categorie._Categorie' table. You can move, or remove it, as needed.
            this.categorieTableAdapter.Fill(this.categorie._Categorie);
            config(true);
            refresh();
            //dataGridView1.Columns[IdCategorie].ReadOnly = true;


        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            try
            {
                categorieTableAdapter.Update(categorie._Categorie);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }

        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();

        }


        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        
    }
}
