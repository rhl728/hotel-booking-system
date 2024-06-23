namespace Hotel_Booking
{
    partial class Form1
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
            btnCtp = new Button();
            label1 = new Label();
            txtAddress = new TextBox();
            cmbRt = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtNof = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbYn = new ComboBox();
            txtTc = new TextBox();
            label7 = new Label();
            btnClear = new Button();
            btnExit = new Button();
            label8 = new Label();
            txtNod = new TextBox();
            SuspendLayout();
            // 
            // btnCtp
            // 
            btnCtp.Location = new Point(633, 82);
            btnCtp.Name = "btnCtp";
            btnCtp.Size = new Size(138, 38);
            btnCtp.TabIndex = 0;
            btnCtp.Text = "Calculate the Price";
            btnCtp.UseVisualStyleBackColor = true;
            btnCtp.Click += btnCtp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 90);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(252, 139);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(299, 23);
            txtAddress.TabIndex = 2;
            // 
            // cmbRt
            // 
            cmbRt.FormattingEnabled = true;
            cmbRt.Items.AddRange(new object[] { "Single", "Double", "Family", "Suite" });
            cmbRt.Location = new Point(252, 198);
            cmbRt.Name = "cmbRt";
            cmbRt.Size = new Size(121, 23);
            cmbRt.TabIndex = 3;
            cmbRt.SelectedIndexChanged += cmbRt_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 142);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 198);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "Room Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 256);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 6;
            label4.Text = "Number of Rooms";
            // 
            // txtName
            // 
            txtName.Location = new Point(252, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 23);
            txtName.TabIndex = 7;
            // 
            // txtNof
            // 
            txtNof.Location = new Point(252, 248);
            txtNof.Name = "txtNof";
            txtNof.Size = new Size(60, 23);
            txtNof.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(62, 383);
            label5.Name = "label5";
            label5.Size = new Size(274, 20);
            label5.TabIndex = 9;
            label5.Text = "Do you want to do an another booking?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(566, 384);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "Total Cost";
            // 
            // cmbYn
            // 
            cmbYn.FormattingEnabled = true;
            cmbYn.Items.AddRange(new object[] { "Yes", "No" });
            cmbYn.Location = new Point(361, 384);
            cmbYn.Name = "cmbYn";
            cmbYn.Size = new Size(58, 23);
            cmbYn.TabIndex = 11;
            cmbYn.SelectedIndexChanged += cmbYn_SelectedIndexChanged;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(647, 383);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(88, 23);
            txtTc.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(335, 22);
            label7.Name = "label7";
            label7.Size = new Size(132, 25);
            label7.TabIndex = 13;
            label7.Text = "Booking Form";
            label7.Click += label7_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(633, 154);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 42);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(633, 229);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 42);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(81, 302);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 16;
            label8.Text = "Number of Days";
            // 
            // txtNod
            // 
            txtNod.Location = new Point(252, 294);
            txtNod.Name = "txtNod";
            txtNod.Size = new Size(60, 23);
            txtNod.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNod);
            Controls.Add(label8);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(label7);
            Controls.Add(txtTc);
            Controls.Add(cmbYn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNof);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbRt);
            Controls.Add(txtAddress);
            Controls.Add(label1);
            Controls.Add(btnCtp);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Hotel Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCtp;
        private Label label1;
        private TextBox txtAddress;
        private ComboBox cmbRt;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtNof;
        private Label label5;
        private Label label6;
        private ComboBox cmbYn;
        private TextBox txtTc;
        private Label label7;
        private Button btnClear;
        private Button btnExit;
        private Label label8;
        private TextBox txtNod;
    }
}