namespace SwissPublicTransport
{
    partial class Abfahrtstafeln
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.autoCompleteAbfahrtstafelnTB = new System.Windows.Forms.ListView();
            this.abfahrtstafelVonTB = new System.Windows.Forms.TextBox();
            this.verbindungenDatumLbl = new System.Windows.Forms.Label();
            this.verbindungenDtp = new System.Windows.Forms.DateTimePicker();
            this.abfahrtstafelSuchenBtn = new System.Windows.Forms.Button();
            this.verbindungenVonLbl = new System.Windows.Forms.Label();
            this.abfahrtstafelLBL = new System.Windows.Forms.Label();
            this.abfahrtstafelnSuchresultatDG = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtsZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richtung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.abfahrtstafelnSuchresultatDG)).BeginInit();
            this.SuspendLayout();
            // 
            // autoCompleteAbfahrtstafelnTB
            // 
            this.autoCompleteAbfahrtstafelnTB.Location = new System.Drawing.Point(522, 377);
            this.autoCompleteAbfahrtstafelnTB.Name = "autoCompleteAbfahrtstafelnTB";
            this.autoCompleteAbfahrtstafelnTB.Size = new System.Drawing.Size(227, 324);
            this.autoCompleteAbfahrtstafelnTB.TabIndex = 1;
            this.autoCompleteAbfahrtstafelnTB.TabStop = false;
            this.autoCompleteAbfahrtstafelnTB.UseCompatibleStateImageBehavior = false;
            this.autoCompleteAbfahrtstafelnTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.abfahrtstafelVonTBKeyDown);
            this.autoCompleteAbfahrtstafelnTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.autoCompleteAnsichtAbfahrtstafelnMouseClick);
            // 
            // abfahrtstafelVonTB
            // 
            this.abfahrtstafelVonTB.Location = new System.Drawing.Point(522, 341);
            this.abfahrtstafelVonTB.Name = "abfahrtstafelVonTB";
            this.abfahrtstafelVonTB.Size = new System.Drawing.Size(356, 31);
            this.abfahrtstafelVonTB.TabIndex = 0;
            this.abfahrtstafelVonTB.TextChanged += new System.EventHandler(this.abfahrtstafelVonTBTextChanged);
            this.abfahrtstafelVonTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.abfahrtstafelVonTBKeyDown);
            // 
            // verbindungenDatumLbl
            // 
            this.verbindungenDatumLbl.AutoSize = true;
            this.verbindungenDatumLbl.Location = new System.Drawing.Point(517, 404);
            this.verbindungenDatumLbl.Name = "verbindungenDatumLbl";
            this.verbindungenDatumLbl.Size = new System.Drawing.Size(80, 25);
            this.verbindungenDatumLbl.TabIndex = 15;
            this.verbindungenDatumLbl.Text = "Datum:";
            // 
            // verbindungenDtp
            // 
            this.verbindungenDtp.Location = new System.Drawing.Point(522, 432);
            this.verbindungenDtp.MinDate = new System.DateTime(2017, 5, 17, 0, 0, 0, 0);
            this.verbindungenDtp.Name = "verbindungenDtp";
            this.verbindungenDtp.Size = new System.Drawing.Size(200, 31);
            this.verbindungenDtp.TabIndex = 12;
            // 
            // abfahrtstafelSuchenBtn
            // 
            this.abfahrtstafelSuchenBtn.Location = new System.Drawing.Point(924, 335);
            this.abfahrtstafelSuchenBtn.Name = "abfahrtstafelSuchenBtn";
            this.abfahrtstafelSuchenBtn.Size = new System.Drawing.Size(237, 43);
            this.abfahrtstafelSuchenBtn.TabIndex = 1;
            this.abfahrtstafelSuchenBtn.Text = "Abfahrtstafel suchen";
            this.abfahrtstafelSuchenBtn.UseVisualStyleBackColor = true;
            this.abfahrtstafelSuchenBtn.Click += new System.EventHandler(this.abfahrtstafelSuchenBTNClick);
            // 
            // verbindungenVonLbl
            // 
            this.verbindungenVonLbl.AutoSize = true;
            this.verbindungenVonLbl.Location = new System.Drawing.Point(517, 312);
            this.verbindungenVonLbl.Name = "verbindungenVonLbl";
            this.verbindungenVonLbl.Size = new System.Drawing.Size(56, 25);
            this.verbindungenVonLbl.TabIndex = 11;
            this.verbindungenVonLbl.Text = "Von:";
            // 
            // abfahrtstafelLBL
            // 
            this.abfahrtstafelLBL.AutoSize = true;
            this.abfahrtstafelLBL.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abfahrtstafelLBL.Location = new System.Drawing.Point(512, 229);
            this.abfahrtstafelLBL.Name = "abfahrtstafelLBL";
            this.abfahrtstafelLBL.Size = new System.Drawing.Size(420, 59);
            this.abfahrtstafelLBL.TabIndex = 10;
            this.abfahrtstafelLBL.Text = "Abfahrtstafel suchen:";
            // 
            // abfahrtstafelnSuchresultatDG
            // 
            this.abfahrtstafelnSuchresultatDG.BackgroundColor = System.Drawing.Color.DimGray;
            this.abfahrtstafelnSuchresultatDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.abfahrtstafelnSuchresultatDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.abfahrtstafelnSuchresultatDG.ColumnHeadersHeight = 50;
            this.abfahrtstafelnSuchresultatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.abfahrtstafelnSuchresultatDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.abfahrtsZeit,
            this.richtung});
            this.abfahrtstafelnSuchresultatDG.Location = new System.Drawing.Point(413, 404);
            this.abfahrtstafelnSuchresultatDG.Name = "abfahrtstafelnSuchresultatDG";
            this.abfahrtstafelnSuchresultatDG.RowHeadersVisible = false;
            this.abfahrtstafelnSuchresultatDG.RowHeadersWidth = 300;
            this.abfahrtstafelnSuchresultatDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.abfahrtstafelnSuchresultatDG.RowTemplate.Height = 45;
            this.abfahrtstafelnSuchresultatDG.RowTemplate.ReadOnly = true;
            this.abfahrtstafelnSuchresultatDG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.abfahrtstafelnSuchresultatDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abfahrtstafelnSuchresultatDG.Size = new System.Drawing.Size(602, 485);
            this.abfahrtstafelnSuchresultatDG.TabIndex = 19;
            this.abfahrtstafelnSuchresultatDG.TabStop = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name:";
            this.name.Name = "name";
            // 
            // abfahrtsZeit
            // 
            this.abfahrtsZeit.HeaderText = "Abfahrts Zeit:";
            this.abfahrtsZeit.Name = "abfahrtsZeit";
            // 
            // richtung
            // 
            this.richtung.HeaderText = "Richtung:";
            this.richtung.Name = "richtung";
            // 
            // Abfahrtstafeln
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.abfahrtstafelnSuchresultatDG);
            this.Controls.Add(this.autoCompleteAbfahrtstafelnTB);
            this.Controls.Add(this.abfahrtstafelVonTB);
            this.Controls.Add(this.verbindungenDatumLbl);
            this.Controls.Add(this.verbindungenDtp);
            this.Controls.Add(this.abfahrtstafelSuchenBtn);
            this.Controls.Add(this.verbindungenVonLbl);
            this.Controls.Add(this.abfahrtstafelLBL);
            this.Name = "Abfahrtstafeln";
            this.Size = new System.Drawing.Size(1478, 927);
            ((System.ComponentModel.ISupportInitialize)(this.abfahrtstafelnSuchresultatDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView autoCompleteAbfahrtstafelnTB;
        private System.Windows.Forms.TextBox abfahrtstafelVonTB;
        private System.Windows.Forms.Label verbindungenDatumLbl;
        private System.Windows.Forms.DateTimePicker verbindungenDtp;
        private System.Windows.Forms.Button abfahrtstafelSuchenBtn;
        private System.Windows.Forms.Label verbindungenVonLbl;
        private System.Windows.Forms.Label abfahrtstafelLBL;
        private System.Windows.Forms.DataGridView abfahrtstafelnSuchresultatDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtsZeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn richtung;
    }
}
