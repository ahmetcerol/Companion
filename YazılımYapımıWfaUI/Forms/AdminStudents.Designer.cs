
namespace YazılımYapımıWfaUI.Forms
{
    partial class AdminStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStudents));
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.lblAdminStudents = new System.Windows.Forms.Label();
            this.pnlAdminStudents = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbxStudents = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.pnlAdminStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStudents
            // 
            this.dgwStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgwStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.GridColor = System.Drawing.Color.White;
            this.dgwStudents.Location = new System.Drawing.Point(167, 64);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwStudents.RowTemplate.Height = 25;
            this.dgwStudents.Size = new System.Drawing.Size(533, 315);
            this.dgwStudents.TabIndex = 0;
            // 
            // lblAdminStudents
            // 
            this.lblAdminStudents.AutoSize = true;
            this.lblAdminStudents.BackColor = System.Drawing.Color.White;
            this.lblAdminStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminStudents.Location = new System.Drawing.Point(157, 26);
            this.lblAdminStudents.Name = "lblAdminStudents";
            this.lblAdminStudents.Size = new System.Drawing.Size(160, 20);
            this.lblAdminStudents.TabIndex = 1;
            this.lblAdminStudents.Text = "Registered Students:";
            this.lblAdminStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAdminStudents
            // 
            this.pnlAdminStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAdminStudents.BackColor = System.Drawing.Color.White;
            this.pnlAdminStudents.Controls.Add(this.btnDelete);
            this.pnlAdminStudents.Controls.Add(this.pbxStudents);
            this.pnlAdminStudents.Controls.Add(this.dgwStudents);
            this.pnlAdminStudents.Controls.Add(this.lblAdminStudents);
            this.pnlAdminStudents.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminStudents.Name = "pnlAdminStudents";
            this.pnlAdminStudents.Size = new System.Drawing.Size(724, 447);
            this.pnlAdminStudents.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(448, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(252, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete the selected Student";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbxStudents
            // 
            this.pbxStudents.Image = ((System.Drawing.Image)(resources.GetObject("pbxStudents.Image")));
            this.pbxStudents.Location = new System.Drawing.Point(25, 12);
            this.pbxStudents.Name = "pbxStudents";
            this.pbxStudents.Size = new System.Drawing.Size(111, 96);
            this.pbxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStudents.TabIndex = 2;
            this.pbxStudents.TabStop = false;
            // 
            // AdminStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 447);
            this.Controls.Add(this.pnlAdminStudents);
            this.Name = "AdminStudents";
            this.Text = "AdminStudents";
            this.Load += new System.EventHandler(this.AdminStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.pnlAdminStudents.ResumeLayout(false);
            this.pnlAdminStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.Label lblAdminStudents;
        private System.Windows.Forms.Panel pnlAdminStudents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pbxStudents;
    }
}