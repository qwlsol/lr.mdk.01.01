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
    public partial class TableForm : Form
    {
        private PgExhibitionsLoader exhibitionsLoader = new PgExhibitionsLoader();

        public TableForm()
        {
            InitializeComponent();
            LoadExhibitions();
        }

        private void LoadExhibitions()
        {
            var exhibitions = exhibitionsLoader.Load();
            dataGridViewExhibitions.DataSource = exhibitions;
            dataGridViewExhibitions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEditForm addForm = new AddEditForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Для добавления нужно создать временный объект с данными из формы
                var tempExhibition = new Exhibition
                {
                    Place = addForm.Controls["textBoxPlace"].Text,
                    DateAndTime = (DateTime)(addForm.Controls["dateTimePickerDateTime"] as DateTimePicker).Value,
                    Performer = addForm.Controls["textBoxPerformer"].Text,
                    Cost = (decimal)(addForm.Controls["numericUpDownCost"] as NumericUpDown).Value
                };

                exhibitionsLoader.AddExhibition(tempExhibition.Place, tempExhibition.DateAndTime,
                                               tempExhibition.Performer, tempExhibition.Cost);
                LoadExhibitions();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewExhibitions.SelectedRows.Count > 0)
            {
                Exhibition selectedExhibition = dataGridViewExhibitions.SelectedRows[0].DataBoundItem as Exhibition;

                AddEditForm editForm = new AddEditForm(selectedExhibition);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    exhibitionsLoader.UpdateExhibition(selectedExhibition, selectedExhibition);
                    LoadExhibitions();
                }
                else
                {
                    MessageBox.Show("Изменения не были применены.");
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования!");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewExhibitions.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Удалить выбранные выставки?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewExhibitions.SelectedRows)
                    {
                        Exhibition exhibition = row.DataBoundItem as Exhibition;
                        if (exhibition != null)
                        {
                            exhibitionsLoader.DeleteExhibition(exhibition.Place, exhibition.DateAndTime);
                        }
                    }
                    LoadExhibitions();
                }
            }
            else
            {
                MessageBox.Show("Выберите записи для удаления!");
            }
        }
    }
    
}


