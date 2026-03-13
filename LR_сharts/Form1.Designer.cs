namespace LR_сharts
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
            this.listBoxDrinks = new System.Windows.Forms.ListBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDrinks
            // 
            this.listBoxDrinks.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxDrinks.FormattingEnabled = true;
            this.listBoxDrinks.Location = new System.Drawing.Point(0, 0);
            this.listBoxDrinks.Name = "listBoxDrinks";
            this.listBoxDrinks.Size = new System.Drawing.Size(134, 450);
            this.listBoxDrinks.TabIndex = 0;
            this.listBoxDrinks.SelectedIndexChanged += new System.EventHandler(this.listBoxDrinks_SelectedIndexChanged);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(666, 212);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cartesianChart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(134, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 212);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pieChart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(134, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 230);
            this.panel2.TabIndex = 3;
            // 
            // pieChart
            // 
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart.Location = new System.Drawing.Point(0, 0);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(666, 230);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxDrinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDrinks;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LiveCharts.WinForms.PieChart pieChart;
    }
}

