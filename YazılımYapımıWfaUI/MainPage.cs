using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazılımYapımıWfaUI.Concrete;

namespace YazılımYapımıWfaUI
{
    public partial class MainPage : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        //Constructor
        public MainPage()
        {
            InitializeComponent();
            random = new Random();
            btnBackMain.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // This code will help,drag and drop operations in the form application.

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods

        
        private Color SelectThemeColor()
        {
            /*It makes different colors appear when the button is clicked.Colors are in the ThemeColor class in html format.*/
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);

            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    pnlTopTitle.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnBackMain.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMainMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 59,111);
                    previousBtn.ForeColor = Color.Gainsboro;
                
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            /*With this code, we can send different Form Pages to the side panel(pnlMainContent).*/
            
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMainContent.Controls.Add(childForm);
            this.pnlMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void btnBackMain_Click(object sender, EventArgs e)
        {

            if (activateForm != null)
            {
                activateForm.Close();

            }
            Reset();
        }
        private void Reset()
        {
            //Returning to the start page
            DisableButton();
            lblTitle.Text = "WE ARE COMPANION FOR YOUR EXAMS,WHAT ARE WE WAITING FOR LET'S GET STARTED";
            pnlLogo.BackColor = Color.FromArgb(0, 59, 111);
            pnlTopTitle.BackColor = Color.FromArgb(0, 59, 111);
            currentButton = null;
            btnBackMain.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void btnRegister_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.RegisterForm(), sender);
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.AdminForm(), sender);
        }
        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StudentLoginForm(), sender);
        }
        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TeacherLoginForm(), sender);
        }
        private void pnlTopTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
