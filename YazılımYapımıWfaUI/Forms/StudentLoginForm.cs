using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YazılımYapımıProje.Bussiness.Abstract;
using YazılımYapımıProje.Bussiness.Concrete;
using YazılımYapımıProje.DataAccess.Concrete;
using YazılımYapımıWfaUI.Concrete;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class StudentLoginForm : Form
    {
        public StudentLoginForm()
        {
            InitializeComponent();
            LoadTheme();
            
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }
           
        }
        
        SqlConnection baglanti = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=CompanionData;integrated security=true");
        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            Logging();
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
            this.gbxStudentLogin.Controls.Add(childForm);
            this.gbxStudentLogin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private int UserId;
        private void Logging()
        {
            try
            {

                baglanti.Open();
                string sql = "Select * From UserTable where UserType='Student'AND UserEMail=@adi AND UserPassword=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", tbxStudentEmail.Text);
                SqlParameter prm2 = new SqlParameter("sifresi", tbxStudentPassword.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    UserId = Convert.ToInt32(reader["UserId"]);
                }

                if (dt.Rows.Count > 0)
                {
                    StudentPage studentPage = new StudentPage(UserId);
                    studentPage.ShowDialog();
                    this.Hide();
                    baglanti.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Incorrect password or email");
                baglanti.Close();
            }
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new Forms.ForgetPassword(), sender);   
   
        }
    }
}
