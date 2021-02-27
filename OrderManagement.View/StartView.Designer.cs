namespace OrderManagement.View
{
    partial class StartView
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CmdCustomerManagement = new System.Windows.Forms.Button();
            this.CmdOrderManagement = new System.Windows.Forms.Button();
            this.CmdYearlyCompare = new System.Windows.Forms.Button();
            this.CmdArticleManagement = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdCustomerManagement
            // 
            this.CmdCustomerManagement.Location = new System.Drawing.Point(14, 8);
            this.CmdCustomerManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdCustomerManagement.Name = "CmdCustomerManagement";
            this.CmdCustomerManagement.Size = new System.Drawing.Size(206, 27);
            this.CmdCustomerManagement.TabIndex = 0;
            this.CmdCustomerManagement.Text = "Kundenverwaltung";
            this.CmdCustomerManagement.UseVisualStyleBackColor = true;
            this.CmdCustomerManagement.Click += new System.EventHandler(this.CmdCustomerManagement_Click);
            // 
            // CmdOrderManagement
            // 
            this.CmdOrderManagement.Location = new System.Drawing.Point(14, 42);
            this.CmdOrderManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdOrderManagement.Name = "CmdOrderManagement";
            this.CmdOrderManagement.Size = new System.Drawing.Size(206, 27);
            this.CmdOrderManagement.TabIndex = 1;
            this.CmdOrderManagement.Text = "Auftragsverwaltung";
            this.CmdOrderManagement.UseVisualStyleBackColor = true;
            this.CmdOrderManagement.Click += new System.EventHandler(this.CmdOrderManagement_Click);
            // 
            // CmdYearlyCompare
            // 
            this.CmdYearlyCompare.Location = new System.Drawing.Point(13, 141);
            this.CmdYearlyCompare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdYearlyCompare.Name = "CmdYearlyCompare";
            this.CmdYearlyCompare.Size = new System.Drawing.Size(206, 27);
            this.CmdYearlyCompare.TabIndex = 2;
            this.CmdYearlyCompare.Text = "Jahresvergleich";
            this.CmdYearlyCompare.UseVisualStyleBackColor = true;
            this.CmdYearlyCompare.Click += new System.EventHandler(this.CmdYearCompare_Click);
            // 
            // CmdArticleManagement
            // 
            this.CmdArticleManagement.Location = new System.Drawing.Point(14, 75);
            this.CmdArticleManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdArticleManagement.Name = "CmdArticleManagement";
            this.CmdArticleManagement.Size = new System.Drawing.Size(206, 27);
            this.CmdArticleManagement.TabIndex = 3;
            this.CmdArticleManagement.Text = "Artikelverwaltung";
            this.CmdArticleManagement.UseVisualStyleBackColor = true;
            this.CmdArticleManagement.Click += new System.EventHandler(this.CmdArticleManagement_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(14, 312);
            this.CmdClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(206, 27);
            this.CmdClose.TabIndex = 4;
            this.CmdClose.Text = "Beenden";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdInvoice
            // 
            this.CmdInvoice.Location = new System.Drawing.Point(14, 108);
            this.CmdInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdInvoice.Name = "CmdInvoice";
            this.CmdInvoice.Size = new System.Drawing.Size(206, 27);
            this.CmdInvoice.TabIndex = 5;
            this.CmdInvoice.Text = "Rechnungserwaltung";
            this.CmdInvoice.UseVisualStyleBackColor = true;
            this.CmdInvoice.Click += new System.EventHandler(this.CmdInvoice_Click);
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 352);
            this.Controls.Add(this.CmdInvoice);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdArticleManagement);
            this.Controls.Add(this.CmdYearlyCompare);
            this.Controls.Add(this.CmdOrderManagement);
            this.Controls.Add(this.CmdCustomerManagement);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StartView";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CmdCustomerManagement;
        private System.Windows.Forms.Button CmdYearlyCompare;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdOrderManagement;
        private System.Windows.Forms.Button CmdArticleManagement;
        private System.Windows.Forms.Button CmdInvoice;
    }
}