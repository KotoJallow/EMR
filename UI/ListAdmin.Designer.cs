namespace UI
{
    partial class ListAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uID,
            this.uFirstName,
            this.uMiddleName,
            this.uLastName,
            this.uGender,
            this.uPhoneNumber,
            this.uType});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(810, 373);
            this.dataGridView1.TabIndex = 1;
            // 
            // uID
            // 
            this.uID.DataPropertyName = "userID";
            this.uID.HeaderText = "ID";
            this.uID.Name = "uID";
            this.uID.ReadOnly = true;
            // 
            // uFirstName
            // 
            this.uFirstName.DataPropertyName = "firstName";
            this.uFirstName.HeaderText = "FirstName";
            this.uFirstName.Name = "uFirstName";
            this.uFirstName.ReadOnly = true;
            // 
            // uMiddleName
            // 
            this.uMiddleName.DataPropertyName = "middleName";
            this.uMiddleName.HeaderText = "MiddleName";
            this.uMiddleName.Name = "uMiddleName";
            this.uMiddleName.ReadOnly = true;
            // 
            // uLastName
            // 
            this.uLastName.DataPropertyName = "lastName";
            this.uLastName.HeaderText = "LastName";
            this.uLastName.Name = "uLastName";
            this.uLastName.ReadOnly = true;
            // 
            // uGender
            // 
            this.uGender.DataPropertyName = "gender";
            this.uGender.HeaderText = "Gender";
            this.uGender.Name = "uGender";
            this.uGender.ReadOnly = true;
            // 
            // uPhoneNumber
            // 
            this.uPhoneNumber.DataPropertyName = "phoneNumber";
            this.uPhoneNumber.HeaderText = "PhoneNumber";
            this.uPhoneNumber.Name = "uPhoneNumber";
            this.uPhoneNumber.ReadOnly = true;
            // 
            // uType
            // 
            this.uType.DataPropertyName = "type";
            this.uType.HeaderText = "Type";
            this.uType.Name = "uType";
            this.uType.ReadOnly = true;
            // 
            // ListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListAdmin";
            this.Size = new System.Drawing.Size(930, 458);
            this.Load += new System.EventHandler(this.ListAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn uType;
    }
}
