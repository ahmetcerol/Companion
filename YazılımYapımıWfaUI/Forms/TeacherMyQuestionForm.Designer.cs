
namespace YazılımYapımıWfaUI.Forms
{
    partial class TeacherMyQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMyQuestionForm));
            this.pnlTeacherMyQ = new System.Windows.Forms.Panel();
            this.dgwMyQuestions = new System.Windows.Forms.DataGridView();
            this.lblYourQuestion = new System.Windows.Forms.Label();
            this.pbxMyQuestion = new System.Windows.Forms.PictureBox();
            this.pnlTeacherMyQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMyQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTeacherMyQ
            // 
            this.pnlTeacherMyQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTeacherMyQ.BackColor = System.Drawing.Color.White;
            this.pnlTeacherMyQ.Controls.Add(this.dgwMyQuestions);
            this.pnlTeacherMyQ.Controls.Add(this.lblYourQuestion);
            this.pnlTeacherMyQ.Controls.Add(this.pbxMyQuestion);
            this.pnlTeacherMyQ.Location = new System.Drawing.Point(0, 0);
            this.pnlTeacherMyQ.Name = "pnlTeacherMyQ";
            this.pnlTeacherMyQ.Size = new System.Drawing.Size(704, 444);
            this.pnlTeacherMyQ.TabIndex = 0;
            // 
            // dgwMyQuestions
            // 
            this.dgwMyQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgwMyQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMyQuestions.Location = new System.Drawing.Point(99, 160);
            this.dgwMyQuestions.Name = "dgwMyQuestions";
            this.dgwMyQuestions.RowTemplate.Height = 25;
            this.dgwMyQuestions.Size = new System.Drawing.Size(563, 254);
            this.dgwMyQuestions.TabIndex = 5;
            // 
            // lblYourQuestion
            // 
            this.lblYourQuestion.AutoSize = true;
            this.lblYourQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYourQuestion.Location = new System.Drawing.Point(63, 137);
            this.lblYourQuestion.Name = "lblYourQuestion";
            this.lblYourQuestion.Size = new System.Drawing.Size(193, 20);
            this.lblYourQuestion.TabIndex = 4;
            this.lblYourQuestion.Text = "Here is your questions:";
            // 
            // pbxMyQuestion
            // 
            this.pbxMyQuestion.Image = ((System.Drawing.Image)(resources.GetObject("pbxMyQuestion.Image")));
            this.pbxMyQuestion.Location = new System.Drawing.Point(35, 12);
            this.pbxMyQuestion.Name = "pbxMyQuestion";
            this.pbxMyQuestion.Size = new System.Drawing.Size(127, 110);
            this.pbxMyQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMyQuestion.TabIndex = 0;
            this.pbxMyQuestion.TabStop = false;
            // 
            // TeacherMyQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 444);
            this.Controls.Add(this.pnlTeacherMyQ);
            this.Name = "TeacherMyQuestionForm";
            this.Text = "TeacherMyQuestionForm";
            this.Load += new System.EventHandler(this.TeacherMyQuestionForm_Load);
            this.pnlTeacherMyQ.ResumeLayout(false);
            this.pnlTeacherMyQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMyQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTeacherMyQ;
        private System.Windows.Forms.PictureBox pbxMyQuestion;
        private System.Windows.Forms.DataGridView dgwMyQuestions;
        private System.Windows.Forms.Label lblYourQuestion;
    }
}