namespace CroMed
{
    partial class UrediStanjeDokumenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrediStanjeDokumenta));
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.comboStanje = new System.Windows.Forms.ComboBox();
            this.stanjeDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblStanje = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeDokumentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(130, 102);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(118, 20);
            this.inputDatum.TabIndex = 0;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(305, 341);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 1;
            this.btnUnesi.Text = "Izmjeni";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Location = new System.Drawing.Point(55, 102);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // comboStanje
            // 
            this.comboStanje.DataSource = this.stanjeDokumentaBindingSource;
            this.comboStanje.DisplayMember = "Vrsta";
            this.comboStanje.FormattingEnabled = true;
            this.comboStanje.Location = new System.Drawing.Point(127, 150);
            this.comboStanje.Name = "comboStanje";
            this.comboStanje.Size = new System.Drawing.Size(121, 21);
            this.comboStanje.TabIndex = 5;
            this.comboStanje.ValueMember = "Id";
            // 
            // stanjeDokumentaBindingSource
            // 
            this.stanjeDokumentaBindingSource.DataSource = typeof(CroMed.StanjeDokumenta);
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.BackColor = System.Drawing.Color.Transparent;
            this.lblStanje.Location = new System.Drawing.Point(56, 153);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(40, 13);
            this.lblStanje.TabIndex = 6;
            this.lblStanje.Text = "Stanje:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(127, 193);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(177, 87);
            this.txtNapomena.TabIndex = 7;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.BackColor = System.Drawing.Color.Transparent;
            this.lblNapomena.Location = new System.Drawing.Point(56, 193);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 8;
            this.lblNapomena.Text = "Napomena:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 341);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // UrediStanjeDokumenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(392, 376);
            this.ControlBox = false;
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.comboStanje);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.inputDatum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UrediStanjeDokumenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi stanje dokumenta";
            this.Load += new System.EventHandler(this.UrediStanjeDokumenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stanjeDokumentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ComboBox comboStanje;
        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.BindingSource stanjeDokumentaBindingSource;
        private System.Windows.Forms.Button btnOdustani;
    }
}