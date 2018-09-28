namespace CroMed
{
    partial class LoginForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForma));
            this.inputKorisnickoIme = new System.Windows.Forms.TextBox();
            this.inputLozinka = new System.Windows.Forms.TextBox();
            this.KorisnickoImeLabel = new System.Windows.Forms.Label();
            this.LozinkaLabel = new System.Windows.Forms.Label();
            this.PrijavaButton = new System.Windows.Forms.Button();
            this.IzlazButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputKorisnickoIme
            // 
            this.inputKorisnickoIme.Location = new System.Drawing.Point(112, 221);
            this.inputKorisnickoIme.Name = "inputKorisnickoIme";
            this.inputKorisnickoIme.Size = new System.Drawing.Size(108, 20);
            this.inputKorisnickoIme.TabIndex = 0;
            // 
            // inputLozinka
            // 
            this.inputLozinka.Location = new System.Drawing.Point(112, 255);
            this.inputLozinka.Name = "inputLozinka";
            this.inputLozinka.PasswordChar = '*';
            this.inputLozinka.Size = new System.Drawing.Size(108, 20);
            this.inputLozinka.TabIndex = 1;
            // 
            // KorisnickoImeLabel
            // 
            this.KorisnickoImeLabel.AutoSize = true;
            this.KorisnickoImeLabel.Location = new System.Drawing.Point(25, 228);
            this.KorisnickoImeLabel.Name = "KorisnickoImeLabel";
            this.KorisnickoImeLabel.Size = new System.Drawing.Size(81, 13);
            this.KorisnickoImeLabel.TabIndex = 2;
            this.KorisnickoImeLabel.Text = "Korisničko ime: ";
            // 
            // LozinkaLabel
            // 
            this.LozinkaLabel.AutoSize = true;
            this.LozinkaLabel.Location = new System.Drawing.Point(56, 262);
            this.LozinkaLabel.Name = "LozinkaLabel";
            this.LozinkaLabel.Size = new System.Drawing.Size(50, 13);
            this.LozinkaLabel.TabIndex = 3;
            this.LozinkaLabel.Text = "Lozinka: ";
            // 
            // PrijavaButton
            // 
            this.PrijavaButton.Location = new System.Drawing.Point(132, 303);
            this.PrijavaButton.Name = "PrijavaButton";
            this.PrijavaButton.Size = new System.Drawing.Size(88, 34);
            this.PrijavaButton.TabIndex = 3;
            this.PrijavaButton.Text = "Prijava";
            this.PrijavaButton.UseVisualStyleBackColor = true;
            this.PrijavaButton.Click += new System.EventHandler(this.PrijavaButton_Click);
            // 
            // IzlazButton
            // 
            this.IzlazButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IzlazButton.Location = new System.Drawing.Point(28, 303);
            this.IzlazButton.Name = "IzlazButton";
            this.IzlazButton.Size = new System.Drawing.Size(88, 34);
            this.IzlazButton.TabIndex = 4;
            this.IzlazButton.Text = "Izlaz";
            this.IzlazButton.UseVisualStyleBackColor = true;
            this.IzlazButton.Click += new System.EventHandler(this.IzlazButton_Click);
            // 
            // LoginForma
            // 
            this.AcceptButton = this.PrijavaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.IzlazButton;
            this.ClientSize = new System.Drawing.Size(262, 353);
            this.ControlBox = false;
            this.Controls.Add(this.IzlazButton);
            this.Controls.Add(this.PrijavaButton);
            this.Controls.Add(this.LozinkaLabel);
            this.Controls.Add(this.KorisnickoImeLabel);
            this.Controls.Add(this.inputLozinka);
            this.Controls.Add(this.inputKorisnickoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijavi se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputKorisnickoIme;
        private System.Windows.Forms.TextBox inputLozinka;
        private System.Windows.Forms.Label KorisnickoImeLabel;
        private System.Windows.Forms.Label LozinkaLabel;
        private System.Windows.Forms.Button PrijavaButton;
        private System.Windows.Forms.Button IzlazButton;
    }
}