using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YazılımYapımıProje.Bussiness.Abstract;
using YazılımYapımıProje.Bussiness.Concrete;
using YazılımYapımıProje.DataAccess.Concrete.SqlServer;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class AdminLibrary : Form
    {
        public AdminLibrary()
        {
            InitializeComponent();
            _questionService = new QuestionManager(new QuestionDal());
        }
        private IQuestionService _questionService;

        private void AdminLibrary_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgwLibrary.DataSource = _questionService.GetAll();
            dgwLibrary.Columns[0].Visible = false;
            dgwLibrary.Columns[7].Visible = false;
        }

        private void DeleteSelectedItem()
        {
            _questionService.Delete(Convert.ToInt32(dgwLibrary.CurrentRow.Cells[0].Value));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
            LoadData();
        }
    }
}
