namespace MedicalISDB
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.AddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Passcode1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WorkTitle1 = new System.Windows.Forms.TextBox();
            this.DateOfBirth1 = new System.Windows.Forms.TextBox();
            this.Location1 = new System.Windows.Forms.TextBox();
            this.WorkTitle = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.Salary1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(121, 30);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(199, 20);
            this.Name1.TabIndex = 1;
            this.Name1.TextChanged += new System.EventHandler(this.Name1_TextChanged);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(187, 238);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(75, 23);
            this.AddUser.TabIndex = 2;
            this.AddUser.Text = "Add User";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Passcode";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Passcode1
            // 
            this.Passcode1.Location = new System.Drawing.Point(121, 65);
            this.Passcode1.Name = "Passcode1";
            this.Passcode1.Size = new System.Drawing.Size(199, 20);
            this.Passcode1.TabIndex = 4;
            this.Passcode1.TextChanged += new System.EventHandler(this.Passcode1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Salary1);
            this.groupBox1.Controls.Add(this.Salary);
            this.groupBox1.Controls.Add(this.DateOfBirth);
            this.groupBox1.Controls.Add(this.Location);
            this.groupBox1.Controls.Add(this.WorkTitle);
            this.groupBox1.Controls.Add(this.Location1);
            this.groupBox1.Controls.Add(this.DateOfBirth1);
            this.groupBox1.Controls.Add(this.WorkTitle1);
            this.groupBox1.Controls.Add(this.Passcode1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Name1);
            this.groupBox1.Controls.Add(this.AddUser);
            this.groupBox1.Location = new System.Drawing.Point(201, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // WorkTitle1
            // 
            this.WorkTitle1.Location = new System.Drawing.Point(121, 91);
            this.WorkTitle1.Name = "WorkTitle1";
            this.WorkTitle1.Size = new System.Drawing.Size(199, 20);
            this.WorkTitle1.TabIndex = 5;
            // 
            // DateOfBirth1
            // 
            this.DateOfBirth1.Location = new System.Drawing.Point(121, 124);
            this.DateOfBirth1.Name = "DateOfBirth1";
            this.DateOfBirth1.Size = new System.Drawing.Size(199, 20);
            this.DateOfBirth1.TabIndex = 6;
            // 
            // Location1
            // 
            this.Location1.Location = new System.Drawing.Point(121, 159);
            this.Location1.Name = "Location1";
            this.Location1.Size = new System.Drawing.Size(199, 20);
            this.Location1.TabIndex = 7;
            // 
            // WorkTitle
            // 
            this.WorkTitle.AutoSize = true;
            this.WorkTitle.Location = new System.Drawing.Point(43, 94);
            this.WorkTitle.Name = "WorkTitle";
            this.WorkTitle.Size = new System.Drawing.Size(56, 13);
            this.WorkTitle.TabIndex = 8;
            this.WorkTitle.Text = "Work Title";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(51, 162);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(48, 13);
            this.Location.TabIndex = 9;
            this.Location.Text = "Location";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Location = new System.Drawing.Point(32, 127);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.DateOfBirth.TabIndex = 10;
            this.DateOfBirth.Text = "Date Of Birth";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(64, 196);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(36, 13);
            this.Salary.TabIndex = 11;
            this.Salary.Text = "Salary";
            // 
            // Salary1
            // 
            this.Salary1.Location = new System.Drawing.Point(121, 193);
            this.Salary1.Name = "Salary1";
            this.Salary1.Size = new System.Drawing.Size(199, 20);
            this.Salary1.TabIndex = 12;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 312);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Add_User";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Passcode1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Location1;
        private System.Windows.Forms.TextBox DateOfBirth1;
        private System.Windows.Forms.TextBox WorkTitle1;
        private System.Windows.Forms.Label DateOfBirth;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label WorkTitle;
        private System.Windows.Forms.TextBox Salary1;
        private System.Windows.Forms.Label Salary;
    }
}