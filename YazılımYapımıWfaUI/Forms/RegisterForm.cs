using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YazılımYapımıProje.Bussiness.Abstract;
using YazılımYapımıProje.Bussiness.Concrete;
using YazılımYapımıProje.DataAccess.Concrete;
using YazılımYapımıProje.Entities.Concrete;
using YazılımYapımıWfaUI.Concrete;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoadTheme();
            _userService = new UserManager(new UserDal());
        }
        private IUserService _userService;
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }         
        }

        private string UserTypeControl;
        private void btnRegister_Click(object sender, EventArgs e)
        {

            UserControl();
            Registeration();
         
        }

        private void UserControl()
        {
            if (rdbRegisterStudent.Checked)
            {
                UserTypeControl = rdbRegisterStudent.Text;
            }
            else if (rdbRegisterTeacher.Checked)
            {
                UserTypeControl = rdbRegisterTeacher.Text;
            }
        }
        private void Registeration()
        {
            if (tbxRegisterPassword.Text == "" || tbxRegisterEmail.Text=="" || tbxRegisterName.Text=="" || tbxRegisterSurname.Text=="")
            {
                MessageBox.Show("Please fill everything");
            }

           else if( tbxRegisterPassword.Text != tbxRegisterAuthorized.Text)
            {
                MessageBox.Show("PASSWORDS DO NOT MATCH");
            }
            else
            {
                _userService.Add(new Users
                {
                    UserName = tbxRegisterName.Text,
                    UserSurname = tbxRegisterSurname.Text,
                    UserEMail = tbxRegisterEmail.Text,
                    UserPassword = Convert.ToInt32(tbxRegisterPassword.Text),
                    UserType = UserTypeControl,
                });
                MessageBox.Show("Registration successful. Please login.");
            }

        }
    }
}
