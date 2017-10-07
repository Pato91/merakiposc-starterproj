namespace MedicalISDB
{
    partial class Form7
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ProductName1 = new System.Windows.Forms.TextBox();
            this.ProductDescription1 = new System.Windows.Forms.TextBox();
            this.Manufacturer1 = new System.Windows.Forms.TextBox();
            this.DateOfEntry1 = new System.Windows.Forms.TextBox();
            this.DateOfExit1 = new System.Windows.Forms.TextBox();
            this.Category1 = new System.Windows.Forms.TextBox();
            this.ExpiryDate1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductPrice1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, -26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, -19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(218, 363);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 2;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ProductName1
            // 
            this.ProductName1.Location = new System.Drawing.Point(153, 23);
            this.ProductName1.Name = "ProductName1";
            this.ProductName1.Size = new System.Drawing.Size(140, 20);
            this.ProductName1.TabIndex = 3;
            // 
            // ProductDescription1
            // 
            this.ProductDescription1.Location = new System.Drawing.Point(153, 50);
            this.ProductDescription1.Multiline = true;
            this.ProductDescription1.Name = "ProductDescription1";
            this.ProductDescription1.Size = new System.Drawing.Size(140, 73);
            this.ProductDescription1.TabIndex = 4;
            this.ProductDescription1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Manufacturer1
            // 
            this.Manufacturer1.Location = new System.Drawing.Point(153, 143);
            this.Manufacturer1.Name = "Manufacturer1";
            this.Manufacturer1.Size = new System.Drawing.Size(140, 20);
            this.Manufacturer1.TabIndex = 5;
            // 
            // DateOfEntry1
            // 
            this.DateOfEntry1.Location = new System.Drawing.Point(153, 177);
            this.DateOfEntry1.Name = "DateOfEntry1";
            this.DateOfEntry1.Size = new System.Drawing.Size(140, 20);
            this.DateOfEntry1.TabIndex = 6;
            // 
            // DateOfExit1
            // 
            this.DateOfExit1.Location = new System.Drawing.Point(153, 210);
            this.DateOfExit1.Name = "DateOfExit1";
            this.DateOfExit1.Size = new System.Drawing.Size(140, 20);
            this.DateOfExit1.TabIndex = 7;
            // 
            // Category1
            // 
            this.Category1.Location = new System.Drawing.Point(153, 243);
            this.Category1.Name = "Category1";
            this.Category1.Size = new System.Drawing.Size(140, 20);
            this.Category1.TabIndex = 8;
            // 
            // ExpiryDate1
            // 
            this.ExpiryDate1.Location = new System.Drawing.Point(153, 274);
            this.ExpiryDate1.Name = "ExpiryDate1";
            this.ExpiryDate1.Size = new System.Drawing.Size(140, 20);
            this.ExpiryDate1.TabIndex = 9;
            this.ExpiryDate1.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date Of Entry";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date Of Exit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Expiry Date";
            // 
            // ProductPrice1
            // 
            this.ProductPrice1.Location = new System.Drawing.Point(153, 313);
            this.ProductPrice1.Name = "ProductPrice1";
            this.ProductPrice1.Size = new System.Drawing.Size(140, 20);
            this.ProductPrice1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Product Price";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Category1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ProductPrice1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AddProduct);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ProductName1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ProductDescription1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Manufacturer1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DateOfEntry1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DateOfExit1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ExpiryDate1);
            this.groupBox1.Location = new System.Drawing.Point(235, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 392);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 416);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.TextBox ProductName1;
        private System.Windows.Forms.TextBox ProductDescription1;
        private System.Windows.Forms.TextBox Manufacturer1;
        private System.Windows.Forms.TextBox DateOfEntry1;
        private System.Windows.Forms.TextBox DateOfExit1;
        private System.Windows.Forms.TextBox Category1;
        private System.Windows.Forms.TextBox ExpiryDate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProductPrice1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}