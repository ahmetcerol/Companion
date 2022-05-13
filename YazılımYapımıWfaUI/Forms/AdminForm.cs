using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YazılımYapımıWfaUI.Concrete;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
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

        SqlConnection ebaglanti = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=CompanionData;integrated security=true");
        private bool ahmet;
        private void btnLogin_Click(object sender, EventArgs e)
        {
    
            try
            {
               
                ebaglanti.Open();
                string sql = "Select * From UserTable where UserType='Admin' AND UserEMail=@adi AND UserPassword=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", tbxAdminEmail.Text);
                SqlParameter prm2 = new SqlParameter("sifresi", tbxAdminPassword.Text);
                SqlCommand komut = new SqlCommand(sql, ebaglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ahmet = true;
                    this.Close();
                    ebaglanti.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect password or email");
                ebaglanti.Close();
            }

            if (ahmet == true)
            {
                AdminPage adminPage = new AdminPage();
                adminPage.ShowDialog();
            }

        }
    }
}
