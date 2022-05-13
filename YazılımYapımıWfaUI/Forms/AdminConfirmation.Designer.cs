
namespace YazılımYapımıWfaUI.Forms
{
    partial class AdminConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminConfirmation));
            this.pnlConfirmation = new System.Windows.Forms.Panel();
            this.btnApproval = new System.Windows.Forms.Button();
            this.btnDisapproval = new System.Windows.Forms.Button();
            this.dgwConfirmation = new System.Windows.Forms.DataGridView();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.pnlConfirmation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConfirmation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConfirmation
            // 
            this.pnlConfirmation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlConfirmation.BackColor = System.Drawing.Color.White;
            this.pnlConfirmation.Controls.Add(this.btnApproval);
            this.pnlConfirmation.Controls.Add(this.btnDisapproval);
            this.pnlConfirmation.Controls.Add(this.dgwConfirmation);
            this.pnlConfirmation.Controls.Add(this.lblConfirmation);
            this.pnlConfirmation.Location = new System.Drawing.Point(0, 0);
            this.pnlConfirmation.Name = "pnlConfirmation";
            this.pnlConfirmation.Size = new System.Drawing.Size(724, 447);
            this.pnlConfirmation.TabIndex = 4;
            // 
            // btnApproval
            // 
            this.btnApproval.FlatAppearance.BorderSize = 0;
            this.btnApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApproval.Image = ((System.Drawing.Image)(resources.GetObject("btnApproval.Image")));
            this.btnApproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproval.Location = new System.Drawing.Point(434, 385);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(132, 50);
            this.btnApproval.TabIndex = 4;
            this.btnApproval.Text = "Approval";
            this.btnApproval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApproval.UseVisualStyleBackColor = true;
            this.btnApproval.Click += new System.EventHandler(this.btnApproval_Click);
            // 
            // btnDisapproval
            // 
            this.btnDisapproval.FlatAppearance.BorderSize = 0;
            this.btnDisapproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisapproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisapproval.Image = ((System.Drawing.Image)(resources.GetObject("btnDisapproval.Image")));
            this.btnDisapproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisapproval.Location = new System.Drawing.Point(572, 385);
            this.btnDisapproval.Name = "btnDisapproval";
            this.btnDisapproval.Size = new System.Drawing.Size(133, 50);
            this.btnDisapproval.TabIndex = 3;
            this.btnDisapproval.Text = "Disapproval";
            this.btnDisapproval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisapproval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisapproval.UseVisualStyleBackColor = true;
            this.btnDisapproval.Click += new System.EventHandler(this.btnDisapproval_Click);
            // 
            // dgwConfirmation
            // 
            this.dgwConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwConfirmation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwConfirmation.BackgroundColor = System.Drawing.Color.White;
            this.dgwConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwConfirmation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwConfirmation.GridColor = System.Drawing.Color.White;
            this.dgwConfirmation.Location = new System.Drawing.Point(112, 49);
            this.dgwConfirmation.Name = "dgwConfirmation";
            this.dgwConfirmation.RowTemplate.Height = 25;
            this.dgwConfirmation.Size = new System.Drawing.Size(555, 330);
            this.dgwConfirmation.TabIndex = 0;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.BackColor = System.Drawing.Color.White;
            this.lblConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmation.Location = new System.Drawing.Point(21, 20);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(213, 20);
            this.lblConfirmation.TabIndex = 1;
            this.lblConfirmation.Text = "Questions Pending Approval:";
            this.lblConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 447);
            this.Controls.Add(this.pnlConfirmation);
            this.Name = "AdminConfirmation";
            this.Text = "AdminConfirmation";
            this.Load += new System.EventHandler(this.AdminConfirmation_Load);
            this.pnlConfirmation.ResumeLayout(false);
            this.pnlConfirmation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConfirmation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfirmation;
        private System.Windows.Forms.Button btnApproval;
        private System.Windows.Forms.Button btnDisapproval;
        private System.Windows.Forms.DataGridView dgwConfirmation;
        private System.Windows.Forms.Label lblConfirmation;
    }
}