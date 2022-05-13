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
    public partial class AdminStudents : Form
    {
        public AdminStudents()
        {
            InitializeComponent();
            _userService = new UserManager(new UserDal());
        }
        private IUserService _userService;
        private void AdminStudents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgwStudents.DataSource = _userService.StudentGetAll();
            dgwStudents.ColumnHeadersVisible = false;
            dgwStudents.Columns[0].Visible = false;
            dgwStudents.Columns[4].Visible = false;
            dgwStudents.Columns[5].Visible = false;
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {  
            _userService.Delete(Convert.ToInt32(dgwStudents.CurrentRow.Cells[0].Value));
            LoadData();
        }
    }
}
