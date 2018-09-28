namespace CroMed
{
    partial class DodajUrediZaposlenika
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label kontaktLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label korisnickoImeLabel;
            System.Windows.Forms.Label lozinkaLabel;
            System.Windows.Forms.Label razinaOvlastiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajUrediZaposlenika));
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.kontaktTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.razinaOvlastiComboBox = new System.Windows.Forms.ComboBox();
            this.razinaOvlastiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            kontaktLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            korisnickoImeLabel = new System.Windows.Forms.Label();
            lozinkaLabel = new System.Windows.Forms.Label();
            razinaOvlastiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razinaOvlastiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Location = new System.Drawing.Point(77, 25);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.BackColor = System.Drawing.Color.Transparent;
            imeLabel.Location = new System.Drawing.Point(69, 65);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.BackColor = System.Drawing.Color.Transparent;
            prezimeLabel.Location = new System.Drawing.Point(49, 104);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 5;
            prezimeLabel.Text = "Prezime:";
            // 
            // kontaktLabel
            // 
            kontaktLabel.AutoSize = true;
            kontaktLabel.BackColor = System.Drawing.Color.Transparent;
            kontaktLabel.Location = new System.Drawing.Point(52, 143);
            kontaktLabel.Name = "kontaktLabel";
            kontaktLabel.Size = new System.Drawing.Size(47, 13);
            kontaktLabel.TabIndex = 7;
            kontaktLabel.Text = "Kontakt:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.BackColor = System.Drawing.Color.Transparent;
            adresaLabel.Location = new System.Drawing.Point(56, 181);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 8;
            adresaLabel.Text = "Adresa:";
            // 
            // korisnickoImeLabel
            // 
            korisnickoImeLabel.AutoSize = true;
            korisnickoImeLabel.BackColor = System.Drawing.Color.Transparent;
            korisnickoImeLabel.Location = new System.Drawing.Point(20, 221);
            korisnickoImeLabel.Name = "korisnickoImeLabel";
            korisnickoImeLabel.Size = new System.Drawing.Size(78, 13);
            korisnickoImeLabel.TabIndex = 10;
            korisnickoImeLabel.Text = "Korisnicko ime:";
            // 
            // lozinkaLabel
            // 
            lozinkaLabel.AutoSize = true;
            lozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            lozinkaLabel.Location = new System.Drawing.Point(52, 258);
            lozinkaLabel.Name = "lozinkaLabel";
            lozinkaLabel.Size = new System.Drawing.Size(47, 13);
            lozinkaLabel.TabIndex = 12;
            lozinkaLabel.Text = "Lozinka:";
            // 
            // razinaOvlastiLabel
            // 
            razinaOvlastiLabel.AutoSize = true;
            razinaOvlastiLabel.Location = new System.Drawing.Point(21, 295);
            razinaOvlastiLabel.Name = "razinaOvlastiLabel";
            razinaOvlastiLabel.Size = new System.Drawing.Size(76, 13);
            razinaOvlastiLabel.TabIndex = 16;
            razinaOvlastiLabel.Text = "Razina ovlasti:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(105, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(39, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(CroMed.Zaposlenik);
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(105, 62);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(145, 20);
            this.imeTextBox.TabIndex = 4;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(105, 101);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(145, 20);
            this.prezimeTextBox.TabIndex = 6;
            // 
            // kontaktTextBox
            // 
            this.kontaktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Kontakt", true));
            this.kontaktTextBox.Location = new System.Drawing.Point(105, 140);
            this.kontaktTextBox.Name = "kontaktTextBox";
            this.kontaktTextBox.Size = new System.Drawing.Size(182, 20);
            this.kontaktTextBox.TabIndex = 8;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(105, 178);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(182, 20);
            this.adresaTextBox.TabIndex = 9;
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "KorisnickoIme", true));
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(105, 218);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(145, 20);
            this.korisnickoImeTextBox.TabIndex = 11;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Lozinka", true));
            this.lozinkaTextBox.Location = new System.Drawing.Point(105, 255);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(145, 20);
            this.lozinkaTextBox.TabIndex = 13;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(312, 334);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 334);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // razinaOvlastiComboBox
            // 
            this.razinaOvlastiComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "RazinaOvlasti", true));
            this.razinaOvlastiComboBox.DataSource = this.razinaOvlastiBindingSource;
            this.razinaOvlastiComboBox.DisplayMember = "Naziv";
            this.razinaOvlastiComboBox.FormattingEnabled = true;
            this.razinaOvlastiComboBox.Location = new System.Drawing.Point(105, 292);
            this.razinaOvlastiComboBox.Name = "razinaOvlastiComboBox";
            this.razinaOvlastiComboBox.Size = new System.Drawing.Size(121, 21);
            this.razinaOvlastiComboBox.TabIndex = 17;
            this.razinaOvlastiComboBox.ValueMember = "Id";
            // 
            // razinaOvlastiBindingSource
            // 
            this.razinaOvlastiBindingSource.DataSource = typeof(CroMed.RazinaOvlasti);
            // 
            // DodajUrediZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(407, 377);
            this.ControlBox = false;
            this.Controls.Add(razinaOvlastiLabel);
            this.Controls.Add(this.razinaOvlastiComboBox);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(lozinkaLabel);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(korisnickoImeLabel);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(kontaktLabel);
            this.Controls.Add(this.kontaktTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajUrediZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj / Uredi zaposlenika";
            this.Load += new System.EventHandler(this.DodajUrediZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razinaOvlastiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox kontaktTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox razinaOvlastiComboBox;
        private System.Windows.Forms.BindingSource razinaOvlastiBindingSource;
    }
}