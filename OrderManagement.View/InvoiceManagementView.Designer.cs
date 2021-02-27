
namespace OrderManagement.View
{
    partial class InvoiceManagementView
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
            this.TabInvoice = new System.Windows.Forms.TabControl();
            this.TbpYearlyCompare = new System.Windows.Forms.TabPage();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.CmbUser = new System.Windows.Forms.ComboBox();
            this.LblInvoice = new System.Windows.Forms.Label();
            this.GrdInvoice = new System.Windows.Forms.DataGridView();
            this.TabInvoice.SuspendLayout();
            this.TbpYearlyCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // TabInvoice
            // 
            this.TabInvoice.Controls.Add(this.TbpYearlyCompare);
            this.TabInvoice.Location = new System.Drawing.Point(-2, 2);
            this.TabInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabInvoice.Name = "TabInvoice";
            this.TabInvoice.SelectedIndex = 0;
            this.TabInvoice.Size = new System.Drawing.Size(937, 545);
            this.TabInvoice.TabIndex = 3;
            // 
            // TbpYearlyCompare
            // 
            this.TbpYearlyCompare.Controls.Add(this.DtpDate);
            this.TbpYearlyCompare.Controls.Add(this.CmbUser);
            this.TbpYearlyCompare.Controls.Add(this.LblInvoice);
            this.TbpYearlyCompare.Controls.Add(this.GrdInvoice);
            this.TbpYearlyCompare.Location = new System.Drawing.Point(4, 24);
            this.TbpYearlyCompare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpYearlyCompare.Name = "TbpYearlyCompare";
            this.TbpYearlyCompare.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpYearlyCompare.Size = new System.Drawing.Size(929, 517);
            this.TbpYearlyCompare.TabIndex = 0;
            this.TbpYearlyCompare.Text = "Rechnungen";
            this.TbpYearlyCompare.UseVisualStyleBackColor = true;
            // 
            // DtpDate
            // 
            this.DtpDate.Location = new System.Drawing.Point(155, 62);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.ShowCheckBox = true;
            this.DtpDate.Size = new System.Drawing.Size(200, 23);
            this.DtpDate.TabIndex = 3;
            this.DtpDate.ValueChanged += new System.EventHandler(this.DtpDate_ValueChanged);
            // 
            // CmbUser
            // 
            this.CmbUser.FormattingEnabled = true;
            this.CmbUser.Location = new System.Drawing.Point(13, 62);
            this.CmbUser.Name = "CmbUser";
            this.CmbUser.Size = new System.Drawing.Size(136, 23);
            this.CmbUser.TabIndex = 2;
            this.CmbUser.Text = "Bitte wählen Sie einen Kunden aus";
            this.CmbUser.SelectedIndexChanged += new System.EventHandler(this.CmbUser_SelectedIndexChanged);
            // 
            // LblInvoice
            // 
            this.LblInvoice.AutoSize = true;
            this.LblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblInvoice.Location = new System.Drawing.Point(13, 26);
            this.LblInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInvoice.Name = "LblInvoice";
            this.LblInvoice.Size = new System.Drawing.Size(168, 31);
            this.LblInvoice.TabIndex = 1;
            this.LblInvoice.Text = "Rechnungen";
            // 
            // GrdInvoice
            // 
            this.GrdInvoice.AllowUserToAddRows = false;
            this.GrdInvoice.AllowUserToDeleteRows = false;
            this.GrdInvoice.AllowUserToResizeColumns = false;
            this.GrdInvoice.AllowUserToResizeRows = false;
            this.GrdInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdInvoice.Location = new System.Drawing.Point(9, 91);
            this.GrdInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdInvoice.Name = "GrdInvoice";
            this.GrdInvoice.ReadOnly = true;
            this.GrdInvoice.Size = new System.Drawing.Size(905, 417);
            this.GrdInvoice.TabIndex = 0;
            // 
            // InvoiceManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 549);
            this.Controls.Add(this.TabInvoice);
            this.Name = "InvoiceManagementView";
            this.Text = "InvoiceManagementView";
            this.TabInvoice.ResumeLayout(false);
            this.TbpYearlyCompare.ResumeLayout(false);
            this.TbpYearlyCompare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabInvoice;
        private System.Windows.Forms.TabPage TbpYearlyCompare;
        private System.Windows.Forms.Label LblInvoice;
        private System.Windows.Forms.DataGridView GrdInvoice;
        private System.Windows.Forms.ComboBox CmbUser;
        private System.Windows.Forms.DateTimePicker DtpDate;
    }
}