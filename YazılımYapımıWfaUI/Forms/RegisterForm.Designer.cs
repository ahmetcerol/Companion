
namespace YazılımYapımıWfaUI.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.gbxRegister = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegisterType = new System.Windows.Forms.Label();
            this.rdbRegisterTeacher = new System.Windows.Forms.RadioButton();
            this.rdbRegisterStudent = new System.Windows.Forms.RadioButton();
            this.tbxRegisterAuthorized = new System.Windows.Forms.TextBox();
            this.tbxRegisterPassword = new System.Windows.Forms.TextBox();
            this.tbxRegisterEmail = new System.Windows.Forms.TextBox();
            this.tbxRegisterSurname = new System.Windows.Forms.TextBox();
            this.tbxRegisterName = new System.Windows.Forms.TextBox();
            this.lblRegisterAuthorized = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.lblRegisterSurname = new System.Windows.Forms.Label();
            this.lblRegisterName = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.pbxRegister = new System.Windows.Forms.PictureBox();
            this.gbxRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxRegister
            // 
            this.gbxRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxRegister.Controls.Add(this.btnRegister);
            this.gbxRegister.Controls.Add(this.lblRegisterType);
            this.gbxRegister.Controls.Add(this.rdbRegisterTeacher);
            this.gbxRegister.Controls.Add(this.rdbRegisterStudent);
            this.gbxRegister.Controls.Add(this.tbxRegisterAuthorized);
            this.gbxRegister.Controls.Add(this.tbxRegisterPassword);
            this.gbxRegister.Controls.Add(this.tbxRegisterEmail);
            this.gbxRegister.Controls.Add(this.tbxRegisterSurname);
            this.gbxRegister.Controls.Add(this.tbxRegisterName);
            this.gbxRegister.Controls.Add(this.lblRegisterAuthorized);
            this.gbxRegister.Controls.Add(this.lblRegisterPassword);
            this.gbxRegister.Controls.Add(this.lblRegisterEmail);
            this.gbxRegister.Controls.Add(this.lblRegisterSurname);
            this.gbxRegister.Controls.Add(this.lblRegisterName);
            this.gbxRegister.Controls.Add(this.lblRegister);
            this.gbxRegister.Controls.Add(this.pbxRegister);
            this.gbxRegister.Location = new System.Drawing.Point(12, 2);
            this.gbxRegister.Name = "gbxRegister";
            this.gbxRegister.Size = new System.Drawing.Size(639, 366);
            this.gbxRegister.TabIndex = 0;
            this.gbxRegister.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(426, 326);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(98, 34);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Sign In";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegisterType
            // 
            this.lblRegisterType.AutoSize = true;
            this.lblRegisterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterType.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterType.Location = new System.Drawing.Point(150, 303);
            this.lblRegisterType.Name = "lblRegisterType";
            this.lblRegisterType.Size = new System.Drawing.Size(137, 20);
            this.lblRegisterType.TabIndex = 14;
            this.lblRegisterType.Text = "Registration Type:";
            // 
            // rdbRegisterTeacher
            // 
            this.rdbRegisterTeacher.AutoSize = true;
            this.rdbRegisterTeacher.Location = new System.Drawing.Point(375, 307);
            this.rdbRegisterTeacher.Name = "rdbRegisterTeacher";
            this.rdbRegisterTeacher.Size = new System.Drawing.Size(65, 19);
            this.rdbRegisterTeacher.TabIndex = 13;
            this.rdbRegisterTeacher.TabStop = true;
            this.rdbRegisterTeacher.Text = "Teacher";
            this.rdbRegisterTeacher.UseVisualStyleBackColor = true;
            // 
            // rdbRegisterStudent
            // 
            this.rdbRegisterStudent.AutoSize = true;
            this.rdbRegisterStudent.Location = new System.Drawing.Point(303, 305);
            this.rdbRegisterStudent.Name = "rdbRegisterStudent";
            this.rdbRegisterStudent.Size = new System.Drawing.Size(66, 19);
            this.rdbRegisterStudent.TabIndex = 12;
            this.rdbRegisterStudent.TabStop = true;
            this.rdbRegisterStudent.Text = "Student";
            this.rdbRegisterStudent.UseVisualStyleBackColor = true;
            // 
            // tbxRegisterAuthorized
            // 
            this.tbxRegisterAuthorized.Location = new System.Drawing.Point(303, 271);
            this.tbxRegisterAuthorized.Name = "tbxRegisterAuthorized";
            this.tbxRegisterAuthorized.PasswordChar = '*';
            this.tbxRegisterAuthorized.Size = new System.Drawing.Size(136, 23);
            this.tbxRegisterAuthorized.TabIndex = 11;
            // 
            // tbxRegisterPassword
            // 
            this.tbxRegisterPassword.Location = new System.Drawing.Point(303, 237);
            this.tbxRegisterPassword.Name = "tbxRegisterPassword";
            this.tbxRegisterPassword.PasswordChar = '*';
            this.tbxRegisterPassword.Size = new System.Drawing.Size(136, 23);
            this.tbxRegisterPassword.TabIndex = 10;
            // 
            // tbxRegisterEmail
            // 
            this.tbxRegisterEmail.Location = new System.Drawing.Point(303, 205);
            this.tbxRegisterEmail.Name = "tbxRegisterEmail";
            this.tbxRegisterEmail.Size = new System.Drawing.Size(136, 23);
            this.tbxRegisterEmail.TabIndex = 9;
            // 
            // tbxRegisterSurname
            // 
            this.tbxRegisterSurname.Location = new System.Drawing.Point(303, 174);
            this.tbxRegisterSurname.Name = "tbxRegisterSurname";
            this.tbxRegisterSurname.Size = new System.Drawing.Size(136, 23);
            this.tbxRegisterSurname.TabIndex = 8;
            // 
            // tbxRegisterName
            // 
            this.tbxRegisterName.Location = new System.Drawing.Point(303, 144);
            this.tbxRegisterName.Name = "tbxRegisterName";
            this.tbxRegisterName.Size = new System.Drawing.Size(136, 23);
            this.tbxRegisterName.TabIndex = 7;
            // 
            // lblRegisterAuthorized
            // 
            this.lblRegisterAuthorized.AutoSize = true;
            this.lblRegisterAuthorized.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterAuthorized.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterAuthorized.Location = new System.Drawing.Point(150, 274);
            this.lblRegisterAuthorized.Name = "lblRegisterAuthorized";
            this.lblRegisterAuthorized.Size = new System.Drawing.Size(127, 20);
            this.lblRegisterAuthorized.TabIndex = 6;
            this.lblRegisterAuthorized.Text = "Password Again:";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterPassword.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterPassword.Location = new System.Drawing.Point(150, 240);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(82, 20);
            this.lblRegisterPassword.TabIndex = 5;
            this.lblRegisterPassword.Text = "Password:";
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterEmail.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterEmail.Location = new System.Drawing.Point(150, 208);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(57, 20);
            this.lblRegisterEmail.TabIndex = 4;
            this.lblRegisterEmail.Text = "E-Mail:";
            // 
            // lblRegisterSurname
            // 
            this.lblRegisterSurname.AutoSize = true;
            this.lblRegisterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterSurname.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterSurname.Location = new System.Drawing.Point(150, 173);
            this.lblRegisterSurname.Name = "lblRegisterSurname";
            this.lblRegisterSurname.Size = new System.Drawing.Size(78, 20);
            this.lblRegisterSurname.TabIndex = 3;
            this.lblRegisterSurname.Text = "Surname:";
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.AutoSize = true;
            this.lblRegisterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterName.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterName.Location = new System.Drawing.Point(150, 143);
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(55, 20);
            this.lblRegisterName.TabIndex = 2;
            this.lblRegisterName.Text = "Name:";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.ForeColor = System.Drawing.Color.Red;
            this.lblRegister.Location = new System.Drawing.Point(279, 102);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(76, 20);
            this.lblRegister.TabIndex = 1;
            this.lblRegister.Text = "SIGN IN";
            // 
            // pbxRegister
            // 
            this.pbxRegister.Image = ((System.Drawing.Image)(resources.GetObject("pbxRegister.Image")));
            this.pbxRegister.Location = new System.Drawing.Point(277, 22);
            this.pbxRegister.Name = "pbxRegister";
            this.pbxRegister.Size = new System.Drawing.Size(78, 77);
            this.pbxRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegister.TabIndex = 0;
            this.pbxRegister.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 391);
            this.Controls.Add(this.gbxRegister);
            this.Name = "RegisterForm";
            this.Text = "REGISTER PAGE";
            this.gbxRegister.ResumeLayout(false);
            this.gbxRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRegister;
        private System.Windows.Forms.Label lblRegisterType;
        private System.Windows.Forms.RadioButton rdbRegisterTeacher;
        private System.Windows.Forms.RadioButton rdbRegisterStudent;
        private System.Windows.Forms.TextBox tbxRegisterAuthorized;
        private System.Windows.Forms.TextBox tbxRegisterPassword;
        private System.Windows.Forms.TextBox tbxRegisterEmail;
        private System.Windows.Forms.TextBox tbxRegisterSurname;
        private System.Windows.Forms.TextBox tbxRegisterName;
        private System.Windows.Forms.Label lblRegisterAuthorized;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterEmail;
        private System.Windows.Forms.Label lblRegisterSurname;
        private System.Windows.Forms.Label lblRegisterName;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.PictureBox pbxRegister;
        private System.Windows.Forms.Button btnRegister;
    }
}