
namespace YazılımYapımıWfaUI.Forms
{
    partial class StartExamForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartExamForm));
            this.pnlStartExam = new System.Windows.Forms.Panel();
            this.lblAboutQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblAboutTimer = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.gbxTeacherAnswer = new System.Windows.Forms.GroupBox();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.tbxD = new System.Windows.Forms.TextBox();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.pbxQuestionImage = new System.Windows.Forms.PictureBox();
            this.rtbxQuestion = new System.Windows.Forms.RichTextBox();
            this.pbxExam = new System.Windows.Forms.PictureBox();
            this.dgwQuestions = new System.Windows.Forms.DataGridView();
            this.tmrStartExam = new System.Windows.Forms.Timer(this.components);
            this.pnlStartExam.SuspendLayout();
            this.gbxTeacherAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuestionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStartExam
            // 
            this.pnlStartExam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlStartExam.BackColor = System.Drawing.Color.White;
            this.pnlStartExam.Controls.Add(this.lblQuestionNumber);
            this.pnlStartExam.Controls.Add(this.lblAboutQuestionNumber);
            this.pnlStartExam.Controls.Add(this.lblAboutTimer);
            this.pnlStartExam.Controls.Add(this.lblTimer);
            this.pnlStartExam.Controls.Add(this.gbxTeacherAnswer);
            this.pnlStartExam.Controls.Add(this.btnNextQuestion);
            this.pnlStartExam.Controls.Add(this.pbxQuestionImage);
            this.pnlStartExam.Controls.Add(this.rtbxQuestion);
            this.pnlStartExam.Controls.Add(this.pbxExam);
            this.pnlStartExam.Controls.Add(this.dgwQuestions);
            this.pnlStartExam.Location = new System.Drawing.Point(10, 1);
            this.pnlStartExam.Name = "pnlStartExam";
            this.pnlStartExam.Size = new System.Drawing.Size(704, 444);
            this.pnlStartExam.TabIndex = 1;
            // 
            // lblAboutQuestionNumber
            // 
            this.lblAboutQuestionNumber.AutoSize = true;
            this.lblAboutQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAboutQuestionNumber.Location = new System.Drawing.Point(101, 32);
            this.lblAboutQuestionNumber.Name = "lblAboutQuestionNumber";
            this.lblAboutQuestionNumber.Size = new System.Drawing.Size(123, 15);
            this.lblAboutQuestionNumber.TabIndex = 19;
            this.lblAboutQuestionNumber.Text = "Question Number:";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestionNumber.Location = new System.Drawing.Point(220, 32);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(15, 15);
            this.lblQuestionNumber.TabIndex = 2;
            this.lblQuestionNumber.Text = "0";
            // 
            // lblAboutTimer
            // 
            this.lblAboutTimer.AutoSize = true;
            this.lblAboutTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAboutTimer.Location = new System.Drawing.Point(522, 12);
            this.lblAboutTimer.Name = "lblAboutTimer";
            this.lblAboutTimer.Size = new System.Drawing.Size(92, 16);
            this.lblAboutTimer.TabIndex = 17;
            this.lblAboutTimer.Text = "Your Minute:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(611, 12);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(22, 16);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "---";
            // 
            // gbxTeacherAnswer
            // 
            this.gbxTeacherAnswer.Controls.Add(this.rdbD);
            this.gbxTeacherAnswer.Controls.Add(this.rdbC);
            this.gbxTeacherAnswer.Controls.Add(this.rdbB);
            this.gbxTeacherAnswer.Controls.Add(this.rdbA);
            this.gbxTeacherAnswer.Controls.Add(this.tbxD);
            this.gbxTeacherAnswer.Controls.Add(this.tbxC);
            this.gbxTeacherAnswer.Controls.Add(this.tbxB);
            this.gbxTeacherAnswer.Controls.Add(this.tbxA);
            this.gbxTeacherAnswer.Location = new System.Drawing.Point(147, 246);
            this.gbxTeacherAnswer.Name = "gbxTeacherAnswer";
            this.gbxTeacherAnswer.Size = new System.Drawing.Size(285, 158);
            this.gbxTeacherAnswer.TabIndex = 15;
            this.gbxTeacherAnswer.TabStop = false;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbD.Location = new System.Drawing.Point(6, 119);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(41, 20);
            this.rdbD.TabIndex = 27;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D)";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbC.Location = new System.Drawing.Point(6, 88);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(40, 20);
            this.rdbC.TabIndex = 26;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C)";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbB.Location = new System.Drawing.Point(6, 56);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(40, 20);
            this.rdbB.TabIndex = 25;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B)";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbA.Location = new System.Drawing.Point(6, 22);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(40, 20);
            this.rdbA.TabIndex = 24;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A)";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // tbxD
            // 
            this.tbxD.BackColor = System.Drawing.Color.White;
            this.tbxD.Enabled = false;
            this.tbxD.ForeColor = System.Drawing.Color.Black;
            this.tbxD.Location = new System.Drawing.Point(48, 116);
            this.tbxD.Name = "tbxD";
            this.tbxD.Size = new System.Drawing.Size(145, 23);
            this.tbxD.TabIndex = 22;
            // 
            // tbxC
            // 
            this.tbxC.BackColor = System.Drawing.Color.White;
            this.tbxC.Enabled = false;
            this.tbxC.ForeColor = System.Drawing.Color.Black;
            this.tbxC.Location = new System.Drawing.Point(48, 85);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(145, 23);
            this.tbxC.TabIndex = 21;
            // 
            // tbxB
            // 
            this.tbxB.BackColor = System.Drawing.Color.White;
            this.tbxB.Enabled = false;
            this.tbxB.ForeColor = System.Drawing.Color.Black;
            this.tbxB.Location = new System.Drawing.Point(48, 53);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(145, 23);
            this.tbxB.TabIndex = 20;
            // 
            // tbxA
            // 
            this.tbxA.BackColor = System.Drawing.Color.White;
            this.tbxA.Enabled = false;
            this.tbxA.ForeColor = System.Drawing.Color.Black;
            this.tbxA.Location = new System.Drawing.Point(48, 22);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(145, 23);
            this.tbxA.TabIndex = 19;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.FlatAppearance.BorderSize = 0;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnNextQuestion.Image")));
            this.btnNextQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextQuestion.Location = new System.Drawing.Point(491, 365);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(170, 47);
            this.btnNextQuestion.TabIndex = 6;
            this.btnNextQuestion.Text = "Send Answer";
            this.btnNextQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // pbxQuestionImage
            // 
            this.pbxQuestionImage.Location = new System.Drawing.Point(522, 73);
            this.pbxQuestionImage.Name = "pbxQuestionImage";
            this.pbxQuestionImage.Size = new System.Drawing.Size(158, 159);
            this.pbxQuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxQuestionImage.TabIndex = 5;
            this.pbxQuestionImage.TabStop = false;
            // 
            // rtbxQuestion
            // 
            this.rtbxQuestion.BackColor = System.Drawing.Color.White;
            this.rtbxQuestion.Enabled = false;
            this.rtbxQuestion.Location = new System.Drawing.Point(120, 73);
            this.rtbxQuestion.Name = "rtbxQuestion";
            this.rtbxQuestion.Size = new System.Drawing.Size(357, 150);
            this.rtbxQuestion.TabIndex = 1;
            this.rtbxQuestion.Text = "";
            // 
            // pbxExam
            // 
            this.pbxExam.Image = ((System.Drawing.Image)(resources.GetObject("pbxExam.Image")));
            this.pbxExam.Location = new System.Drawing.Point(24, 12);
            this.pbxExam.Name = "pbxExam";
            this.pbxExam.Size = new System.Drawing.Size(71, 72);
            this.pbxExam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExam.TabIndex = 0;
            this.pbxExam.TabStop = false;
            // 
            // dgwQuestions
            // 
            this.dgwQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwQuestions.Location = new System.Drawing.Point(510, 379);
            this.dgwQuestions.Name = "dgwQuestions";
            this.dgwQuestions.RowTemplate.Height = 25;
            this.dgwQuestions.Size = new System.Drawing.Size(111, 25);
            this.dgwQuestions.TabIndex = 18;
            // 
            // tmrStartExam
            // 
            this.tmrStartExam.Tick += new System.EventHandler(this.tmrStartExam_Tick);
            // 
            // StartExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 447);
            this.Controls.Add(this.pnlStartExam);
            this.Name = "StartExamForm";
            this.Text = "StartExamForm";
            this.Load += new System.EventHandler(this.StartExamForm_Load);
            this.pnlStartExam.ResumeLayout(false);
            this.pnlStartExam.PerformLayout();
            this.gbxTeacherAnswer.ResumeLayout(false);
            this.gbxTeacherAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuestionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStartExam;
        private System.Windows.Forms.GroupBox gbxTeacherAnswer;
        private System.Windows.Forms.TextBox tbxD;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.PictureBox pbxQuestionImage;
        private System.Windows.Forms.RichTextBox rtbxQuestion;
        private System.Windows.Forms.PictureBox pbxExam;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Label lblAboutTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrStartExam;
        private System.Windows.Forms.DataGridView dgwQuestions;
        private System.Windows.Forms.Label lblAboutQuestionNumber;
        private System.Windows.Forms.Label lblQuestionNumber;
    }
}