namespace UI
{
    partial class ListDoctorsAdmin
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
            this.Content = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.uID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSpecialisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Content.Controls.Add(this.panelFooter);
            this.Content.Controls.Add(this.dataGridView1);
            this.Content.Location = new System.Drawing.Point(3, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(745, 434);
            this.Content.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnDelete);
            this.panelFooter.Controls.Add(this.btnUpdate);
            this.panelFooter.Location = new System.Drawing.Point(3, 365);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(739, 49);
            this.panelFooter.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(360, 49);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
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
            this.uSpecialisation});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 356);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(366, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(361, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uID
            // 
            this.uID.DataPropertyName = "doctorID";
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
            this.uPhoneNumber.HeaderText = "PhoneNumber";
            this.uPhoneNumber.Name = "uPhoneNumber";
            this.uPhoneNumber.ReadOnly = true;
            // 
            // uSpecialisation
            // 
            this.uSpecialisation.DataPropertyName = "specialisation";
            this.uSpecialisation.HeaderText = "Specialisation";
            this.uSpecialisation.Name = "uSpecialisation";
            this.uSpecialisation.ReadOnly = true;
            // 
            // ListDoctorsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Content);
            this.Name = "ListDoctorsAdmin";
            this.Size = new System.Drawing.Size(749, 434);
            this.Load += new System.EventHandler(this.ListDoctorsAdmin_Load);
            this.Content.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn uID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSpecialisation;
    }
}
