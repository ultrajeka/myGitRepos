namespace RemontV2
{
    partial class MastersForm
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
            this.dgMasters = new System.Windows.Forms.DataGridView();
            this.btnAddMasters = new System.Windows.Forms.Button();
            this.btnUpdateMasters = new System.Windows.Forms.Button();
            this.btnDeleteMasters = new System.Windows.Forms.Button();
            this.btnCloseMastersForm = new System.Windows.Forms.Button();
            this.btnClearMastersDB = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMasters
            // 
            this.dgMasters.AllowUserToAddRows = false;
            this.dgMasters.AllowUserToDeleteRows = false;
            this.dgMasters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMasters.Location = new System.Drawing.Point(12, 12);
            this.dgMasters.Name = "dgMasters";
            this.dgMasters.ReadOnly = true;
            this.dgMasters.Size = new System.Drawing.Size(446, 226);
            this.dgMasters.TabIndex = 0;
            // 
            // btnAddMasters
            // 
            this.btnAddMasters.Location = new System.Drawing.Point(12, 244);
            this.btnAddMasters.Name = "btnAddMasters";
            this.btnAddMasters.Size = new System.Drawing.Size(107, 45);
            this.btnAddMasters.TabIndex = 1;
            this.btnAddMasters.Text = "Добавить";
            this.btnAddMasters.UseVisualStyleBackColor = true;
            this.btnAddMasters.Click += new System.EventHandler(this.btnAddMasters_Click);
            // 
            // btnUpdateMasters
            // 
            this.btnUpdateMasters.Location = new System.Drawing.Point(125, 244);
            this.btnUpdateMasters.Name = "btnUpdateMasters";
            this.btnUpdateMasters.Size = new System.Drawing.Size(107, 45);
            this.btnUpdateMasters.TabIndex = 2;
            this.btnUpdateMasters.Text = "Изменить";
            this.btnUpdateMasters.UseVisualStyleBackColor = true;
            this.btnUpdateMasters.Click += new System.EventHandler(this.btnUpdateMasters_Click);
            // 
            // btnDeleteMasters
            // 
            this.btnDeleteMasters.Location = new System.Drawing.Point(238, 244);
            this.btnDeleteMasters.Name = "btnDeleteMasters";
            this.btnDeleteMasters.Size = new System.Drawing.Size(107, 45);
            this.btnDeleteMasters.TabIndex = 3;
            this.btnDeleteMasters.Text = "Удалить";
            this.btnDeleteMasters.UseVisualStyleBackColor = true;
            // 
            // btnCloseMastersForm
            // 
            this.btnCloseMastersForm.Location = new System.Drawing.Point(351, 244);
            this.btnCloseMastersForm.Name = "btnCloseMastersForm";
            this.btnCloseMastersForm.Size = new System.Drawing.Size(107, 45);
            this.btnCloseMastersForm.TabIndex = 4;
            this.btnCloseMastersForm.Text = "Вернуться";
            this.btnCloseMastersForm.UseVisualStyleBackColor = true;
            this.btnCloseMastersForm.Click += new System.EventHandler(this.btnCloseMastersForm_Click);
            // 
            // btnClearMastersDB
            // 
            this.btnClearMastersDB.Location = new System.Drawing.Point(12, 295);
            this.btnClearMastersDB.Name = "btnClearMastersDB";
            this.btnClearMastersDB.Size = new System.Drawing.Size(107, 45);
            this.btnClearMastersDB.TabIndex = 5;
            this.btnClearMastersDB.Text = "Очистить базу";
            this.btnClearMastersDB.UseVisualStyleBackColor = true;
            this.btnClearMastersDB.Click += new System.EventHandler(this.btnClearMastersDB_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(251, 340);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 6;
            // 
            // MastersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 365);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnClearMastersDB);
            this.Controls.Add(this.btnCloseMastersForm);
            this.Controls.Add(this.btnDeleteMasters);
            this.Controls.Add(this.btnUpdateMasters);
            this.Controls.Add(this.btnAddMasters);
            this.Controls.Add(this.dgMasters);
            this.MaximizeBox = false;
            this.Name = "MastersForm";
            this.Text = "Ремонтники";
            this.Load += new System.EventHandler(this.MastersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMasters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMasters;
        private System.Windows.Forms.Button btnAddMasters;
        private System.Windows.Forms.Button btnUpdateMasters;
        private System.Windows.Forms.Button btnDeleteMasters;
        private System.Windows.Forms.Button btnCloseMastersForm;
        private System.Windows.Forms.Button btnClearMastersDB;
        private System.Windows.Forms.Label lbl1;
    }
}