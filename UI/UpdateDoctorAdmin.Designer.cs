namespace UI
{
    partial class UpdateDoctorAdmin
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
            this.hr = new System.Windows.Forms.Label();
            this.txtSpecialisation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addUserDoctor = new UI.AddUser();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hr
            // 
            this.hr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hr.Location = new System.Drawing.Point(85, 280);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(321, 2);
            this.hr.TabIndex = 6;
            // 
            // txtSpecialisation
            // 
            this.txtSpecialisation.Location = new System.Drawing.Point(172, 313);
            this.txtSpecialisation.Name = "txtSpecialisation";
            this.txtSpecialisation.Size = new System.Drawing.Size(210, 20);
            this.txtSpecialisation.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addUserDoctor
            // 
            this.addUserDoctor.BackColor = System.Drawing.Color.Transparent;
            this.addUserDoctor.ComboxBoxUserPermSelectedIndex = -1;
            this.addUserDoctor.ComboxBoxUserTypeSelectedIndex = -1;
            this.addUserDoctor.Firstname = "";
            this.addUserDoctor.Gender = "";
            this.addUserDoctor.Lastname = "";
            this.addUserDoctor.Location = new System.Drawing.Point(12, 33);
            this.addUserDoctor.Middlename = "";
            this.addUserDoctor.Name = "addUserDoctor";
            this.addUserDoctor.PhoneNumber = "";
            this.addUserDoctor.Size = new System.Drawing.Size(398, 265);
            this.addUserDoctor.TabIndex = 9;
            this.addUserDoctor.Username = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Specialisation";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(172, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(214, 20);
            this.txtID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // UpdateDoctorAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.updateDoctor;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUserDoctor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSpecialisation);
            this.Controls.Add(this.hr);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDoctorAdmin";
            this.Text = "UpdateDoctorAdmin";
            this.Load += new System.EventHandler(this.UpdateDoctorAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hr;
        private System.Windows.Forms.TextBox txtSpecialisation;
        private System.Windows.Forms.Button button1;
        private AddUser addUserDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
    }
}