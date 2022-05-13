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
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class AdminConfirmation : Form
    {
        public AdminConfirmation()
        {
            InitializeComponent();
            _wquestionService = new WQuestionManager(new WQuestionDal());
            _questionService = new QuestionManager(new QuestionDal());
        }
        private IWQuestionService _wquestionService;
        private IQuestionService  _questionService;
        private void AdminConfirmation_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgwConfirmation.ColumnHeadersVisible = false;
            dgwConfirmation.DataSource = _wquestionService.GetAll();
            dgwConfirmation.Columns[0].Visible = false;
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            ConfirmQuestion();
           
        }

        private void ConfirmQuestion()
        {
            _questionService.Add(new Questions
            {
                QuestionText =    (dgwConfirmation.CurrentRow.Cells[1].Value).ToString(),
                QuestionAnswerA = (dgwConfirmation.CurrentRow.Cells[2].Value).ToString(),
                QuestionAnswerB = (dgwConfirmation.CurrentRow.Cells[3].Value).ToString(),
                QuestionAnswerC = (dgwConfirmation.CurrentRow.Cells[4].Value).ToString(),
                QuestionAnswerD = (dgwConfirmation.CurrentRow.Cells[5].Value).ToString(),
                QuestionTopicId = Convert.ToInt32(dgwConfirmation.CurrentRow.Cells[7].Value),
                QuestionCorrectAnswer=(dgwConfirmation.CurrentRow.Cells[8].Value).ToString(),

            });
            MessageBox.Show("Question Approved");
            DeleteSelectedItem();
            LoadData();

        }

        private void btnDisapproval_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
            LoadData();

        }

        private void DeleteSelectedItem()
        {
            _wquestionService.Delete(Convert.ToInt32(dgwConfirmation.CurrentRow.Cells[0].Value));
        }
    }
}
