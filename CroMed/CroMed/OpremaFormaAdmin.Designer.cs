namespace CroMed
{
    partial class OpremaFormaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpremaFormaAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.SortirajOpremuCombo = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.croMedDB_DataDataSet = new CroMed.CroMedDB_DataDataSet();
            this.OpremaGridView = new System.Windows.Forms.DataGridView();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKProizvodiKategorijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodajOpremuButton = new System.Windows.Forms.Button();
            this.urediOpremuButton = new System.Windows.Forms.Button();
            this.obrisiOpremuButton = new System.Windows.Forms.Button();
            this.kategorijaTableAdapter = new CroMed.CroMedDB_DataDataSetTableAdapters.KategorijaTableAdapter();
            this.proizvodiTableAdapter = new CroMed.CroMedDB_DataDataSetTableAdapters.ProizvodiTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeZalihaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nabavnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodajnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.croMedDB_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpremaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProizvodiKategorijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija: ";
            // 
            // SortirajOpremuCombo
            // 
            this.SortirajOpremuCombo.DataSource = this.kategorijaBindingSource;
            this.SortirajOpremuCombo.DisplayMember = "Naziv";
            this.SortirajOpremuCombo.FormattingEnabled = true;
            this.SortirajOpremuCombo.Location = new System.Drawing.Point(642, 54);
            this.SortirajOpremuCombo.Name = "SortirajOpremuCombo";
            this.SortirajOpremuCombo.Size = new System.Drawing.Size(139, 21);
            this.SortirajOpremuCombo.TabIndex = 1;
            this.SortirajOpremuCombo.ValueMember = "Id";
            this.SortirajOpremuCombo.SelectedIndexChanged += new System.EventHandler(this.SortirajOpremuCombo_SelectedIndexChanged);
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataSource = typeof(CroMed.Kategorija);
            // 
            // kategorijaBindingSource1
            // 
            this.kategorijaBindingSource1.DataMember = "Kategorija";
            this.kategorijaBindingSource1.DataSource = this.croMedDB_DataDataSet;
            // 
            // croMedDB_DataDataSet
            // 
            this.croMedDB_DataDataSet.DataSetName = "CroMedDB_DataDataSet";
            this.croMedDB_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OpremaGridView
            // 
            this.OpremaGridView.AllowUserToAddRows = false;
            this.OpremaGridView.AllowUserToDeleteRows = false;
            this.OpremaGridView.AllowUserToResizeColumns = false;
            this.OpremaGridView.AllowUserToResizeRows = false;
            this.OpremaGridView.AutoGenerateColumns = false;
            this.OpremaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpremaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kategorijaDataGridViewTextBoxColumn,
            this.stanjeZalihaDataGridViewTextBoxColumn,
            this.nabavnaCijenaDataGridViewTextBoxColumn,
            this.prodajnaCijenaDataGridViewTextBoxColumn});
            this.OpremaGridView.DataSource = this.proizvodiBindingSource;
            this.OpremaGridView.Location = new System.Drawing.Point(26, 104);
            this.OpremaGridView.Name = "OpremaGridView";
            this.OpremaGridView.ReadOnly = true;
            this.OpremaGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OpremaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OpremaGridView.Size = new System.Drawing.Size(882, 335);
            this.OpremaGridView.TabIndex = 2;
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataSource = typeof(CroMed.Proizvodi);
            // 
            // fKProizvodiKategorijeBindingSource
            // 
            this.fKProizvodiKategorijeBindingSource.DataMember = "FK_Proizvodi_Kategorije";
            this.fKProizvodiKategorijeBindingSource.DataSource = this.kategorijaBindingSource1;
            // 
            // dodajOpremuButton
            // 
            this.dodajOpremuButton.Location = new System.Drawing.Point(30, 44);
            this.dodajOpremuButton.Name = "dodajOpremuButton";
            this.dodajOpremuButton.Size = new System.Drawing.Size(100, 38);
            this.dodajOpremuButton.TabIndex = 3;
            this.dodajOpremuButton.Text = "Dodaj";
            this.dodajOpremuButton.UseVisualStyleBackColor = true;
            this.dodajOpremuButton.Click += new System.EventHandler(this.DodajOpremuButton_Click);
            // 
            // urediOpremuButton
            // 
            this.urediOpremuButton.Location = new System.Drawing.Point(163, 44);
            this.urediOpremuButton.Name = "urediOpremuButton";
            this.urediOpremuButton.Size = new System.Drawing.Size(100, 38);
            this.urediOpremuButton.TabIndex = 4;
            this.urediOpremuButton.Text = "Uredi";
            this.urediOpremuButton.UseVisualStyleBackColor = true;
            this.urediOpremuButton.Click += new System.EventHandler(this.UrediOpremuButton_Click);
            // 
            // obrisiOpremuButton
            // 
            this.obrisiOpremuButton.Location = new System.Drawing.Point(296, 44);
            this.obrisiOpremuButton.Name = "obrisiOpremuButton";
            this.obrisiOpremuButton.Size = new System.Drawing.Size(100, 38);
            this.obrisiOpremuButton.TabIndex = 5;
            this.obrisiOpremuButton.Text = "Obriši";
            this.obrisiOpremuButton.UseVisualStyleBackColor = true;
            this.obrisiOpremuButton.Click += new System.EventHandler(this.obrisiOpremuButton_Click);
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // proizvodiTableAdapter
            // 
            this.proizvodiTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Šifra artikla";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 84;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategorijaDataGridViewTextBoxColumn
            // 
            this.kategorijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kategorijaDataGridViewTextBoxColumn.DataPropertyName = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.HeaderText = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.Name = "kategorijaDataGridViewTextBoxColumn";
            this.kategorijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategorijaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kategorijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stanjeZalihaDataGridViewTextBoxColumn
            // 
            this.stanjeZalihaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stanjeZalihaDataGridViewTextBoxColumn.DataPropertyName = "StanjeZaliha";
            this.stanjeZalihaDataGridViewTextBoxColumn.HeaderText = "Stanje zaliha";
            this.stanjeZalihaDataGridViewTextBoxColumn.Name = "stanjeZalihaDataGridViewTextBoxColumn";
            this.stanjeZalihaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nabavnaCijenaDataGridViewTextBoxColumn
            // 
            this.nabavnaCijenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nabavnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "NabavnaCijena";
            this.nabavnaCijenaDataGridViewTextBoxColumn.HeaderText = "Nabavna cijena";
            this.nabavnaCijenaDataGridViewTextBoxColumn.Name = "nabavnaCijenaDataGridViewTextBoxColumn";
            this.nabavnaCijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodajnaCijenaDataGridViewTextBoxColumn
            // 
            this.prodajnaCijenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodajnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "ProdajnaCijena";
            this.prodajnaCijenaDataGridViewTextBoxColumn.HeaderText = "Prodajna cijena";
            this.prodajnaCijenaDataGridViewTextBoxColumn.Name = "prodajnaCijenaDataGridViewTextBoxColumn";
            this.prodajnaCijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OpremaFormaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 461);
            this.Controls.Add(this.obrisiOpremuButton);
            this.Controls.Add(this.urediOpremuButton);
            this.Controls.Add(this.dodajOpremuButton);
            this.Controls.Add(this.OpremaGridView);
            this.Controls.Add(this.SortirajOpremuCombo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpremaFormaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oprema";
            this.Load += new System.EventHandler(this.OpremaFormaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.croMedDB_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpremaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProizvodiKategorijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SortirajOpremuCombo;
        private System.Windows.Forms.DataGridView OpremaGridView;
        private System.Windows.Forms.Button dodajOpremuButton;
        private System.Windows.Forms.Button urediOpremuButton;
        private System.Windows.Forms.Button obrisiOpremuButton;
        private CroMedDB_DataDataSet croMedDB_DataDataSet;
        private System.Windows.Forms.BindingSource kategorijaBindingSource1;
        private CroMedDB_DataDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private System.Windows.Forms.BindingSource fKProizvodiKategorijeBindingSource;
        private CroMedDB_DataDataSetTableAdapters.ProizvodiTableAdapter proizvodiTableAdapter;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeZalihaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nabavnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodajnaCijenaDataGridViewTextBoxColumn;
    }
}