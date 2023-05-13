
namespace InregistrareCheltuieliZilnice
{
    partial class Produse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorie = new InregistrareCheltuieliZilnice.Categorie();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.txtSpPoza = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.lblIdP = new System.Windows.Forms.Label();
            this.lblSpPoza = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblUM = new System.Windows.Forms.Label();
            this.txtDenumireP = new System.Windows.Forms.TextBox();
            this.lblDenumireP = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produseDS = new InregistrareCheltuieliZilnice.ProduseDS();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.categorieTableAdapter = new InregistrareCheltuieliZilnice.CategorieTableAdapters.CategorieTableAdapter();
            this.produseTableAdapter = new InregistrareCheltuieliZilnice.ProduseDSTableAdapters.ProduseTableAdapter();
            this.denumireProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(907, 84);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(111, 34);
            this.btnRenuntare.TabIndex = 21;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(759, 84);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(107, 35);
            this.btnConfirmare.TabIndex = 20;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCategorie);
            this.panel1.Controls.Add(this.lblCategorie);
            this.panel1.Controls.Add(this.pb);
            this.panel1.Controls.Add(this.txtIdP);
            this.panel1.Controls.Add(this.txtSpPoza);
            this.panel1.Controls.Add(this.txtPret);
            this.panel1.Controls.Add(this.txtUM);
            this.panel1.Controls.Add(this.lblIdP);
            this.panel1.Controls.Add(this.lblSpPoza);
            this.panel1.Controls.Add(this.lblPret);
            this.panel1.Controls.Add(this.lblUM);
            this.panel1.Controls.Add(this.txtDenumireP);
            this.panel1.Controls.Add(this.lblDenumireP);
            this.panel1.Location = new System.Drawing.Point(759, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 216);
            this.panel1.TabIndex = 19;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.DataSource = this.categorieBindingSource;
            this.cmbCategorie.DisplayMember = "DenumireCategorie";
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(139, 172);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(121, 21);
            this.cmbCategorie.TabIndex = 12;
            this.cmbCategorie.ValueMember = "IdCategorie";
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.categorie;
            // 
            // categorie
            // 
            this.categorie.DataSetName = "Categorie";
            this.categorie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(22, 172);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 11;
            this.lblCategorie.Text = "Categorie";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(297, 21);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(198, 172);
            this.pb.TabIndex = 10;
            this.pb.TabStop = false;
            // 
            // txtIdP
            // 
            this.txtIdP.Location = new System.Drawing.Point(139, 140);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(120, 20);
            this.txtIdP.TabIndex = 9;
            // 
            // txtSpPoza
            // 
            this.txtSpPoza.Location = new System.Drawing.Point(139, 113);
            this.txtSpPoza.Name = "txtSpPoza";
            this.txtSpPoza.Size = new System.Drawing.Size(120, 20);
            this.txtSpPoza.TabIndex = 8;
            this.txtSpPoza.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSpPoza_MouseDoubleClick);
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(139, 86);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(120, 20);
            this.txtPret.TabIndex = 7;
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(139, 58);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(120, 20);
            this.txtUM.TabIndex = 6;
            // 
            // lblIdP
            // 
            this.lblIdP.AutoSize = true;
            this.lblIdP.Location = new System.Drawing.Point(22, 143);
            this.lblIdP.Name = "lblIdP";
            this.lblIdP.Size = new System.Drawing.Size(49, 13);
            this.lblIdP.TabIndex = 5;
            this.lblIdP.Text = "IdProdus";
            // 
            // lblSpPoza
            // 
            this.lblSpPoza.AutoSize = true;
            this.lblSpPoza.Location = new System.Drawing.Point(22, 112);
            this.lblSpPoza.Name = "lblSpPoza";
            this.lblSpPoza.Size = new System.Drawing.Size(31, 13);
            this.lblSpPoza.TabIndex = 4;
            this.lblSpPoza.Text = "Poza";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(22, 86);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(26, 13);
            this.lblPret.TabIndex = 3;
            this.lblPret.Text = "Pret";
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Location = new System.Drawing.Point(22, 58);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(24, 13);
            this.lblUM.TabIndex = 2;
            this.lblUM.Text = "UM";
            // 
            // txtDenumireP
            // 
            this.txtDenumireP.Location = new System.Drawing.Point(139, 24);
            this.txtDenumireP.Name = "txtDenumireP";
            this.txtDenumireP.Size = new System.Drawing.Size(120, 20);
            this.txtDenumireP.TabIndex = 1;
            // 
            // lblDenumireP
            // 
            this.lblDenumireP.AutoSize = true;
            this.lblDenumireP.Location = new System.Drawing.Point(19, 27);
            this.lblDenumireP.Name = "lblDenumireP";
            this.lblDenumireP.Size = new System.Drawing.Size(85, 13);
            this.lblDenumireP.TabIndex = 0;
            this.lblDenumireP.Text = "DenumireProdus";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireProdusDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 294);
            this.dataGridView1.TabIndex = 18;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.produseDS;
            // 
            // produseDS
            // 
            this.produseDS.DataSetName = "ProduseDS";
            this.produseDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(319, 84);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(106, 36);
            this.btnStergere.TabIndex = 17;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(183, 84);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(105, 36);
            this.btnModificare.TabIndex = 16;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(41, 84);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(113, 37);
            this.btnAdaugare.TabIndex = 15;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(1053, 104);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(31, 13);
            this.lblOp.TabIndex = 22;
            this.lblOp.Text = "lblOp";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // denumireProdusDataGridViewTextBoxColumn
            // 
            this.denumireProdusDataGridViewTextBoxColumn.DataPropertyName = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.HeaderText = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.Name = "denumireProdusDataGridViewTextBoxColumn";
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            // 
            // Produse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 494);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "Produse";
            this.Text = "Produse";
            this.Load += new System.EventHandler(this.Produse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDenumireP;
        private System.Windows.Forms.Label lblDenumireP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnAdaugare;
        private ProduseDS produseDS;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.TextBox txtSpPoza;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label lblIdP;
        private System.Windows.Forms.Label lblSpPoza;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblUM;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label lblCategorie;
        private Categorie categorie;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private CategorieTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private ProduseDSTableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
    }
}