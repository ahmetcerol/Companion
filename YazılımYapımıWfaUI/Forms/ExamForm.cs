using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
        }
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
            this.pnlExam.Controls.Add(childForm);
            this.pnlExam.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        void List()
        {
            Thread.Sleep(3000);
        }
        private void btnStartExam_Click(object sender, EventArgs e)
        {
            Wait_Form wait_Form = new Wait_Form(List);
            wait_Form.ShowDialog();
            OpenChildForm(new Forms.StartExamForm(), sender);
        }
    }
}
