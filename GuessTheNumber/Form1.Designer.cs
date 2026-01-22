namespace GuessTheNumber
{
    partial class GuessNumber
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
            this.countdownText = new System.Windows.Forms.Label();
            this.choosingNumberText = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.DateTimePicker();
            this.checkBtn = new System.Windows.Forms.Button();
            this.choosingNumber = new System.Windows.Forms.TextBox();
            this.statisticsOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // countdownText
            // 
            this.countdownText.AutoSize = true;
            this.countdownText.Location = new System.Drawing.Point(264, 36);
            this.countdownText.Name = "countdownText";
            this.countdownText.Size = new System.Drawing.Size(158, 21);
            this.countdownText.TabIndex = 0;
            this.countdownText.Text = "- обратный отсчет";
            // 
            // choosingNumberText
            // 
            this.choosingNumberText.AutoSize = true;
            this.choosingNumberText.Location = new System.Drawing.Point(45, 80);
            this.choosingNumberText.Name = "choosingNumberText";
            this.choosingNumberText.Size = new System.Drawing.Size(226, 21);
            this.choosingNumberText.TabIndex = 0;
            this.choosingNumberText.Text = "Введите число от 1 до 100:";
            // 
            // countdown
            // 
            this.countdown.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.countdown.Location = new System.Drawing.Point(49, 30);
            this.countdown.Name = "countdown";
            this.countdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countdown.Size = new System.Drawing.Size(200, 29);
            this.countdown.TabIndex = 1;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(338, 123);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(138, 34);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "Проверить";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // choosingNumber
            // 
            this.choosingNumber.Location = new System.Drawing.Point(277, 77);
            this.choosingNumber.Name = "choosingNumber";
            this.choosingNumber.Size = new System.Drawing.Size(145, 29);
            this.choosingNumber.TabIndex = 3;
            // 
            // statisticsOutput
            // 
            this.statisticsOutput.Location = new System.Drawing.Point(49, 177);
            this.statisticsOutput.Name = "statisticsOutput";
            this.statisticsOutput.Size = new System.Drawing.Size(427, 72);
            this.statisticsOutput.TabIndex = 4;
            this.statisticsOutput.Text = "";
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(538, 261);
            this.Controls.Add(this.statisticsOutput);
            this.Controls.Add(this.choosingNumber);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.choosingNumberText);
            this.Controls.Add(this.countdownText);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "GuessNumber";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countdownText;
        private System.Windows.Forms.Label choosingNumberText;
        private System.Windows.Forms.DateTimePicker countdown;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox choosingNumber;
        private System.Windows.Forms.RichTextBox statisticsOutput;
    }
}

