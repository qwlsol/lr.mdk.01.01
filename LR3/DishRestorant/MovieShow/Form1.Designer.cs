namespace MovieShow
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
            this.ListBoxGroup = new System.Windows.Forms.ListBox();
            this.ComboBoxDish = new System.Windows.Forms.ComboBox();
            this.PictureBoxDish = new System.Windows.Forms.PictureBox();
            this.ButtonOrderDish = new System.Windows.Forms.Button();
            this.RichTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.totalOrdersDish = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalOrdersDish)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxGroup
            // 
            this.ListBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxGroup.FormattingEnabled = true;
            this.ListBoxGroup.ItemHeight = 16;
            this.ListBoxGroup.Location = new System.Drawing.Point(-2, 11);
            this.ListBoxGroup.Name = "ListBoxGroup";
            this.ListBoxGroup.Size = new System.Drawing.Size(126, 436);
            this.ListBoxGroup.TabIndex = 0;
            this.ListBoxGroup.SelectedIndexChanged += new System.EventHandler(this.ListBoxGroup_SelectedIndexChanged);
            // 
            // ComboBoxDish
            // 
            this.ComboBoxDish.FormattingEnabled = true;
            this.ComboBoxDish.Location = new System.Drawing.Point(340, 67);
            this.ComboBoxDish.Name = "ComboBoxDish";
            this.ComboBoxDish.Size = new System.Drawing.Size(113, 21);
            this.ComboBoxDish.TabIndex = 1;
            this.ComboBoxDish.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDish_SelectedIndexChanged);
            // 
            // PictureBoxDish
            // 
            this.PictureBoxDish.Location = new System.Drawing.Point(458, 0);
            this.PictureBoxDish.Name = "PictureBoxDish";
            this.PictureBoxDish.Size = new System.Drawing.Size(457, 327);
            this.PictureBoxDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxDish.TabIndex = 2;
            this.PictureBoxDish.TabStop = false;
            // 
            // ButtonOrderDish
            // 
            this.ButtonOrderDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOrderDish.Location = new System.Drawing.Point(184, 202);
            this.ButtonOrderDish.Name = "ButtonOrderDish";
            this.ButtonOrderDish.Size = new System.Drawing.Size(153, 64);
            this.ButtonOrderDish.TabIndex = 3;
            this.ButtonOrderDish.Text = "Отчёт";
            this.ButtonOrderDish.UseVisualStyleBackColor = true;
            this.ButtonOrderDish.Click += new System.EventHandler(this.ButtonOrderDish_Click);
            // 
            // RichTextBoxInfo
            // 
            this.RichTextBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxInfo.Location = new System.Drawing.Point(458, 355);
            this.RichTextBoxInfo.Name = "RichTextBoxInfo";
            this.RichTextBoxInfo.Size = new System.Drawing.Size(458, 125);
            this.RichTextBoxInfo.TabIndex = 4;
            this.RichTextBoxInfo.Text = "";
            // 
            // totalOrdersDish
            // 
            this.totalOrdersDish.Location = new System.Drawing.Point(340, 132);
            this.totalOrdersDish.Margin = new System.Windows.Forms.Padding(2);
            this.totalOrdersDish.Name = "totalOrdersDish";
            this.totalOrdersDish.Size = new System.Drawing.Size(112, 20);
            this.totalOrdersDish.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(181, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите блюдо";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(169, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выбериете кол-во ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalOrdersDish);
            this.Controls.Add(this.RichTextBoxInfo);
            this.Controls.Add(this.ButtonOrderDish);
            this.Controls.Add(this.PictureBoxDish);
            this.Controls.Add(this.ComboBoxDish);
            this.Controls.Add(this.ListBoxGroup);
            this.MaximumSize = new System.Drawing.Size(942, 535);
            this.Name = "MainForm";
            this.Text = "Ресторан";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalOrdersDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxGroup;
        private System.Windows.Forms.ComboBox ComboBoxDish;
        private System.Windows.Forms.PictureBox PictureBoxDish;
        private System.Windows.Forms.Button ButtonOrderDish;
        private System.Windows.Forms.RichTextBox RichTextBoxInfo;
        private System.Windows.Forms.NumericUpDown totalOrdersDish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

