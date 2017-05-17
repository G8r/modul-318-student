namespace SwissPublicTransport
{
    partial class Verbindungen
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
            this.verbindungenLbl = new System.Windows.Forms.Label();
            this.verbindungenVonLbl = new System.Windows.Forms.Label();
            this.verbindungenVonTb = new System.Windows.Forms.TextBox();
            this.verbindungenBisTb = new System.Windows.Forms.TextBox();
            this.verbindungenBisLbl = new System.Windows.Forms.Label();
            this.verbindungSuchenBtn = new System.Windows.Forms.Button();
            this.verbindungenSuchresultatDg = new System.Windows.Forms.DataGridView();
            this.verbindungenDtp = new System.Windows.Forms.DateTimePicker();
            this.verbindungenDatumLbl = new System.Windows.Forms.Label();
            this.vonStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bisStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vGleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.verbindungenSuchresultatDg)).BeginInit();
            this.SuspendLayout();
            // 
            // verbindungenLbl
            // 
            this.verbindungenLbl.AutoSize = true;
            this.verbindungenLbl.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verbindungenLbl.Location = new System.Drawing.Point(499, 133);
            this.verbindungenLbl.Name = "verbindungenLbl";
            this.verbindungenLbl.Size = new System.Drawing.Size(396, 59);
            this.verbindungenLbl.TabIndex = 0;
            this.verbindungenLbl.Text = "Verbindung suchen:";
            // 
            // verbindungenVonLbl
            // 
            this.verbindungenVonLbl.AutoSize = true;
            this.verbindungenVonLbl.Location = new System.Drawing.Point(325, 218);
            this.verbindungenVonLbl.Name = "verbindungenVonLbl";
            this.verbindungenVonLbl.Size = new System.Drawing.Size(56, 25);
            this.verbindungenVonLbl.TabIndex = 1;
            this.verbindungenVonLbl.Text = "Von:";
            // 
            // verbindungenVonTb
            // 
            this.verbindungenVonTb.Location = new System.Drawing.Point(330, 246);
            this.verbindungenVonTb.Name = "verbindungenVonTb";
            this.verbindungenVonTb.Size = new System.Drawing.Size(326, 31);
            this.verbindungenVonTb.TabIndex = 0;
            // 
            // verbindungenBisTb
            // 
            this.verbindungenBisTb.Location = new System.Drawing.Point(772, 246);
            this.verbindungenBisTb.Name = "verbindungenBisTb";
            this.verbindungenBisTb.Size = new System.Drawing.Size(326, 31);
            this.verbindungenBisTb.TabIndex = 1;
            // 
            // verbindungenBisLbl
            // 
            this.verbindungenBisLbl.AutoSize = true;
            this.verbindungenBisLbl.Location = new System.Drawing.Point(767, 218);
            this.verbindungenBisLbl.Name = "verbindungenBisLbl";
            this.verbindungenBisLbl.Size = new System.Drawing.Size(48, 25);
            this.verbindungenBisLbl.TabIndex = 3;
            this.verbindungenBisLbl.Text = "Bis:";
            // 
            // verbindungSuchenBtn
            // 
            this.verbindungSuchenBtn.Location = new System.Drawing.Point(861, 338);
            this.verbindungSuchenBtn.Name = "verbindungSuchenBtn";
            this.verbindungSuchenBtn.Size = new System.Drawing.Size(237, 43);
            this.verbindungSuchenBtn.TabIndex = 3;
            this.verbindungSuchenBtn.Text = "Verbindungen suchen";
            this.verbindungSuchenBtn.UseVisualStyleBackColor = true;
            this.verbindungSuchenBtn.Click += new System.EventHandler(this.verbindungSuchenBtn_Click);
            // 
            // verbindungenSuchresultatDg
            // 
            this.verbindungenSuchresultatDg.BackgroundColor = System.Drawing.Color.DimGray;
            this.verbindungenSuchresultatDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verbindungenSuchresultatDg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.verbindungenSuchresultatDg.ColumnHeadersHeight = 50;
            this.verbindungenSuchresultatDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.verbindungenSuchresultatDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vonStation,
            this.bisStation,
            this.dauer,
            this.abfahrt,
            this.ankunft,
            this.vGleis,
            this.bGleis});
            this.verbindungenSuchresultatDg.Location = new System.Drawing.Point(65, 496);
            this.verbindungenSuchresultatDg.Name = "verbindungenSuchresultatDg";
            this.verbindungenSuchresultatDg.RowHeadersVisible = false;
            this.verbindungenSuchresultatDg.RowHeadersWidth = 300;
            this.verbindungenSuchresultatDg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.verbindungenSuchresultatDg.RowTemplate.Height = 45;
            this.verbindungenSuchresultatDg.RowTemplate.ReadOnly = true;
            this.verbindungenSuchresultatDg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.verbindungenSuchresultatDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.verbindungenSuchresultatDg.Size = new System.Drawing.Size(1355, 293);
            this.verbindungenSuchresultatDg.TabIndex = 4;
            // 
            // verbindungenDtp
            // 
            this.verbindungenDtp.Location = new System.Drawing.Point(330, 338);
            this.verbindungenDtp.MinDate = new System.DateTime(2017, 5, 17, 0, 0, 0, 0);
            this.verbindungenDtp.Name = "verbindungenDtp";
            this.verbindungenDtp.Size = new System.Drawing.Size(200, 31);
            this.verbindungenDtp.TabIndex = 5;
            // 
            // verbindungenDatumLbl
            // 
            this.verbindungenDatumLbl.AutoSize = true;
            this.verbindungenDatumLbl.Location = new System.Drawing.Point(325, 310);
            this.verbindungenDatumLbl.Name = "verbindungenDatumLbl";
            this.verbindungenDatumLbl.Size = new System.Drawing.Size(80, 25);
            this.verbindungenDatumLbl.TabIndex = 6;
            this.verbindungenDatumLbl.Text = "Datum:";
            // 
            // vonStation
            // 
            this.vonStation.HeaderText = "Von:";
            this.vonStation.Name = "vonStation";
            // 
            // bisStation
            // 
            this.bisStation.HeaderText = "Bis:";
            this.bisStation.Name = "bisStation";
            // 
            // dauer
            // 
            this.dauer.HeaderText = "Dauer:";
            this.dauer.Name = "dauer";
            // 
            // abfahrt
            // 
            this.abfahrt.HeaderText = "Abfahrt";
            this.abfahrt.Name = "abfahrt";
            // 
            // ankunft
            // 
            this.ankunft.HeaderText = "Ankunft";
            this.ankunft.Name = "ankunft";
            // 
            // vGleis
            // 
            this.vGleis.HeaderText = "Gleis Abfahrt:";
            this.vGleis.Name = "vGleis";
            // 
            // bGleis
            // 
            this.bGleis.HeaderText = "Gleis Ankunft:";
            this.bGleis.Name = "bGleis";
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verbindungenDatumLbl);
            this.Controls.Add(this.verbindungenDtp);
            this.Controls.Add(this.verbindungenSuchresultatDg);
            this.Controls.Add(this.verbindungSuchenBtn);
            this.Controls.Add(this.verbindungenBisTb);
            this.Controls.Add(this.verbindungenBisLbl);
            this.Controls.Add(this.verbindungenVonTb);
            this.Controls.Add(this.verbindungenVonLbl);
            this.Controls.Add(this.verbindungenLbl);
            this.Name = "Verbindungen";
            this.Size = new System.Drawing.Size(1478, 927);
            ((System.ComponentModel.ISupportInitialize)(this.verbindungenSuchresultatDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label verbindungenLbl;
        private System.Windows.Forms.Label verbindungenVonLbl;
        private System.Windows.Forms.TextBox verbindungenVonTb;
        private System.Windows.Forms.TextBox verbindungenBisTb;
        private System.Windows.Forms.Label verbindungenBisLbl;
        private System.Windows.Forms.Button verbindungSuchenBtn;
        private System.Windows.Forms.DataGridView verbindungenSuchresultatDg;
        private System.Windows.Forms.DateTimePicker verbindungenDtp;
        private System.Windows.Forms.Label verbindungenDatumLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn vonStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn bisStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn vGleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGleis;
    }
}
