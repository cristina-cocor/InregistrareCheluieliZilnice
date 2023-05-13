
namespace InregistrareCheltuieliZilnice
{
    partial class Cheltuieli
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cheltuieliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cheltuieliDS = new InregistrareCheltuieliZilnice.CheltuieliDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cheltuieliContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cheltuieliTableAdapter = new InregistrareCheltuieliZilnice.CheltuieliDSTableAdapters.CheltuieliTableAdapter();
            this.cheltuieliContinutTableAdapter = new InregistrareCheltuieliZilnice.CheltuieliDSTableAdapters.CheltuieliContinutTableAdapter();
            this.txtIdCheltuiala = new System.Windows.Forms.TextBox();
            this.btnCNoua = new System.Windows.Forms.Button();
            this.btnCModif = new System.Windows.Forms.Button();
            this.btnCStergere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseDS = new InregistrareCheltuieliZilnice.ProduseDS();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produseTableAdapter = new InregistrareCheltuieliZilnice.ProduseDSTableAdapters.ProduseTableAdapter();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cheltuieliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // cheltuieliBindingSource
            // 
            this.cheltuieliBindingSource.DataMember = "Cheltuieli";
            this.cheltuieliBindingSource.DataSource = this.cheltuieliDS;
            this.cheltuieliBindingSource.PositionChanged += new System.EventHandler(this.cheltuieliBindingSource_PositionChanged);
            // 
            // cheltuieliDS
            // 
            this.cheltuieliDS.DataSetName = "CheltuieliDS";
            this.cheltuieliDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pretDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cheltuieliContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(50, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(575, 203);
            this.dataGridView2.TabIndex = 1;
            // 
            // cheltuieliContinutBindingSource
            // 
            this.cheltuieliContinutBindingSource.DataMember = "CheltuieliContinut";
            this.cheltuieliContinutBindingSource.DataSource = this.cheltuieliDS;
            // 
            // cheltuieliTableAdapter
            // 
            this.cheltuieliTableAdapter.ClearBeforeFill = true;
            // 
            // cheltuieliContinutTableAdapter
            // 
            this.cheltuieliContinutTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdCheltuiala
            // 
            this.txtIdCheltuiala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheltuieliBindingSource, "IdCheltuiala", true));
            this.txtIdCheltuiala.Location = new System.Drawing.Point(708, 142);
            this.txtIdCheltuiala.Name = "txtIdCheltuiala";
            this.txtIdCheltuiala.ReadOnly = true;
            this.txtIdCheltuiala.Size = new System.Drawing.Size(322, 20);
            this.txtIdCheltuiala.TabIndex = 2;
            // 
            // btnCNoua
            // 
            this.btnCNoua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCNoua.Location = new System.Drawing.Point(742, 200);
            this.btnCNoua.Name = "btnCNoua";
            this.btnCNoua.Size = new System.Drawing.Size(260, 39);
            this.btnCNoua.TabIndex = 3;
            this.btnCNoua.Text = "Adaugare cheltuiala";
            this.btnCNoua.UseVisualStyleBackColor = true;
            this.btnCNoua.Click += new System.EventHandler(this.btnCNoua_Click);
            // 
            // btnCModif
            // 
            this.btnCModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCModif.Location = new System.Drawing.Point(742, 263);
            this.btnCModif.Name = "btnCModif";
            this.btnCModif.Size = new System.Drawing.Size(260, 40);
            this.btnCModif.TabIndex = 4;
            this.btnCModif.Text = "Modificare cheltuiala";
            this.btnCModif.UseVisualStyleBackColor = true;
            this.btnCModif.Click += new System.EventHandler(this.btnCModif_Click);
            // 
            // btnCStergere
            // 
            this.btnCStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCStergere.Location = new System.Drawing.Point(742, 326);
            this.btnCStergere.Name = "btnCStergere";
            this.btnCStergere.Size = new System.Drawing.Size(260, 40);
            this.btnCStergere.TabIndex = 5;
            this.btnCStergere.Text = "Stergere cheltuiala";
            this.btnCStergere.UseVisualStyleBackColor = true;
            this.btnCStergere.Click += new System.EventHandler(this.btnCStergere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cheltuieli";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // produseDS
            // 
            this.produseDS.DataSetName = "ProduseDS";
            this.produseDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.produseDS;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // Cheltuieli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCStergere);
            this.Controls.Add(this.btnCModif);
            this.Controls.Add(this.btnCNoua);
            this.Controls.Add(this.txtIdCheltuiala);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheltuieliBindingSource, "IdCheltuiala", true));
            this.Name = "Cheltuieli";
            this.Text = "Cheltuieli";
            this.Load += new System.EventHandler(this.Cheltuieli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CheltuieliDS cheltuieliDS;
        private System.Windows.Forms.BindingSource cheltuieliBindingSource;
        private CheltuieliDSTableAdapters.CheltuieliTableAdapter cheltuieliTableAdapter;
        private System.Windows.Forms.BindingSource cheltuieliContinutBindingSource;
        private CheltuieliDSTableAdapters.CheltuieliContinutTableAdapter cheltuieliContinutTableAdapter;
        private System.Windows.Forms.TextBox txtIdCheltuiala;
        private System.Windows.Forms.Button btnCNoua;
        private System.Windows.Forms.Button btnCModif;
        private System.Windows.Forms.Button btnCStergere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private ProduseDS produseDS;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private ProduseDSTableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
    }
}