using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperProject.Models
{
    public class Question
    {
        private string text_;
        private string topic_;
        private string correctAnswer_;
        private DifficultiLevel difficulty_;

        public Question(string text, string topic, string correctAnswer, DifficultiLevel difficulty)
        {
            text_ = text;
            topic_ = topic;
            correctAnswer_ = correctAnswer;
            difficulty_ = difficulty;
        }
        public string Text
        {
            get { return text_; }
        }
        public string Topic
        {
            get { return topic_; }
        }
        public string CForrectAnswer
        {
            get { return correctAnswer_; }
        }
    }    
}
