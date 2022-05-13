
namespace YazılımYapımıWfaUI.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.gbxAdmin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxAdminPassword = new System.Windows.Forms.TextBox();
            this.tbxAdminEmail = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.lblAdminEMail = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pbxAdmin = new System.Windows.Forms.PictureBox();
            this.gbxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAdmin
            // 
            this.gbxAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxAdmin.Controls.Add(this.btnLogin);
            this.gbxAdmin.Controls.Add(this.tbxAdminPassword);
            this.gbxAdmin.Controls.Add(this.tbxAdminEmail);
            this.gbxAdmin.Controls.Add(this.lblAdminPassword);
            this.gbxAdmin.Controls.Add(this.lblAdminEMail);
            this.gbxAdmin.Controls.Add(this.lblAdmin);
            this.gbxAdmin.Controls.Add(this.pbxAdmin);
            this.gbxAdmin.Location = new System.Drawing.Point(150, 27);
            this.gbxAdmin.Name = "gbxAdmin";
            this.gbxAdmin.Size = new System.Drawing.Size(359, 320);
            this.gbxAdmin.TabIndex = 0;
            this.gbxAdmin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(228, 245);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 34);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Admin Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxAdminPassword
            // 
            this.tbxAdminPassword.Location = new System.Drawing.Point(155, 205);
            this.tbxAdminPassword.Name = "tbxAdminPassword";
            this.tbxAdminPassword.PasswordChar = '*';
            this.tbxAdminPassword.Size = new System.Drawing.Size(157, 23);
            this.tbxAdminPassword.TabIndex = 5;
            this.tbxAdminPassword.UseSystemPasswordChar = true;
            // 
            // tbxAdminEmail
            // 
            this.tbxAdminEmail.Location = new System.Drawing.Point(155, 172);
            this.tbxAdminEmail.Name = "tbxAdminEmail";
            this.tbxAdminEmail.Size = new System.Drawing.Size(157, 23);
            this.tbxAdminEmail.TabIndex = 4;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminPassword.ForeColor = System.Drawing.Color.Black;
            this.lblAdminPassword.Location = new System.Drawing.Point(24, 208);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(131, 20);
            this.lblAdminPassword.TabIndex = 3;
            this.lblAdminPassword.Text = "Admin Password:";
            // 
            // lblAdminEMail
            // 
            this.lblAdminEMail.AutoSize = true;
            this.lblAdminEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminEMail.ForeColor = System.Drawing.Color.Black;
            this.lblAdminEMail.Location = new System.Drawing.Point(24, 175);
            this.lblAdminEMail.Name = "lblAdminEMail";
            this.lblAdminEMail.Size = new System.Drawing.Size(106, 20);
            this.lblAdminEMail.TabIndex = 2;
            this.lblAdminEMail.Text = "Admin E-Mail:";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblAdmin.Location = new System.Drawing.Point(105, 134);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(126, 20);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "ADMIN LOGIN";
            // 
            // pbxAdmin
            // 
            this.pbxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdmin.Image")));
            this.pbxAdmin.Location = new System.Drawing.Point(115, 22);
            this.pbxAdmin.Name = "pbxAdmin";
            this.pbxAdmin.Size = new System.Drawing.Size(101, 99);
            this.pbxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdmin.TabIndex = 0;
            this.pbxAdmin.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 391);
            this.Controls.Add(this.gbxAdmin);
            this.Name = "AdminForm";
            this.Text = "ADMIN  PAGE";
            this.gbxAdmin.ResumeLayout(false);
            this.gbxAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pbxAdmin;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblAdminEMail;
        private System.Windows.Forms.TextBox tbxAdminPassword;
        private System.Windows.Forms.TextBox tbxAdminEmail;
        private System.Windows.Forms.Button btnLogin;
    }
}