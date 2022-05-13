
namespace YazılımYapımıWfaUI.Forms
{
    partial class StudentLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLoginForm));
            this.gbxStudentLogin = new System.Windows.Forms.GroupBox();
            this.lblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.tbxStudentPassword = new System.Windows.Forms.TextBox();
            this.tbxStudentEmail = new System.Windows.Forms.TextBox();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.lblStudentLoginEmail = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.pnlStudentLogın = new System.Windows.Forms.Panel();
            this.gbxStudentLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStudentLogin
            // 
            this.gbxStudentLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxStudentLogin.Controls.Add(this.lblForgotPassword);
            this.gbxStudentLogin.Controls.Add(this.btnStudentLogin);
            this.gbxStudentLogin.Controls.Add(this.tbxStudentPassword);
            this.gbxStudentLogin.Controls.Add(this.tbxStudentEmail);
            this.gbxStudentLogin.Controls.Add(this.lblStudentPassword);
            this.gbxStudentLogin.Controls.Add(this.lblStudentLoginEmail);
            this.gbxStudentLogin.Controls.Add(this.lblStudent);
            this.gbxStudentLogin.Controls.Add(this.pbxLogin);
            this.gbxStudentLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxStudentLogin.Name = "gbxStudentLogin";
            this.gbxStudentLogin.Size = new System.Drawing.Size(640, 367);
            this.gbxStudentLogin.TabIndex = 0;
            this.gbxStudentLogin.TabStop = false;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.LinkColor = System.Drawing.Color.Gray;
            this.lblForgotPassword.Location = new System.Drawing.Point(343, 221);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(125, 15);
            this.lblForgotPassword.TabIndex = 9;
            this.lblForgotPassword.TabStop = true;
            this.lblForgotPassword.Text = "I forgot my password..";
            this.lblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPassword_LinkClicked);
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.FlatAppearance.BorderSize = 0;
            this.btnStudentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudentLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentLogin.Image")));
            this.btnStudentLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentLogin.Location = new System.Drawing.Point(377, 239);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(101, 34);
            this.btnStudentLogin.TabIndex = 8;
            this.btnStudentLogin.Text = "Log In";
            this.btnStudentLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentLogin.UseVisualStyleBackColor = true;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
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
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentPassword.Location = new System.Drawing.Point(172, 197);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(82, 20);
            this.lblStudentPassword.TabIndex = 4;
            this.lblStudentPassword.Text = "Password:";
            // 
            // lblStudentLoginEmail
            // 
            this.lblStudentLoginEmail.AutoSize = true;
            this.lblStudentLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentLoginEmail.Location = new System.Drawing.Point(172, 157);
            this.lblStudentLoginEmail.Name = "lblStudentLoginEmail";
            this.lblStudentLoginEmail.Size = new System.Drawing.Size(57, 20);
            this.lblStudentLoginEmail.TabIndex = 3;
            this.lblStudentLoginEmail.Text = "E-Mail:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudent.ForeColor = System.Drawing.Color.Red;
            this.lblStudent.Location = new System.Drawing.Point(242, 110);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(151, 20);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "STUDENT LOGIN";
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
            // pnlStudentLogın
            // 
            this.pnlStudentLogın.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudentLogın.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentLogın.Name = "pnlStudentLogın";
            this.pnlStudentLogın.Size = new System.Drawing.Size(664, 391);
            this.pnlStudentLogın.TabIndex = 1;
            // 
            // StudentLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 391);
            this.Controls.Add(this.gbxStudentLogin);
            this.Controls.Add(this.pnlStudentLogın);
            this.Name = "StudentLoginForm";
            this.Text = "STUDENT PAGE";
            this.gbxStudentLogin.ResumeLayout(false);
            this.gbxStudentLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStudentLogin;
        private System.Windows.Forms.PictureBox pbxLogin;
        private System.Windows.Forms.TextBox tbxStudentPassword;
        private System.Windows.Forms.TextBox tbxStudentEmail;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.Label lblStudentLoginEmail;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnStudentLogin;
        private System.Windows.Forms.LinkLabel lblForgotPassword;
        private System.Windows.Forms.Panel pnlStudentLogın;
    }
}