namespace UI
{
    partial class AddPatient
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
            this.addUserPatient = new UI.AddUser();
            this.content = new System.Windows.Forms.Panel();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hr6 = new UI.HR();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.hr5 = new UI.HR();
            this.hr4 = new UI.HR();
            this.txtNextOfKinNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNextOfKin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hr3 = new UI.HR();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.hr2 = new UI.HR();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hr1 = new UI.HR();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserPatient
            // 
            this.addUserPatient.ComboxBoxUserPermSelectedIndex = -1;
            this.addUserPatient.ComboxBoxUserTypeSelectedIndex = -1;
            this.addUserPatient.Firstname = "";
            this.addUserPatient.Gender = "";
            this.addUserPatient.Lastname = "";
            this.addUserPatient.Location = new System.Drawing.Point(3, 3);
            this.addUserPatient.Middlename = "";
            this.addUserPatient.Name = "addUserPatient";
            this.addUserPatient.PhoneNumber = "";
            this.addUserPatient.Size = new System.Drawing.Size(398, 263);
            this.addUserPatient.TabIndex = 0;
            this.addUserPatient.Username = "";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.content.Controls.Add(this.txtBloodGroup);
            this.content.Controls.Add(this.label8);
            this.content.Controls.Add(this.button1);
            this.content.Controls.Add(this.hr6);
            this.content.Controls.Add(this.label7);
            this.content.Controls.Add(this.rtbAddress);
            this.content.Controls.Add(this.hr5);
            this.content.Controls.Add(this.hr4);
            this.content.Controls.Add(this.txtNextOfKinNum);
            this.content.Controls.Add(this.label6);
            this.content.Controls.Add(this.label5);
            this.content.Controls.Add(this.txtNextOfKin);
            this.content.Controls.Add(this.label4);
            this.content.Controls.Add(this.hr3);
            this.content.Controls.Add(this.txtHeight);
            this.content.Controls.Add(this.label3);
            this.content.Controls.Add(this.txtWeight);
            this.content.Controls.Add(this.hr2);
            this.content.Controls.Add(this.dtpDOB);
            this.content.Controls.Add(this.label2);
            this.content.Controls.Add(this.label1);
            this.content.Controls.Add(this.hr1);
            this.content.Controls.Add(this.addUserPatient);
            this.content.Location = new System.Drawing.Point(3, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(712, 386);
            this.content.TabIndex = 0;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(511, 126);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(194, 20);
            this.txtBloodGroup.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Blood Group";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(591, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hr6
            // 
            this.hr6.Location = new System.Drawing.Point(407, 314);
            this.hr6.Name = "hr6";
            this.hr6.Size = new System.Drawing.Size(295, 10);
            this.hr6.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Address";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(511, 155);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(194, 154);
            this.rtbAddress.TabIndex = 17;
            this.rtbAddress.Text = "";
            // 
            // hr5
            // 
            this.hr5.Location = new System.Drawing.Point(410, 110);
            this.hr5.Name = "hr5";
            this.hr5.Size = new System.Drawing.Size(295, 10);
            this.hr5.TabIndex = 16;
            // 
            // hr4
            // 
            this.hr4.Location = new System.Drawing.Point(410, 39);
            this.hr4.Name = "hr4";
            this.hr4.Size = new System.Drawing.Size(295, 10);
            this.hr4.TabIndex = 15;
            // 
            // txtNextOfKinNum
            // 
            this.txtNextOfKinNum.Location = new System.Drawing.Point(511, 84);
            this.txtNextOfKinNum.Name = "txtNextOfKinNum";
            this.txtNextOfKinNum.Size = new System.Drawing.Size(194, 20);
            this.txtNextOfKinNum.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Relationship";
            // 
            // txtNextOfKin
            // 
            this.txtNextOfKin.Location = new System.Drawing.Point(511, 50);
            this.txtNextOfKin.Name = "txtNextOfKin";
            this.txtNextOfKin.Size = new System.Drawing.Size(194, 20);
            this.txtNextOfKin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Next Of Kin";
            // 
            // hr3
            // 
            this.hr3.Location = new System.Drawing.Point(51, 369);
            this.hr3.Name = "hr3";
            this.hr3.Size = new System.Drawing.Size(350, 10);
            this.hr3.TabIndex = 9;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(163, 346);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(214, 20);
            this.txtHeight.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Height";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(163, 320);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(214, 20);
            this.txtWeight.TabIndex = 6;
            // 
            // hr2
            // 
            this.hr2.Location = new System.Drawing.Point(45, 314);
            this.hr2.Name = "hr2";
            this.hr2.Size = new System.Drawing.Size(356, 10);
            this.hr2.TabIndex = 5;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(163, 288);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(214, 20);
            this.dtpDOB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Of Birth";
            // 
            // hr1
            // 
            this.hr1.Location = new System.Drawing.Point(45, 272);
            this.hr1.Name = "hr1";
            this.hr1.Size = new System.Drawing.Size(356, 10);
            this.hr1.TabIndex = 1;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.content);
            this.Name = "AddPatient";
            this.Size = new System.Drawing.Size(732, 400);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AddUser addUserPatient;
        private System.Windows.Forms.Panel content;
        private HR hr1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private HR hr2;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HR hr5;
        private HR hr4;
        private System.Windows.Forms.TextBox txtNextOfKinNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNextOfKin;
        private System.Windows.Forms.Label label4;
        private HR hr3;
        private System.Windows.Forms.Button button1;
        private HR hr6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.Label label8;
    }
}
