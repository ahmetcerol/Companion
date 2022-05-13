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
    public partial class TeacherMyQuestionForm : Form
    {
        public TeacherMyQuestionForm()
        {
            InitializeComponent();
            _questionService = new QuestionManager(new QuestionDal());
        }
        private IQuestionService _questionService;

        private void TeacherMyQuestionForm_Load(object sender, EventArgs e)
        {
            dgwMyQuestions.DataSource = _questionService.GetAll();
            dgwMyQuestions.Columns[0].Visible = false;
            dgwMyQuestions.Columns[7].Visible = false;
        }
    }
}
