namespace SQLTest
{
    partial class Form1
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddBtn.Location = new System.Drawing.Point(127, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(106, 32);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(12, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(106, 32);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.Location = new System.Drawing.Point(0, 0);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(489, 257);
            this.userDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 40);
            this.panel1.TabIndex = 2;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EditBtn.Location = new System.Drawing.Point(239, 5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(106, 32);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelBtn.Location = new System.Drawing.Point(414, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(68, 32);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button EditBtn;
    }
}

