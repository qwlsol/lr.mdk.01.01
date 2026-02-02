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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupsDishLlistBox);
            this.Name = "MainForm";
            this.Text = "Ресторан";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox groupsDishLlistBox;
    }
}

