namespace UI
{
    partial class AddDoctor
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
            this.content = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSpecialisation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hr = new System.Windows.Forms.Label();
            this.addUserDoctor = new UI.AddUser();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.button1);
            this.content.Controls.Add(this.txtSpecialisation);
            this.content.Controls.Add(this.label1);
            this.content.Controls.Add(this.hr);
            this.content.Controls.Add(this.addUserDoctor);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(461, 352);
            this.content.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSpecialisation
            // 
            this.txtSpecialisation.Location = new System.Drawing.Point(163, 279);
            this.txtSpecialisation.Name = "txtSpecialisation";
            this.txtSpecialisation.Size = new System.Drawing.Size(210, 20);
            this.txtSpecialisation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Specialisation";
            // 
            // hr
            // 
            this.hr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hr.Location = new System.Drawing.Point(52, 268);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(321, 2);
            this.hr.TabIndex = 1;
            // 
            // addUserDoctor
            // 
            this.addUserDoctor.ComboxBoxUserPermSelectedIndex = -1;
            this.addUserDoctor.ComboxBoxUserTypeSelectedIndex = -1;
            this.addUserDoctor.Firstname = "";
            this.addUserDoctor.Gender = "";
            this.addUserDoctor.Lastname = "";
            this.addUserDoctor.Location = new System.Drawing.Point(0, 0);
            this.addUserDoctor.Middlename = "";
            this.addUserDoctor.Name = "addUserDoctor";
            this.addUserDoctor.PhoneNumber = "";
            this.addUserDoctor.Size = new System.Drawing.Size(398, 265);
            this.addUserDoctor.TabIndex = 0;
            this.addUserDoctor.Username = "";
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::UI.Properties.Resources.updateadmin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.content);
            this.Name = "AddDoctor";
            this.Size = new System.Drawing.Size(461, 352);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private AddUser addUserDoctor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSpecialisation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hr;
    }
}
