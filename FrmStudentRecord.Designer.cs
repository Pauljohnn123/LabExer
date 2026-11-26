namespace LabExer
{
    partial class FrmStudentRecord
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
            this.lvShowRecord = new System.Windows.Forms.ListView();
            this.lblViewRecord = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShowRecord
            // 
            this.lvShowRecord.HideSelection = false;
            this.lvShowRecord.Location = new System.Drawing.Point(12, 37);
            this.lvShowRecord.Name = "lvShowRecord";
            this.lvShowRecord.Size = new System.Drawing.Size(447, 236);
            this.lvShowRecord.TabIndex = 0;
            this.lvShowRecord.UseCompatibleStateImageBehavior = false;
            // 
            // lblViewRecord
            // 
            this.lblViewRecord.AutoSize = true;
            this.lblViewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewRecord.Location = new System.Drawing.Point(12, 9);
            this.lblViewRecord.Name = "lblViewRecord";
            this.lblViewRecord.Size = new System.Drawing.Size(133, 25);
            this.lblViewRecord.TabIndex = 1;
            this.lblViewRecord.Text = "View Record";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(465, 37);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(82, 31);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(465, 74);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(82, 31);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(465, 111);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(82, 31);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 306);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblViewRecord);
            this.Controls.Add(this.lvShowRecord);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShowRecord;
        private System.Windows.Forms.Label lblViewRecord;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpload;
    }
}