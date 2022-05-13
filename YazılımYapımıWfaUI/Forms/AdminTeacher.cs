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
    public partial class AdminTeacher : Form
    {
        public AdminTeacher()
        {
            InitializeComponent();
            _userService = new UserManager(new UserDal());
        }

        private IUserService _userService;
        private void AdminTeacher_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgwTeachers.DataSource = _userService.TeacherGetAll();
            dgwTeachers.ColumnHeadersVisible = false;
            dgwTeachers.Columns[4].Visible = false;
            dgwTeachers.Columns[5].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _userService.Delete(Convert.ToInt32(dgwTeachers.CurrentRow.Cells[0].Value));
            LoadData();
           
        }
    }
}
