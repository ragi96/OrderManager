namespace OrderManagement.View
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
            this.GrdArticle = new System.Windows.Forms.DataGridView();
            this.TxtSearchArticle = new System.Windows.Forms.TextBox();
            this.CmdSaveArticle = new System.Windows.Forms.Button();
            this.LblArticle = new System.Windows.Forms.Label();
            this.TbpArticleGroupe = new System.Windows.Forms.TabPage();
            this.TxtArticleGroupSearch = new System.Windows.Forms.TextBox();
            this.GrdArticleGroups = new System.Windows.Forms.DataGridView();
            this.TrvArticlegroups = new System.Windows.Forms.TreeView();
            this.LblArticlegroups = new System.Windows.Forms.Label();
            this.TabArticle.SuspendLayout();
            this.TbpArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdArticle)).BeginInit();
            this.TbpArticleGroupe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdArticleGroups)).BeginInit();
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
            this.TabArticle.Size = new System.Drawing.Size(936, 550);
            this.TabArticle.TabIndex = 0;
            // 
            // TbpArticle
            // 
            this.TbpArticle.Controls.Add(this.GrdArticle);
            this.TbpArticle.Controls.Add(this.TxtSearchArticle);
            this.TbpArticle.Controls.Add(this.CmdSaveArticle);
            this.TbpArticle.Controls.Add(this.LblArticle);
            this.TbpArticle.Location = new System.Drawing.Point(4, 24);
            this.TbpArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpArticle.Name = "TbpArticle";
            this.TbpArticle.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpArticle.Size = new System.Drawing.Size(928, 522);
            this.TbpArticle.TabIndex = 0;
            this.TbpArticle.Text = "Artikel";
            this.TbpArticle.UseVisualStyleBackColor = true;
            // 
            // GrdArticle
            // 
            this.GrdArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdArticle.Location = new System.Drawing.Point(9, 103);
            this.GrdArticle.Name = "GrdArticle";
            this.GrdArticle.RowTemplate.Height = 25;
            this.GrdArticle.Size = new System.Drawing.Size(906, 374);
            this.GrdArticle.TabIndex = 6;
            this.GrdArticle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdArticle_CellEndEdit);
            this.GrdArticle.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.GrdArticle_CellValidating);
            this.GrdArticle.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GrdArticle_UserDeletingRow);
            // 
            // TxtSearchArticle
            // 
            this.TxtSearchArticle.Location = new System.Drawing.Point(16, 73);
            this.TxtSearchArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchArticle.Name = "TxtSearchArticle";
            this.TxtSearchArticle.PlaceholderText = "Suche...";
            this.TxtSearchArticle.Size = new System.Drawing.Size(206, 23);
            this.TxtSearchArticle.TabIndex = 5;
            this.TxtSearchArticle.TextChanged += new System.EventHandler(this.TxtSearchArticle_TextChanged);
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
            // TbpArticleGroupe
            // 
            this.TbpArticleGroupe.Controls.Add(this.TxtArticleGroupSearch);
            this.TbpArticleGroupe.Controls.Add(this.GrdArticleGroups);
            this.TbpArticleGroupe.Controls.Add(this.TrvArticlegroups);
            this.TbpArticleGroupe.Controls.Add(this.LblArticlegroups);
            this.TbpArticleGroupe.Location = new System.Drawing.Point(4, 24);
            this.TbpArticleGroupe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpArticleGroupe.Name = "TbpArticleGroupe";
            this.TbpArticleGroupe.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpArticleGroupe.Size = new System.Drawing.Size(928, 522);
            this.TbpArticleGroupe.TabIndex = 1;
            this.TbpArticleGroupe.Text = "Artikelgruppen";
            this.TbpArticleGroupe.UseVisualStyleBackColor = true;
            // 
            // TxtArticleGroupSearch
            // 
            this.TxtArticleGroupSearch.Location = new System.Drawing.Point(16, 70);
            this.TxtArticleGroupSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtArticleGroupSearch.Name = "TxtArticleGroupSearch";
            this.TxtArticleGroupSearch.PlaceholderText = "Suche...";
            this.TxtArticleGroupSearch.Size = new System.Drawing.Size(206, 23);
            this.TxtArticleGroupSearch.TabIndex = 9;
            this.TxtArticleGroupSearch.TextChanged += new System.EventHandler(this.TxtArticleGroupSearch_TextChanged);
            // 
            // GrdArticleGroups
            // 
            this.GrdArticleGroups.AllowUserToOrderColumns = true;
            this.GrdArticleGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdArticleGroups.Location = new System.Drawing.Point(9, 100);
            this.GrdArticleGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdArticleGroups.Name = "GrdArticleGroups";
            this.GrdArticleGroups.Size = new System.Drawing.Size(447, 384);
            this.GrdArticleGroups.TabIndex = 7;
            this.GrdArticleGroups.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdArticleGroup_CellEndEdit);
            this.GrdArticleGroups.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GrdArticleGroups_UserDeletingRow);
            // 
            // TrvArticlegroups
            // 
            this.TrvArticlegroups.Location = new System.Drawing.Point(496, 100);
            this.TrvArticlegroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrvArticlegroups.Name = "TrvArticlegroups";
            this.TrvArticlegroups.Size = new System.Drawing.Size(418, 384);
            this.TrvArticlegroups.TabIndex = 6;
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
            // ArticleManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 548);
            this.Controls.Add(this.TabArticle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ArticleManagementView";
            this.Text = "ArticleManagment";
            this.TabArticle.ResumeLayout(false);
            this.TbpArticle.ResumeLayout(false);
            this.TbpArticle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdArticle)).EndInit();
            this.TbpArticleGroupe.ResumeLayout(false);
            this.TbpArticleGroupe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdArticleGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabArticle;
        private System.Windows.Forms.TabPage TbpArticle;
        private System.Windows.Forms.TabPage TbpArticleGroupe;
        private System.Windows.Forms.Button CmdSaveArticle;
        private System.Windows.Forms.Label LblArticle;
        private System.Windows.Forms.Label LblArticlegroups;
        private System.Windows.Forms.TreeView TrvArticlegroups;
        private System.Windows.Forms.DataGridView GrdArticleGroups;
        private System.Windows.Forms.TextBox TxtSearchArticle;
        private System.Windows.Forms.TextBox TxtArticleGroupSearch;
        private System.Windows.Forms.DataGridView GrdArticle;
    }
}