namespace OrderManagement.View
{
    partial class OrderManagementView
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
            this.TbpOrders = new System.Windows.Forms.TabPage();
            this.TxtSearchOrder = new System.Windows.Forms.TextBox();
            this.CmdSearchOrder = new System.Windows.Forms.Button();
            this.CmdCreateInvoice = new System.Windows.Forms.Button();
            this.CmdSaveOrder = new System.Windows.Forms.Button();
            this.LblPosition = new System.Windows.Forms.Label();
            this.GrdPosition = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblOrder = new System.Windows.Forms.Label();
            this.GrdOrder = new System.Windows.Forms.DataGridView();
            this.TabArticle.SuspendLayout();
            this.TbpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPosition)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // TabArticle
            // 
            this.TabArticle.Controls.Add(this.TbpOrders);
            this.TabArticle.Location = new System.Drawing.Point(-1, 1);
            this.TabArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabArticle.Name = "TabArticle";
            this.TabArticle.SelectedIndex = 0;
            this.TabArticle.Size = new System.Drawing.Size(937, 545);
            this.TabArticle.TabIndex = 1;
            // 
            // TbpOrders
            // 
            this.TbpOrders.Controls.Add(this.TxtSearchOrder);
            this.TbpOrders.Controls.Add(this.CmdSearchOrder);
            this.TbpOrders.Controls.Add(this.CmdCreateInvoice);
            this.TbpOrders.Controls.Add(this.CmdSaveOrder);
            this.TbpOrders.Controls.Add(this.LblPosition);
            this.TbpOrders.Controls.Add(this.GrdPosition);
            this.TbpOrders.Controls.Add(this.tabControl1);
            this.TbpOrders.Controls.Add(this.LblOrder);
            this.TbpOrders.Controls.Add(this.GrdOrder);
            this.TbpOrders.Location = new System.Drawing.Point(4, 24);
            this.TbpOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpOrders.Name = "TbpOrders";
            this.TbpOrders.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbpOrders.Size = new System.Drawing.Size(929, 517);
            this.TbpOrders.TabIndex = 0;
            this.TbpOrders.Text = "Aufträge";
            this.TbpOrders.UseVisualStyleBackColor = true;
            // 
            // TxtSearchOrder
            // 
            this.TxtSearchOrder.Location = new System.Drawing.Point(16, 62);
            this.TxtSearchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchOrder.Name = "TxtSearchOrder";
            this.TxtSearchOrder.Size = new System.Drawing.Size(206, 23);
            this.TxtSearchOrder.TabIndex = 8;
            // 
            // CmdSearchOrder
            // 
            this.CmdSearchOrder.Location = new System.Drawing.Point(230, 60);
            this.CmdSearchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdSearchOrder.Name = "CmdSearchOrder";
            this.CmdSearchOrder.Size = new System.Drawing.Size(88, 27);
            this.CmdSearchOrder.TabIndex = 7;
            this.CmdSearchOrder.Text = "Suchen";
            this.CmdSearchOrder.UseVisualStyleBackColor = true;
            // 
            // CmdCreateInvoice
            // 
            this.CmdCreateInvoice.Location = new System.Drawing.Point(10, 481);
            this.CmdCreateInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdCreateInvoice.Name = "CmdCreateInvoice";
            this.CmdCreateInvoice.Size = new System.Drawing.Size(136, 27);
            this.CmdCreateInvoice.TabIndex = 6;
            this.CmdCreateInvoice.Text = "Rechnung erstellen";
            this.CmdCreateInvoice.UseVisualStyleBackColor = true;
            // 
            // CmdSaveOrder
            // 
            this.CmdSaveOrder.Location = new System.Drawing.Point(827, 485);
            this.CmdSaveOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdSaveOrder.Name = "CmdSaveOrder";
            this.CmdSaveOrder.Size = new System.Drawing.Size(88, 27);
            this.CmdSaveOrder.TabIndex = 3;
            this.CmdSaveOrder.Text = "Speichern";
            this.CmdSaveOrder.UseVisualStyleBackColor = true;
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPosition.Location = new System.Drawing.Point(9, 258);
            this.LblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(248, 31);
            this.LblPosition.TabIndex = 5;
            this.LblPosition.Text = "Auftragspositionen:";
            // 
            // GrdPosition
            // 
            this.GrdPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPosition.Location = new System.Drawing.Point(9, 301);
            this.GrdPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdPosition.Name = "GrdPosition";
            this.GrdPosition.Size = new System.Drawing.Size(905, 173);
            this.GrdPosition.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(607, 300);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(9, 9);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1, -19);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LblOrder
            // 
            this.LblOrder.AutoSize = true;
            this.LblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOrder.Location = new System.Drawing.Point(9, 23);
            this.LblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOrder.Name = "LblOrder";
            this.LblOrder.Size = new System.Drawing.Size(117, 31);
            this.LblOrder.TabIndex = 1;
            this.LblOrder.Text = "Aufträge";
            // 
            // GrdOrder
            // 
            this.GrdOrder.AllowUserToDeleteRows = false;
            this.GrdOrder.AllowUserToOrderColumns = true;
            this.GrdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdOrder.Location = new System.Drawing.Point(9, 91);
            this.GrdOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdOrder.Name = "GrdOrder";
            this.GrdOrder.Size = new System.Drawing.Size(905, 163);
            this.GrdOrder.TabIndex = 0;
            this.GrdOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOrder_CellEndEdit);
            // 
            // OrderManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 549);
            this.Controls.Add(this.TabArticle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderManagementView";
            this.Text = "OrderManagmentView";
            this.TabArticle.ResumeLayout(false);
            this.TbpOrders.ResumeLayout(false);
            this.TbpOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPosition)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabArticle;
        private System.Windows.Forms.TabPage TbpOrders;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LblOrder;
        private System.Windows.Forms.DataGridView GrdOrder;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.DataGridView GrdPosition;
        private System.Windows.Forms.Button CmdCreateInvoice;
        private System.Windows.Forms.Button CmdSaveOrder;
        private System.Windows.Forms.TextBox TxtSearchOrder;
        private System.Windows.Forms.Button CmdSearchOrder;
    }
}