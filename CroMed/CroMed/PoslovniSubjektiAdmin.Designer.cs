namespace CroMed
{
    partial class PoslovniSubjektiAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoslovniSubjektiAdmin));
            this.dgvPoslovniSubjekti = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaSubjektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaSubjekta1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovniSubjektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UrediPoslovniSubjekt = new System.Windows.Forms.Button();
            this.DodajPoslovniSubjekt = new System.Windows.Forms.Button();
            this.IzbrisiPoslovniSubjekt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVrstaSubjekta = new System.Windows.Forms.ComboBox();
            this.vrstaSubjektaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovniSubjekti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniSubjektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaSubjektaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoslovniSubjekti
            // 
            this.dgvPoslovniSubjekti.AllowUserToAddRows = false;
            this.dgvPoslovniSubjekti.AllowUserToDeleteRows = false;
            this.dgvPoslovniSubjekti.AllowUserToResizeColumns = false;
            this.dgvPoslovniSubjekti.AllowUserToResizeRows = false;
            this.dgvPoslovniSubjekti.AutoGenerateColumns = false;
            this.dgvPoslovniSubjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPoslovniSubjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.vrstaSubjektaDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn,
            this.vrstaSubjekta1DataGridViewTextBoxColumn});
            this.dgvPoslovniSubjekti.DataSource = this.poslovniSubjektBindingSource;
            this.dgvPoslovniSubjekti.Location = new System.Drawing.Point(26, 112);
            this.dgvPoslovniSubjekti.MultiSelect = false;
            this.dgvPoslovniSubjekti.Name = "dgvPoslovniSubjekti";
            this.dgvPoslovniSubjekti.ReadOnly = true;
            this.dgvPoslovniSubjekti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPoslovniSubjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoslovniSubjekti.Size = new System.Drawing.Size(879, 321);
            this.dgvPoslovniSubjekti.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaSubjektaDataGridViewTextBoxColumn
            // 
            this.vrstaSubjektaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrstaSubjektaDataGridViewTextBoxColumn.DataPropertyName = "VrstaSubjekta";
            this.vrstaSubjektaDataGridViewTextBoxColumn.HeaderText = "Vrsta subjekta";
            this.vrstaSubjektaDataGridViewTextBoxColumn.Name = "vrstaSubjektaDataGridViewTextBoxColumn";
            this.vrstaSubjektaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaSubjektaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vrstaSubjektaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dokumentDataGridViewTextBoxColumn
            // 
            this.dokumentDataGridViewTextBoxColumn.DataPropertyName = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.HeaderText = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.Name = "dokumentDataGridViewTextBoxColumn";
            this.dokumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // vrstaSubjekta1DataGridViewTextBoxColumn
            // 
            this.vrstaSubjekta1DataGridViewTextBoxColumn.DataPropertyName = "VrstaSubjekta1";
            this.vrstaSubjekta1DataGridViewTextBoxColumn.HeaderText = "VrstaSubjekta1";
            this.vrstaSubjekta1DataGridViewTextBoxColumn.Name = "vrstaSubjekta1DataGridViewTextBoxColumn";
            this.vrstaSubjekta1DataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaSubjekta1DataGridViewTextBoxColumn.Visible = false;
            // 
            // poslovniSubjektBindingSource
            // 
            this.poslovniSubjektBindingSource.DataSource = typeof(CroMed.PoslovniSubjekt);
            // 
            // UrediPoslovniSubjekt
            // 
            this.UrediPoslovniSubjekt.Location = new System.Drawing.Point(207, 44);
            this.UrediPoslovniSubjekt.Name = "UrediPoslovniSubjekt";
            this.UrediPoslovniSubjekt.Size = new System.Drawing.Size(100, 38);
            this.UrediPoslovniSubjekt.TabIndex = 4;
            this.UrediPoslovniSubjekt.Text = "Uredi";
            this.UrediPoslovniSubjekt.UseVisualStyleBackColor = true;
            this.UrediPoslovniSubjekt.Click += new System.EventHandler(this.UrediDobavljaca_Click);
            // 
            // DodajPoslovniSubjekt
            // 
            this.DodajPoslovniSubjekt.Location = new System.Drawing.Point(30, 44);
            this.DodajPoslovniSubjekt.Name = "DodajPoslovniSubjekt";
            this.DodajPoslovniSubjekt.Size = new System.Drawing.Size(157, 38);
            this.DodajPoslovniSubjekt.TabIndex = 3;
            this.DodajPoslovniSubjekt.Text = "Dodaj poslovni subjekt";
            this.DodajPoslovniSubjekt.UseVisualStyleBackColor = true;
            this.DodajPoslovniSubjekt.Click += new System.EventHandler(this.DodajDobavljaca_Click);
            // 
            // IzbrisiPoslovniSubjekt
            // 
            this.IzbrisiPoslovniSubjekt.Location = new System.Drawing.Point(328, 44);
            this.IzbrisiPoslovniSubjekt.Name = "IzbrisiPoslovniSubjekt";
            this.IzbrisiPoslovniSubjekt.Size = new System.Drawing.Size(100, 38);
            this.IzbrisiPoslovniSubjekt.TabIndex = 5;
            this.IzbrisiPoslovniSubjekt.Text = "Izbriši";
            this.IzbrisiPoslovniSubjekt.UseVisualStyleBackColor = true;
            this.IzbrisiPoslovniSubjekt.Click += new System.EventHandler(this.IzbrisiDobavljaca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(567, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vrsta subjekta: ";
            // 
            // cmbVrstaSubjekta
            // 
            this.cmbVrstaSubjekta.DataSource = this.vrstaSubjektaBindingSource;
            this.cmbVrstaSubjekta.DisplayMember = "Opis";
            this.cmbVrstaSubjekta.FormattingEnabled = true;
            this.cmbVrstaSubjekta.Location = new System.Drawing.Point(653, 61);
            this.cmbVrstaSubjekta.Name = "cmbVrstaSubjekta";
            this.cmbVrstaSubjekta.Size = new System.Drawing.Size(121, 21);
            this.cmbVrstaSubjekta.TabIndex = 7;
            this.cmbVrstaSubjekta.ValueMember = "Id";
            this.cmbVrstaSubjekta.SelectedValueChanged += new System.EventHandler(this.cmbVrstaSubjekta_SelectedValueChanged);
            // 
            // vrstaSubjektaBindingSource
            // 
            this.vrstaSubjektaBindingSource.DataSource = typeof(CroMed.VrstaSubjekta);
            // 
            // PoslovniSubjektiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 461);
            this.Controls.Add(this.cmbVrstaSubjekta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IzbrisiPoslovniSubjekt);
            this.Controls.Add(this.UrediPoslovniSubjekt);
            this.Controls.Add(this.DodajPoslovniSubjekt);
            this.Controls.Add(this.dgvPoslovniSubjekti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PoslovniSubjektiAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poslovni subjekti";
            this.Activated += new System.EventHandler(this.PoslovniSubjektiAdmin_Activated);
            this.Load += new System.EventHandler(this.PoslovniSubjektiAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovniSubjekti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniSubjektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaSubjektaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPoslovniSubjekti;
        private System.Windows.Forms.Button UrediPoslovniSubjekt;
        private System.Windows.Forms.Button DodajPoslovniSubjekt;
        private System.Windows.Forms.Button IzbrisiPoslovniSubjekt;
        private System.Windows.Forms.BindingSource poslovniSubjektBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaSubjektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaSubjekta1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVrstaSubjekta;
        private System.Windows.Forms.BindingSource vrstaSubjektaBindingSource;
    }
}