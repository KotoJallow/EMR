namespace UI
{
    partial class ListPatientsAdmin
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
            this.uLoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNextOfKin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNumNextOfKin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
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
            this.uLoginID,
            this.uFirstName,
            this.uMiddleName,
            this.uLastName,
            this.uGender,
            this.uPhoneNumber,
            this.uBloodGroup,
            this.uWeight,
            this.uHeight,
            this.uDOB,
            this.uNextOfKin,
            this.uNumNextOfKin});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 373);
            this.dataGridView1.TabIndex = 1;
            // 
            // uID
            // 
            this.uID.DataPropertyName = "patientID";
            this.uID.HeaderText = "ID";
            this.uID.Name = "uID";
            this.uID.ReadOnly = true;
            // 
            // uLoginID
            // 
            this.uLoginID.DataPropertyName = "loginID";
            this.uLoginID.HeaderText = "LoginID";
            this.uLoginID.Name = "uLoginID";
            this.uLoginID.ReadOnly = true;
            this.uLoginID.Visible = false;
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
            this.uPhoneNumber.HeaderText = "Phone Number";
            this.uPhoneNumber.Name = "uPhoneNumber";
            this.uPhoneNumber.ReadOnly = true;
            // 
            // uBloodGroup
            // 
            this.uBloodGroup.DataPropertyName = "bloodGroup";
            this.uBloodGroup.HeaderText = "Blood Group";
            this.uBloodGroup.Name = "uBloodGroup";
            this.uBloodGroup.ReadOnly = true;
            // 
            // uWeight
            // 
            this.uWeight.DataPropertyName = "weight";
            this.uWeight.HeaderText = "Weight";
            this.uWeight.Name = "uWeight";
            this.uWeight.ReadOnly = true;
            // 
            // uHeight
            // 
            this.uHeight.DataPropertyName = "height";
            this.uHeight.HeaderText = "Height";
            this.uHeight.Name = "uHeight";
            this.uHeight.ReadOnly = true;
            // 
            // uDOB
            // 
            this.uDOB.DataPropertyName = "DOB";
            this.uDOB.HeaderText = "DOB";
            this.uDOB.Name = "uDOB";
            this.uDOB.ReadOnly = true;
            // 
            // uNextOfKin
            // 
            this.uNextOfKin.DataPropertyName = "nextOfKin";
            this.uNextOfKin.HeaderText = "nextOfKin";
            this.uNextOfKin.Name = "uNextOfKin";
            this.uNextOfKin.ReadOnly = true;
            // 
            // uNumNextOfKin
            // 
            this.uNumNextOfKin.DataPropertyName = "numNextOfKin";
            this.uNumNextOfKin.HeaderText = "NumNextOfKin";
            this.uNumNextOfKin.Name = "uNumNextOfKin";
            this.uNumNextOfKin.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(548, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(526, 47);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(539, 49);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ListPatientsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListPatientsAdmin";
            this.Size = new System.Drawing.Size(1077, 455);
            this.Load += new System.EventHandler(this.ListPatientsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn uBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn uWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn uHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNextOfKin;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNumNextOfKin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
