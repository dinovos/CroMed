namespace CroMed
{
    partial class KategorijeFormaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategorijeFormaAdmin));
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DodajKategoriju = new System.Windows.Forms.Button();
            this.UrediKategoriju = new System.Windows.Forms.Button();
            this.ObrisiKategoriju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.AllowUserToAddRows = false;
            this.dgvKategorije.AllowUserToDeleteRows = false;
            this.dgvKategorije.AllowUserToResizeColumns = false;
            this.dgvKategorije.AllowUserToResizeRows = false;
            this.dgvKategorije.AutoGenerateColumns = false;
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.proizvodiDataGridViewTextBoxColumn});
            this.dgvKategorije.DataSource = this.kategorijaBindingSource;
            this.dgvKategorije.Location = new System.Drawing.Point(28, 125);
            this.dgvKategorije.MultiSelect = false;
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.ReadOnly = true;
            this.dgvKategorije.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategorije.Size = new System.Drawing.Size(879, 311);
            this.dgvKategorije.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Šifra kategorije";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 102;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proizvodiDataGridViewTextBoxColumn
            // 
            this.proizvodiDataGridViewTextBoxColumn.DataPropertyName = "Proizvodi";
            this.proizvodiDataGridViewTextBoxColumn.HeaderText = "Proizvodi";
            this.proizvodiDataGridViewTextBoxColumn.Name = "proizvodiDataGridViewTextBoxColumn";
            this.proizvodiDataGridViewTextBoxColumn.ReadOnly = true;
            this.proizvodiDataGridViewTextBoxColumn.Visible = false;
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataSource = typeof(CroMed.Kategorija);
            // 
            // DodajKategoriju
            // 
            this.DodajKategoriju.Location = new System.Drawing.Point(30, 44);
            this.DodajKategoriju.Name = "DodajKategoriju";
            this.DodajKategoriju.Size = new System.Drawing.Size(100, 38);
            this.DodajKategoriju.TabIndex = 1;
            this.DodajKategoriju.Text = "Dodaj kategoriju";
            this.DodajKategoriju.UseVisualStyleBackColor = true;
            this.DodajKategoriju.Click += new System.EventHandler(this.DodajKategoriju_Click);
            // 
            // UrediKategoriju
            // 
            this.UrediKategoriju.Location = new System.Drawing.Point(163, 44);
            this.UrediKategoriju.Name = "UrediKategoriju";
            this.UrediKategoriju.Size = new System.Drawing.Size(100, 38);
            this.UrediKategoriju.TabIndex = 2;
            this.UrediKategoriju.Text = "Uredi kategoriju";
            this.UrediKategoriju.UseVisualStyleBackColor = true;
            this.UrediKategoriju.Click += new System.EventHandler(this.UrediKategoriju_Click);
            // 
            // ObrisiKategoriju
            // 
            this.ObrisiKategoriju.Location = new System.Drawing.Point(296, 44);
            this.ObrisiKategoriju.Name = "ObrisiKategoriju";
            this.ObrisiKategoriju.Size = new System.Drawing.Size(100, 38);
            this.ObrisiKategoriju.TabIndex = 3;
            this.ObrisiKategoriju.Text = "Obriši kategoriju";
            this.ObrisiKategoriju.UseVisualStyleBackColor = true;
            this.ObrisiKategoriju.Click += new System.EventHandler(this.ObrisiKategoriju_Click);
            // 
            // KategorijeFormaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 461);
            this.Controls.Add(this.ObrisiKategoriju);
            this.Controls.Add(this.UrediKategoriju);
            this.Controls.Add(this.DodajKategoriju);
            this.Controls.Add(this.dgvKategorije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KategorijeFormaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorije";
            this.Activated += new System.EventHandler(this.KategorijeFormaAdmin_Activated);
            this.Load += new System.EventHandler(this.KategorijeFormaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.Button DodajKategoriju;
        private System.Windows.Forms.Button UrediKategoriju;
        private System.Windows.Forms.Button ObrisiKategoriju;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodiDataGridViewTextBoxColumn;
    }
}