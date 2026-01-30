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
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.dishLabel = new System.Windows.Forms.Label();
            this.dishesComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantitySelector = new System.Windows.Forms.NumericUpDown();
            this.dishPicture = new System.Windows.Forms.PictureBox();
            this.dishDescription = new System.Windows.Forms.Label();
            this.dishPrice = new System.Windows.Forms.Label();
            this.dishIngredients = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.orderSummary = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(13, 9);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(73, 13);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "Группа меню";
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.Location = new System.Drawing.Point(16, 41);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(120, 95);
            this.groupsListBox.TabIndex = 1;
            // 
            // dishLabel
            // 
            this.dishLabel.AutoSize = true;
            this.dishLabel.Location = new System.Drawing.Point(13, 155);
            this.dishLabel.Name = "dishLabel";
            this.dishLabel.Size = new System.Drawing.Size(92, 13);
            this.dishLabel.TabIndex = 0;
            this.dishLabel.Text = "Выберите блюдо";
            // 
            // dishesComboBox
            // 
            this.dishesComboBox.FormattingEnabled = true;
            this.dishesComboBox.Location = new System.Drawing.Point(16, 187);
            this.dishesComboBox.Name = "dishesComboBox";
            this.dishesComboBox.Size = new System.Drawing.Size(121, 21);
            this.dishesComboBox.TabIndex = 2;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(13, 226);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(66, 13);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Количество";
            // 
            // quantitySelector
            // 
            this.quantitySelector.Location = new System.Drawing.Point(16, 243);
            this.quantitySelector.Name = "quantitySelector";
            this.quantitySelector.Size = new System.Drawing.Size(120, 20);
            this.quantitySelector.TabIndex = 3;
            // 
            // dishPicture
            // 
            this.dishPicture.Location = new System.Drawing.Point(201, 21);
            this.dishPicture.Name = "dishPicture";
            this.dishPicture.Size = new System.Drawing.Size(165, 115);
            this.dishPicture.TabIndex = 4;
            this.dishPicture.TabStop = false;
            // 
            // dishDescription
            // 
            this.dishDescription.AutoSize = true;
            this.dishDescription.Location = new System.Drawing.Point(198, 155);
            this.dishDescription.Name = "dishDescription";
            this.dishDescription.Size = new System.Drawing.Size(35, 13);
            this.dishDescription.TabIndex = 5;
            this.dishDescription.Text = "label1";
            // 
            // dishPrice
            // 
            this.dishPrice.AutoSize = true;
            this.dishPrice.Location = new System.Drawing.Point(198, 190);
            this.dishPrice.Name = "dishPrice";
            this.dishPrice.Size = new System.Drawing.Size(35, 13);
            this.dishPrice.TabIndex = 5;
            this.dishPrice.Text = "label1";
            // 
            // dishIngredients
            // 
            this.dishIngredients.AutoSize = true;
            this.dishIngredients.Location = new System.Drawing.Point(198, 226);
            this.dishIngredients.Name = "dishIngredients";
            this.dishIngredients.Size = new System.Drawing.Size(35, 13);
            this.dishIngredients.TabIndex = 5;
            this.dishIngredients.Text = "label1";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(16, 284);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Заказать";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // orderSummary
            // 
            this.orderSummary.Location = new System.Drawing.Point(16, 319);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(350, 137);
            this.orderSummary.TabIndex = 7;
            this.orderSummary.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(388, 468);
            this.Controls.Add(this.orderSummary);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.dishIngredients);
            this.Controls.Add(this.dishPrice);
            this.Controls.Add(this.dishDescription);
            this.Controls.Add(this.dishPicture);
            this.Controls.Add(this.quantitySelector);
            this.Controls.Add(this.dishesComboBox);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.dishLabel);
            this.Controls.Add(this.groupLabel);
            this.Name = "Form1";
            this.Text = "Ресторан";
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.Label dishLabel;
        private System.Windows.Forms.ComboBox dishesComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantitySelector;
        private System.Windows.Forms.PictureBox dishPicture;
        private System.Windows.Forms.Label dishDescription;
        private System.Windows.Forms.Label dishPrice;
        private System.Windows.Forms.Label dishIngredients;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.RichTextBox orderSummary;
    }
}

