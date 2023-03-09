namespace Lab2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnOpenAddForm = new Button();
            button2 = new Button();
            btnRemoveItem = new Button();
            groupBox1 = new GroupBox();
            teachersDataGridView = new DataGridView();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            academicDegreeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ProgrammingLanguages = new DataGridViewTextBoxColumn();
            teacherBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            importStripMenu = new ToolStripMenuItem();
            cSVToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            exportStripMenu = new ToolStripMenuItem();
            cSVToolStripMenuItem1 = new ToolStripMenuItem();
            xMLToolStripMenuItem1 = new ToolStripMenuItem();
            jSONToolStripMenuItem1 = new ToolStripMenuItem();
            DevelopmentEnvironments = new DataGridViewTextBoxColumn();
            TechnologyStack = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenAddForm
            // 
            btnOpenAddForm.Location = new Point(6, 26);
            btnOpenAddForm.Name = "btnOpenAddForm";
            btnOpenAddForm.Size = new Size(94, 29);
            btnOpenAddForm.TabIndex = 0;
            btnOpenAddForm.Text = "Добавить";
            btnOpenAddForm.UseVisualStyleBackColor = true;
            btnOpenAddForm.Click += btnOpenAddForm_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(6, 96);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(94, 29);
            btnRemoveItem.TabIndex = 2;
            btnRemoveItem.Text = "Удалить";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOpenAddForm);
            groupBox1.Controls.Add(btnRemoveItem);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(776, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 133);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия";
            // 
            // teachersDataGridView
            // 
            teachersDataGridView.AllowUserToAddRows = false;
            teachersDataGridView.AllowUserToDeleteRows = false;
            teachersDataGridView.AutoGenerateColumns = false;
            teachersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            teachersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teachersDataGridView.Columns.AddRange(new DataGridViewColumn[] { fullNameDataGridViewTextBoxColumn, academicDegreeDataGridViewTextBoxColumn, ProgrammingLanguages, DevelopmentEnvironments, TechnologyStack });
            teachersDataGridView.DataSource = teacherBindingSource;
            teachersDataGridView.Location = new Point(66, 170);
            teachersDataGridView.Name = "teachersDataGridView";
            teachersDataGridView.ReadOnly = true;
            teachersDataGridView.RowHeadersWidth = 51;
            teachersDataGridView.RowTemplate.Height = 29;
            teachersDataGridView.Size = new Size(917, 393);
            teachersDataGridView.TabIndex = 4;
            teachersDataGridView.CellDoubleClick += teachersDataGridView_CellDoubleClick;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            fullNameDataGridViewTextBoxColumn.Width = 71;
            // 
            // academicDegreeDataGridViewTextBoxColumn
            // 
            academicDegreeDataGridViewTextBoxColumn.DataPropertyName = "AcademicDegree";
            academicDegreeDataGridViewTextBoxColumn.HeaderText = "Ученая степень";
            academicDegreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            academicDegreeDataGridViewTextBoxColumn.Name = "academicDegreeDataGridViewTextBoxColumn";
            academicDegreeDataGridViewTextBoxColumn.ReadOnly = true;
            academicDegreeDataGridViewTextBoxColumn.Width = 135;
            // 
            // ProgrammingLanguages
            // 
            ProgrammingLanguages.DataPropertyName = "ProgrammingLanguages";
            ProgrammingLanguages.HeaderText = "Языки программирования";
            ProgrammingLanguages.MinimumWidth = 6;
            ProgrammingLanguages.Name = "ProgrammingLanguages";
            ProgrammingLanguages.ReadOnly = true;
            ProgrammingLanguages.Width = 206;
            // 
            // teacherBindingSource
            // 
            teacherBindingSource.DataSource = typeof(Teacher);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { importStripMenu, exportStripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1067, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // importStripMenu
            // 
            importStripMenu.DropDownItems.AddRange(new ToolStripItem[] { cSVToolStripMenuItem, xMLToolStripMenuItem, jSONToolStripMenuItem });
            importStripMenu.Name = "importStripMenu";
            importStripMenu.Size = new Size(69, 24);
            importStripMenu.Text = "Иморт";
            // 
            // cSVToolStripMenuItem
            // 
            cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            cSVToolStripMenuItem.Size = new Size(127, 26);
            cSVToolStripMenuItem.Text = "CSV";
            cSVToolStripMenuItem.Click += csvToolStripMenuItem_Click;
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(127, 26);
            xMLToolStripMenuItem.Text = "XML";
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(127, 26);
            jSONToolStripMenuItem.Text = "JSON";
            // 
            // exportStripMenu
            // 
            exportStripMenu.DropDownItems.AddRange(new ToolStripItem[] { cSVToolStripMenuItem1, xMLToolStripMenuItem1, jSONToolStripMenuItem1 });
            exportStripMenu.Name = "exportStripMenu";
            exportStripMenu.Size = new Size(79, 24);
            exportStripMenu.Text = "Экспорт";
            // 
            // cSVToolStripMenuItem1
            // 
            cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            cSVToolStripMenuItem1.Size = new Size(127, 26);
            cSVToolStripMenuItem1.Text = "CSV";
            // 
            // xMLToolStripMenuItem1
            // 
            xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            xMLToolStripMenuItem1.Size = new Size(127, 26);
            xMLToolStripMenuItem1.Text = "XML";
            // 
            // jSONToolStripMenuItem1
            // 
            jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            jSONToolStripMenuItem1.Size = new Size(127, 26);
            jSONToolStripMenuItem1.Text = "JSON";
            // 
            // DevelopmentEnvironments
            // 
            DevelopmentEnvironments.DataPropertyName = "DevelopmentEnvironments";
            DevelopmentEnvironments.HeaderText = "Среды разработки";
            DevelopmentEnvironments.MinimumWidth = 6;
            DevelopmentEnvironments.Name = "DevelopmentEnvironments";
            DevelopmentEnvironments.ReadOnly = true;
            DevelopmentEnvironments.Width = 154;
            // 
            // TechnologyStack
            // 
            TechnologyStack.DataPropertyName = "TechnologyStack";
            TechnologyStack.HeaderText = "Стек технологий";
            TechnologyStack.MinimumWidth = 6;
            TechnologyStack.Name = "TechnologyStack";
            TechnologyStack.ReadOnly = true;
            TechnologyStack.Width = 139;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 575);
            Controls.Add(teachersDataGridView);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Activated += MainForm_Activated;
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teachersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenAddForm;
        private Button button2;
        private Button btnRemoveItem;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem importStripMenu;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem jSONToolStripMenuItem;
        private ToolStripMenuItem exportStripMenu;
        private ToolStripMenuItem cSVToolStripMenuItem1;
        private ToolStripMenuItem xMLToolStripMenuItem1;
        private ToolStripMenuItem jSONToolStripMenuItem1;
        public BindingSource teacherBindingSource;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn academicDegreeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProgrammingLanguages;
        private DataGridView teachersDataGridView;
        private DataGridViewTextBoxColumn DevelopmentEnvironments;
        private DataGridViewTextBoxColumn TechnologyStack;
    }
}