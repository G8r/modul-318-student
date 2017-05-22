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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verbindungen));
            this.verbindungenLbl = new System.Windows.Forms.Label();
            this.verbindungenVonLbl = new System.Windows.Forms.Label();
            this.verbindungenBisLbl = new System.Windows.Forms.Label();
            this.verbindungSuchenBtn = new System.Windows.Forms.Button();
            this.verbindungenSuchresultatDG = new System.Windows.Forms.DataGridView();
            this.vonStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bisStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vGleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verbindungenDtp = new System.Windows.Forms.DateTimePicker();
            this.verbindungenDatumLbl = new System.Windows.Forms.Label();
            this.verbindungenVonTB = new System.Windows.Forms.TextBox();
            this.verbindungenBisTB = new System.Windows.Forms.TextBox();
            this.autoCompleteVerbindungenLV = new System.Windows.Forms.ListView();
            this.autoCompleteVerbindungenBis = new System.Windows.Forms.ListView();
            this.zeitPicker = new System.Windows.Forms.DateTimePicker();
            this.swapButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.verbindungenSuchresultatDG)).BeginInit();
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
            this.verbindungSuchenBtn.TabIndex = 4;
            this.verbindungSuchenBtn.Text = "Verbindungen suchen";
            this.verbindungSuchenBtn.UseVisualStyleBackColor = true;
            this.verbindungSuchenBtn.Click += new System.EventHandler(this.verbindungSuchenBtn_Click);
            this.verbindungSuchenBtn.Enter += new System.EventHandler(this.verbindungSuchenBTNEnter);
            // 
            // verbindungenSuchresultatDg
            // 
            this.verbindungenSuchresultatDG.BackgroundColor = System.Drawing.Color.DimGray;
            this.verbindungenSuchresultatDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verbindungenSuchresultatDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.verbindungenSuchresultatDG.ColumnHeadersHeight = 50;
            this.verbindungenSuchresultatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.verbindungenSuchresultatDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vonStation,
            this.bisStation,
            this.dauer,
            this.abfahrt,
            this.ankunft,
            this.vGleis,
            this.bGleis});
            this.verbindungenSuchresultatDG.Location = new System.Drawing.Point(38, 512);
            this.verbindungenSuchresultatDG.Name = "verbindungenSuchresultatDg";
            this.verbindungenSuchresultatDG.RowHeadersVisible = false;
            this.verbindungenSuchresultatDG.RowHeadersWidth = 300;
            this.verbindungenSuchresultatDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.verbindungenSuchresultatDG.RowTemplate.Height = 45;
            this.verbindungenSuchresultatDG.RowTemplate.ReadOnly = true;
            this.verbindungenSuchresultatDG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.verbindungenSuchresultatDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.verbindungenSuchresultatDG.Size = new System.Drawing.Size(1400, 293);
            this.verbindungenSuchresultatDG.TabIndex = 4;
            this.verbindungenSuchresultatDG.TabStop = false;
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
            // verbindungenDtp
            // 
            this.verbindungenDtp.Location = new System.Drawing.Point(330, 338);
            this.verbindungenDtp.MinDate = new System.DateTime(2017, 5, 17, 0, 0, 0, 0);
            this.verbindungenDtp.Name = "verbindungenDtp";
            this.verbindungenDtp.Size = new System.Drawing.Size(200, 31);
            this.verbindungenDtp.TabIndex = 2;
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
            // verbindungenVonTB
            // 
            this.verbindungenVonTB.Location = new System.Drawing.Point(330, 247);
            this.verbindungenVonTB.Name = "verbindungenVonTB";
            this.verbindungenVonTB.Size = new System.Drawing.Size(356, 31);
            this.verbindungenVonTB.TabIndex = 0;
            this.verbindungenVonTB.TextChanged += new System.EventHandler(this.verbindungenVonTB_TextChanged_1);
            this.verbindungenVonTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.verbindungenVonKeyDown);
            // 
            // verbindungenBisTB
            // 
            this.verbindungenBisTB.Location = new System.Drawing.Point(772, 247);
            this.verbindungenBisTB.Name = "verbindungenBisTB";
            this.verbindungenBisTB.Size = new System.Drawing.Size(356, 31);
            this.verbindungenBisTB.TabIndex = 2;
            this.verbindungenBisTB.TextChanged += new System.EventHandler(this.verbindungenBisTB_TextChanged);
            this.verbindungenBisTB.Enter += new System.EventHandler(this.benutzerSteuerungEnter);
            this.verbindungenBisTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.verbindungenBisTBKeyDown);
            // 
            // autoCompleteVerbindungen
            // 
            this.autoCompleteVerbindungenLV.Location = new System.Drawing.Point(330, 282);
            this.autoCompleteVerbindungenLV.Name = "autoCompleteVerbindungen";
            this.autoCompleteVerbindungenLV.Size = new System.Drawing.Size(356, 324);
            this.autoCompleteVerbindungenLV.TabIndex = 9;
            this.autoCompleteVerbindungenLV.UseCompatibleStateImageBehavior = false;
            this.autoCompleteVerbindungenLV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.verbindungenVonKeyDown);
            this.autoCompleteVerbindungenLV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.autoCompleteVerbindungenMouseClick);
            // 
            // autoCompleteVerbindungenBis
            // 
            this.autoCompleteVerbindungenBis.Location = new System.Drawing.Point(772, 282);
            this.autoCompleteVerbindungenBis.Name = "autoCompleteVerbindungenBis";
            this.autoCompleteVerbindungenBis.Size = new System.Drawing.Size(356, 324);
            this.autoCompleteVerbindungenBis.TabIndex = 10;
            this.autoCompleteVerbindungenBis.UseCompatibleStateImageBehavior = false;
            this.autoCompleteVerbindungenBis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.verbindungenBisTBKeyDown);
            this.autoCompleteVerbindungenBis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.autoCompleteVerbindungenBisMouseClick);
            // 
            // zeitPicker
            // 
            this.zeitPicker.Location = new System.Drawing.Point(563, 338);
            this.zeitPicker.Name = "zeitPicker";
            this.zeitPicker.Size = new System.Drawing.Size(123, 31);
            this.zeitPicker.TabIndex = 3;
            // 
            // swapButton
            // 
            this.swapButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.swapButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swapButton.BackgroundImage")));
            this.swapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swapButton.Location = new System.Drawing.Point(698, 233);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(63, 61);
            this.swapButton.TabIndex = 1;
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.stationenWechselnClick);
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.autoCompleteVerbindungenLV);
            this.Controls.Add(this.zeitPicker);
            this.Controls.Add(this.autoCompleteVerbindungenBis);
            this.Controls.Add(this.verbindungenBisTB);
            this.Controls.Add(this.verbindungenVonTB);
            this.Controls.Add(this.verbindungenDatumLbl);
            this.Controls.Add(this.verbindungenDtp);
            this.Controls.Add(this.verbindungenSuchresultatDG);
            this.Controls.Add(this.verbindungSuchenBtn);
            this.Controls.Add(this.verbindungenBisLbl);
            this.Controls.Add(this.verbindungenVonLbl);
            this.Controls.Add(this.verbindungenLbl);
            this.MaximumSize = new System.Drawing.Size(1478, 927);
            this.MinimumSize = new System.Drawing.Size(1478, 927);
            this.Name = "Verbindungen";
            this.Size = new System.Drawing.Size(1478, 927);
            ((System.ComponentModel.ISupportInitialize)(this.verbindungenSuchresultatDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label verbindungenLbl;
        private System.Windows.Forms.Label verbindungenVonLbl;
        private System.Windows.Forms.Label verbindungenBisLbl;
        private System.Windows.Forms.Button verbindungSuchenBtn;
        private System.Windows.Forms.DataGridView verbindungenSuchresultatDG;
        private System.Windows.Forms.DateTimePicker verbindungenDtp;
        private System.Windows.Forms.Label verbindungenDatumLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn vonStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn bisStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn vGleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGleis;
        private System.Windows.Forms.TextBox verbindungenVonTB;
        private System.Windows.Forms.TextBox verbindungenBisTB;
        private System.Windows.Forms.ListView autoCompleteVerbindungenLV;
        private System.Windows.Forms.ListView autoCompleteVerbindungenBis;
        private System.Windows.Forms.DateTimePicker zeitPicker;
        private System.Windows.Forms.Button swapButton;
    }

   
}
