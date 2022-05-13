
using System;

namespace YazılımYapımıWfaUI.Forms
{
    partial class ExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            this.pnlExam = new System.Windows.Forms.Panel();
            this.lblAboutSigma = new System.Windows.Forms.Label();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblNumberQuestions = new System.Windows.Forms.Label();
            this.lblExam = new System.Windows.Forms.Label();
            this.pbxExam = new System.Windows.Forms.PictureBox();
            this.pnlExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExam)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExam
            // 
            this.pnlExam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlExam.Controls.Add(this.lblAboutSigma);
            this.pnlExam.Controls.Add(this.btnStartExam);
            this.pnlExam.Controls.Add(this.tbxNumber);
            this.pnlExam.Controls.Add(this.lblNumberQuestions);
            this.pnlExam.Controls.Add(this.lblExam);
            this.pnlExam.Controls.Add(this.pbxExam);
            this.pnlExam.Location = new System.Drawing.Point(0, 0);
            this.pnlExam.Name = "pnlExam";
            this.pnlExam.Size = new System.Drawing.Size(724, 471);
            this.pnlExam.TabIndex = 0;
            // 
            // lblAboutSigma
            // 
            this.lblAboutSigma.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblAboutSigma.AutoSize = true;
            this.lblAboutSigma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAboutSigma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAboutSigma.ForeColor = System.Drawing.Color.DimGray;
            this.lblAboutSigma.Location = new System.Drawing.Point(34, 284);
            this.lblAboutSigma.Name = "lblAboutSigma";
            this.lblAboutSigma.Size = new System.Drawing.Size(393, 80);
            this.lblAboutSigma.TabIndex = 5;
            this.lblAboutSigma.Text = resources.GetString("lblAboutSigma.Text");
            this.lblAboutSigma.UseMnemonic = false;
            // 
            // btnStartExam
            // 
            this.btnStartExam.BackColor = System.Drawing.Color.White;
            this.btnStartExam.FlatAppearance.BorderSize = 0;
            this.btnStartExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartExam.ForeColor = System.Drawing.Color.Black;
            this.btnStartExam.Image = ((System.Drawing.Image)(resources.GetObject("btnStartExam.Image")));
            this.btnStartExam.Location = new System.Drawing.Point(617, 346);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(70, 45);
            this.btnStartExam.TabIndex = 4;
            this.btnStartExam.UseVisualStyleBackColor = false;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // tbxNumber
            // 
            this.tbxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNumber.Location = new System.Drawing.Point(533, 185);
            this.tbxNumber.MaxLength = 50;
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.PlaceholderText = "10";
            this.tbxNumber.Size = new System.Drawing.Size(36, 24);
            this.tbxNumber.TabIndex = 3;
            this.tbxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumberQuestions
            // 
            this.lblNumberQuestions.AutoSize = true;
            this.lblNumberQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberQuestions.ForeColor = System.Drawing.Color.Black;
            this.lblNumberQuestions.Location = new System.Drawing.Point(278, 185);
            this.lblNumberQuestions.Name = "lblNumberQuestions";
            this.lblNumberQuestions.Size = new System.Drawing.Size(246, 18);
            this.lblNumberQuestions.TabIndex = 2;
            this.lblNumberQuestions.Text = "Number of Questions(Minimum-10):";
            // 
            // lblExam
            // 
            this.lblExam.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblExam.AutoSize = true;
            this.lblExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExam.ForeColor = System.Drawing.Color.Black;
            this.lblExam.Location = new System.Drawing.Point(278, 58);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(424, 72);
            this.lblExam.TabIndex = 1;
            this.lblExam.Text = "You have 1 and a half minute for each question.\r\nIf you think you don\'t understan" +
    "d a subject, don\'t worry,\r\nyou will continue to solve it until you do.\r\nThanks t" +
    "o 6 sigma";
            this.lblExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExam.UseMnemonic = false;
            // 
            // pbxExam
            // 
            this.pbxExam.Image = ((System.Drawing.Image)(resources.GetObject("pbxExam.Image")));
            this.pbxExam.Location = new System.Drawing.Point(46, 58);
            this.pbxExam.Name = "pbxExam";
            this.pbxExam.Size = new System.Drawing.Size(206, 166);
            this.pbxExam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExam.TabIndex = 0;
            this.pbxExam.TabStop = false;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 471);
            this.Controls.Add(this.pnlExam);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.pnlExam.ResumeLayout(false);
            this.pnlExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExam;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.PictureBox pbxExam;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblNumberQuestions;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Label lblAboutSigma;
    }
}