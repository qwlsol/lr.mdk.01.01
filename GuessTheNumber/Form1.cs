using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class GuessNumber : Form
    {
        int secretNum;
        public GuessNumber()
        {
            InitializeComponent();
            Random rnd = new Random();
            secretNum = rnd.Next(1, 101);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            string number = choosingNumber.Text;
            int myNum = Convert.ToInt32(number);

            if (secretNum < myNum) 
            {
                MessageBox.Show("Вы не угадали! Введите число меньше.");
            }
            else if (secretNum > myNum)
            {
                MessageBox.Show("Вы не угадали! Введите число больше.");
            }
            else 
            {
                MessageBox.Show("Число было угадано!");
            }
        }
    }
}
