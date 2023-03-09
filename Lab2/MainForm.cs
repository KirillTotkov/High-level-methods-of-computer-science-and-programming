using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public static List<Teacher> teachers = new List<Teacher>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            teacherBindingSource.DataSource = teachers;
            teachersDataGridView.DataSource = teacherBindingSource;
            teacherBindingSource.ResetBindings(false);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            teacherBindingSource.ResetBindings(false);
        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Encoding = Encoding.UTF8,
                    Delimiter = ";",
                    HeaderValidated = null,
                };

                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                using (CsvReader reader = new CsvReader(sr, config))
                {
                    teachers = reader.GetRecords<Teacher>().ToList();
                    teacherBindingSource.DataSource = teachers;
                    //teacherBindingSource.ResetBindings(false);
                }
            }
        }

        private void btnOpenAddForm_Click(object sender, EventArgs e)
        {
            AddForm infoForm = new AddForm();
            infoForm.ShowDialog();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in teachersDataGridView.SelectedRows)
            {
                teachersDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
        }


        private void teachersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Teacher selectedTeacher = (Teacher)teachersDataGridView.Rows[e.RowIndex].DataBoundItem;
                EditForm editForm = new EditForm(selectedTeacher, e.RowIndex);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }
    }
}