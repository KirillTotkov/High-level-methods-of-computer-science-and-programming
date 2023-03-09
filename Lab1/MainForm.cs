using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbZodiac.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void MoveSelectedItems(ListBox listBoxFrom, ListBox listBoxTo)
        {
            for (int i = listBoxFrom.SelectedItems.Count - 1; i >= 0; i--)
            {
                int index = listBoxFrom.SelectedIndices[i];
                listBoxTo.Items.Add(listBoxFrom.Items[index]);
                listBoxFrom.Items.RemoveAt(index);
            }
        }

        private void btnAddSuper_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstSuperheroesFrom, lstSuperheroesTo);
        }

        private void btnRemoveSuper_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstSuperheroesTo, lstSuperheroesFrom);
        }

        private void btnSaveForm_Click(object sender, EventArgs e)
        {
            string mess = $"<h1>Анкета</h1>" +
                          $"<p> <b>ФИО</b>: {tbFullName.Text} </p>" +
                          $"<p> <b>Дата рождения</b>: {dateTimePicker1.Value.ToShortDateString()} </p>" +
                          $"<p> <b>Знак зодиака</b>: {cbZodiac.Text} </p>" +
                          $"<p> <b>Любимое блюдо</b>: {tbFood.Text} </p>" +
                          $"<p> <b>Любимая музыкальная группа</b>: {tbMusicGroup.Text} </p>" +
                          $"<p> <b>Гуманитарий</b>: {(checkBox1.Checked ? "Да" : "Нет")} </p>" +
                          $"<p> <b>Любимая книга</b>: {textBox3.Text} </p>" +
                          $"<p> <b>Фильм для вечернего просмотра</b>: {comboBox2.Text} </p>" +
                          $"<p> <b>Супергерои</b>: " +
                          $"{String.Join(", ", lstSuperheroesTo.Items.Cast<object>().ToArray())} <p>";

            if (CheckTextBoxes())
            {
                Mail.SendEmailFromMailRu("k.totkov@yandex.ru", "Test 3", mess);
            }
        }

        private bool CheckTextBoxes()
        {
            bool allValid = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (String.IsNullOrWhiteSpace(tb.Text))
                    {
                        errorProvider1.SetError(tb, "Пожалуйста, введите значение");
                        allValid = false;
                    }
                    else
                    {
                        errorProvider1.SetError(tb, "");
                    }
                }
            }

            return allValid;
        }

        private void btnOpenPythagoreanSquare_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            PythagoreanSquareForm form = new PythagoreanSquareForm(date);
            form.ShowDialog();
        }
    }
}