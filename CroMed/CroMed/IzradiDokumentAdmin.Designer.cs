namespace CroMed
{
    partial class IzradiDokumentAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzradiDokumentAdmin));
            this.UnesiDokument = new System.Windows.Forms.Button();
            this.StavkeDokumentaListBox = new System.Windows.Forms.ListBox();
            this.StavkeNarudzbeLabela = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.inputKolicina = new System.Windows.Forms.TextBox();
            this.inputArtiklCombo = new System.Windows.Forms.ComboBox();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputSubjektCombo = new System.Windows.Forms.ComboBox();
            this.poslovniSubjektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputIDNarudzbe = new System.Windows.Forms.TextBox();
            this.KolicinaLabela = new System.Windows.Forms.Label();
            this.ArtiklLabela = new System.Windows.Forms.Label();
            this.ZaposlenikLabela = new System.Windows.Forms.Label();
            this.DatumLabela = new System.Windows.Forms.Label();
            this.IDDokumentLbl = new System.Windows.Forms.Label();
            this.txtRabat = new System.Windows.Forms.TextBox();
            this.lblRabat = new System.Windows.Forms.Label();
            this.btnZavrsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniSubjektBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UnesiDokument
            // 
            this.UnesiDokument.Location = new System.Drawing.Point(175, 163);
            this.UnesiDokument.Name = "UnesiDokument";
            this.UnesiDokument.Size = new System.Drawing.Size(69, 23);
            this.UnesiDokument.TabIndex = 32;
            this.UnesiDokument.Text = "Unesi";
            this.UnesiDokument.UseVisualStyleBackColor = true;
            this.UnesiDokument.Click += new System.EventHandler(this.UnesiDokument_Click);
            // 
            // StavkeDokumentaListBox
            // 
            this.StavkeDokumentaListBox.FormattingEnabled = true;
            this.StavkeDokumentaListBox.Location = new System.Drawing.Point(315, 103);
            this.StavkeDokumentaListBox.Name = "StavkeDokumentaListBox";
            this.StavkeDokumentaListBox.Size = new System.Drawing.Size(227, 199);
            this.StavkeDokumentaListBox.TabIndex = 31;
            // 
            // StavkeNarudzbeLabela
            // 
            this.StavkeNarudzbeLabela.AutoSize = true;
            this.StavkeNarudzbeLabela.BackColor = System.Drawing.Color.Transparent;
            this.StavkeNarudzbeLabela.Location = new System.Drawing.Point(312, 76);
            this.StavkeNarudzbeLabela.Name = "StavkeNarudzbeLabela";
            this.StavkeNarudzbeLabela.Size = new System.Drawing.Size(103, 13);
            this.StavkeNarudzbeLabela.TabIndex = 30;
            this.StavkeNarudzbeLabela.Text = "Stavke dokumenta; ";
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(241, 233);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(43, 86);
            this.Dodaj.TabIndex = 29;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(123, 91);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(121, 20);
            this.inputDatum.TabIndex = 28;
            // 
            // inputKolicina
            // 
            this.inputKolicina.Location = new System.Drawing.Point(95, 267);
            this.inputKolicina.Name = "inputKolicina";
            this.inputKolicina.Size = new System.Drawing.Size(121, 20);
            this.inputKolicina.TabIndex = 27;
            // 
            // inputArtiklCombo
            // 
            this.inputArtiklCombo.DataSource = this.proizvodiBindingSource;
            this.inputArtiklCombo.DisplayMember = "Naziv";
            this.inputArtiklCombo.FormattingEnabled = true;
            this.inputArtiklCombo.Location = new System.Drawing.Point(96, 233);
            this.inputArtiklCombo.Name = "inputArtiklCombo";
            this.inputArtiklCombo.Size = new System.Drawing.Size(121, 21);
            this.inputArtiklCombo.TabIndex = 26;
            this.inputArtiklCombo.ValueMember = "Id";
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataSource = typeof(CroMed.Proizvodi);
            // 
            // inputSubjektCombo
            // 
            this.inputSubjektCombo.DataSource = this.poslovniSubjektBindingSource;
            this.inputSubjektCombo.DisplayMember = "Naziv";
            this.inputSubjektCombo.FormattingEnabled = true;
            this.inputSubjektCombo.Location = new System.Drawing.Point(121, 127);
            this.inputSubjektCombo.Name = "inputSubjektCombo";
            this.inputSubjektCombo.Size = new System.Drawing.Size(121, 21);
            this.inputSubjektCombo.TabIndex = 24;
            this.inputSubjektCombo.ValueMember = "Id";
            // 
            // poslovniSubjektBindingSource
            // 
            this.poslovniSubjektBindingSource.DataSource = typeof(CroMed.PoslovniSubjekt);
            // 
            // inputIDNarudzbe
            // 
            this.inputIDNarudzbe.Enabled = false;
            this.inputIDNarudzbe.Location = new System.Drawing.Point(123, 65);
            this.inputIDNarudzbe.Name = "inputIDNarudzbe";
            this.inputIDNarudzbe.Size = new System.Drawing.Size(121, 20);
            this.inputIDNarudzbe.TabIndex = 23;
            // 
            // KolicinaLabela
            // 
            this.KolicinaLabela.AutoSize = true;
            this.KolicinaLabela.BackColor = System.Drawing.Color.Transparent;
            this.KolicinaLabela.Location = new System.Drawing.Point(22, 270);
            this.KolicinaLabela.Name = "KolicinaLabela";
            this.KolicinaLabela.Size = new System.Drawing.Size(50, 13);
            this.KolicinaLabela.TabIndex = 22;
            this.KolicinaLabela.Text = "Količina: ";
            // 
            // ArtiklLabela
            // 
            this.ArtiklLabela.AutoSize = true;
            this.ArtiklLabela.BackColor = System.Drawing.Color.Transparent;
            this.ArtiklLabela.Location = new System.Drawing.Point(22, 236);
            this.ArtiklLabela.Name = "ArtiklLabela";
            this.ArtiklLabela.Size = new System.Drawing.Size(54, 13);
            this.ArtiklLabela.TabIndex = 21;
            this.ArtiklLabela.Text = "Proizvod: ";
            // 
            // ZaposlenikLabela
            // 
            this.ZaposlenikLabela.AutoSize = true;
            this.ZaposlenikLabela.BackColor = System.Drawing.Color.Transparent;
            this.ZaposlenikLabela.Location = new System.Drawing.Point(20, 130);
            this.ZaposlenikLabela.Name = "ZaposlenikLabela";
            this.ZaposlenikLabela.Size = new System.Drawing.Size(90, 13);
            this.ZaposlenikLabela.TabIndex = 19;
            this.ZaposlenikLabela.Text = "Poslovni subjekt: ";
            // 
            // DatumLabela
            // 
            this.DatumLabela.AutoSize = true;
            this.DatumLabela.BackColor = System.Drawing.Color.Transparent;
            this.DatumLabela.Location = new System.Drawing.Point(22, 96);
            this.DatumLabela.Name = "DatumLabela";
            this.DatumLabela.Size = new System.Drawing.Size(44, 13);
            this.DatumLabela.TabIndex = 18;
            this.DatumLabela.Text = "Datum: ";
            // 
            // IDDokumentLbl
            // 
            this.IDDokumentLbl.AutoSize = true;
            this.IDDokumentLbl.BackColor = System.Drawing.Color.Transparent;
            this.IDDokumentLbl.Location = new System.Drawing.Point(20, 68);
            this.IDDokumentLbl.Name = "IDDokumentLbl";
            this.IDDokumentLbl.Size = new System.Drawing.Size(77, 13);
            this.IDDokumentLbl.TabIndex = 17;
            this.IDDokumentLbl.Text = "ID dokumenta:";
            // 
            // txtRabat
            // 
            this.txtRabat.Enabled = false;
            this.txtRabat.Location = new System.Drawing.Point(96, 299);
            this.txtRabat.Name = "txtRabat";
            this.txtRabat.Size = new System.Drawing.Size(121, 20);
            this.txtRabat.TabIndex = 34;
            // 
            // lblRabat
            // 
            this.lblRabat.AutoSize = true;
            this.lblRabat.BackColor = System.Drawing.Color.Transparent;
            this.lblRabat.Location = new System.Drawing.Point(22, 301);
            this.lblRabat.Name = "lblRabat";
            this.lblRabat.Size = new System.Drawing.Size(42, 13);
            this.lblRabat.TabIndex = 33;
            this.lblRabat.Text = "Rabat: ";
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Location = new System.Drawing.Point(439, 326);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(103, 23);
            this.btnZavrsi.TabIndex = 35;
            this.btnZavrsi.Text = "Završi";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // IzradiDokumentAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.txtRabat);
            this.Controls.Add(this.lblRabat);
            this.Controls.Add(this.UnesiDokument);
            this.Controls.Add(this.StavkeDokumentaListBox);
            this.Controls.Add(this.StavkeNarudzbeLabela);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.inputDatum);
            this.Controls.Add(this.inputKolicina);
            this.Controls.Add(this.inputArtiklCombo);
            this.Controls.Add(this.inputSubjektCombo);
            this.Controls.Add(this.inputIDNarudzbe);
            this.Controls.Add(this.KolicinaLabela);
            this.Controls.Add(this.ArtiklLabela);
            this.Controls.Add(this.ZaposlenikLabela);
            this.Controls.Add(this.DatumLabela);
            this.Controls.Add(this.IDDokumentLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzradiDokumentAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izradi dokument";
            this.Load += new System.EventHandler(this.IzradiDokumentAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniSubjektBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnesiDokument;
        private System.Windows.Forms.ListBox StavkeDokumentaListBox;
        private System.Windows.Forms.Label StavkeNarudzbeLabela;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.TextBox inputKolicina;
        private System.Windows.Forms.ComboBox inputArtiklCombo;
        private System.Windows.Forms.ComboBox inputSubjektCombo;
        private System.Windows.Forms.TextBox inputIDNarudzbe;
        private System.Windows.Forms.Label KolicinaLabela;
        private System.Windows.Forms.Label ArtiklLabela;
        private System.Windows.Forms.Label ZaposlenikLabela;
        private System.Windows.Forms.Label DatumLabela;
        private System.Windows.Forms.Label IDDokumentLbl;
        private System.Windows.Forms.TextBox txtRabat;
        private System.Windows.Forms.Label lblRabat;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.BindingSource poslovniSubjektBindingSource;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
    }
}