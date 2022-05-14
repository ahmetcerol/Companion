using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YazılımYapımıWfaUI.Concrete;

namespace YazılımYapımıWfaUI
{
    public partial class StudentPage : Form
    {
        
        private Form activateForm;
        private int UserInformationId;

        public StudentPage(int UserId)
        {
            UserInformationId = UserId;
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
            this.pnlStudentContent.Controls.Add(childForm);
            this.pnlStudentContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ExamForm(), sender);
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StudentProgress(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserSettings(UserInformationId), sender);
        }
    }
}
