namespace LR3
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
            this.groupsDishLlistBox = new System.Windows.Forms.ListBox();
            this.dishComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dishPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dishPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsDishLlistBox
            // 
            this.groupsDishLlistBox.FormattingEnabled = true;
            this.groupsDishLlistBox.Location = new System.Drawing.Point(46, 34);
            this.groupsDishLlistBox.Name = "groupsDishLlistBox";
            this.groupsDishLlistBox.Size = new System.Drawing.Size(120, 95);
            this.groupsDishLlistBox.TabIndex = 0;
            this.groupsDishLlistBox.SelectedIndexChanged += new System.EventHandler(this.groupsDishLlistBox_SelectedIndexChanged);
            // 
            // dishComboBox
            // 
            this.dishComboBox.FormattingEnabled = true;
            this.dishComboBox.Location = new System.Drawing.Point(207, 34);
            this.dishComboBox.Name = "dishComboBox";
            this.dishComboBox.Size = new System.Drawing.Size(121, 21);
            this.dishComboBox.TabIndex = 1;
            this.dishComboBox.SelectedIndexChanged += new System.EventHandler(this.dishComboBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(293, 71);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "label1";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(293, 93);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "label1";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(293, 115);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(35, 13);
            this.ingredientsLabel.TabIndex = 2;
            this.ingredientsLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ингредиенты:";
            // 
            // dishPictureBox
            // 
            this.dishPictureBox.Location = new System.Drawing.Point(46, 159);
            this.dishPictureBox.Name = "dishPictureBox";
            this.dishPictureBox.Size = new System.Drawing.Size(282, 219);
            this.dishPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dishPictureBox.TabIndex = 3;
            this.dishPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 442);
            this.Controls.Add(this.dishPictureBox);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dishComboBox);
            this.Controls.Add(this.groupsDishLlistBox);
            this.Name = "MainForm";
            this.Text = "Ресторан";
            ((System.ComponentModel.ISupportInitialize)(this.dishPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groupsDishLlistBox;
        private System.Windows.Forms.ComboBox dishComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox dishPictureBox;
    }
}

