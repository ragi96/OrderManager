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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TabArticle.Location = new System.Drawing.Point(-2, 2);
            this.TabArticle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TabArticle.Name = "TabArticle";
            this.TabArticle.SelectedIndex = 0;
            this.TabArticle.Size = new System.Drawing.Size(3866, 1163);
            this.TabArticle.TabIndex = 2;
            // 
            // TbpYearlyCompare
            // 
            this.TbpYearlyCompare.Controls.Add(this.LblYearlyCompare);
            this.TbpYearlyCompare.Controls.Add(this.GrdYearlyCompare);
            this.TbpYearlyCompare.Location = new System.Drawing.Point(8, 46);
            this.TbpYearlyCompare.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TbpYearlyCompare.Name = "TbpYearlyCompare";
            this.TbpYearlyCompare.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TbpYearlyCompare.Size = new System.Drawing.Size(3850, 1109);
            this.TbpYearlyCompare.TabIndex = 0;
            this.TbpYearlyCompare.Text = "Jahrevergleich";
            this.TbpYearlyCompare.UseVisualStyleBackColor = true;
            // 
            // LblYearlyCompare
            // 
            this.LblYearlyCompare.AutoSize = true;
            this.LblYearlyCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblYearlyCompare.Location = new System.Drawing.Point(17, 49);
            this.LblYearlyCompare.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblYearlyCompare.Name = "LblYearlyCompare";
            this.LblYearlyCompare.Size = new System.Drawing.Size(407, 63);
            this.LblYearlyCompare.TabIndex = 1;
            this.LblYearlyCompare.Text = "Jahresvergleich";
            // 
            // GrdYearlyCompare
            // 
            this.GrdYearlyCompare.AllowUserToAddRows = false;
            this.GrdYearlyCompare.AllowUserToDeleteRows = false;
            this.GrdYearlyCompare.AllowUserToResizeColumns = false;
            this.GrdYearlyCompare.AllowUserToResizeRows = false;
            this.GrdYearlyCompare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdYearlyCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdYearlyCompare.DefaultCellStyle = dataGridViewCellStyle1;
            this.GrdYearlyCompare.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GrdYearlyCompare.Location = new System.Drawing.Point(17, 194);
            this.GrdYearlyCompare.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.GrdYearlyCompare.Name = "GrdYearlyCompare";
            this.GrdYearlyCompare.RowHeadersWidth = 82;
            this.GrdYearlyCompare.Size = new System.Drawing.Size(3811, 890);
            this.GrdYearlyCompare.TabIndex = 0;
            // 
            // YearlyCompareView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3865, 1171);
            this.Controls.Add(this.TabArticle);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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