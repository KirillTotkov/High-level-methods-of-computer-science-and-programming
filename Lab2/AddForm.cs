namespace Lab2
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string academicDegree = txtAcademicDegree.Text;
            string programmingLangs = txtProgrammingLangs.Text;
            string developmentEnvironments = txtDevelopmentEnvironments.Text;
            string technologyStack = txtTechnologyStack.Text;

            MainForm.teachers.Add(new Teacher(fullName, academicDegree, programmingLangs, developmentEnvironments,
                technologyStack));
        }
    }
}