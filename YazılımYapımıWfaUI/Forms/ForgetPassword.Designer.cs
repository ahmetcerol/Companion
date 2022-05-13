
namespace YazılımYapımıWfaUI.Forms
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.gbxForgotPassword = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForgot = new System.Windows.Forms.Button();
            this.tbxYourEmail = new System.Windows.Forms.TextBox();
            this.lblAdminEMail = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.pbxForgot = new System.Windows.Forms.PictureBox();
            this.gbxForgotPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForgot)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxForgotPassword
            // 
            this.gbxForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxForgotPassword.Controls.Add(this.label1);
            this.gbxForgotPassword.Controls.Add(this.btnForgot);
            this.gbxForgotPassword.Controls.Add(this.tbxYourEmail);
            this.gbxForgotPassword.Controls.Add(this.lblAdminEMail);
            this.gbxForgotPassword.Controls.Add(this.lblForgotPassword);
            this.gbxForgotPassword.Controls.Add(this.pbxForgot);
            this.gbxForgotPassword.Location = new System.Drawing.Point(153, 35);
            this.gbxForgotPassword.Name = "gbxForgotPassword";
            this.gbxForgotPassword.Size = new System.Drawing.Size(359, 320);
            this.gbxForgotPassword.TabIndex = 1;
            this.gbxForgotPassword.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(24, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "**Your password will be\r\n sent to your email.**";
            // 
            // btnForgot
            // 
            this.btnForgot.FlatAppearance.BorderSize = 0;
            this.btnForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForgot.Image = ((System.Drawing.Image)(resources.GetObject("btnForgot.Image")));
            this.btnForgot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForgot.Location = new System.Drawing.Point(228, 213);
            this.btnForgot.Name = "btnForgot";
            this.btnForgot.Size = new System.Drawing.Size(131, 34);
            this.btnForgot.TabIndex = 7;
            this.btnForgot.Text = "Send EMail";
            this.btnForgot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForgot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnForgot.UseVisualStyleBackColor = true;
            this.btnForgot.Click += new System.EventHandler(this.btnForgot_Click);
            // 
            // tbxYourEmail
            // 
            this.tbxYourEmail.Location = new System.Drawing.Point(155, 172);
            this.tbxYourEmail.Name = "tbxYourEmail";
            this.tbxYourEmail.Size = new System.Drawing.Size(157, 23);
            this.tbxYourEmail.TabIndex = 4;
            // 
            // lblAdminEMail
            // 
            this.lblAdminEMail.AutoSize = true;
            this.lblAdminEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminEMail.ForeColor = System.Drawing.Color.Black;
            this.lblAdminEMail.Location = new System.Drawing.Point(24, 175);
            this.lblAdminEMail.Name = "lblAdminEMail";
            this.lblAdminEMail.Size = new System.Drawing.Size(95, 20);
            this.lblAdminEMail.TabIndex = 2;
            this.lblAdminEMail.Text = "Your E-Mail:";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Red;
            this.lblForgotPassword.Location = new System.Drawing.Point(105, 134);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(144, 20);
            this.lblForgotPassword.TabIndex = 1;
            this.lblForgotPassword.Text = "Forgot Password";
            // 
            // pbxForgot
            // 
            this.pbxForgot.Image = ((System.Drawing.Image)(resources.GetObject("pbxForgot.Image")));
            this.pbxForgot.Location = new System.Drawing.Point(115, 22);
            this.pbxForgot.Name = "pbxForgot";
            this.pbxForgot.Size = new System.Drawing.Size(101, 99);
            this.pbxForgot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForgot.TabIndex = 0;
            this.pbxForgot.TabStop = false;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 391);
            this.Controls.Add(this.gbxForgotPassword);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.gbxForgotPassword.ResumeLayout(false);
            this.gbxForgotPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForgot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxForgotPassword;
        private System.Windows.Forms.Button btnForgot;
        private System.Windows.Forms.TextBox tbxYourEmail;
        private System.Windows.Forms.Label lblAdminEMail;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.PictureBox pbxForgot;
        private System.Windows.Forms.Label label1;
    }
}