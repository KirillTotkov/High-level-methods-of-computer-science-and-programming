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
            string mess = $"<h1>������</h1>" +
                          $"<p> <b>���</b>: {tbFullName.Text} </p>" +
                          $"<p> <b>���� ��������</b>: {dateTimePicker1.Value.ToShortDateString()} </p>" +
                          $"<p> <b>���� �������</b>: {cbZodiac.Text} </p>" +
                          $"<p> <b>������� �����</b>: {tbFood.Text} </p>" +
                          $"<p> <b>������� ����������� ������</b>: {tbMusicGroup.Text} </p>" +
                          $"<p> <b>�����������</b>: {(checkBox1.Checked ? "��" : "���")} </p>" +
                          $"<p> <b>������� �����</b>: {textBox3.Text} </p>" +
                          $"<p> <b>����� ��� ��������� ���������</b>: {comboBox2.Text} </p>" +
                          $"<p> <b>����������</b>: " +
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
                        errorProvider1.SetError(tb, "����������, ������� ��������");
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