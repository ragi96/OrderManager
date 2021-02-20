namespace OrderManagment.View
{
    partial class ArticleManagementView
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
            this.TbpArticle = new System.Windows.Forms.TabPage();
            this.TxtSearchArticle = new System.Windows.Forms.TextBox();
            this.CmdSearchArticle = new System.Windows.Forms.Button();
            this.CmdSaveArticle = new System.Windows.Forms.Button();
            this.LblArticle = new System.Windows.Forms.Label();
            this.GrdArticle = new System.Windows.Forms.DataGridView();
            this.TbpArticleGroupe = new System.Windows.Forms.TabPage();
            this.GridArticleGroups = new System.Windows.Forms.DataGridView();
            this.TrvArticlegroups = new System.Windows.Forms.TreeView();
            this.CmdSaveArticleGroups = new System.Windows.Forms.Button();
            this.LblArticlegroups = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.TxtArticleGroupSearch = new System.Windows.Forms.TextBox();
            this.CmdArticleGroupSearch = new System.Windows.Forms.Button();
            this.TabArticle.SuspendLayout();
            this.TbpArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdArticle)).BeginInit();
            this.TbpArticleGroupe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridArticleGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // TabArticle
            // 
            this.TabArticle.Controls.Add(this.TbpArticle);
            this.TabArticle.Controls.Add(this.TbpArticleGroupe);
            this.TabArticle.Location = new System.Drawing.Point(0, 0);
            this.TabArticle.Name = "TabArticle";
            this.TabArticle.SelectedIndex = 0;
            this.TabArticle.Size = new System.Drawing.Size(802, 475);
            this.TabArticle.TabIndex = 0;
            // 
            // TbpArticle
            // 
            this.TbpArticle.Controls.Add(this.TxtSearchArticle);
            this.TbpArticle.Controls.Add(this.CmdSearchArticle);
            this.TbpArticle.Controls.Add(this.CmdSaveArticle);
            this.TbpArticle.Controls.Add(this.LblArticle);
            this.TbpArticle.Controls.Add(this.GrdArticle);
            this.TbpArticle.Location = new System.Drawing.Point(4, 22);
            this.TbpArticle.Name = "TbpArticle";
            this.TbpArticle.Padding = new System.Windows.Forms.Padding(3);
            this.TbpArticle.Size = new System.Drawing.Size(794, 449);
            this.TbpArticle.TabIndex = 0;
            this.TbpArticle.Text = "Artikel";
            this.TbpArticle.UseVisualStyleBackColor = true;
            // 
            // TxtSearchArticle
            // 
            this.TxtSearchArticle.Location = new System.Drawing.Point(14, 63);
            this.TxtSearchArticle.Name = "TxtSearchArticle";
            this.TxtSearchArticle.Size = new System.Drawing.Size(177, 20);
            this.TxtSearchArticle.TabIndex = 5;
            // 
            // CmdSearchArticle
            // 
            this.CmdSearchArticle.Location = new System.Drawing.Point(197, 61);
            this.CmdSearchArticle.Name = "CmdSearchArticle";
            this.CmdSearchArticle.Size = new System.Drawing.Size(75, 23);
            this.CmdSearchArticle.TabIndex = 4;
            this.CmdSearchArticle.Text = "Suchen";
            this.CmdSearchArticle.UseVisualStyleBackColor = true;
            // 
            // CmdSaveArticle
            // 
            this.CmdSaveArticle.Location = new System.Drawing.Point(709, 419);
            this.CmdSaveArticle.Name = "CmdSaveArticle";
            this.CmdSaveArticle.Size = new System.Drawing.Size(75, 23);
            this.CmdSaveArticle.TabIndex = 2;
            this.CmdSaveArticle.Text = "Speichern";
            this.CmdSaveArticle.UseVisualStyleBackColor = true;
            // 
            // LblArticle
            // 
            this.LblArticle.AutoSize = true;
            this.LblArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArticle.Location = new System.Drawing.Point(8, 20);
            this.LblArticle.Name = "LblArticle";
            this.LblArticle.Size = new System.Drawing.Size(90, 31);
            this.LblArticle.TabIndex = 1;
            this.LblArticle.Text = "Artikel";
            // 
            // GrdArticle
            // 
            this.GrdArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdArticle.Location = new System.Drawing.Point(8, 92);
            this.GrdArticle.Name = "GrdArticle";
            this.GrdArticle.Size = new System.Drawing.Size(776, 321);
            this.GrdArticle.TabIndex = 0;
            // 
            // TbpArticleGroupe
            // 
            this.TbpArticleGroupe.Controls.Add(this.TxtArticleGroupSearch);
            this.TbpArticleGroupe.Controls.Add(this.CmdArticleGroupSearch);
            this.TbpArticleGroupe.Controls.Add(this.GridArticleGroups);
            this.TbpArticleGroupe.Controls.Add(this.TrvArticlegroups);
            this.TbpArticleGroupe.Controls.Add(this.CmdSaveArticleGroups);
            this.TbpArticleGroupe.Controls.Add(this.LblArticlegroups);
            this.TbpArticleGroupe.Location = new System.Drawing.Point(4, 22);
            this.TbpArticleGroupe.Name = "TbpArticleGroupe";
            this.TbpArticleGroupe.Padding = new System.Windows.Forms.Padding(3);
            this.TbpArticleGroupe.Size = new System.Drawing.Size(794, 449);
            this.TbpArticleGroupe.TabIndex = 1;
            this.TbpArticleGroupe.Text = "Artikelgruppen";
            this.TbpArticleGroupe.UseVisualStyleBackColor = true;
            // 
            // GridArticleGroups
            // 
            this.GridArticleGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridArticleGroups.Location = new System.Drawing.Point(8, 87);
            this.GridArticleGroups.Name = "GridArticleGroups";
            this.GridArticleGroups.Size = new System.Drawing.Size(383, 333);
            this.GridArticleGroups.TabIndex = 7;
            // 
            // TrvArticlegroups
            // 
            this.TrvArticlegroups.Location = new System.Drawing.Point(433, 87);
            this.TrvArticlegroups.Name = "TrvArticlegroups";
            this.TrvArticlegroups.Size = new System.Drawing.Size(351, 333);
            this.TrvArticlegroups.TabIndex = 6;
            // 
            // CmdSaveArticleGroups
            // 
            this.CmdSaveArticleGroups.Location = new System.Drawing.Point(709, 426);
            this.CmdSaveArticleGroups.Name = "CmdSaveArticleGroups";
            this.CmdSaveArticleGroups.Size = new System.Drawing.Size(75, 23);
            this.CmdSaveArticleGroups.TabIndex = 5;
            this.CmdSaveArticleGroups.Text = "Speichern";
            this.CmdSaveArticleGroups.UseVisualStyleBackColor = true;
            // 
            // LblArticlegroups
            // 
            this.LblArticlegroups.AutoSize = true;
            this.LblArticlegroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArticlegroups.Location = new System.Drawing.Point(8, 20);
            this.LblArticlegroups.Name = "LblArticlegroups";
            this.LblArticlegroups.Size = new System.Drawing.Size(189, 31);
            this.LblArticlegroups.TabIndex = 4;
            this.LblArticlegroups.Text = "Artikelgruppen";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // TxtArticleGroupSearch
            // 
            this.TxtArticleGroupSearch.Location = new System.Drawing.Point(14, 61);
            this.TxtArticleGroupSearch.Name = "TxtArticleGroupSearch";
            this.TxtArticleGroupSearch.Size = new System.Drawing.Size(177, 20);
            this.TxtArticleGroupSearch.TabIndex = 9;
            // 
            // CmdArticleGroupSearch
            // 
            this.CmdArticleGroupSearch.Location = new System.Drawing.Point(197, 59);
            this.CmdArticleGroupSearch.Name = "CmdArticleGroupSearch";
            this.CmdArticleGroupSearch.Size = new System.Drawing.Size(75, 23);
            this.CmdArticleGroupSearch.TabIndex = 8;
            this.CmdArticleGroupSearch.Text = "Suchen";
            this.CmdArticleGroupSearch.UseVisualStyleBackColor = true;
            // 
            // ArticleManagmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.TabArticle);
            this.Name = "ArticleManagmentView";
            this.Text = "ArticleManagment";
            this.TabArticle.ResumeLayout(false);
            this.TbpArticle.ResumeLayout(false);
            this.TbpArticle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdArticle)).EndInit();
            this.TbpArticleGroupe.ResumeLayout(false);
            this.TbpArticleGroupe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridArticleGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabArticle;
        private System.Windows.Forms.TabPage TbpArticle;
        private System.Windows.Forms.TabPage TbpArticleGroupe;
        private System.Windows.Forms.DataGridView GrdArticle;
        private System.Windows.Forms.Button CmdSaveArticle;
        private System.Windows.Forms.Label LblArticle;
        private System.Windows.Forms.Button CmdSaveArticleGroups;
        private System.Windows.Forms.Label LblArticlegroups;
        private System.Windows.Forms.TreeView TrvArticlegroups;
        private System.Windows.Forms.DataGridView GridArticleGroups;
        private System.Windows.Forms.Button CmdSearchArticle;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox TxtSearchArticle;
        private System.Windows.Forms.TextBox TxtArticleGroupSearch;
        private System.Windows.Forms.Button CmdArticleGroupSearch;
    }
}