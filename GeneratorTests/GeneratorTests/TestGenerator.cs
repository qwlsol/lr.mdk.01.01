using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorTests
{
    public class TestGenerator
    {
        private List<Question> _allQuestions = new List<Question>();
        private Random _random = new Random();
        private int _nextId = 1;

        public bool LoadFromFile(string path)
        {
            try
            {
                _allQuestions.Clear();
                _nextId = 1;

                string[] lines = File.ReadAllLines(path);

                if (lines.Length == 0)
                {
                    MessageBox.Show("Файл пуст. Добавьте вопросы.");
                    return false;
                }

                string currentTopic = "";
                string currentText = "";
                string currentCorrect = "";
                string currentDifficulty = "";
                string currentType = "одиночный";
                List<string> currentOptions = new List<string>();

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i].Trim();

                    if (line == "")
                    {
                        if (currentText != "")
                        {
                            SaveQuestion(currentTopic, currentText, currentCorrect, 
                                currentDifficulty, currentType, currentOptions);
                            currentText = "";
                            currentTopic = "";
                            currentCorrect = "";
                            currentDifficulty = "";
                            currentType = "одиночный";
                            currentOptions = new List<string>();
                        }
                        continue;
                    }

                    if (line.StartsWith("Тема:"))
                    {
                        currentTopic = line.Substring(5).Trim();
                    }
                    else if (line.StartsWith("Вопрос:"))
                    {
                        currentText = line.Substring(7).Trim();
                    }
                    else if (line.StartsWith("Варианты:"))
                    {
                        string opts = line.Substring(9).Trim();
                        if (opts != "")
                        {
                            string[] parts = opts.Split(';');
                            currentOptions = new List<string>();
                            foreach (string p in parts)
                            {
                                currentOptions.Add(p.Trim());
                            }
                        }
                    }
                    else if (line.StartsWith("Правильный ответ:"))
                    {
                        currentCorrect = line.Substring(18).Trim();
                    }
                    else if (line.StartsWith("Тип:"))
                    {
                        currentType = line.Substring(4).Trim();
                    }
                    else if (line.StartsWith("Сложность:"))
                    {
                        currentDifficulty = line.Substring(10).Trim();
                    }
                }

                if (currentText != "")
                {
                    SaveQuestion(currentTopic, currentText, currentCorrect,
                        currentDifficulty, currentType, currentOptions);
                }

                MessageBox.Show("Загружено " + _allQuestions.Count + " вопросов");

                if (_allQuestions.Count == 0)
                {
                    MessageBox.Show("Не удалось загрузить ни одного вопроса. Проверьте формат файла.");
                    return false;
                }

                return true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден. Проверьте путь.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                return false;
            }
        }

        private void SaveQuestion(string topic, string text, string correct, string difficulty, string type, List<string> options)
        {
            QuestionType qt = QuestionType.Single;
            if (type == "множественный")
                qt = QuestionType.Multiple;
            else if (type == "текстовый")
                qt = QuestionType.Text;

            Question q = new Question(_nextId, text, topic, difficulty, correct, options, qt);
            _allQuestions.Add(q);
            _nextId++;
        }

        public List<string> GetTopics()
        {
            List<string> topics = new List<string>();

            foreach (Question q in _allQuestions)
            {
                bool found = false;
                foreach (string t in topics)
                {
                    if (t == q.Topic)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    topics.Add(q.Topic);
                }
            }

            return topics;
        }

        public List<Question> GetQuestionsByTopic(string topic)
        {
            List<Question> result = new List<Question>();
            foreach (Question q in _allQuestions)
            {
                if (q.Topic == topic)
                {
                    result.Add(q);
                }
            }
            return result;
        }

        public List<Test> GenerateVariants(string tema, int kolichestvoVariants, int voprosovVVariante)
        {
            List<Question> available = GetQuestionsByTopic(tema);
            int totalNeeded = kolichestvoVariants * voprosovVVariante;

            if (available.Count < totalNeeded)
            {
                MessageBox.Show("Ошибка! Для создания " + kolichestvoVariants + " вариантов по " + voprosovVVariante +
                               " вопросов требуется " + totalNeeded + " уникальных вопросов. " +
                               "В теме \"" + tema + "\" доступно только " + available.Count + ". Создание невозможно.");
                return new List<Test>();
            }

            List<Question> tempPool = new List<Question>();
            foreach (Question q in available)
            {
                tempPool.Add(q);
            }

            List<Test> variants = new List<Test>();

            for (int v = 0; v < kolichestvoVariants; v++)
            {
                List<Question> variantQuestions = new List<Question>();

                for (int q = 0; q < voprosovVVariante; q++)
                {
                    int idx = _random.Next(0, tempPool.Count);
                    variantQuestions.Add(tempPool[idx]);
                    tempPool.RemoveAt(idx);
                }

                variants.Add(new Test(v + 1, "Вариант " + (v + 1), variantQuestions));
            }

            return variants;
        }
    }
}
