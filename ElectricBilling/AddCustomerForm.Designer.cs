namespace ElectricBillingForm
{
    partial class AddCustomerForm
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            LastName = new TextBox();
            label1 = new Label();
            CustomerID = new TextBox();
            Usage = new TextBox();
            label5 = new Label();
            FirstName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            CancelButton = new Button();
            ConfirmButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CustomerID);
            groupBox1.Controls.Add(Usage);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(FirstName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 235);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(185, 191);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 17;
            label3.Text = "kWh";
            // 
            // LastName
            // 
            LastName.BackColor = SystemColors.Window;
            LastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LastName.Location = new Point(185, 125);
            LastName.Name = "LastName";
            LastName.Size = new Size(173, 33);
            LastName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 101);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 15;
            label1.Text = "Last Name";
            // 
            // CustomerID
            // 
            CustomerID.BackColor = SystemColors.ControlLight;
            CustomerID.Enabled = false;
            CustomerID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerID.Location = new Point(6, 65);
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Size = new Size(88, 33);
            CustomerID.TabIndex = 14;
            CustomerID.TextAlign = HorizontalAlignment.Center;
            // 
            // Usage
            // 
            Usage.BackColor = SystemColors.Window;
            Usage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Usage.Location = new Point(6, 185);
            Usage.Name = "Usage";
            Usage.Size = new Size(173, 33);
            Usage.TabIndex = 11;
            Usage.TextAlign = HorizontalAlignment.Right;
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
            // FirstName
            // 
            FirstName.BackColor = SystemColors.Window;
            FirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FirstName.Location = new Point(6, 125);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(173, 33);
            FirstName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 101);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 8;
            label4.Text = "First Name";
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
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.Location = new Point(12, 253);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(182, 32);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += OnClickCancel;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmButton.Location = new Point(199, 252);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(182, 32);
            ConfirmButton.TabIndex = 8;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += OnClickConfirm;
            // 
            // AddCustomerForm
            // 
            AcceptButton = ConfirmButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 296);
            Controls.Add(ConfirmButton);
            Controls.Add(CancelButton);
            Controls.Add(groupBox1);
            Name = "AddCustomerForm";
            Text = "AddCustomerForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox LastName;
        private Label label1;
        private TextBox CustomerID;
        private TextBox Usage;
        private Label label5;
        private TextBox FirstName;
        private Label label4;
        private Label label2;
        private Button CancelButton;
        private Button ConfirmButton;
    }
}