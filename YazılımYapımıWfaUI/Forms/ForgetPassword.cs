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

namespace YazılımYapımıWfaUI.Forms
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
            _userService = new UserManager(new UserDal());
        }
        private IUserService _userService;
        private void btnForgot_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.SendEmail((tbxYourEmail.Text).ToString());
                MessageBox.Show("Your password has been sent to your email");

            }
            catch (Exception)
            {
                MessageBox.Show("Your email address was not found");
                
            }
          
        }
    }
}
