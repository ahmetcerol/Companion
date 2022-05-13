
namespace YazılımYapımıWfaUI.Forms
{
    partial class ExamResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamResult));
            this.pnlExamResult = new System.Windows.Forms.Panel();
            this.lblMotivation = new System.Windows.Forms.Label();
            this.pbxExam = new System.Windows.Forms.PictureBox();
            this.tbxWrong = new System.Windows.Forms.TextBox();
            this.tbxCorrect = new System.Windows.Forms.TextBox();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.pnlExamResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExam)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExamResult
            // 
            this.pnlExamResult.BackColor = System.Drawing.Color.White;
            this.pnlExamResult.Controls.Add(this.lblMotivation);
            this.pnlExamResult.Controls.Add(this.pbxExam);
            this.pnlExamResult.Controls.Add(this.tbxWrong);
            this.pnlExamResult.Controls.Add(this.tbxCorrect);
            this.pnlExamResult.Controls.Add(this.lblWrong);
            this.pnlExamResult.Controls.Add(this.lblCorrect);
            this.pnlExamResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExamResult.Location = new System.Drawing.Point(0, 0);
            this.pnlExamResult.Name = "pnlExamResult";
            this.pnlExamResult.Size = new System.Drawing.Size(724, 447);
            this.pnlExamResult.TabIndex = 0;
            // 
            // lblMotivation
            // 
            this.lblMotivation.AutoSize = true;
            this.lblMotivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotivation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMotivation.Location = new System.Drawing.Point(213, 371);
            this.lblMotivation.Name = "lblMotivation";
            this.lblMotivation.Size = new System.Drawing.Size(293, 32);
            this.lblMotivation.TabIndex = 6;
            this.lblMotivation.Text = "**Don\'t worry about your mistakes.In our system, \r\nthere are more questions about" +
    " that subject.**\r\n";
            // 
            // pbxExam
            // 
            this.pbxExam.Image = ((System.Drawing.Image)(resources.GetObject("pbxExam.Image")));
            this.pbxExam.Location = new System.Drawing.Point(29, 26);
            this.pbxExam.Name = "pbxExam";
            this.pbxExam.Size = new System.Drawing.Size(128, 117);
            this.pbxExam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExam.TabIndex = 4;
            this.pbxExam.TabStop = false;
            // 
            // tbxWrong
            // 
            this.tbxWrong.BackColor = System.Drawing.Color.White;
            this.tbxWrong.Enabled = false;
            this.tbxWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxWrong.Location = new System.Drawing.Point(386, 206);
            this.tbxWrong.Name = "tbxWrong";
            this.tbxWrong.Size = new System.Drawing.Size(100, 22);
            this.tbxWrong.TabIndex = 3;
            // 
            // tbxCorrect
            // 
            this.tbxCorrect.BackColor = System.Drawing.Color.White;
            this.tbxCorrect.Enabled = false;
            this.tbxCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCorrect.Location = new System.Drawing.Point(386, 162);
            this.tbxCorrect.Name = "tbxCorrect";
            this.tbxCorrect.Size = new System.Drawing.Size(100, 22);
            this.tbxCorrect.TabIndex = 2;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWrong.Location = new System.Drawing.Point(222, 208);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(129, 16);
            this.lblWrong.TabIndex = 1;
            this.lblWrong.Text = "Wrong Questions:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorrect.Location = new System.Drawing.Point(222, 164);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(134, 16);
            this.lblCorrect.TabIndex = 0;
            this.lblCorrect.Text = "Correct Questions:";
            // 
            // ExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 447);
            this.Controls.Add(this.pnlExamResult);
            this.Name = "ExamResult";
            this.Text = "ExamResult";
            this.pnlExamResult.ResumeLayout(false);
            this.pnlExamResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExamResult;
        private System.Windows.Forms.TextBox tbxWrong;
        private System.Windows.Forms.TextBox tbxCorrect;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.PictureBox pbxExam;
        private System.Windows.Forms.Label lblMotivation;
    }
}