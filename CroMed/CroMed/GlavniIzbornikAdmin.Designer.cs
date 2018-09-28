namespace CroMed
{
    partial class GlavniIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavniIzbornik));
            this.ButtonOdjavaIzPrograma = new System.Windows.Forms.Button();
            this.ButtonOprema = new System.Windows.Forms.Button();
            this.ButtonKategorije = new System.Windows.Forms.Button();
            this.ButtonPoslovniSubjekti = new System.Windows.Forms.Button();
            this.ButtonDokumenti = new System.Windows.Forms.Button();
            this.ButtonZaposlenici = new System.Windows.Forms.Button();
            this.trenutnoVrijemeLabela = new System.Windows.Forms.Label();
            this.timerVrijeme = new System.Windows.Forms.Timer(this.components);
            this.lblOvlasti = new System.Windows.Forms.Label();
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeZalihaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nabavnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodajnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonOdjavaIzPrograma
            // 
            this.ButtonOdjavaIzPrograma.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOdjavaIzPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonOdjavaIzPrograma.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonOdjavaIzPrograma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonOdjavaIzPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOdjavaIzPrograma.ForeColor = System.Drawing.Color.Black;
            this.ButtonOdjavaIzPrograma.Location = new System.Drawing.Point(705, 346);
            this.ButtonOdjavaIzPrograma.Name = "ButtonOdjavaIzPrograma";
            this.ButtonOdjavaIzPrograma.Size = new System.Drawing.Size(170, 87);
            this.ButtonOdjavaIzPrograma.TabIndex = 5;
            this.ButtonOdjavaIzPrograma.Text = "Odjava";
            this.ButtonOdjavaIzPrograma.UseVisualStyleBackColor = false;
            this.ButtonOdjavaIzPrograma.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonOprema
            // 
            this.ButtonOprema.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOprema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonOprema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOprema.ForeColor = System.Drawing.Color.Black;
            this.ButtonOprema.Location = new System.Drawing.Point(57, 97);
            this.ButtonOprema.Name = "ButtonOprema";
            this.ButtonOprema.Size = new System.Drawing.Size(170, 87);
            this.ButtonOprema.TabIndex = 0;
            this.ButtonOprema.Text = "Oprema";
            this.ButtonOprema.UseVisualStyleBackColor = false;
            this.ButtonOprema.Click += new System.EventHandler(this.ButtonOprema_Click);
            // 
            // ButtonKategorije
            // 
            this.ButtonKategorije.BackColor = System.Drawing.Color.Transparent;
            this.ButtonKategorije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonKategorije.ForeColor = System.Drawing.Color.Black;
            this.ButtonKategorije.Location = new System.Drawing.Point(57, 216);
            this.ButtonKategorije.Name = "ButtonKategorije";
            this.ButtonKategorije.Size = new System.Drawing.Size(170, 87);
            this.ButtonKategorije.TabIndex = 1;
            this.ButtonKategorije.Text = "Kategorije";
            this.ButtonKategorije.UseVisualStyleBackColor = false;
            this.ButtonKategorije.Click += new System.EventHandler(this.ButtonKategorije_Click);
            // 
            // ButtonPoslovniSubjekti
            // 
            this.ButtonPoslovniSubjekti.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPoslovniSubjekti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPoslovniSubjekti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPoslovniSubjekti.ForeColor = System.Drawing.Color.Black;
            this.ButtonPoslovniSubjekti.Location = new System.Drawing.Point(57, 346);
            this.ButtonPoslovniSubjekti.Name = "ButtonPoslovniSubjekti";
            this.ButtonPoslovniSubjekti.Size = new System.Drawing.Size(170, 87);
            this.ButtonPoslovniSubjekti.TabIndex = 2;
            this.ButtonPoslovniSubjekti.Text = "Poslovni subjekti";
            this.ButtonPoslovniSubjekti.UseVisualStyleBackColor = false;
            this.ButtonPoslovniSubjekti.Click += new System.EventHandler(this.ButtonDobavljaci_Click);
            // 
            // ButtonDokumenti
            // 
            this.ButtonDokumenti.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDokumenti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDokumenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDokumenti.ForeColor = System.Drawing.Color.Black;
            this.ButtonDokumenti.Location = new System.Drawing.Point(705, 216);
            this.ButtonDokumenti.Name = "ButtonDokumenti";
            this.ButtonDokumenti.Size = new System.Drawing.Size(170, 87);
            this.ButtonDokumenti.TabIndex = 4;
            this.ButtonDokumenti.Text = "Dokumenti";
            this.ButtonDokumenti.UseVisualStyleBackColor = false;
            this.ButtonDokumenti.Click += new System.EventHandler(this.ButtonNarudzbe_Click);
            // 
            // ButtonZaposlenici
            // 
            this.ButtonZaposlenici.BackColor = System.Drawing.Color.Transparent;
            this.ButtonZaposlenici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonZaposlenici.ForeColor = System.Drawing.Color.Black;
            this.ButtonZaposlenici.Location = new System.Drawing.Point(705, 92);
            this.ButtonZaposlenici.Name = "ButtonZaposlenici";
            this.ButtonZaposlenici.Size = new System.Drawing.Size(170, 87);
            this.ButtonZaposlenici.TabIndex = 3;
            this.ButtonZaposlenici.Text = "Zaposlenici";
            this.ButtonZaposlenici.UseVisualStyleBackColor = false;
            this.ButtonZaposlenici.Click += new System.EventHandler(this.ButtonZaposlenici_Click);
            // 
            // trenutnoVrijemeLabela
            // 
            this.trenutnoVrijemeLabela.AutoSize = true;
            this.trenutnoVrijemeLabela.BackColor = System.Drawing.Color.Transparent;
            this.trenutnoVrijemeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trenutnoVrijemeLabela.Location = new System.Drawing.Point(847, 9);
            this.trenutnoVrijemeLabela.Name = "trenutnoVrijemeLabela";
            this.trenutnoVrijemeLabela.Size = new System.Drawing.Size(55, 17);
            this.trenutnoVrijemeLabela.TabIndex = 7;
            this.trenutnoVrijemeLabela.Text = "Vrijeme";
            // 
            // timerVrijeme
            // 
            this.timerVrijeme.Enabled = true;
            this.timerVrijeme.Tick += new System.EventHandler(this.timerVrijeme_Tick);
            // 
            // lblOvlasti
            // 
            this.lblOvlasti.AutoSize = true;
            this.lblOvlasti.BackColor = System.Drawing.Color.Transparent;
            this.lblOvlasti.Location = new System.Drawing.Point(12, 11);
            this.lblOvlasti.Name = "lblOvlasti";
            this.lblOvlasti.Size = new System.Drawing.Size(0, 13);
            this.lblOvlasti.TabIndex = 9;
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AllowUserToDeleteRows = false;
            this.dgvObavijesti.AllowUserToResizeColumns = false;
            this.dgvObavijesti.AllowUserToResizeRows = false;
            this.dgvObavijesti.AutoGenerateColumns = false;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kategorijaDataGridViewTextBoxColumn,
            this.stanjeZalihaDataGridViewTextBoxColumn,
            this.nabavnaCijenaDataGridViewTextBoxColumn,
            this.prodajnaCijenaDataGridViewTextBoxColumn,
            this.stavkeDokumentaDataGridViewTextBoxColumn});
            this.dgvObavijesti.DataSource = this.proizvodiBindingSource;
            this.dgvObavijesti.Location = new System.Drawing.Point(276, 346);
            this.dgvObavijesti.MultiSelect = false;
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.ReadOnly = true;
            this.dgvObavijesti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvObavijesti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObavijesti.Size = new System.Drawing.Size(387, 87);
            this.dgvObavijesti.TabIndex = 10;
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
            this.stanjeZalihaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stanjeZalihaDataGridViewTextBoxColumn.DataPropertyName = "StanjeZaliha";
            this.stanjeZalihaDataGridViewTextBoxColumn.HeaderText = "Stanje zaliha";
            this.stanjeZalihaDataGridViewTextBoxColumn.Name = "stanjeZalihaDataGridViewTextBoxColumn";
            this.stanjeZalihaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanjeZalihaDataGridViewTextBoxColumn.Width = 92;
            // 
            // nabavnaCijenaDataGridViewTextBoxColumn
            // 
            this.nabavnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "NabavnaCijena";
            this.nabavnaCijenaDataGridViewTextBoxColumn.HeaderText = "NabavnaCijena";
            this.nabavnaCijenaDataGridViewTextBoxColumn.Name = "nabavnaCijenaDataGridViewTextBoxColumn";
            this.nabavnaCijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nabavnaCijenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodajnaCijenaDataGridViewTextBoxColumn
            // 
            this.prodajnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "ProdajnaCijena";
            this.prodajnaCijenaDataGridViewTextBoxColumn.HeaderText = "ProdajnaCijena";
            this.prodajnaCijenaDataGridViewTextBoxColumn.Name = "prodajnaCijenaDataGridViewTextBoxColumn";
            this.prodajnaCijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodajnaCijenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkeDokumentaDataGridViewTextBoxColumn.DataPropertyName = "StavkeDokumenta";
            this.stavkeDokumentaDataGridViewTextBoxColumn.HeaderText = "StavkeDokumenta";
            this.stavkeDokumentaDataGridViewTextBoxColumn.Name = "stavkeDokumentaDataGridViewTextBoxColumn";
            this.stavkeDokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkeDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataSource = typeof(CroMed.Proizvodi);
            // 
            // GlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.ButtonOdjavaIzPrograma;
            this.ClientSize = new System.Drawing.Size(930, 462);
            this.ControlBox = false;
            this.Controls.Add(this.dgvObavijesti);
            this.Controls.Add(this.lblOvlasti);
            this.Controls.Add(this.trenutnoVrijemeLabela);
            this.Controls.Add(this.ButtonPoslovniSubjekti);
            this.Controls.Add(this.ButtonDokumenti);
            this.Controls.Add(this.ButtonZaposlenici);
            this.Controls.Add(this.ButtonKategorije);
            this.Controls.Add(this.ButtonOprema);
            this.Controls.Add(this.ButtonOdjavaIzPrograma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.Activated += new System.EventHandler(this.GlavniIzbornik_Activated);
            this.Load += new System.EventHandler(this.GlavniIzbornik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOdjavaIzPrograma;
        private System.Windows.Forms.Button ButtonOprema;
        private System.Windows.Forms.Button ButtonKategorije;
        private System.Windows.Forms.Button ButtonPoslovniSubjekti;
        private System.Windows.Forms.Button ButtonDokumenti;
        private System.Windows.Forms.Button ButtonZaposlenici;
        private System.Windows.Forms.Label trenutnoVrijemeLabela;
        private System.Windows.Forms.Timer timerVrijeme;
        private System.Windows.Forms.Label lblOvlasti;
        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeZalihaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nabavnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodajnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeDokumentaDataGridViewTextBoxColumn;
    }
}

