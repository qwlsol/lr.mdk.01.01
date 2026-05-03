using System.Windows.Forms;

namespace GeneratorTests
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbTopics;
        private ComboBox cmbDifficulty;  // НОВЫЙ элемент для сложности
        private NumericUpDown numQuestions;
        private NumericUpDown numVariants;
        private Button btnLoad;
        private Button btnGenerateTest;
        private Button btnGenerateVariants;
        private Button btnSaveWord;
        private Button btnEditQuestion;
        private Button btnStartTest;
        private Button btnSubmitAnswer;
        private Button btnFinishTest;
        private Button btnLoginTeacher;   // НОВАЯ кнопка
        private Button btnLoginStudent;   // НОВАЯ кнопка
        private ListBox listBoxQuestions;
        private Label lblStatus;
        private TextBox txtAnswer;
        private Label lblTopic;
        private Label lblDifficulty;      // НОВАЯ метка
        private Label lblQuestions;
        private Label lblVariants;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbTopics = new System.Windows.Forms.ComboBox();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.numQuestions = new System.Windows.Forms.NumericUpDown();
            this.numVariants = new System.Windows.Forms.NumericUpDown();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGenerateTest = new System.Windows.Forms.Button();
            this.btnGenerateVariants = new System.Windows.Forms.Button();
            this.btnSaveWord = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.btnFinishTest = new System.Windows.Forms.Button();
            this.btnLoginTeacher = new System.Windows.Forms.Button();
            this.btnLoginStudent = new System.Windows.Forms.Button();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.lblVariants = new System.Windows.Forms.Label();
            this.lableInput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariants)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTopics
            // 
            this.cmbTopics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTopics.Location = new System.Drawing.Point(80, 20);
            this.cmbTopics.Name = "cmbTopics";
            this.cmbTopics.Size = new System.Drawing.Size(120, 21);
            this.cmbTopics.TabIndex = 4;
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Все",
            "лёгкий",
            "средний",
            "сложный"});
            this.cmbDifficulty.Location = new System.Drawing.Point(290, 20);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(80, 21);
            this.cmbDifficulty.TabIndex = 5;
            // 
            // numQuestions
            // 
            this.numQuestions.Location = new System.Drawing.Point(460, 20);
            this.numQuestions.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuestions.Name = "numQuestions";
            this.numQuestions.Size = new System.Drawing.Size(60, 20);
            this.numQuestions.TabIndex = 6;
            this.numQuestions.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numVariants
            // 
            this.numVariants.Location = new System.Drawing.Point(610, 20);
            this.numVariants.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVariants.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVariants.Name = "numVariants";
            this.numVariants.Size = new System.Drawing.Size(60, 20);
            this.numVariants.TabIndex = 7;
            this.numVariants.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(240, 60);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 30);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGenerateTest
            // 
            this.btnGenerateTest.Location = new System.Drawing.Point(330, 60);
            this.btnGenerateTest.Name = "btnGenerateTest";
            this.btnGenerateTest.Size = new System.Drawing.Size(80, 30);
            this.btnGenerateTest.TabIndex = 11;
            this.btnGenerateTest.Text = "Тест";
            this.btnGenerateTest.Click += new System.EventHandler(this.btnGenerateTest_Click);
            // 
            // btnGenerateVariants
            // 
            this.btnGenerateVariants.Location = new System.Drawing.Point(420, 60);
            this.btnGenerateVariants.Name = "btnGenerateVariants";
            this.btnGenerateVariants.Size = new System.Drawing.Size(80, 30);
            this.btnGenerateVariants.TabIndex = 12;
            this.btnGenerateVariants.Text = "Варианты";
            this.btnGenerateVariants.Click += new System.EventHandler(this.btnGenerateVariants_Click);
            // 
            // btnSaveWord
            // 
            this.btnSaveWord.Location = new System.Drawing.Point(510, 60);
            this.btnSaveWord.Name = "btnSaveWord";
            this.btnSaveWord.Size = new System.Drawing.Size(80, 30);
            this.btnSaveWord.TabIndex = 13;
            this.btnSaveWord.Text = "Сохранить";
            this.btnSaveWord.Click += new System.EventHandler(this.btnSaveWord_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(600, 60);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(80, 30);
            this.btnEditQuestion.TabIndex = 14;
            this.btnEditQuestion.Text = "Ред.";
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(20, 440);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(100, 30);
            this.btnStartTest.TabIndex = 15;
            this.btnStartTest.Text = "Начать тест";
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(130, 440);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(100, 30);
            this.btnSubmitAnswer.TabIndex = 16;
            this.btnSubmitAnswer.Text = "Ответить";
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // btnFinishTest
            // 
            this.btnFinishTest.Location = new System.Drawing.Point(240, 440);
            this.btnFinishTest.Name = "btnFinishTest";
            this.btnFinishTest.Size = new System.Drawing.Size(100, 30);
            this.btnFinishTest.TabIndex = 17;
            this.btnFinishTest.Text = "Завершить";
            this.btnFinishTest.Click += new System.EventHandler(this.btnFinishTest_Click);
            // 
            // btnLoginTeacher
            // 
            this.btnLoginTeacher.Location = new System.Drawing.Point(20, 60);
            this.btnLoginTeacher.Name = "btnLoginTeacher";
            this.btnLoginTeacher.Size = new System.Drawing.Size(100, 30);
            this.btnLoginTeacher.TabIndex = 8;
            this.btnLoginTeacher.Text = "Вход (учитель)";
            this.btnLoginTeacher.Click += new System.EventHandler(this.btnLoginTeacher_Click);
            // 
            // btnLoginStudent
            // 
            this.btnLoginStudent.Location = new System.Drawing.Point(130, 60);
            this.btnLoginStudent.Name = "btnLoginStudent";
            this.btnLoginStudent.Size = new System.Drawing.Size(100, 30);
            this.btnLoginStudent.TabIndex = 9;
            this.btnLoginStudent.Text = "Вход (студент)";
            this.btnLoginStudent.Click += new System.EventHandler(this.btnLoginStudent_Click);
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.Font = new System.Drawing.Font("Courier New", 9F);
            this.listBoxQuestions.ItemHeight = 15;
            this.listBoxQuestions.Location = new System.Drawing.Point(20, 100);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(660, 319);
            this.listBoxQuestions.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(20, 480);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(660, 40);
            this.lblStatus.TabIndex = 20;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAnswer.Location = new System.Drawing.Point(552, 441);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(128, 29);
            this.txtAnswer.TabIndex = 19;
            // 
            // lblTopic
            // 
            this.lblTopic.Location = new System.Drawing.Point(20, 22);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(50, 20);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "Тема:";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Location = new System.Drawing.Point(220, 22);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(70, 20);
            this.lblDifficulty.TabIndex = 1;
            this.lblDifficulty.Text = "Сложность:";
            // 
            // lblQuestions
            // 
            this.lblQuestions.Location = new System.Drawing.Point(390, 22);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(70, 20);
            this.lblQuestions.TabIndex = 2;
            this.lblQuestions.Text = "Вопросов:";
            // 
            // lblVariants
            // 
            this.lblVariants.Location = new System.Drawing.Point(540, 22);
            this.lblVariants.Name = "lblVariants";
            this.lblVariants.Size = new System.Drawing.Size(70, 20);
            this.lblVariants.TabIndex = 3;
            this.lblVariants.Text = "Вариантов:";
            // 
            // lableInput
            // 
            this.lableInput.AutoSize = true;
            this.lableInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableInput.Location = new System.Drawing.Point(433, 448);
            this.lableInput.Name = "lableInput";
            this.lableInput.Size = new System.Drawing.Size(113, 18);
            this.lableInput.TabIndex = 21;
            this.lableInput.Text = "Введите ответ:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 540);
            this.Controls.Add(this.lableInput);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.lblVariants);
            this.Controls.Add(this.cmbTopics);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.numQuestions);
            this.Controls.Add(this.numVariants);
            this.Controls.Add(this.btnLoginTeacher);
            this.Controls.Add(this.btnLoginStudent);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnGenerateTest);
            this.Controls.Add(this.btnGenerateVariants);
            this.Controls.Add(this.btnSaveWord);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.btnFinishTest);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.listBoxQuestions);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для создания тестов";
            ((System.ComponentModel.ISupportInitialize)(this.numQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lableInput;
    }
}