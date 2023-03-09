using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class EditForm : Form
    {
        private Teacher teacher;
        private int teacherIndex;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Teacher teacher, int idx)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.teacherIndex = idx;
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            if (teacher != null)
            {
                txtFullName.Text = teacher.FullName;
                txtAcademicDegree.Text = teacher.AcademicDegree;
                txtProgrammingLangs.Text = teacher.ProgrammingLanguages;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            teacher.FullName = txtFullName.Text;
            teacher.AcademicDegree = txtAcademicDegree.Text;
            teacher.ProgrammingLanguages = txtProgrammingLangs.Text;
            teacher.DevelopmentEnvironments = txtDevelopmentEnvironments.Text;
            teacher.TechnologyStack = txtTechnologyStack.Text;

            MainForm.teachers[teacherIndex] = teacher;
        }
    }
}