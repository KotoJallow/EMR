namespace UI
{
    partial class ListUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnChangePerm = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 373);
            this.dataGridView1.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 373);
            this.panel1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(366, 47);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangePerm
            // 
            this.btnChangePerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePerm.Location = new System.Drawing.Point(375, 379);
            this.btnChangePerm.Name = "btnChangePerm";
            this.btnChangePerm.Size = new System.Drawing.Size(362, 47);
            this.btnChangePerm.TabIndex = 3;
            this.btnChangePerm.Text = "Change Permission";
            this.btnChangePerm.UseVisualStyleBackColor = true;
            this.btnChangePerm.Click += new System.EventHandler(this.btnChangePerm_Click);
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnChangePerm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Name = "ListUsers";
            this.Size = new System.Drawing.Size(740, 429);
            this.Load += new System.EventHandler(this.ListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn uID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn uType;
        private System.Windows.Forms.Button btnChangePerm;
    }
}
