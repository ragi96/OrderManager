namespace OrderManagement.View
{
    partial class CustomerManagementView
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
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.LblAdressHistory = new System.Windows.Forms.Label();
            this.GrdAdressHistory = new System.Windows.Forms.DataGridView();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.GrdCustomers = new System.Windows.Forms.DataGridView();
            this.TbpCustomers = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabCustomer = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdressHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomers)).BeginInit();
            this.TbpCustomers.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.Location = new System.Drawing.Point(30, 132);
            this.TxtSearchCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(379, 39);
            this.TxtSearchCustomer.TabIndex = 8;
            // 
            // LblAdressHistory
            // 
            this.LblAdressHistory.AutoSize = true;
            this.LblAdressHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAdressHistory.Location = new System.Drawing.Point(17, 550);
            this.LblAdressHistory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblAdressHistory.Name = "LblAdressHistory";
            this.LblAdressHistory.Size = new System.Drawing.Size(371, 63);
            this.LblAdressHistory.TabIndex = 5;
            this.LblAdressHistory.Text = "Adresshistorie";
            // 
            // GrdAdressHistory
            // 
            this.GrdAdressHistory.AllowUserToAddRows = false;
            this.GrdAdressHistory.AllowUserToDeleteRows = false;
            this.GrdAdressHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAdressHistory.Location = new System.Drawing.Point(17, 642);
            this.GrdAdressHistory.Margin = new System.Windows.Forms.Padding(6);
            this.GrdAdressHistory.Name = "GrdAdressHistory";
            this.GrdAdressHistory.RowHeadersWidth = 82;
            this.GrdAdressHistory.Size = new System.Drawing.Size(1681, 369);
            this.GrdAdressHistory.TabIndex = 4;
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCustomer.Location = new System.Drawing.Point(17, 49);
            this.LblCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(213, 63);
            this.LblCustomer.TabIndex = 1;
            this.LblCustomer.Text = "Kunden";
            // 
            // GrdCustomers
            // 
            this.GrdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCustomers.Location = new System.Drawing.Point(17, 194);
            this.GrdCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.GrdCustomers.Name = "GrdCustomers";
            this.GrdCustomers.RowHeadersWidth = 82;
            this.GrdCustomers.Size = new System.Drawing.Size(1681, 348);
            this.GrdCustomers.TabIndex = 0;
            this.GrdCustomers.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GrdCustomers_UserDeletingRow);
            // 
            // TbpCustomers
            // 
            this.TbpCustomers.Controls.Add(this.TxtSearchCustomer);
            this.TbpCustomers.Controls.Add(this.LblAdressHistory);
            this.TbpCustomers.Controls.Add(this.GrdAdressHistory);
            this.TbpCustomers.Controls.Add(this.tabControl1);
            this.TbpCustomers.Controls.Add(this.LblCustomer);
            this.TbpCustomers.Controls.Add(this.GrdCustomers);
            this.TbpCustomers.Location = new System.Drawing.Point(8, 46);
            this.TbpCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.TbpCustomers.Name = "TbpCustomers";
            this.TbpCustomers.Padding = new System.Windows.Forms.Padding(6);
            this.TbpCustomers.Size = new System.Drawing.Size(1724, 1047);
            this.TbpCustomers.TabIndex = 0;
            this.TbpCustomers.Text = "Kunden";
            this.TbpCustomers.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1127, 640);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(17, 19);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1, -35);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabCustomer
            // 
            this.TabCustomer.Controls.Add(this.TbpCustomers);
            this.TabCustomer.Location = new System.Drawing.Point(-2, 2);
            this.TabCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.TabCustomer.Name = "TabCustomer";
            this.TabCustomer.SelectedIndex = 0;
            this.TabCustomer.Size = new System.Drawing.Size(1740, 1101);
            this.TabCustomer.TabIndex = 2;
            // 
            // CustomerManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 1111);
            this.Controls.Add(this.TabCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "CustomerManagementView";
            this.Text = "CustomerManagment";
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdressHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomers)).EndInit();
            this.TbpCustomers.ResumeLayout(false);
            this.TbpCustomers.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.Label LblAdressHistory;
        private System.Windows.Forms.DataGridView GrdAdressHistory;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.DataGridView GrdCustomers;
        private System.Windows.Forms.TabPage TbpCustomers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TabCustomer;
    }
}