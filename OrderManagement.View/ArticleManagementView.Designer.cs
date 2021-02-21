﻿namespace OrderManagement.View
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
            System.DirectoryServices.SortOption sortOption1 = new System.DirectoryServices.SortOption();
            this.TabArticle = new System.Windows.Forms.TabControl();
            this.TbpArticle = new System.Windows.Forms.TabPage();
            this.TxtSearchArticle = new System.Windows.Forms.TextBox();
            this.CmdSearchArticle = new System.Windows.Forms.Button();
            this.CmdSaveArticle = new System.Windows.Forms.Button();
            this.LblArticle = new System.Windows.Forms.Label();
            this.GrdArticle = new System.Windows.Forms.DataGridView();
            this.TbpArticleGroupe = new System.Windows.Forms.TabPage();
            this.TxtArticleGroupSearch = new System.Windows.Forms.TextBox();
            this.CmdArticleGroupSearch = new System.Windows.Forms.Button();
            this.GridArticleGroups = new System.Windows.Forms.DataGridView();
            this.TrvArticlegroups = new System.Windows.Forms.TreeView();
            this.CmdSaveArticleGroups = new System.Windows.Forms.Button();
            this.LblArticlegroups = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
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
            this.TabArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabArticle.Name = "TabArticle";
            this.TabArticle.SelectedIndex = 0;
            this.TabArticle.Size = new System.Drawing.Size(936, 548);
            this.TabArticle.TabIndex = 0;
            // 
            // TbpArticle
            // 
            this.TbpArticle.Controls.Add(this.TxtSearchArticle);
            this.TbpArticle.Controls.Add(this.CmdSearchArticle);
            this.TbpArticle.Controls.Add(this.CmdSaveArticle);
            this.TbpArticle.Controls.Add(this.LblArticle);
            this.TbpArticle.Controls.Add(this.GrdArticle);
            this.TbpArticle.Location = new System.Drawing.Point(4, 24);
            this.TbpArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpArticle.Name = "TbpArticle";
            this.TbpArticle.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpArticle.Size = new System.Drawing.Size(928, 520);
            this.TbpArticle.TabIndex = 0;
            this.TbpArticle.Text = "Artikel";
            this.TbpArticle.UseVisualStyleBackColor = true;
            // 
            // TxtSearchArticle
            // 
            this.TxtSearchArticle.Location = new System.Drawing.Point(16, 73);
            this.TxtSearchArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchArticle.Name = "TxtSearchArticle";
            this.TxtSearchArticle.Size = new System.Drawing.Size(206, 23);
            this.TxtSearchArticle.TabIndex = 5;
            // 
            // CmdSearchArticle
            // 
            this.CmdSearchArticle.Location = new System.Drawing.Point(230, 70);
            this.CmdSearchArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdSearchArticle.Name = "CmdSearchArticle";
            this.CmdSearchArticle.Size = new System.Drawing.Size(88, 27);
            this.CmdSearchArticle.TabIndex = 4;
            this.CmdSearchArticle.Text = "Suchen";
            this.CmdSearchArticle.UseVisualStyleBackColor = true;
            // 
            // CmdSaveArticle
            // 
            this.CmdSaveArticle.Location = new System.Drawing.Point(827, 483);
            this.CmdSaveArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdSaveArticle.Name = "CmdSaveArticle";
            this.CmdSaveArticle.Size = new System.Drawing.Size(88, 27);
            this.CmdSaveArticle.TabIndex = 2;
            this.CmdSaveArticle.Text = "Speichern";
            this.CmdSaveArticle.UseVisualStyleBackColor = true;
            // 
            // LblArticle
            // 
            this.LblArticle.AutoSize = true;
            this.LblArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblArticle.Location = new System.Drawing.Point(9, 23);
            this.LblArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblArticle.Name = "LblArticle";
            this.LblArticle.Size = new System.Drawing.Size(90, 31);
            this.LblArticle.TabIndex = 1;
            this.LblArticle.Text = "Artikel";
            // 
            // GrdArticle
            // 
            this.GrdArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdArticle.Location = new System.Drawing.Point(4, 3);
            this.GrdArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdArticle.Name = "GrdArticle";
            this.GrdArticle.Size = new System.Drawing.Size(920, 514);
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
            this.TbpArticleGroupe.Location = new System.Drawing.Point(4, 24);
            this.TbpArticleGroupe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpArticleGroupe.Name = "TbpArticleGroupe";
            this.TbpArticleGroupe.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpArticleGroupe.Size = new System.Drawing.Size(928, 520);
            this.TbpArticleGroupe.TabIndex = 1;
            this.TbpArticleGroupe.Text = "Artikelgruppen";
            this.TbpArticleGroupe.UseVisualStyleBackColor = true;
            // 
            // TxtArticleGroupSearch
            // 
            this.TxtArticleGroupSearch.Location = new System.Drawing.Point(16, 70);
            this.TxtArticleGroupSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtArticleGroupSearch.Name = "TxtArticleGroupSearch";
            this.TxtArticleGroupSearch.Size = new System.Drawing.Size(206, 23);
            this.TxtArticleGroupSearch.TabIndex = 9;
            // 
            // CmdArticleGroupSearch
            // 
            this.CmdArticleGroupSearch.Location = new System.Drawing.Point(230, 68);
            this.CmdArticleGroupSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdArticleGroupSearch.Name = "CmdArticleGroupSearch";
            this.CmdArticleGroupSearch.Size = new System.Drawing.Size(88, 27);
            this.CmdArticleGroupSearch.TabIndex = 8;
            this.CmdArticleGroupSearch.Text = "Suchen";
            this.CmdArticleGroupSearch.UseVisualStyleBackColor = true;
            // 
            // GridArticleGroups
            // 
            this.GridArticleGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridArticleGroups.Location = new System.Drawing.Point(9, 100);
            this.GridArticleGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GridArticleGroups.Name = "GridArticleGroups";
            this.GridArticleGroups.Size = new System.Drawing.Size(447, 384);
            this.GridArticleGroups.TabIndex = 7;
            // 
            // TrvArticlegroups
            // 
            this.TrvArticlegroups.Location = new System.Drawing.Point(505, 100);
            this.TrvArticlegroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrvArticlegroups.Name = "TrvArticlegroups";
            this.TrvArticlegroups.Size = new System.Drawing.Size(409, 384);
            this.TrvArticlegroups.TabIndex = 6;
            // 
            // CmdSaveArticleGroups
            // 
            this.CmdSaveArticleGroups.Location = new System.Drawing.Point(827, 492);
            this.CmdSaveArticleGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdSaveArticleGroups.Name = "CmdSaveArticleGroups";
            this.CmdSaveArticleGroups.Size = new System.Drawing.Size(88, 27);
            this.CmdSaveArticleGroups.TabIndex = 5;
            this.CmdSaveArticleGroups.Text = "Speichern";
            this.CmdSaveArticleGroups.UseVisualStyleBackColor = true;
            // 
            // LblArticlegroups
            // 
            this.LblArticlegroups.AutoSize = true;
            this.LblArticlegroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblArticlegroups.Location = new System.Drawing.Point(9, 23);
            this.LblArticlegroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.directorySearcher1.Sort = sortOption1;
            // 
            // ArticleManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 549);
            this.Controls.Add(this.TabArticle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ArticleManagementView";
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