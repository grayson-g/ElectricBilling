namespace ElectricBilling
{
    partial class BillingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CustomerListBox = new ListBox();
            AddCustomerButton = new Button();
            DeleteCustomerButton = new Button();
            OverviewGroup = new GroupBox();
            TotalBilled = new TextBox();
            label9 = new Label();
            AverageBilled = new TextBox();
            label10 = new Label();
            TotalUsage = new TextBox();
            label6 = new Label();
            AverageUsage = new TextBox();
            label7 = new Label();
            CustomerCount = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            CustomerID = new TextBox();
            CustomerBilled = new TextBox();
            label8 = new Label();
            CustomerUsage = new TextBox();
            label5 = new Label();
            CustomerName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            OverviewGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Margin = new Padding(3, 0, 3, 8);
            label1.Name = "label1";
            label1.Size = new Size(157, 40);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // CustomerListBox
            // 
            CustomerListBox.BackColor = SystemColors.InactiveBorder;
            CustomerListBox.BorderStyle = BorderStyle.FixedSingle;
            CustomerListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerListBox.FormattingEnabled = true;
            CustomerListBox.ItemHeight = 25;
            CustomerListBox.Location = new Point(12, 69);
            CustomerListBox.Name = "CustomerListBox";
            CustomerListBox.Size = new Size(360, 402);
            CustomerListBox.TabIndex = 1;
            CustomerListBox.SelectedIndexChanged += OnSelectCustomer;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Location = new Point(12, 504);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(178, 32);
            AddCustomerButton.TabIndex = 2;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += OnClickAdd;
            // 
            // DeleteCustomerButton
            // 
            DeleteCustomerButton.Location = new Point(194, 504);
            DeleteCustomerButton.Name = "DeleteCustomerButton";
            DeleteCustomerButton.Size = new Size(178, 32);
            DeleteCustomerButton.TabIndex = 3;
            DeleteCustomerButton.Text = "Remove";
            DeleteCustomerButton.UseVisualStyleBackColor = true;
            DeleteCustomerButton.Click += OnClickRemove;
            // 
            // OverviewGroup
            // 
            OverviewGroup.BackColor = SystemColors.InactiveBorder;
            OverviewGroup.Controls.Add(TotalBilled);
            OverviewGroup.Controls.Add(label9);
            OverviewGroup.Controls.Add(AverageBilled);
            OverviewGroup.Controls.Add(label10);
            OverviewGroup.Controls.Add(TotalUsage);
            OverviewGroup.Controls.Add(label6);
            OverviewGroup.Controls.Add(AverageUsage);
            OverviewGroup.Controls.Add(label7);
            OverviewGroup.Controls.Add(CustomerCount);
            OverviewGroup.Controls.Add(label3);
            OverviewGroup.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            OverviewGroup.Location = new Point(378, 69);
            OverviewGroup.Name = "OverviewGroup";
            OverviewGroup.Size = new Size(369, 222);
            OverviewGroup.TabIndex = 4;
            OverviewGroup.TabStop = false;
            OverviewGroup.Text = "Overview";
            // 
            // TotalBilled
            // 
            TotalBilled.BackColor = SystemColors.GradientInactiveCaption;
            TotalBilled.Enabled = false;
            TotalBilled.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalBilled.ForeColor = SystemColors.MenuText;
            TotalBilled.Location = new Point(187, 173);
            TotalBilled.Name = "TotalBilled";
            TotalBilled.ReadOnly = true;
            TotalBilled.Size = new Size(173, 33);
            TotalBilled.TabIndex = 21;
            TotalBilled.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(187, 149);
            label9.Name = "label9";
            label9.Size = new Size(90, 21);
            label9.TabIndex = 20;
            label9.Text = "Total Billed";
            // 
            // AverageBilled
            // 
            AverageBilled.BackColor = SystemColors.GradientInactiveCaption;
            AverageBilled.Enabled = false;
            AverageBilled.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AverageBilled.ForeColor = SystemColors.MenuText;
            AverageBilled.Location = new Point(6, 173);
            AverageBilled.Name = "AverageBilled";
            AverageBilled.ReadOnly = true;
            AverageBilled.Size = new Size(173, 33);
            AverageBilled.TabIndex = 19;
            AverageBilled.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(6, 149);
            label10.Name = "label10";
            label10.Size = new Size(116, 21);
            label10.TabIndex = 18;
            label10.Text = "Average Billed";
            // 
            // TotalUsage
            // 
            TotalUsage.BackColor = SystemColors.GradientInactiveCaption;
            TotalUsage.Enabled = false;
            TotalUsage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalUsage.ForeColor = SystemColors.MenuText;
            TotalUsage.Location = new Point(187, 113);
            TotalUsage.Name = "TotalUsage";
            TotalUsage.ReadOnly = true;
            TotalUsage.Size = new Size(173, 33);
            TotalUsage.TabIndex = 17;
            TotalUsage.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(187, 89);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 16;
            label6.Text = "Total Usage";
            // 
            // AverageUsage
            // 
            AverageUsage.BackColor = SystemColors.GradientInactiveCaption;
            AverageUsage.Enabled = false;
            AverageUsage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AverageUsage.ForeColor = SystemColors.MenuText;
            AverageUsage.Location = new Point(6, 113);
            AverageUsage.Name = "AverageUsage";
            AverageUsage.ReadOnly = true;
            AverageUsage.Size = new Size(173, 33);
            AverageUsage.TabIndex = 15;
            AverageUsage.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 89);
            label7.Name = "label7";
            label7.Size = new Size(120, 21);
            label7.TabIndex = 14;
            label7.Text = "Average Usage";
            // 
            // CustomerCount
            // 
            CustomerCount.BackColor = SystemColors.GradientInactiveCaption;
            CustomerCount.Enabled = false;
            CustomerCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerCount.ForeColor = SystemColors.MenuText;
            CustomerCount.Location = new Point(6, 53);
            CustomerCount.Name = "CustomerCount";
            CustomerCount.ReadOnly = true;
            CustomerCount.Size = new Size(88, 33);
            CustomerCount.TabIndex = 11;
            CustomerCount.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 10;
            label3.Text = "Customers";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveBorder;
            groupBox1.Controls.Add(CustomerID);
            groupBox1.Controls.Add(CustomerBilled);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(CustomerUsage);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CustomerName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(378, 297);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 235);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // CustomerID
            // 
            CustomerID.BackColor = SystemColors.GradientInactiveCaption;
            CustomerID.Enabled = false;
            CustomerID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerID.ForeColor = SystemColors.MenuText;
            CustomerID.Location = new Point(6, 65);
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Size = new Size(88, 33);
            CustomerID.TabIndex = 14;
            CustomerID.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerBilled
            // 
            CustomerBilled.BackColor = SystemColors.GradientInactiveCaption;
            CustomerBilled.Enabled = false;
            CustomerBilled.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerBilled.ForeColor = SystemColors.MenuText;
            CustomerBilled.Location = new Point(187, 185);
            CustomerBilled.Name = "CustomerBilled";
            CustomerBilled.ReadOnly = true;
            CustomerBilled.Size = new Size(173, 33);
            CustomerBilled.TabIndex = 13;
            CustomerBilled.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(187, 161);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 12;
            label8.Text = "Billed";
            // 
            // CustomerUsage
            // 
            CustomerUsage.BackColor = SystemColors.GradientInactiveCaption;
            CustomerUsage.Enabled = false;
            CustomerUsage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerUsage.ForeColor = SystemColors.MenuText;
            CustomerUsage.Location = new Point(6, 185);
            CustomerUsage.Name = "CustomerUsage";
            CustomerUsage.ReadOnly = true;
            CustomerUsage.Size = new Size(173, 33);
            CustomerUsage.TabIndex = 11;
            CustomerUsage.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 161);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 10;
            label5.Text = "Usage";
            // 
            // CustomerName
            // 
            CustomerName.BackColor = SystemColors.GradientInactiveCaption;
            CustomerName.Enabled = false;
            CustomerName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerName.ForeColor = SystemColors.MenuText;
            CustomerName.Location = new Point(6, 125);
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Size = new Size(354, 33);
            CustomerName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 101);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(26, 21);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(759, 545);
            Controls.Add(groupBox1);
            Controls.Add(OverviewGroup);
            Controls.Add(CustomerListBox);
            Controls.Add(label1);
            Controls.Add(AddCustomerButton);
            Controls.Add(DeleteCustomerButton);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BillingForm";
            Text = "Billing Overview";
            Load += OnLoad;
            OverviewGroup.ResumeLayout(false);
            OverviewGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox CustomerListBox;
        private Button AddCustomerButton;
        private Button DeleteCustomerButton;
        private GroupBox OverviewGroup;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox CustomerUsage;
        private Label label5;
        private TextBox CustomerName;
        private Label label4;
        private TextBox TotalBilled;
        private Label label9;
        private TextBox AverageBilled;
        private Label label10;
        private TextBox TotalUsage;
        private Label label6;
        private TextBox AverageUsage;
        private Label label7;
        private TextBox CustomerCount;
        private Label label3;
        private TextBox CustomerBilled;
        private Label label8;
        private TextBox CustomerID;
    }
}