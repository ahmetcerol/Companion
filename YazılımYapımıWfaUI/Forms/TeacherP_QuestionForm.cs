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
using YazılımYapımıProje.DataAccess.Concrete.SqlServer;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class TeacherP_QuestionForm : Form
    {
        public TeacherP_QuestionForm()
        {
            InitializeComponent();
            _topicService = new TopicManager(new TopicsDal());
            _wquestionService = new WQuestionManager(new WQuestionDal());
        }

        private IWQuestionService _wquestionService;
        private ITopicService _topicService;
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "*.png |*.jpg";
            file.CheckFileExists = false;
            file.Title = "Select a picture...";
            /*WE USE THIS CODE FOR FILE FILTER(PNG)*/
            file.ShowDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
            }
            pbxSelectFile.Image = Image.FromFile(file.FileName);
          
        }

        private void TeacherP_QuestionForm_Load(object sender, EventArgs e)
        {
            cbxTopic.DataSource = _topicService.GetAll();
            cbxTopic.DisplayMember = "QuestionTopicName";
            cbxTopic.ValueMember = "QuestionTopicId";
        }
        private string CorrectAnswer;
        private void CheckCorrectAnswer()
        {
            if (rdbA.Checked)
            {
                CorrectAnswer = "A";
            }
            else if (rdbB.Checked)
            {
                CorrectAnswer = "B";
            }
            else if (rdbC.Checked)
            {
                CorrectAnswer = "C";
            }
            else if(rdbD.Checked)
            {
                CorrectAnswer = "D";
            }
            else
            {
                MessageBox.Show("Please mark the correct answer");
            }
        }
        private void ClearForm()
        {
            tbxTeacherA.Text = "";
            tbxTeacherB.Text = "";
            tbxTeacherC .Text= "";
            tbxTeacherD.Text = "";
            rtbxQuestion.Text = "";
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
            pbxSelectFile.Image= null;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            CheckCorrectAnswer();
            _wquestionService.Add(new WQuestions
            {
                WQuestionText = (rtbxQuestion.Text).ToString(),
                WQuestionAnswerA = (tbxTeacherA.Text).ToString(),
                WQuestionAnswerB = (tbxTeacherB.Text).ToString(),
                WQuestionAnswerC = (tbxTeacherC.Text).ToString(),
                WQuestionAnswerD = (tbxTeacherD.Text).ToString(),
                WQuestionTopicId = Convert.ToInt32(cbxTopic.SelectedValue),
                WQuestionCorrectAnswer = CorrectAnswer,

            }) ;
            MessageBox.Show("Thanks. Your question will be added to the question pool after review.");
            ClearForm();

        }
    }
}
