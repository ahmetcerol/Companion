
namespace YazılımYapımıWfaUI.Forms
{
    partial class Wait_Form
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
            this.lblWaitForm = new System.Windows.Forms.Label();
            this.pgbWaitForm = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblWaitForm
            // 
            this.lblWaitForm.AutoSize = true;
            this.lblWaitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWaitForm.Location = new System.Drawing.Point(12, 9);
            this.lblWaitForm.Name = "lblWaitForm";
            this.lblWaitForm.Size = new System.Drawing.Size(197, 15);
            this.lblWaitForm.TabIndex = 0;
            this.lblWaitForm.Text = "Your exam will  start in 3 seconds...";
            // 
            // pgbWaitForm
            // 
            this.pgbWaitForm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pgbWaitForm.Location = new System.Drawing.Point(34, 25);
            this.pgbWaitForm.Name = "pgbWaitForm";
            this.pgbWaitForm.Size = new System.Drawing.Size(233, 25);
            this.pgbWaitForm.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbWaitForm.TabIndex = 1;
            // 
            // Wait_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 68);
            this.Controls.Add(this.pgbWaitForm);
            this.Controls.Add(this.lblWaitForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wait_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wait_Form";
            this.Load += new System.EventHandler(this.Wait_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWaitForm;
        private System.Windows.Forms.ProgressBar pgbWaitForm;
    }
}