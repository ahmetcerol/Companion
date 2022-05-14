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

namespace YazılımYapımıWfaUI.Forms
{
    public partial class UserSettings : Form
    {
        private int UserInformationId;

        public UserSettings(int UserId)
        {
            UserInformationId =UserId;
            InitializeComponent();
            _userService = new UserManager(new UserDal());
        }
        private IUserService _userService;
      

        private void UserSettings_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            dgwUserInformation.DataSource = _userService.GetUserInformation(UserInformationId);
            tbxUserName.Text = dgwUserInformation.Rows[0].Cells[1].Value.ToString();
            tbxUserSurname.Text = dgwUserInformation.Rows[0].Cells[2].Value.ToString();
            tbxUserEmail.Text = dgwUserInformation.Rows[0].Cells[3].Value.ToString();
            tbxUserPassword.Text = dgwUserInformation.Rows[0].Cells[4].Value.ToString();
        }

      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbxUserEmail.Text == "" || tbxUserName.Text == "" || tbxUserPassword.Text == "" || tbxUserSurname.Text == "")
            {
                MessageBox.Show("You can't leave fields blank");
                LoadData();
            }
            else
            {
                _userService.Update(new Users
                {
                    UserId = UserInformationId,
                    UserName = tbxUserName.Text.ToString(),
                    UserSurname = tbxUserSurname.Text.ToString(),
                    UserEMail = tbxUserEmail.Text.ToString(),
                    UserPassword = Convert.ToInt32(tbxUserPassword.Text),
                });
                MessageBox.Show("Your Information Has Been Updated Successfully");
            }
        }
    }
}
