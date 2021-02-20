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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblYearlyCompare = new System.Windows.Forms.Label();
            this.GrdYearlyCompare = new System.Windows.Forms.DataGridView();
            this.TabArticle.SuspendLayout();
            this.TbpYearlyCompare.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdYearlyCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // TabArticle
            // 
            this.TabArticle.Controls.Add(this.TbpYearlyCompare);
            this.TabArticle.Location = new System.Drawing.Point(-1, 1);
            this.TabArticle.Name = "TabArticle";
            this.TabArticle.SelectedIndex = 0;
            this.TabArticle.Size = new System.Drawing.Size(803, 472);
            this.TabArticle.TabIndex = 2;
            // 
            // TbpYearlyCompare
            // 
            this.TbpYearlyCompare.Controls.Add(this.tabControl1);
            this.TbpYearlyCompare.Controls.Add(this.LblYearlyCompare);
            this.TbpYearlyCompare.Controls.Add(this.GrdYearlyCompare);
            this.TbpYearlyCompare.Location = new System.Drawing.Point(4, 22);
            this.TbpYearlyCompare.Name = "TbpYearlyCompare";
            this.TbpYearlyCompare.Padding = new System.Windows.Forms.Padding(3);
            this.TbpYearlyCompare.Size = new System.Drawing.Size(795, 446);
            this.TbpYearlyCompare.TabIndex = 0;
            this.TbpYearlyCompare.Text = "Jahrevergleich";
            this.TbpYearlyCompare.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(520, 260);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LblYearlyCompare
            // 
            this.LblYearlyCompare.AutoSize = true;
            this.LblYearlyCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYearlyCompare.Location = new System.Drawing.Point(8, 20);
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
            this.GrdYearlyCompare.Location = new System.Drawing.Point(8, 79);
            this.GrdYearlyCompare.Name = "GrdYearlyCompare";
            this.GrdYearlyCompare.Size = new System.Drawing.Size(776, 361);
            this.GrdYearlyCompare.TabIndex = 0;
            // 
            // YearlyCompareView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.TabArticle);
            this.Name = "YearlyCompareView";
            this.Text = "YearlyCompare";
            this.TabArticle.ResumeLayout(false);
            this.TbpYearlyCompare.ResumeLayout(false);
            this.TbpYearlyCompare.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdYearlyCompare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabArticle;
        private System.Windows.Forms.TabPage TbpYearlyCompare;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LblYearlyCompare;
        private System.Windows.Forms.DataGridView GrdYearlyCompare;
    }
}