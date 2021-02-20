namespace OrderManagement.View
{
    partial class YearlyCompareView
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
            this.TabArticle = new System.Windows.Forms.TabControl();
            this.TbpYearlyCompare = new System.Windows.Forms.TabPage();
            this.LblYearlyCompare = new System.Windows.Forms.Label();
            this.GrdYearlyCompare = new System.Windows.Forms.DataGridView();
            this.TabArticle.SuspendLayout();
            this.TbpYearlyCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdYearlyCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // TabArticle
            // 
            this.TabArticle.Controls.Add(this.TbpYearlyCompare);
            this.TabArticle.Location = new System.Drawing.Point(-1, 1);
            this.TabArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabArticle.Name = "TabArticle";
            this.TabArticle.SelectedIndex = 0;
            this.TabArticle.Size = new System.Drawing.Size(937, 545);
            this.TabArticle.TabIndex = 2;
            // 
            // TbpYearlyCompare
            // 
            this.TbpYearlyCompare.Controls.Add(this.LblYearlyCompare);
            this.TbpYearlyCompare.Controls.Add(this.GrdYearlyCompare);
            this.TbpYearlyCompare.Location = new System.Drawing.Point(4, 24);
            this.TbpYearlyCompare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpYearlyCompare.Name = "TbpYearlyCompare";
            this.TbpYearlyCompare.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpYearlyCompare.Size = new System.Drawing.Size(929, 517);
            this.TbpYearlyCompare.TabIndex = 0;
            this.TbpYearlyCompare.Text = "Jahrevergleich";
            this.TbpYearlyCompare.UseVisualStyleBackColor = true;
            // 
            // LblYearlyCompare
            // 
            this.LblYearlyCompare.AutoSize = true;
            this.LblYearlyCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblYearlyCompare.Location = new System.Drawing.Point(9, 23);
            this.LblYearlyCompare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblYearlyCompare.Name = "LblYearlyCompare";
            this.LblYearlyCompare.Size = new System.Drawing.Size(205, 31);
            this.LblYearlyCompare.TabIndex = 1;
            this.LblYearlyCompare.Text = "Jahresvergleich";
            // 
            // GrdYearlyCompare
            // 
            this.GrdYearlyCompare.AllowUserToAddRows = false;
            this.GrdYearlyCompare.AllowUserToDeleteRows = false;
            this.GrdYearlyCompare.AllowUserToResizeColumns = false;
            this.GrdYearlyCompare.AllowUserToResizeRows = false;
            this.GrdYearlyCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdYearlyCompare.Location = new System.Drawing.Point(9, 91);
            this.GrdYearlyCompare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdYearlyCompare.Name = "GrdYearlyCompare";
            this.GrdYearlyCompare.Size = new System.Drawing.Size(905, 417);
            this.GrdYearlyCompare.TabIndex = 0;
            // 
            // YearlyCompareView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 549);
            this.Controls.Add(this.TabArticle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "YearlyCompareView";
            this.Text = "YearlyCompare";
            this.TabArticle.ResumeLayout(false);
            this.TbpYearlyCompare.ResumeLayout(false);
            this.TbpYearlyCompare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdYearlyCompare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabArticle;
        private System.Windows.Forms.TabPage TbpYearlyCompare;
        private System.Windows.Forms.Label LblYearlyCompare;
        private System.Windows.Forms.DataGridView GrdYearlyCompare;
    }
}