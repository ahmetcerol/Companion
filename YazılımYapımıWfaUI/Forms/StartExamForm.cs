using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using YazılımYapımıProje.Bussiness.Abstract;
using YazılımYapımıProje.Bussiness.Concrete;
using YazılımYapımıProje.DataAccess.Concrete.SqlServer;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class StartExamForm : Form
    {
        private int QuestionNumber;
        public StartExamForm(int NumberOfQuestion)
        {
            InitializeComponent();
            
            _questionService = new QuestionManager(new QuestionDal());
            QuestionNumber = NumberOfQuestion;
            
        }

        private IQuestionService _questionService;
        private int seconds = 60;
        private int minutes = 0;
        private Form activateForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlStartExam.Controls.Add(childForm);
            this.pnlStartExam.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void StartExamForm_Load(object sender, EventArgs e)
        {
            RandomQuestion();
            lblQuestionNumber.Text = "1";
            tmrStartExam.Start();
            minutes = 15;
            

        }
        private void RandomQuestion()
        {
                dgwQuestions.DataSource = _questionService.Exam();
                rtbxQuestion.Text = dgwQuestions.Rows[0].Cells[1].Value.ToString();
                tbxA.Text = dgwQuestions.Rows[0].Cells[2].Value.ToString();
                tbxB.Text = dgwQuestions.Rows[0].Cells[3].Value.ToString();
                tbxC.Text = dgwQuestions.Rows[0].Cells[4].Value.ToString();
                tbxD.Text = dgwQuestions.Rows[0].Cells[5].Value.ToString();
                TrueAnswer = dgwQuestions.Rows[0].Cells[7].Value.ToString();
                pbxQuestionImage.ImageLocation = dgwQuestions.Rows[0].Cells[9].Value.ToString();
            



        }
        private string Answer;
        private string TrueAnswer;
        private void AnswerControl()
        {
            
            if (rdbA.Checked)
            {
                Answer = "A";
            }
            else if (rdbB.Checked)
            {
                Answer = "B";
            }
            else if (rdbC.Checked)
            {
                Answer = "C";
            }
            else if (rdbD.Checked)
            {
                Answer = "D";
            }
            else
            {
                MessageBox.Show("Okey, but don't worry you can be back this question.");
            }
            check();
        }

        private void check()
        {
           
          
            if (TrueAnswer == Answer)
            {
                _TrueCounter++;
            }
            else
            {
                _WrongCounter++;
            }
        }

        private void tmrStartExam_Tick(object sender, EventArgs e)
        {
            ExamTimer();
        }
        void List()
        {
            Thread.Sleep(3000);
        }
        private void ExamTimer()
        {
            tmrStartExam.Interval = 1000;/*1000 = 1 seconds in c#*/
            seconds = seconds - 1;
            lblTimer.Text = minutes.ToString();
            if (seconds == 0)
            {
                minutes = minutes - 1;
                lblTimer.Text = Convert.ToString(minutes);
                seconds = 60;
            }
            if (lblTimer.Text == "-1")
            {
                tmrStartExam.Stop();
                lblTimer.Text = "Time Over";
            }
        }
        private int _counter= 1;
        public int _TrueCounter = 0;
        public int _WrongCounter = 0;
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (_counter == QuestionNumber)
            {
                AnswerControl();
                WaitFormResult wait_Form = new WaitFormResult(List);
                wait_Form.ShowDialog();
                OpenChildForm(new Forms.ExamResult(_TrueCounter, _WrongCounter), sender);
            }

            else
            {
                AnswerControl();
                RdbClear();
                _counter++;
                RandomQuestion();
                lblQuestionNumber.Text = _counter.ToString();
            }
           
            
           
        }

        private void RdbClear()
        {
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
        }
    }
}
