
using System;

namespace YazılımYapımıWfaUI.Forms
{
    partial class StudentProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProgress));
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblMotivation = new System.Windows.Forms.Label();
            this.lblYourProgress = new System.Windows.Forms.Label();
            this.pgbStudent = new System.Windows.Forms.ProgressBar();
            this.lblTopics = new System.Windows.Forms.Label();
            this.cbxTopic = new System.Windows.Forms.ComboBox();
            this.lblAboutProgresses = new System.Windows.Forms.Label();
            this.lblAboutProgress = new System.Windows.Forms.Label();
            this.pbxStudentProgress = new System.Windows.Forms.PictureBox();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProgress
            // 
            this.pnlProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlProgress.Controls.Add(this.lblMotivation);
            this.pnlProgress.Controls.Add(this.lblYourProgress);
            this.pnlProgress.Controls.Add(this.pgbStudent);
            this.pnlProgress.Controls.Add(this.lblTopics);
            this.pnlProgress.Controls.Add(this.cbxTopic);
            this.pnlProgress.Controls.Add(this.lblAboutProgresses);
            this.pnlProgress.Controls.Add(this.lblAboutProgress);
            this.pnlProgress.Location = new System.Drawing.Point(0, 0);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(724, 471);
            this.pnlProgress.TabIndex = 0;
            // 
            // lblMotivation
            // 
            this.lblMotivation.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMotivation.AutoSize = true;
            this.lblMotivation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMotivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotivation.ForeColor = System.Drawing.Color.DimGray;
            this.lblMotivation.Location = new System.Drawing.Point(80, 375);
            this.lblMotivation.Name = "lblMotivation";
            this.lblMotivation.Size = new System.Drawing.Size(539, 40);
            this.lblMotivation.TabIndex = 11;
            this.lblMotivation.Text = "**Not everyone can truly succeed in everything.But success only comes with\r\n self" +
    "-management and determination.**";
            this.lblMotivation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMotivation.UseMnemonic = false;
            // 
            // lblYourProgress
            // 
            this.lblYourProgress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblYourProgress.AutoSize = true;
            this.lblYourProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblYourProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYourProgress.ForeColor = System.Drawing.Color.Black;
            this.lblYourProgress.Location = new System.Drawing.Point(80, 236);
            this.lblYourProgress.Name = "lblYourProgress";
            this.lblYourProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYourProgress.Size = new System.Drawing.Size(122, 18);
            this.lblYourProgress.TabIndex = 10;
            this.lblYourProgress.Text = "Your Progress:";
            this.lblYourProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYourProgress.UseMnemonic = false;
            // 
            // pgbStudent
            // 
            this.pgbStudent.BackColor = System.Drawing.Color.White;
            this.pgbStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.pgbStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(195)))), ((int)(((byte)(15)))));
            this.pgbStudent.Location = new System.Drawing.Point(208, 231);
            this.pgbStudent.Name = "pgbStudent";
            this.pgbStudent.Size = new System.Drawing.Size(182, 23);
            this.pgbStudent.TabIndex = 9;
            // 
            // lblTopics
            // 
            this.lblTopics.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTopics.AutoSize = true;
            this.lblTopics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopics.ForeColor = System.Drawing.Color.Black;
            this.lblTopics.Location = new System.Drawing.Point(80, 175);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(64, 18);
            this.lblTopics.TabIndex = 8;
            this.lblTopics.Text = "Topics:";
            this.lblTopics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTopics.UseMnemonic = false;
            // 
            // cbxTopic
            // 
            this.cbxTopic.FormattingEnabled = true;
            this.cbxTopic.Location = new System.Drawing.Point(205, 175);
            this.cbxTopic.Name = "cbxTopic";
            this.cbxTopic.Size = new System.Drawing.Size(185, 23);
            this.cbxTopic.TabIndex = 7;
            // 
            // lblAboutProgresses
            // 
            this.lblAboutProgresses.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblAboutProgresses.AutoSize = true;
            this.lblAboutProgresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAboutProgresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAboutProgresses.ForeColor = System.Drawing.Color.DimGray;
            this.lblAboutProgresses.Location = new System.Drawing.Point(366, 31);
            this.lblAboutProgresses.Name = "lblAboutProgresses";
            this.lblAboutProgresses.Size = new System.Drawing.Size(300, 20);
            this.lblAboutProgresses.TabIndex = 6;
            this.lblAboutProgresses.Text = "This will asisst you in your work for exams.";
            this.lblAboutProgresses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAboutProgresses.UseMnemonic = false;
            // 
            // lblAboutProgress
            // 
            this.lblAboutProgress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblAboutProgress.AutoSize = true;
            this.lblAboutProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAboutProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAboutProgress.ForeColor = System.Drawing.Color.Black;
            this.lblAboutProgress.Location = new System.Drawing.Point(160, 31);
            this.lblAboutProgress.Name = "lblAboutProgress";
            this.lblAboutProgress.Size = new System.Drawing.Size(200, 18);
            this.lblAboutProgress.TabIndex = 2;
            this.lblAboutProgress.Text = "Check out your progress:";
            this.lblAboutProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAboutProgress.UseMnemonic = false;
            // 
            // pbxStudentProgress
            // 
            this.pbxStudentProgress.Image = ((System.Drawing.Image)(resources.GetObject("pbxStudentProgress.Image")));
            this.pbxStudentProgress.Location = new System.Drawing.Point(37, 43);
            this.pbxStudentProgress.Name = "pbxStudentProgress";
            this.pbxStudentProgress.Size = new System.Drawing.Size(107, 86);
            this.pbxStudentProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStudentProgress.TabIndex = 0;
            this.pbxStudentProgress.TabStop = false;
            // 
            // StudentProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 471);
            this.Controls.Add(this.pbxStudentProgress);
            this.Controls.Add(this.pnlProgress);
            this.Name = "StudentProgress";
            this.Text = "StudentProgress";
            this.Load += new System.EventHandler(this.StudentProgress_Load);
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.PictureBox pbxStudentProgress;
        private System.Windows.Forms.Label lblAboutProgress;
        private System.Windows.Forms.Label lblAboutProgresses;
        private System.Windows.Forms.Label lblMotivation;
        private System.Windows.Forms.Label lblYourProgress;
        private System.Windows.Forms.ProgressBar pgbStudent;
        private System.Windows.Forms.Label lblTopics;
        private System.Windows.Forms.ComboBox cbxTopic;
    }
}