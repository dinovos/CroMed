namespace CroMed
{
    partial class DokumentiAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DokumentiAdmin));
            this.DokumentiGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovniSubjektDataGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.poslovniSubjektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.croMedDB_DataDataSet = new CroMed.CroMedDB_DataDataSet();
            this.dokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnPromjena = new System.Windows.Forms.Button();
            this.dtgStavke = new System.Windows.Forms.DataGridView();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKStavkeDokumentaDukumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokumentTableAdapter = new CroMed.CroMedDB_DataDataSetTableAdapters.DokumentTableAdapter();
            this.poslovniSubjektTableAdapter = new CroMed.CroMedDB_DataDataSetTableAdapters.PoslovniSubjektTableAdapter();
            this.stavkeDokumentaTableAdapter = new CroMed.CroMedDB_DataDataSetTableAdapters.StavkeDokumentaTableAdapter();
            this.proizvodiTableAdapter = new CroMed.CroMedDB_DataDataSetTableAdapters.ProizvodiTableAdapter();
            this.dtgPromjene = new System.Windows.Forms.DataGridView();
            this.dokumentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stanjeDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datumPromjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPromjeneStanjaDokumentaDokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promjeneStanjaDokumentaTableAdapter = new CroMed.CroMedDB_DataDataSetTableAdapters.PromjeneStanjaDokumentaTableAdapter();
            this.stanjeDokumentaTableAdapter = new CroMed.CroMedDB_DataDataSetTableAdapters.StanjeDokumentaTableAdapter();
            this.zaposlenikTableAdapter = new CroMed.CroMedDB_DataDataSetTableAdapters.ZaposlenikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DokumentiGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniSubjektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.croMedDB_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkeDokumentaDukumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromjene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeDokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPromjeneStanjaDokumentaDokumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DokumentiGridView
            // 
            this.DokumentiGridView.AllowUserToAddRows = false;
            this.DokumentiGridView.AllowUserToDeleteRows = false;
            this.DokumentiGridView.AllowUserToResizeColumns = false;
            this.DokumentiGridView.AllowUserToResizeRows = false;
            this.DokumentiGridView.AutoGenerateColumns = false;
            this.DokumentiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DokumentiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.poslovniSubjektDataGridViewColumn});
            this.DokumentiGridView.DataSource = this.dokumentBindingSource;
            this.DokumentiGridView.Location = new System.Drawing.Point(30, 122);
            this.DokumentiGridView.MultiSelect = false;
            this.DokumentiGridView.Name = "DokumentiGridView";
            this.DokumentiGridView.ReadOnly = true;
            this.DokumentiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DokumentiGridView.Size = new System.Drawing.Size(304, 309);
            this.DokumentiGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // poslovniSubjektDataGridViewColumn
            // 
            this.poslovniSubjektDataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.poslovniSubjektDataGridViewColumn.DataPropertyName = "PoslovniSubjekt";
            this.poslovniSubjektDataGridViewColumn.DataSource = this.poslovniSubjektBindingSource;
            this.poslovniSubjektDataGridViewColumn.DisplayMember = "Naziv";
            this.poslovniSubjektDataGridViewColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.poslovniSubjektDataGridViewColumn.HeaderText = "Poslovni subjekt";
            this.poslovniSubjektDataGridViewColumn.Name = "poslovniSubjektDataGridViewColumn";
            this.poslovniSubjektDataGridViewColumn.ReadOnly = true;
            this.poslovniSubjektDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.poslovniSubjektDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.poslovniSubjektDataGridViewColumn.ValueMember = "Id";
            // 
            // poslovniSubjektBindingSource
            // 
            this.poslovniSubjektBindingSource.DataMember = "PoslovniSubjekt";
            this.poslovniSubjektBindingSource.DataSource = this.croMedDB_DataDataSet;
            // 
            // croMedDB_DataDataSet
            // 
            this.croMedDB_DataDataSet.DataSetName = "CroMedDB_DataDataSet";
            this.croMedDB_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dokumentBindingSource
            // 
            this.dokumentBindingSource.DataMember = "Dokument";
            this.dokumentBindingSource.DataSource = this.croMedDB_DataDataSet;
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(30, 44);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(100, 38);
            this.btnNaruci.TabIndex = 1;
            this.btnNaruci.Text = "Izradi narudžbu";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(234, 44);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(100, 38);
            this.btnRacun.TabIndex = 3;
            this.btnRacun.Text = "Izradi račun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // btnPromjena
            // 
            this.btnPromjena.Location = new System.Drawing.Point(686, 44);
            this.btnPromjena.Name = "btnPromjena";
            this.btnPromjena.Size = new System.Drawing.Size(100, 38);
            this.btnPromjena.TabIndex = 4;
            this.btnPromjena.Text = "Promjena stanja";
            this.btnPromjena.UseVisualStyleBackColor = true;
            this.btnPromjena.Click += new System.EventHandler(this.btnPromjena_Click);
            // 
            // dtgStavke
            // 
            this.dtgStavke.AllowUserToAddRows = false;
            this.dtgStavke.AllowUserToDeleteRows = false;
            this.dtgStavke.AllowUserToResizeColumns = false;
            this.dtgStavke.AllowUserToResizeRows = false;
            this.dtgStavke.AutoGenerateColumns = false;
            this.dtgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dokumentDataGridViewTextBoxColumn,
            this.proizvodDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.rabatDataGridViewTextBoxColumn});
            this.dtgStavke.DataSource = this.fKStavkeDokumentaDukumentBindingSource;
            this.dtgStavke.Location = new System.Drawing.Point(393, 122);
            this.dtgStavke.MultiSelect = false;
            this.dtgStavke.Name = "dtgStavke";
            this.dtgStavke.ReadOnly = true;
            this.dtgStavke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStavke.Size = new System.Drawing.Size(478, 128);
            this.dtgStavke.TabIndex = 5;
            // 
            // dokumentDataGridViewTextBoxColumn
            // 
            this.dokumentDataGridViewTextBoxColumn.DataPropertyName = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.HeaderText = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.Name = "dokumentDataGridViewTextBoxColumn";
            this.dokumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // proizvodDataGridViewTextBoxColumn
            // 
            this.proizvodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proizvodDataGridViewTextBoxColumn.DataPropertyName = "Proizvod";
            this.proizvodDataGridViewTextBoxColumn.DataSource = this.proizvodiBindingSource;
            this.proizvodDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.proizvodDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.proizvodDataGridViewTextBoxColumn.HeaderText = "Proizvod";
            this.proizvodDataGridViewTextBoxColumn.Name = "proizvodDataGridViewTextBoxColumn";
            this.proizvodDataGridViewTextBoxColumn.ReadOnly = true;
            this.proizvodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proizvodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.proizvodDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataMember = "Proizvodi";
            this.proizvodiBindingSource.DataSource = this.croMedDB_DataDataSet;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 69;
            // 
            // rabatDataGridViewTextBoxColumn
            // 
            this.rabatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rabatDataGridViewTextBoxColumn.DataPropertyName = "Rabat";
            this.rabatDataGridViewTextBoxColumn.HeaderText = "Rabat";
            this.rabatDataGridViewTextBoxColumn.Name = "rabatDataGridViewTextBoxColumn";
            this.rabatDataGridViewTextBoxColumn.ReadOnly = true;
            this.rabatDataGridViewTextBoxColumn.Width = 61;
            // 
            // fKStavkeDokumentaDukumentBindingSource
            // 
            this.fKStavkeDokumentaDukumentBindingSource.DataMember = "FK_StavkeDokumenta_Dukument";
            this.fKStavkeDokumentaDukumentBindingSource.DataSource = this.dokumentBindingSource;
            // 
            // dokumentTableAdapter
            // 
            this.dokumentTableAdapter.ClearBeforeFill = true;
            // 
            // poslovniSubjektTableAdapter
            // 
            this.poslovniSubjektTableAdapter.ClearBeforeFill = true;
            // 
            // stavkeDokumentaTableAdapter
            // 
            this.stavkeDokumentaTableAdapter.ClearBeforeFill = true;
            // 
            // proizvodiTableAdapter
            // 
            this.proizvodiTableAdapter.ClearBeforeFill = true;
            // 
            // dtgPromjene
            // 
            this.dtgPromjene.AllowUserToAddRows = false;
            this.dtgPromjene.AllowUserToDeleteRows = false;
            this.dtgPromjene.AutoGenerateColumns = false;
            this.dtgPromjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPromjene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dokumentDataGridViewTextBoxColumn1,
            this.stanjeDokumentaDataGridViewTextBoxColumn,
            this.datumPromjeneDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn});
            this.dtgPromjene.DataSource = this.fKPromjeneStanjaDokumentaDokumentBindingSource;
            this.dtgPromjene.Location = new System.Drawing.Point(393, 284);
            this.dtgPromjene.Name = "dtgPromjene";
            this.dtgPromjene.ReadOnly = true;
            this.dtgPromjene.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgPromjene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPromjene.Size = new System.Drawing.Size(478, 147);
            this.dtgPromjene.TabIndex = 6;
            // 
            // dokumentDataGridViewTextBoxColumn1
            // 
            this.dokumentDataGridViewTextBoxColumn1.DataPropertyName = "Dokument";
            this.dokumentDataGridViewTextBoxColumn1.HeaderText = "Dokument";
            this.dokumentDataGridViewTextBoxColumn1.Name = "dokumentDataGridViewTextBoxColumn1";
            this.dokumentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dokumentDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stanjeDokumentaDataGridViewTextBoxColumn
            // 
            this.stanjeDokumentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stanjeDokumentaDataGridViewTextBoxColumn.DataPropertyName = "StanjeDokumenta";
            this.stanjeDokumentaDataGridViewTextBoxColumn.DataSource = this.stanjeDokumentaBindingSource;
            this.stanjeDokumentaDataGridViewTextBoxColumn.DisplayMember = "Vrsta";
            this.stanjeDokumentaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.stanjeDokumentaDataGridViewTextBoxColumn.HeaderText = "Stanje dokumenta";
            this.stanjeDokumentaDataGridViewTextBoxColumn.Name = "stanjeDokumentaDataGridViewTextBoxColumn";
            this.stanjeDokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanjeDokumentaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stanjeDokumentaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stanjeDokumentaDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // stanjeDokumentaBindingSource
            // 
            this.stanjeDokumentaBindingSource.DataMember = "StanjeDokumenta";
            this.stanjeDokumentaBindingSource.DataSource = this.croMedDB_DataDataSet;
            // 
            // datumPromjeneDataGridViewTextBoxColumn
            // 
            this.datumPromjeneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumPromjeneDataGridViewTextBoxColumn.DataPropertyName = "DatumPromjene";
            this.datumPromjeneDataGridViewTextBoxColumn.HeaderText = "Datum promjene";
            this.datumPromjeneDataGridViewTextBoxColumn.Name = "datumPromjeneDataGridViewTextBoxColumn";
            this.datumPromjeneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.zaposlenikDataGridViewTextBoxColumn.DisplayMember = "KorisnickoIme";
            this.zaposlenikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zaposlenikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zaposlenikDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.croMedDB_DataDataSet;
            // 
            // fKPromjeneStanjaDokumentaDokumentBindingSource
            // 
            this.fKPromjeneStanjaDokumentaDokumentBindingSource.DataMember = "FK_PromjeneStanjaDokumenta_Dokument";
            this.fKPromjeneStanjaDokumentaDokumentBindingSource.DataSource = this.dokumentBindingSource;
            // 
            // promjeneStanjaDokumentaTableAdapter
            // 
            this.promjeneStanjaDokumentaTableAdapter.ClearBeforeFill = true;
            // 
            // stanjeDokumentaTableAdapter
            // 
            this.stanjeDokumentaTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // DokumentiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 461);
            this.Controls.Add(this.dtgPromjene);
            this.Controls.Add(this.dtgStavke);
            this.Controls.Add(this.btnPromjena);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.DokumentiGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DokumentiAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokumenti";
            this.Load += new System.EventHandler(this.DokumentiAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DokumentiGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniSubjektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.croMedDB_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkeDokumentaDukumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromjene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeDokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPromjeneStanjaDokumentaDokumentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DokumentiGridView;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnPromjena;
        private System.Windows.Forms.DataGridView dtgStavke;
        private CroMedDB_DataDataSet croMedDB_DataDataSet;
        private System.Windows.Forms.BindingSource dokumentBindingSource;
        private CroMedDB_DataDataSetTableAdapters.DokumentTableAdapter dokumentTableAdapter;
        private System.Windows.Forms.BindingSource poslovniSubjektBindingSource;
        private CroMedDB_DataDataSetTableAdapters.PoslovniSubjektTableAdapter poslovniSubjektTableAdapter;
        private System.Windows.Forms.BindingSource fKStavkeDokumentaDukumentBindingSource;
        private CroMedDB_DataDataSetTableAdapters.StavkeDokumentaTableAdapter stavkeDokumentaTableAdapter;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
        private CroMedDB_DataDataSetTableAdapters.ProizvodiTableAdapter proizvodiTableAdapter;
        private System.Windows.Forms.DataGridView dtgPromjene;
        private System.Windows.Forms.BindingSource fKPromjeneStanjaDokumentaDokumentBindingSource;
        private CroMedDB_DataDataSetTableAdapters.PromjeneStanjaDokumentaTableAdapter promjeneStanjaDokumentaTableAdapter;
        private System.Windows.Forms.BindingSource stanjeDokumentaBindingSource;
        private CroMedDB_DataDataSetTableAdapters.StanjeDokumentaTableAdapter stanjeDokumentaTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private CroMedDB_DataDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn poslovniSubjektDataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn proizvodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn stanjeDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPromjeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zaposlenikDataGridViewTextBoxColumn;
    }
}