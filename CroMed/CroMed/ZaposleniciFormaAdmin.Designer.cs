namespace CroMed
{
    partial class ZaposleniciFormaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaposleniciFormaAdmin));
            this.ZaposleniciGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razinaOvlastiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.razinaOvlastiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promjeneStanjaDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DodajZaposlenika = new System.Windows.Forms.Button();
            this.UrediZaposlenika = new System.Windows.Forms.Button();
            this.IzbrisiZaposlenika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razinaOvlastiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ZaposleniciGridView
            // 
            this.ZaposleniciGridView.AllowUserToAddRows = false;
            this.ZaposleniciGridView.AllowUserToDeleteRows = false;
            this.ZaposleniciGridView.AllowUserToResizeColumns = false;
            this.ZaposleniciGridView.AllowUserToResizeRows = false;
            this.ZaposleniciGridView.AutoGenerateColumns = false;
            this.ZaposleniciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZaposleniciGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.razinaOvlastiDataGridViewTextBoxColumn,
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.promjeneStanjaDokumentaDataGridViewTextBoxColumn});
            this.ZaposleniciGridView.DataSource = this.zaposlenikBindingSource;
            this.ZaposleniciGridView.Location = new System.Drawing.Point(31, 110);
            this.ZaposleniciGridView.MultiSelect = false;
            this.ZaposleniciGridView.Name = "ZaposleniciGridView";
            this.ZaposleniciGridView.ReadOnly = true;
            this.ZaposleniciGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ZaposleniciGridView.Size = new System.Drawing.Size(869, 321);
            this.ZaposleniciGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razinaOvlastiDataGridViewTextBoxColumn
            // 
            this.razinaOvlastiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razinaOvlastiDataGridViewTextBoxColumn.DataPropertyName = "RazinaOvlasti";
            this.razinaOvlastiDataGridViewTextBoxColumn.DataSource = this.razinaOvlastiBindingSource;
            this.razinaOvlastiDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.razinaOvlastiDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.razinaOvlastiDataGridViewTextBoxColumn.HeaderText = "Razina ovlasti";
            this.razinaOvlastiDataGridViewTextBoxColumn.Name = "razinaOvlastiDataGridViewTextBoxColumn";
            this.razinaOvlastiDataGridViewTextBoxColumn.ReadOnly = true;
            this.razinaOvlastiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.razinaOvlastiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.razinaOvlastiDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // razinaOvlastiBindingSource
            // 
            this.razinaOvlastiBindingSource.DataSource = typeof(CroMed.RazinaOvlasti);
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "Korisnicko ime";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // promjeneStanjaDokumentaDataGridViewTextBoxColumn
            // 
            this.promjeneStanjaDokumentaDataGridViewTextBoxColumn.DataPropertyName = "PromjeneStanjaDokumenta";
            this.promjeneStanjaDokumentaDataGridViewTextBoxColumn.HeaderText = "PromjeneStanjaDokumenta";
            this.promjeneStanjaDokumentaDataGridViewTextBoxColumn.Name = "promjeneStanjaDokumentaDataGridViewTextBoxColumn";
            this.promjeneStanjaDokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.promjeneStanjaDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(CroMed.Zaposlenik);
            // 
            // DodajZaposlenika
            // 
            this.DodajZaposlenika.BackColor = System.Drawing.Color.Transparent;
            this.DodajZaposlenika.Location = new System.Drawing.Point(30, 44);
            this.DodajZaposlenika.Name = "DodajZaposlenika";
            this.DodajZaposlenika.Size = new System.Drawing.Size(100, 38);
            this.DodajZaposlenika.TabIndex = 1;
            this.DodajZaposlenika.Text = "Dodaj";
            this.DodajZaposlenika.UseVisualStyleBackColor = false;
            this.DodajZaposlenika.Click += new System.EventHandler(this.DodajZaposlenika_Click);
            // 
            // UrediZaposlenika
            // 
            this.UrediZaposlenika.BackColor = System.Drawing.Color.Transparent;
            this.UrediZaposlenika.Location = new System.Drawing.Point(163, 44);
            this.UrediZaposlenika.Name = "UrediZaposlenika";
            this.UrediZaposlenika.Size = new System.Drawing.Size(100, 38);
            this.UrediZaposlenika.TabIndex = 2;
            this.UrediZaposlenika.Text = "Uredi";
            this.UrediZaposlenika.UseVisualStyleBackColor = false;
            this.UrediZaposlenika.Click += new System.EventHandler(this.UrediZaposlenika_Click);
            // 
            // IzbrisiZaposlenika
            // 
            this.IzbrisiZaposlenika.BackColor = System.Drawing.Color.Transparent;
            this.IzbrisiZaposlenika.Location = new System.Drawing.Point(296, 44);
            this.IzbrisiZaposlenika.Name = "IzbrisiZaposlenika";
            this.IzbrisiZaposlenika.Size = new System.Drawing.Size(100, 38);
            this.IzbrisiZaposlenika.TabIndex = 3;
            this.IzbrisiZaposlenika.Text = "Izbriši";
            this.IzbrisiZaposlenika.UseVisualStyleBackColor = false;
            this.IzbrisiZaposlenika.Click += new System.EventHandler(this.IzbrisiZaposlenika_Click);
            // 
            // ZaposleniciFormaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 461);
            this.Controls.Add(this.IzbrisiZaposlenika);
            this.Controls.Add(this.UrediZaposlenika);
            this.Controls.Add(this.DodajZaposlenika);
            this.Controls.Add(this.ZaposleniciGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZaposleniciFormaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.Activated += new System.EventHandler(this.ZaposleniciFormaAdmin_Activated);
            this.Load += new System.EventHandler(this.ZaposleniciFormaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razinaOvlastiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ZaposleniciGridView;
        private System.Windows.Forms.Button DodajZaposlenika;
        private System.Windows.Forms.Button UrediZaposlenika;
        private System.Windows.Forms.Button IzbrisiZaposlenika;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn razinaOvlastiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource razinaOvlastiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promjeneStanjaDokumentaDataGridViewTextBoxColumn;
    }
}