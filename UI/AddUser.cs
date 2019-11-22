using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class AddUser : UserControl
    {
        

        public AddUser()
        {
            InitializeComponent();
        }

        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text;}
        public string Firstname { get => txtFirstName.Text; set => txtFirstName.Text = value; }
        public string Middlename { get => txtMiddleName.Text; set => txtMiddleName.Text = value; }
        public string Lastname { get => txtLastName.Text; set => txtLastName.Text = value; }
        public string Gender { get => txtGender.Text; set => txtGender.Text = value; }
        public string PhoneNumber { get => txtPhoneNumber.Text; set => txtPhoneNumber.Text = value; }
        //permission and type needs no set property 
        public Permission.perm Permission { get => (Permission.perm) cbPermission.SelectedIndex;}
        public uType.userTypes UType { get => (uType.userTypes) cbType.SelectedIndex;}

        public bool ComboxBoxUserTypeEnable { set => cbType.Enabled = value; }
        public int ComboxBoxUserTypeSelectedIndex { get => cbType.SelectedIndex;  set => cbType.SelectedIndex = value; }
        public int ComboxBoxUserPermSelectedIndex { get => cbPermission.SelectedIndex; set => cbPermission.SelectedIndex = value; }

        public bool TextBoxGenderEnable { set => txtGender.Enabled = value; }
        public bool TextBoxPasswordVisibility { set => txtPassword.Visible = value; }
        public bool LabelPasswordVisibility { set => lblPassword.Visible = value; }
        public bool TextBoxUsernameVisibility { set => txtUsername.Visible = value; }
        public bool LabelUsernameVisibility { set => lblUsername.Visible = value; }
    }
}
