using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YazılımYapımıWfaUI
{
    public partial class TeacherPage : Form
    {

        private Form activateForm;
        public TeacherPage()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
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
            this.pnlTeacherContent.Controls.Add(childForm);
            this.pnlTeacherContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrepareQuestion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TeacherP_QuestionForm(), sender);
        }

        private void btnMyQuestions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TeacherMyQuestionForm(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserSettings(), sender);
        }
    }
}
