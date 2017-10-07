namespace MedicalISDB
{
    partial class Form6
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
            this.pharmarcyDbDataSet = new MedicalISDB.PharmarcyDbDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new MedicalISDB.PharmarcyDbDataSetTableAdapters.UsersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasscodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pharmarcyDbDataSet1 = new MedicalISDB.PharmarcyDbDataSet1();
            this.usersTableAdapter1 = new MedicalISDB.PharmarcyDbDataSet1TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pharmarcyDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmarcyDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmarcyDbDataSet
            // 
            this.pharmarcyDbDataSet.DataSetName = "PharmarcyDbDataSet";
            this.pharmarcyDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.pharmarcyDbDataSet;
            this.usersBindingSource.CurrentChanged += new System.EventHandler(this.usersBindingSource_CurrentChanged);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPasscodeDataGridViewTextBoxColumn,
            this.WorkTitle,
            this.DateOfBirth,
            this.Location,
            this.UserSalary});
            this.dataGridView1.DataSource = this.usersBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userPasscodeDataGridViewTextBoxColumn
            // 
            this.userPasscodeDataGridViewTextBoxColumn.DataPropertyName = "UserPasscode";
            this.userPasscodeDataGridViewTextBoxColumn.HeaderText = "UserPasscode";
            this.userPasscodeDataGridViewTextBoxColumn.Name = "userPasscodeDataGridViewTextBoxColumn";
            this.userPasscodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // WorkTitle
            // 
            this.WorkTitle.DataPropertyName = "WorkTitle";
            this.WorkTitle.HeaderText = "WorkTitle";
            this.WorkTitle.Name = "WorkTitle";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // UserSalary
            // 
            this.UserSalary.DataPropertyName = "UserSalary";
            this.UserSalary.HeaderText = "UserSalary";
            this.UserSalary.Name = "UserSalary";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.pharmarcyDbDataSet1;
            // 
            // pharmarcyDbDataSet1
            // 
            this.pharmarcyDbDataSet1.DataSetName = "PharmarcyDbDataSet1";
            this.pharmarcyDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmarcyDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmarcyDbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PharmarcyDbDataSet pharmarcyDbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private PharmarcyDbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PharmarcyDbDataSet1 pharmarcyDbDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private PharmarcyDbDataSet1TableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasscodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSalary;
    }
}