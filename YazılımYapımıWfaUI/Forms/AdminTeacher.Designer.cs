
namespace YazılımYapımıWfaUI.Forms
{
    partial class AdminTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTeacher));
            this.pnlAdminTeacher = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbxTeacher = new System.Windows.Forms.PictureBox();
            this.dgwTeachers = new System.Windows.Forms.DataGridView();
            this.lblAdminTeachers = new System.Windows.Forms.Label();
            this.pnlAdminTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdminTeacher
            // 
            this.pnlAdminTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAdminTeacher.BackColor = System.Drawing.Color.White;
            this.pnlAdminTeacher.Controls.Add(this.btnDelete);
            this.pnlAdminTeacher.Controls.Add(this.pbxTeacher);
            this.pnlAdminTeacher.Controls.Add(this.dgwTeachers);
            this.pnlAdminTeacher.Controls.Add(this.lblAdminTeachers);
            this.pnlAdminTeacher.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminTeacher.Name = "pnlAdminTeacher";
            this.pnlAdminTeacher.Size = new System.Drawing.Size(724, 447);
            this.pnlAdminTeacher.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(460, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(252, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete the selected Teacher";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbxTeacher
            // 
            this.pbxTeacher.Image = ((System.Drawing.Image)(resources.GetObject("pbxTeacher.Image")));
            this.pbxTeacher.Location = new System.Drawing.Point(25, 12);
            this.pbxTeacher.Name = "pbxTeacher";
            this.pbxTeacher.Size = new System.Drawing.Size(111, 96);
            this.pbxTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTeacher.TabIndex = 2;
            this.pbxTeacher.TabStop = false;
            // 
            // dgwTeachers
            // 
            this.dgwTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwTeachers.BackgroundColor = System.Drawing.Color.White;
            this.dgwTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeachers.GridColor = System.Drawing.Color.White;
            this.dgwTeachers.Location = new System.Drawing.Point(212, 49);
            this.dgwTeachers.Name = "dgwTeachers";
            this.dgwTeachers.RowTemplate.Height = 25;
            this.dgwTeachers.Size = new System.Drawing.Size(468, 305);
            this.dgwTeachers.TabIndex = 0;
            // 
            // lblAdminTeachers
            // 
            this.lblAdminTeachers.AutoSize = true;
            this.lblAdminTeachers.BackColor = System.Drawing.Color.White;
            this.lblAdminTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminTeachers.Location = new System.Drawing.Point(157, 26);
            this.lblAdminTeachers.Name = "lblAdminTeachers";
            this.lblAdminTeachers.Size = new System.Drawing.Size(109, 20);
            this.lblAdminTeachers.TabIndex = 1;
            this.lblAdminTeachers.Text = "Our Teachers:";
            this.lblAdminTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 447);
            this.Controls.Add(this.pnlAdminTeacher);
            this.Name = "AdminTeacher";
            this.Text = "AdminTeacher";
            this.Load += new System.EventHandler(this.AdminTeacher_Load);
            this.pnlAdminTeacher.ResumeLayout(false);
            this.pnlAdminTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminTeacher;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pbxTeacher;
        private System.Windows.Forms.DataGridView dgwTeachers;
        private System.Windows.Forms.Label lblAdminTeachers;
    }
}