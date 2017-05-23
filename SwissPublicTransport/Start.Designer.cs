namespace SwissPublicTransport
{
    partial class Start
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.appTitelLbl = new System.Windows.Forms.Label();
            this.abfahrtstafelBtn = new System.Windows.Forms.Button();
            this.verbindungBtn = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.verbindungBtn);
            this.mainPanel.Controls.Add(this.appTitelLbl);
            this.mainPanel.Controls.Add(this.abfahrtstafelBtn);
            this.mainPanel.Location = new System.Drawing.Point(0, -4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1478, 931);
            this.mainPanel.TabIndex = 0;
            // 
            // appTitelLbl
            // 
            this.appTitelLbl.AutoSize = true;
            this.appTitelLbl.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitelLbl.Location = new System.Drawing.Point(499, 133);
            this.appTitelLbl.Name = "appTitelLbl";
            this.appTitelLbl.Size = new System.Drawing.Size(439, 59);
            this.appTitelLbl.TabIndex = 3;
            this.appTitelLbl.Text = "Swiss Public Transport";
            // 
            // abfahrtstafelBtn
            // 
            this.abfahrtstafelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abfahrtstafelBtn.Location = new System.Drawing.Point(774, 319);
            this.abfahrtstafelBtn.Name = "abfahrtstafelBtn";
            this.abfahrtstafelBtn.Size = new System.Drawing.Size(253, 212);
            this.abfahrtstafelBtn.TabIndex = 2;
            this.abfahrtstafelBtn.Text = "Abfahrtstafel suchen";
            this.abfahrtstafelBtn.UseVisualStyleBackColor = true;
            this.abfahrtstafelBtn.Click += new System.EventHandler(this.abfahrtstafelBtn_Click);
            // 
            // verbindungBtn
            // 
            this.verbindungBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.verbindungBtn.Location = new System.Drawing.Point(393, 319);
            this.verbindungBtn.Name = "verbindungBtn";
            this.verbindungBtn.Size = new System.Drawing.Size(253, 212);
            this.verbindungBtn.TabIndex = 1;
            this.verbindungBtn.Text = "Verbindung suchen";
            this.verbindungBtn.UseVisualStyleBackColor = true;
            this.verbindungBtn.Click += new System.EventHandler(this.verbindungBtn_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBTN.Location = new System.Drawing.Point(299, 22);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(80, 42);
            this.cancelBTN.TabIndex = 1;
            this.cancelBTN.Text = "cancelBTN";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.button1Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBTN;
            this.ClientSize = new System.Drawing.Size(1474, 929);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.cancelBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swiss Public Transport";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button abfahrtstafelBtn;
        private System.Windows.Forms.Button verbindungBtn;
        private System.Windows.Forms.Label appTitelLbl;
        private System.Windows.Forms.Button cancelBTN;
    }
}