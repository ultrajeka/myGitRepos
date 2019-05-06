namespace RemontV2
{
    partial class AddRemonters
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
            this.btnAddNewMasters = new System.Windows.Forms.Button();
            this.tbAddFio = new System.Windows.Forms.TextBox();
            this.tbAddEmail = new System.Windows.Forms.TextBox();
            this.tbAddPhone = new System.Windows.Forms.TextBox();
            this.lblFio = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCloseAddNewMasterForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddNewMasters
            // 
            this.btnAddNewMasters.Location = new System.Drawing.Point(138, 29);
            this.btnAddNewMasters.Name = "btnAddNewMasters";
            this.btnAddNewMasters.Size = new System.Drawing.Size(75, 48);
            this.btnAddNewMasters.TabIndex = 0;
            this.btnAddNewMasters.Text = "Добавить";
            this.btnAddNewMasters.UseVisualStyleBackColor = true;
            this.btnAddNewMasters.Click += new System.EventHandler(this.btnAddNewMasters_Click);
            // 
            // tbAddFio
            // 
            this.tbAddFio.Location = new System.Drawing.Point(12, 29);
            this.tbAddFio.Name = "tbAddFio";
            this.tbAddFio.Size = new System.Drawing.Size(100, 20);
            this.tbAddFio.TabIndex = 1;
            // 
            // tbAddEmail
            // 
            this.tbAddEmail.Location = new System.Drawing.Point(12, 107);
            this.tbAddEmail.Name = "tbAddEmail";
            this.tbAddEmail.Size = new System.Drawing.Size(100, 20);
            this.tbAddEmail.TabIndex = 2;
            // 
            // tbAddPhone
            // 
            this.tbAddPhone.Location = new System.Drawing.Point(12, 68);
            this.tbAddPhone.Name = "tbAddPhone";
            this.tbAddPhone.Size = new System.Drawing.Size(100, 20);
            this.tbAddPhone.TabIndex = 3;
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(13, 13);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(38, 13);
            this.lblFio.TabIndex = 4;
            this.lblFio.Text = "ФИО*";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 52);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Телефон*";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // btnCloseAddNewMasterForm
            // 
            this.btnCloseAddNewMasterForm.Location = new System.Drawing.Point(138, 91);
            this.btnCloseAddNewMasterForm.Name = "btnCloseAddNewMasterForm";
            this.btnCloseAddNewMasterForm.Size = new System.Drawing.Size(75, 36);
            this.btnCloseAddNewMasterForm.TabIndex = 7;
            this.btnCloseAddNewMasterForm.Text = "Закрыть";
            this.btnCloseAddNewMasterForm.UseVisualStyleBackColor = true;
            this.btnCloseAddNewMasterForm.Click += new System.EventHandler(this.btnCloseAddNewMasterForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "* - поля обязательные для заполнения";
            // 
            // AddRemonters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseAddNewMasterForm);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblFio);
            this.Controls.Add(this.tbAddPhone);
            this.Controls.Add(this.tbAddEmail);
            this.Controls.Add(this.tbAddFio);
            this.Controls.Add(this.btnAddNewMasters);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRemonters";
            this.Text = "Новый ремонтер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewMasters;
        private System.Windows.Forms.TextBox tbAddFio;
        private System.Windows.Forms.TextBox tbAddEmail;
        private System.Windows.Forms.TextBox tbAddPhone;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCloseAddNewMasterForm;
        private System.Windows.Forms.Label label1;
    }
}