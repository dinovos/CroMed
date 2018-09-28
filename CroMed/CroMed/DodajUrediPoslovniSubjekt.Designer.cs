namespace CroMed
{
    partial class DodajUrediPoslovniSubjekt
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label kontaktLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label vrstaSubjektaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajUrediPoslovniSubjekt));
            this.Spremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.poslovniSubjektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.kontaktTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.vrstaSubjektaComboBox = new System.Windows.Forms.ComboBox();
            this.vrstaSubjektaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            kontaktLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            vrstaSubjektaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniSubjektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaSubjektaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Location = new System.Drawing.Point(67, 70);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 10;
            idLabel.Text = "Id:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Location = new System.Drawing.Point(49, 112);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 11;
            nazivLabel.Text = "Naziv:";
            // 
            // kontaktLabel
            // 
            kontaktLabel.AutoSize = true;
            kontaktLabel.BackColor = System.Drawing.Color.Transparent;
            kontaktLabel.Location = new System.Drawing.Point(39, 148);
            kontaktLabel.Name = "kontaktLabel";
            kontaktLabel.Size = new System.Drawing.Size(47, 13);
            kontaktLabel.TabIndex = 12;
            kontaktLabel.Text = "Kontakt:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.BackColor = System.Drawing.Color.Transparent;
            adresaLabel.Location = new System.Drawing.Point(43, 189);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 13;
            adresaLabel.Text = "Adresa:";
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.BackColor = System.Drawing.Color.Transparent;
            oIBLabel.Location = new System.Drawing.Point(58, 230);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(28, 13);
            oIBLabel.TabIndex = 14;
            oIBLabel.Text = "OIB:";
            // 
            // vrstaSubjektaLabel
            // 
            vrstaSubjektaLabel.AutoSize = true;
            vrstaSubjektaLabel.BackColor = System.Drawing.Color.Transparent;
            vrstaSubjektaLabel.Location = new System.Drawing.Point(49, 270);
            vrstaSubjektaLabel.Name = "vrstaSubjektaLabel";
            vrstaSubjektaLabel.Size = new System.Drawing.Size(37, 13);
            vrstaSubjektaLabel.TabIndex = 15;
            vrstaSubjektaLabel.Text = "Vrsta :";
            // 
            // Spremi
            // 
            this.Spremi.Location = new System.Drawing.Point(297, 326);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(75, 23);
            this.Spremi.TabIndex = 8;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = true;
            this.Spremi.Click += new System.EventHandler(this.Spremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(12, 326);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.button1_Click);
            // 
            // poslovniSubjektBindingSource
            // 
            this.poslovniSubjektBindingSource.DataSource = typeof(CroMed.PoslovniSubjekt);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniSubjektBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(92, 67);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(41, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniSubjektBindingSource, "Naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(92, 109);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(165, 20);
            this.nazivTextBox.TabIndex = 12;
            // 
            // kontaktTextBox
            // 
            this.kontaktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniSubjektBindingSource, "Kontakt", true));
            this.kontaktTextBox.Location = new System.Drawing.Point(92, 145);
            this.kontaktTextBox.Name = "kontaktTextBox";
            this.kontaktTextBox.Size = new System.Drawing.Size(165, 20);
            this.kontaktTextBox.TabIndex = 13;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniSubjektBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(92, 186);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(262, 20);
            this.adresaTextBox.TabIndex = 14;
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniSubjektBindingSource, "OIB", true));
            this.oIBTextBox.Location = new System.Drawing.Point(92, 227);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.Size = new System.Drawing.Size(165, 20);
            this.oIBTextBox.TabIndex = 15;
            // 
            // vrstaSubjektaComboBox
            // 
            this.vrstaSubjektaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniSubjektBindingSource, "VrstaSubjekta", true));
            this.vrstaSubjektaComboBox.DataSource = this.vrstaSubjektaBindingSource;
            this.vrstaSubjektaComboBox.DisplayMember = "Opis";
            this.vrstaSubjektaComboBox.FormattingEnabled = true;
            this.vrstaSubjektaComboBox.Location = new System.Drawing.Point(92, 267);
            this.vrstaSubjektaComboBox.Name = "vrstaSubjektaComboBox";
            this.vrstaSubjektaComboBox.Size = new System.Drawing.Size(165, 21);
            this.vrstaSubjektaComboBox.TabIndex = 16;
            this.vrstaSubjektaComboBox.ValueMember = "Id";
            // 
            // vrstaSubjektaBindingSource
            // 
            this.vrstaSubjektaBindingSource.DataSource = typeof(CroMed.VrstaSubjekta);
            // 
            // DodajUrediPoslovniSubjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(399, 369);
            this.ControlBox = false;
            this.Controls.Add(vrstaSubjektaLabel);
            this.Controls.Add(this.vrstaSubjektaComboBox);
            this.Controls.Add(oIBLabel);
            this.Controls.Add(this.oIBTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(kontaktLabel);
            this.Controls.Add(this.kontaktTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.Spremi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajUrediPoslovniSubjekt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj / Uredi poslovni subjekt";
            this.Load += new System.EventHandler(this.DodajUrediPoslovniSubjekt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poslovniSubjektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaSubjektaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource poslovniSubjektBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox kontaktTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox oIBTextBox;
        private System.Windows.Forms.ComboBox vrstaSubjektaComboBox;
        private System.Windows.Forms.BindingSource vrstaSubjektaBindingSource;
    }
}