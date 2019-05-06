namespace RemontV2
{
    partial class UpdateMastersForm
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
            this.btnCloseUpdateMasterForm = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFio = new System.Windows.Forms.Label();
            this.tbUpdatePhone = new System.Windows.Forms.TextBox();
            this.tbUpdateEmail = new System.Windows.Forms.TextBox();
            this.tbUpdateFio = new System.Windows.Forms.TextBox();
            this.btnUpdateNewMasters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseUpdateMasterForm
            // 
            this.btnCloseUpdateMasterForm.Location = new System.Drawing.Point(138, 87);
            this.btnCloseUpdateMasterForm.Name = "btnCloseUpdateMasterForm";
            this.btnCloseUpdateMasterForm.Size = new System.Drawing.Size(75, 36);
            this.btnCloseUpdateMasterForm.TabIndex = 16;
            this.btnCloseUpdateMasterForm.Text = "Отмена";
            this.btnCloseUpdateMasterForm.UseVisualStyleBackColor = true;
            this.btnCloseUpdateMasterForm.Click += new System.EventHandler(this.btnCloseUpdateMasterForm_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 48);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Телефон";
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(13, 9);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(34, 13);
            this.lblFio.TabIndex = 13;
            this.lblFio.Text = "ФИО";
            // 
            // tbUpdatePhone
            // 
            this.tbUpdatePhone.Location = new System.Drawing.Point(12, 64);
            this.tbUpdatePhone.Name = "tbUpdatePhone";
            this.tbUpdatePhone.Size = new System.Drawing.Size(100, 20);
            this.tbUpdatePhone.TabIndex = 12;
            // 
            // tbUpdateEmail
            // 
            this.tbUpdateEmail.Location = new System.Drawing.Point(12, 103);
            this.tbUpdateEmail.Name = "tbUpdateEmail";
            this.tbUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateEmail.TabIndex = 11;
            // 
            // tbUpdateFio
            // 
            this.tbUpdateFio.Location = new System.Drawing.Point(12, 25);
            this.tbUpdateFio.Name = "tbUpdateFio";
            this.tbUpdateFio.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateFio.TabIndex = 10;
            // 
            // btnUpdateNewMasters
            // 
            this.btnUpdateNewMasters.Location = new System.Drawing.Point(138, 25);
            this.btnUpdateNewMasters.Name = "btnUpdateNewMasters";
            this.btnUpdateNewMasters.Size = new System.Drawing.Size(75, 48);
            this.btnUpdateNewMasters.TabIndex = 9;
            this.btnUpdateNewMasters.Text = "Изменить";
            this.btnUpdateNewMasters.UseVisualStyleBackColor = true;
            this.btnUpdateNewMasters.Click += new System.EventHandler(this.btnUpdateNewMasters_Click);
            // 
            // UpdateMastersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 153);
            this.Controls.Add(this.btnCloseUpdateMasterForm);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblFio);
            this.Controls.Add(this.tbUpdatePhone);
            this.Controls.Add(this.tbUpdateEmail);
            this.Controls.Add(this.tbUpdateFio);
            this.Controls.Add(this.btnUpdateNewMasters);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateMastersForm";
            this.Text = "Редактировать ремонтера";
            this.Load += new System.EventHandler(this.UpdateMastersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseUpdateMasterForm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.TextBox tbUpdatePhone;
        private System.Windows.Forms.TextBox tbUpdateEmail;
        private System.Windows.Forms.TextBox tbUpdateFio;
        private System.Windows.Forms.Button btnUpdateNewMasters;
    }
}