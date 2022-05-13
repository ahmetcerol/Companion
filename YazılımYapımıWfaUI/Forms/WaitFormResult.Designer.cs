
namespace YazılımYapımıWfaUI.Forms
{
    partial class WaitFormResult
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
            this.pgbWaitForm = new System.Windows.Forms.ProgressBar();
            this.lblWaitForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbWaitForm
            // 
            this.pgbWaitForm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pgbWaitForm.Location = new System.Drawing.Point(37, 47);
            this.pgbWaitForm.Name = "pgbWaitForm";
            this.pgbWaitForm.Size = new System.Drawing.Size(233, 25);
            this.pgbWaitForm.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbWaitForm.TabIndex = 3;
            // 
            // lblWaitForm
            // 
            this.lblWaitForm.AutoSize = true;
            this.lblWaitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWaitForm.Location = new System.Drawing.Point(12, 9);
            this.lblWaitForm.Name = "lblWaitForm";
            this.lblWaitForm.Size = new System.Drawing.Size(187, 30);
            this.lblWaitForm.TabIndex = 2;
            this.lblWaitForm.Text = "Your exam your exam is over.\r\n   You are redirected to answers...\r\n";
            // 
            // WaitFormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 85);
            this.Controls.Add(this.pgbWaitForm);
            this.Controls.Add(this.lblWaitForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitFormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaitFormResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbWaitForm;
        private System.Windows.Forms.Label lblWaitForm;
    }
}