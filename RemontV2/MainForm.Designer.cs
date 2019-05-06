namespace RemontV2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGoToService = new System.Windows.Forms.Button();
            this.btnGoToProduction = new System.Windows.Forms.Button();
            this.btnGoToMasters = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToService
            // 
            this.btnGoToService.Location = new System.Drawing.Point(12, 27);
            this.btnGoToService.Name = "btnGoToService";
            this.btnGoToService.Size = new System.Drawing.Size(130, 81);
            this.btnGoToService.TabIndex = 0;
            this.btnGoToService.Text = "Сервис";
            this.btnGoToService.UseVisualStyleBackColor = true;
            this.btnGoToService.Click += new System.EventHandler(this.btnGoToService_Click);
            // 
            // btnGoToProduction
            // 
            this.btnGoToProduction.Location = new System.Drawing.Point(148, 27);
            this.btnGoToProduction.Name = "btnGoToProduction";
            this.btnGoToProduction.Size = new System.Drawing.Size(130, 81);
            this.btnGoToProduction.TabIndex = 1;
            this.btnGoToProduction.Text = "Производство";
            this.btnGoToProduction.UseVisualStyleBackColor = true;
            // 
            // btnGoToMasters
            // 
            this.btnGoToMasters.Location = new System.Drawing.Point(12, 133);
            this.btnGoToMasters.Name = "btnGoToMasters";
            this.btnGoToMasters.Size = new System.Drawing.Size(130, 38);
            this.btnGoToMasters.TabIndex = 2;
            this.btnGoToMasters.Text = "Сервис";
            this.btnGoToMasters.UseVisualStyleBackColor = true;
            this.btnGoToMasters.Click += new System.EventHandler(this.btnGoToMasters_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 199);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToMasters);
            this.Controls.Add(this.btnGoToProduction);
            this.Controls.Add(this.btnGoToService);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Элементная база Owen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToService;
        private System.Windows.Forms.Button btnGoToProduction;
        private System.Windows.Forms.Button btnGoToMasters;
        private System.Windows.Forms.Button btnExit;
    }
}

