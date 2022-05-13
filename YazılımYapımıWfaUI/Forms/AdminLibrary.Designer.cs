
namespace YazılımYapımıWfaUI.Forms
{
    partial class AdminLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLibrary));
            this.pnlLibrary = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgwLibrary = new System.Windows.Forms.DataGridView();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.pnlLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLibrary
            // 
            this.pnlLibrary.BackColor = System.Drawing.Color.White;
            this.pnlLibrary.Controls.Add(this.btnDelete);
            this.pnlLibrary.Controls.Add(this.dgwLibrary);
            this.pnlLibrary.Controls.Add(this.lblLibrary);
            this.pnlLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLibrary.Location = new System.Drawing.Point(0, 0);
            this.pnlLibrary.Name = "pnlLibrary";
            this.pnlLibrary.Size = new System.Drawing.Size(724, 447);
            this.pnlLibrary.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(572, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgwLibrary
            // 
            this.dgwLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwLibrary.BackgroundColor = System.Drawing.Color.White;
            this.dgwLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLibrary.GridColor = System.Drawing.Color.White;
            this.dgwLibrary.Location = new System.Drawing.Point(43, 49);
            this.dgwLibrary.Name = "dgwLibrary";
            this.dgwLibrary.RowTemplate.Height = 25;
            this.dgwLibrary.Size = new System.Drawing.Size(618, 330);
            this.dgwLibrary.TabIndex = 0;
            // 
            // lblLibrary
            // 
            this.lblLibrary.AutoSize = true;
            this.lblLibrary.BackColor = System.Drawing.Color.White;
            this.lblLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLibrary.Location = new System.Drawing.Point(21, 20);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(115, 20);
            this.lblLibrary.TabIndex = 1;
            this.lblLibrary.Text = "Our Questions:";
            this.lblLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 447);
            this.Controls.Add(this.pnlLibrary);
            this.Name = "AdminLibrary";
            this.Text = "AdminLibrary";
            this.Load += new System.EventHandler(this.AdminLibrary_Load);
            this.pnlLibrary.ResumeLayout(false);
            this.pnlLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibrary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLibrary;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgwLibrary;
        private System.Windows.Forms.Label lblLibrary;
    }
}