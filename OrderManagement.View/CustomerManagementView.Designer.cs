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
            this.CmdSearchCustomer = new System.Windows.Forms.Button();
            this.LblAdressHistory = new System.Windows.Forms.Label();
            this.GrdAdressHistory = new System.Windows.Forms.DataGridView();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.GrdCustomers = new System.Windows.Forms.DataGridView();
            this.TbpCustomers = new System.Windows.Forms.TabPage();
            this.CmdSaveCustomer = new System.Windows.Forms.Button();
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
            this.TxtSearchCustomer.Location = new System.Drawing.Point(14, 54);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(177, 20);
            this.TxtSearchCustomer.TabIndex = 8;
            // 
            // CmdSearchCustomer
            // 
            this.CmdSearchCustomer.Location = new System.Drawing.Point(197, 52);
            this.CmdSearchCustomer.Name = "CmdSearchCustomer";
            this.CmdSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.CmdSearchCustomer.TabIndex = 7;
            this.CmdSearchCustomer.Text = "Suchen";
            this.CmdSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // LblAdressHistory
            // 
            this.LblAdressHistory.AutoSize = true;
            this.LblAdressHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdressHistory.Location = new System.Drawing.Point(8, 224);
            this.LblAdressHistory.Name = "LblAdressHistory";
            this.LblAdressHistory.Size = new System.Drawing.Size(187, 31);
            this.LblAdressHistory.TabIndex = 5;
            this.LblAdressHistory.Text = "Adresshistorie";
            // 
            // GrdAdressHistory
            // 
            this.GrdAdressHistory.AllowUserToAddRows = false;
            this.GrdAdressHistory.AllowUserToDeleteRows = false;
            this.GrdAdressHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAdressHistory.Location = new System.Drawing.Point(8, 261);
            this.GrdAdressHistory.Name = "GrdAdressHistory";
            this.GrdAdressHistory.Size = new System.Drawing.Size(776, 150);
            this.GrdAdressHistory.TabIndex = 4;
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomer.Location = new System.Drawing.Point(8, 20);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(107, 31);
            this.LblCustomer.TabIndex = 1;
            this.LblCustomer.Text = "Kunden";
            // 
            // GrdCustomers
            // 
            this.GrdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCustomers.Location = new System.Drawing.Point(8, 79);
            this.GrdCustomers.Name = "GrdCustomers";
            this.GrdCustomers.Size = new System.Drawing.Size(776, 141);
            this.GrdCustomers.TabIndex = 0;
            // 
            // TbpCustomers
            // 
            this.TbpCustomers.Controls.Add(this.TxtSearchCustomer);
            this.TbpCustomers.Controls.Add(this.CmdSearchCustomer);
            this.TbpCustomers.Controls.Add(this.CmdSaveCustomer);
            this.TbpCustomers.Controls.Add(this.LblAdressHistory);
            this.TbpCustomers.Controls.Add(this.GrdAdressHistory);
            this.TbpCustomers.Controls.Add(this.tabControl1);
            this.TbpCustomers.Controls.Add(this.LblCustomer);
            this.TbpCustomers.Controls.Add(this.GrdCustomers);
            this.TbpCustomers.Location = new System.Drawing.Point(4, 22);
            this.TbpCustomers.Name = "TbpCustomers";
            this.TbpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCustomers.Size = new System.Drawing.Size(795, 446);
            this.TbpCustomers.TabIndex = 0;
            this.TbpCustomers.Text = "Kunden";
            this.TbpCustomers.UseVisualStyleBackColor = true;
            // 
            // CmdSaveCustomer
            // 
            this.CmdSaveCustomer.Location = new System.Drawing.Point(709, 420);
            this.CmdSaveCustomer.Name = "CmdSaveCustomer";
            this.CmdSaveCustomer.Size = new System.Drawing.Size(75, 23);
            this.CmdSaveCustomer.TabIndex = 3;
            this.CmdSaveCustomer.Text = "Speichern";
            this.CmdSaveCustomer.UseVisualStyleBackColor = true;
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
            // TabCustomer
            // 
            this.TabCustomer.Controls.Add(this.TbpCustomers);
            this.TabCustomer.Location = new System.Drawing.Point(-1, 1);
            this.TabCustomer.Name = "TabCustomer";
            this.TabCustomer.SelectedIndex = 0;
            this.TabCustomer.Size = new System.Drawing.Size(803, 472);
            this.TabCustomer.TabIndex = 2;
            // 
            // CustomerManagmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.TabCustomer);
            this.Name = "CustomerManagmentView";
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
        private System.Windows.Forms.Button CmdSearchCustomer;
        private System.Windows.Forms.Label LblAdressHistory;
        private System.Windows.Forms.DataGridView GrdAdressHistory;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.DataGridView GrdCustomers;
        private System.Windows.Forms.TabPage TbpCustomers;
        private System.Windows.Forms.Button CmdSaveCustomer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TabCustomer;
    }
}