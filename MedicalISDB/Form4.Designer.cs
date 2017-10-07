namespace MedicalISDB
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Item_Cart = new System.Windows.Forms.GroupBox();
            this.CheckOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.PaidAmount1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soldItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmarcyDbDataSet3 = new MedicalISDB.PharmarcyDbDataSet3();
            this.soldItemsTableAdapter = new MedicalISDB.PharmarcyDbDataSet3TableAdapters.SoldItemsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pharmarcyDbDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Item_Cart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmarcyDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmarcyDbDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductID
            // 
            this.ProductID.Location = new System.Drawing.Point(114, 19);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(159, 20);
            this.ProductID.TabIndex = 0;
            this.ProductID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Product ID";
            // 
            // Item_Cart
            // 
            this.Item_Cart.Controls.Add(this.CheckOut);
            this.Item_Cart.Controls.Add(this.ProductID);
            this.Item_Cart.Controls.Add(this.label1);
            this.Item_Cart.Location = new System.Drawing.Point(307, 25);
            this.Item_Cart.Name = "Item_Cart";
            this.Item_Cart.Size = new System.Drawing.Size(279, 102);
            this.Item_Cart.TabIndex = 2;
            this.Item_Cart.TabStop = false;
            this.Item_Cart.Text = "ItemCart";
            // 
            // CheckOut
            // 
            this.CheckOut.Location = new System.Drawing.Point(186, 59);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(75, 23);
            this.CheckOut.TabIndex = 2;
            this.CheckOut.Text = "checkOut";
            this.CheckOut.UseVisualStyleBackColor = true;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelChange);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonRegister);
            this.groupBox1.Controls.Add(this.PaidAmount1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TotalCalculator";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(121, 74);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(28, 13);
            this.labelChange.TabIndex = 7;
            this.labelChange.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Balance(UgShs)";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(208, 45);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // PaidAmount1
            // 
            this.PaidAmount1.Location = new System.Drawing.Point(124, 19);
            this.PaidAmount1.Name = "PaidAmount1";
            this.PaidAmount1.Size = new System.Drawing.Size(159, 20);
            this.PaidAmount1.TabIndex = 3;
            this.PaidAmount1.TextChanged += new System.EventHandler(this.PaidAmount1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PaidAmount(UgShs)";
            // 
            // soldItemsBindingSource
            // 
            this.soldItemsBindingSource.DataMember = "SoldItems";
            this.soldItemsBindingSource.DataSource = this.pharmarcyDbDataSet3;
            // 
            // pharmarcyDbDataSet3
            // 
            this.pharmarcyDbDataSet3.DataSetName = "PharmarcyDbDataSet3";
            this.pharmarcyDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soldItemsTableAdapter
            // 
            this.soldItemsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.soldItemsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(328, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            // 
            // pharmarcyDbDataSet3BindingSource
            // 
            this.pharmarcyDbDataSet3BindingSource.AllowNew = true;
            this.pharmarcyDbDataSet3BindingSource.DataSource = this.pharmarcyDbDataSet3;
            this.pharmarcyDbDataSet3BindingSource.Position = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost (UgShs)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "0.00";
            // 
            // contextBindingSource
            // 
            this.contextBindingSource.DataSource = typeof(MedicalISDB.Context);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(616, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Item_Cart);
            this.Name = "Form4";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Item_Cart.ResumeLayout(false);
            this.Item_Cart.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmarcyDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmarcyDbDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Item_Cart;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox PaidAmount1;
        private System.Windows.Forms.Label label2;
        private PharmarcyDbDataSet3 pharmarcyDbDataSet3;
        private System.Windows.Forms.BindingSource soldItemsBindingSource;
        private PharmarcyDbDataSet3TableAdapters.SoldItemsTableAdapter soldItemsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contextBindingSource;
        private System.Windows.Forms.BindingSource pharmarcyDbDataSet3BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelChange;
    }
}