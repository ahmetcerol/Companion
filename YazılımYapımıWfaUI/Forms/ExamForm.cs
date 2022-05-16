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
            //Sets the standby screen to 3 seconds
            Thread.Sleep(3000);
        }
        private void btnStartExam_Click(object sender, EventArgs e)
        {

            /*It checks how many questions the student wants in an exam. It must be at least 10.*/
            if (tbxNumber.Text==String.Empty)
            {
                tbxNumber.Text = "10";
            }
           else if (Convert.ToInt32(tbxNumber.Text) < 10 )
            {
                MessageBox.Show("The number of questions can be at least 10.");
            }
            else
            {
                Wait_Form wait_Form = new Wait_Form(List);
                wait_Form.ShowDialog();
                OpenChildForm(new Forms.StartExamForm(Convert.ToInt32(tbxNumber.Text)), sender);
            }
           
        }
        
    }
}
