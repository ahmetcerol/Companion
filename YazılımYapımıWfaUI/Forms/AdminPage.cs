using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YazılımYapımıWfaUI
{
    public partial class AdminPage : Form
    {
        private Form activateForm;
        public AdminPage()
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
            this.pnlAdminContent.Controls.Add(childForm);
            this.pnlAdminContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminStudents(), sender);
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminTeacher(), sender);
        }

        private void btnAdminConfirm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminConfirmation(), sender);
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminLibrary(), sender);
        }
    }
}
