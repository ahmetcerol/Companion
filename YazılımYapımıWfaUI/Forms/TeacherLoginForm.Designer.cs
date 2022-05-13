
namespace YazılımYapımıWfaUI.Forms
{
    partial class TeacherLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherLoginForm));
            this.gbxTeacherLogin = new System.Windows.Forms.GroupBox();
            this.lblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnTeacherLogin = new System.Windows.Forms.Button();
            this.tbxStudentPassword = new System.Windows.Forms.TextBox();
            this.tbxStudentEmail = new System.Windows.Forms.TextBox();
            this.lblTeacherPassword = new System.Windows.Forms.Label();
            this.lblTeacherLoginEmail = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.gbxTeacherLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTeacherLogin
            // 
            this.gbxTeacherLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxTeacherLogin.Controls.Add(this.lblForgotPassword);
            this.gbxTeacherLogin.Controls.Add(this.btnTeacherLogin);
            this.gbxTeacherLogin.Controls.Add(this.tbxStudentPassword);
            this.gbxTeacherLogin.Controls.Add(this.tbxStudentEmail);
            this.gbxTeacherLogin.Controls.Add(this.lblTeacherPassword);
            this.gbxTeacherLogin.Controls.Add(this.lblTeacherLoginEmail);
            this.gbxTeacherLogin.Controls.Add(this.lblTeacher);
            this.gbxTeacherLogin.Controls.Add(this.pbxLogin);
            this.gbxTeacherLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxTeacherLogin.Name = "gbxTeacherLogin";
            this.gbxTeacherLogin.Size = new System.Drawing.Size(640, 367);
            this.gbxTeacherLogin.TabIndex = 1;
            this.gbxTeacherLogin.TabStop = false;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.LinkColor = System.Drawing.Color.Gray;
            this.lblForgotPassword.Location = new System.Drawing.Point(323, 221);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(125, 15);
            this.lblForgotPassword.TabIndex = 10;
            this.lblForgotPassword.TabStop = true;
            this.lblForgotPassword.Text = "I forgot my password..";
            this.lblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPassword_LinkClicked);
            // 
            // btnTeacherLogin
            // 
            this.btnTeacherLogin.FlatAppearance.BorderSize = 0;
            this.btnTeacherLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTeacherLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherLogin.Image")));
            this.btnTeacherLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherLogin.Location = new System.Drawing.Point(377, 239);
            this.btnTeacherLogin.Name = "btnTeacherLogin";
            this.btnTeacherLogin.Size = new System.Drawing.Size(101, 34);
            this.btnTeacherLogin.TabIndex = 8;
            this.btnTeacherLogin.Text = "Log In";
            this.btnTeacherLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacherLogin.UseVisualStyleBackColor = true;
            this.btnTeacherLogin.Click += new System.EventHandler(this.btnTeacherLogin_Click);
            // 
            // tbxStudentPassword
            // 
            this.tbxStudentPassword.Location = new System.Drawing.Point(264, 194);
            this.tbxStudentPassword.Name = "tbxStudentPassword";
            this.tbxStudentPassword.PasswordChar = '*';
            this.tbxStudentPassword.Size = new System.Drawing.Size(141, 23);
            this.tbxStudentPassword.TabIndex = 6;
            this.tbxStudentPassword.UseSystemPasswordChar = true;
            // 
            // tbxStudentEmail
            // 
            this.tbxStudentEmail.Location = new System.Drawing.Point(264, 157);
            this.tbxStudentEmail.Name = "tbxStudentEmail";
            this.tbxStudentEmail.Size = new System.Drawing.Size(141, 23);
            this.tbxStudentEmail.TabIndex = 5;
            // 
            // lblTeacherPassword
            // 
            this.lblTeacherPassword.AutoSize = true;
            this.lblTeacherPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeacherPassword.Location = new System.Drawing.Point(172, 197);
            this.lblTeacherPassword.Name = "lblTeacherPassword";
            this.lblTeacherPassword.Size = new System.Drawing.Size(82, 20);
            this.lblTeacherPassword.TabIndex = 4;
            this.lblTeacherPassword.Text = "Password:";
            // 
            // lblTeacherLoginEmail
            // 
            this.lblTeacherLoginEmail.AutoSize = true;
            this.lblTeacherLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeacherLoginEmail.Location = new System.Drawing.Point(172, 157);
            this.lblTeacherLoginEmail.Name = "lblTeacherLoginEmail";
            this.lblTeacherLoginEmail.Size = new System.Drawing.Size(57, 20);
            this.lblTeacherLoginEmail.TabIndex = 3;
            this.lblTeacherLoginEmail.Text = "E-Mail:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTeacher.ForeColor = System.Drawing.Color.Red;
            this.lblTeacher.Location = new System.Drawing.Point(242, 110);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(153, 20);
            this.lblTeacher.TabIndex = 2;
            this.lblTeacher.Text = "TEACHER LOGIN";
            // 
            // pbxLogin
            // 
            this.pbxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogin.Image")));
            this.pbxLogin.Location = new System.Drawing.Point(264, 22);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(100, 75);
            this.pbxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogin.TabIndex = 0;
            this.pbxLogin.TabStop = false;
            // 
            // TeacherLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 391);
            this.Controls.Add(this.gbxTeacherLogin);
            this.Name = "TeacherLoginForm";
            this.Text = "TEACHER PAGE";
            this.gbxTeacherLogin.ResumeLayout(false);
            this.gbxTeacherLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTeacherLogin;
        private System.Windows.Forms.Button btnTeacherLogin;
        private System.Windows.Forms.TextBox tbxStudentPassword;
        private System.Windows.Forms.TextBox tbxStudentEmail;
        private System.Windows.Forms.Label lblTeacherPassword;
        private System.Windows.Forms.Label lblTeacherLoginEmail;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.PictureBox pbxLogin;
        private System.Windows.Forms.LinkLabel lblForgotPassword;
    }
}