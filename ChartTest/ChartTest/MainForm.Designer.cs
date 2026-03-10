using ChartTest.Views;

namespace ChartTest
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.solid = new LiveCharts.WinForms.SolidGauge();
            this.angular = new LiveCharts.WinForms.AngularGauge();
            this.ItemsList = new System.Windows.Forms.ListBox();
            this.pieChart = new ChartTest.Views.SalesPieChart();
            this.cartesian = new ChartTest.Views.SalesCartesianChart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1173, 735);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.ItemsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1165, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cartesian);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(123, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 703);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.angular);
            this.panel1.Controls.Add(this.pieChart);
            this.panel1.Controls.Add(this.solid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1026, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 703);
            this.panel1.TabIndex = 5;
            // 
            // solid
            // 
            this.solid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.solid.Location = new System.Drawing.Point(0, 598);
            this.solid.Name = "solid";
            this.solid.Size = new System.Drawing.Size(136, 105);
            this.solid.TabIndex = 3;
            // 
            // angular
            // 
            this.angular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angular.Location = new System.Drawing.Point(0, 89);
            this.angular.Name = "angular";
            this.angular.Size = new System.Drawing.Size(136, 509);
            this.angular.TabIndex = 4;
            // 
            // ItemsList
            // 
            this.ItemsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(3, 3);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(120, 703);
            this.ItemsList.TabIndex = 1;
            this.ItemsList.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            // 
            // pieChart
            // 
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pieChart.Location = new System.Drawing.Point(0, 0);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(136, 89);
            this.pieChart.TabIndex = 2;
            // 
            // cartesian
            // 
            this.cartesian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesian.Location = new System.Drawing.Point(0, 0);
            this.cartesian.Name = "cartesian";
            this.cartesian.Size = new System.Drawing.Size(903, 703);
            this.cartesian.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 735);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "LiveCharts-диаграммы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private LiveCharts.WinForms.AngularGauge angular;
        private LiveCharts.WinForms.SolidGauge solid;
        private SalesPieChart pieChart;
        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private SalesCartesianChart cartesian;
    }
}

