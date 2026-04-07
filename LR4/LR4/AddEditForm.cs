using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public partial class AddEditForm : Form
    {
        private Exhibition editingExhibition;

        public AddEditForm(Exhibition exhibition = null)
        {
            InitializeComponent();
            editingExhibition = exhibition;

            if (editingExhibition != null)
            {
                Text = "Редактирование выставки";
                textBoxPlace.Text = editingExhibition.Place;
                dateTimePickerDateTime.Value = editingExhibition.DateAndTime;
                textBoxPerformer.Text = editingExhibition.Performer;
                numericUpDownCost.Value = editingExhibition.Cost;
            }
            else
            {
                Text = "Добавление выставки";
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPlace.Text))
            {
                MessageBox.Show("Введите место проведения!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPerformer.Text))
            {
                MessageBox.Show("Введите исполнителя!");
                return;
            }

            if (editingExhibition != null)
            {
                editingExhibition.Place = textBoxPlace.Text;
                editingExhibition.DateAndTime = dateTimePickerDateTime.Value;
                editingExhibition.Performer = textBoxPerformer.Text;
                editingExhibition.Cost = numericUpDownCost.Value;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}


