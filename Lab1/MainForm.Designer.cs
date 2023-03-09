namespace Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label8 = new Label();
            tbFullName = new TextBox();
            tbFood = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cbZodiac = new ComboBox();
            tbMusicGroup = new TextBox();
            comboBox2 = new ComboBox();
            lstSuperheroesFrom = new ListBox();
            lstSuperheroesTo = new ListBox();
            btnAddSuper = new Button();
            btnRemoveSuper = new Button();
            label9 = new Label();
            btnSaveForm = new Button();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 40);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 0;
            label1.Text = "ФИО друга";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 88);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 1;
            label2.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 136);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 2;
            label3.Text = "Знак зодиака";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 184);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 3;
            label4.Text = "Любимое блюдо";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 232);
            label5.Name = "label5";
            label5.Size = new Size(252, 23);
            label5.TabIndex = 4;
            label5.Text = "Любимая музыкальная группа";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 332);
            label7.Name = "label7";
            label7.Size = new Size(134, 23);
            label7.TabIndex = 6;
            label7.Text = "Любимая книга";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(58, 280);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(215, 27);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Я полный гуманитарий";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 428);
            label6.Name = "label6";
            label6.Size = new Size(365, 23);
            label6.TabIndex = 8;
            label6.Text = "Супергерои, которые могут тебе понравится";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 380);
            label8.Name = "label8";
            label8.Size = new Size(273, 23);
            label8.TabIndex = 9;
            label8.Text = "Фильм для вечернего просмотра";
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(379, 40);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(356, 30);
            tbFullName.TabIndex = 1;
            // 
            // tbFood
            // 
            tbFood.Location = new Point(379, 181);
            tbFood.Name = "tbFood";
            tbFood.Size = new Size(356, 30);
            tbFood.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(379, 332);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(356, 30);
            textBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(379, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(356, 30);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2000, 12, 6, 0, 0, 0, 0);
            // 
            // cbZodiac
            // 
            cbZodiac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbZodiac.FormattingEnabled = true;
            cbZodiac.Items.AddRange(new object[] { "Овен", "Телец", "Близнецы", "Рак ", "Лев ", "Дева ", "Весы ", "Скорпион ", "Стрелец ", "Козерог ", "Водолей ", "Рыбы" });
            cbZodiac.Location = new Point(380, 136);
            cbZodiac.Name = "cbZodiac";
            cbZodiac.Size = new Size(355, 31);
            cbZodiac.TabIndex = 3;
            // 
            // tbMusicGroup
            // 
            tbMusicGroup.Location = new Point(379, 232);
            tbMusicGroup.Name = "tbMusicGroup";
            tbMusicGroup.Size = new Size(356, 30);
            tbMusicGroup.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Зеленая миля", "Побег из Шоушенка", "Форрест Гамп", "Тайна Коко", "Интерстеллар", "Король Лев", "Бойцовский клуб", "Темный рыцарь" });
            comboBox2.Location = new Point(378, 380);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(357, 31);
            comboBox2.TabIndex = 8;
            // 
            // lstSuperheroesFrom
            // 
            lstSuperheroesFrom.AllowDrop = true;
            lstSuperheroesFrom.FormattingEnabled = true;
            lstSuperheroesFrom.ItemHeight = 23;
            lstSuperheroesFrom.Items.AddRange(new object[] { "Черная пантера", "Бэтмен ", "Зеленый фонарь", "Человек-муравей", "Соколиный глаз", "Чудо-женщина" });
            lstSuperheroesFrom.Location = new Point(58, 478);
            lstSuperheroesFrom.Name = "lstSuperheroesFrom";
            lstSuperheroesFrom.SelectionMode = SelectionMode.MultiSimple;
            lstSuperheroesFrom.Size = new Size(273, 188);
            lstSuperheroesFrom.TabIndex = 9;
            // 
            // lstSuperheroesTo
            // 
            lstSuperheroesTo.AllowDrop = true;
            lstSuperheroesTo.FormattingEnabled = true;
            lstSuperheroesTo.ItemHeight = 23;
            lstSuperheroesTo.Location = new Point(424, 478);
            lstSuperheroesTo.Name = "lstSuperheroesTo";
            lstSuperheroesTo.SelectionMode = SelectionMode.MultiSimple;
            lstSuperheroesTo.Size = new Size(273, 188);
            lstSuperheroesTo.TabIndex = 11;
            // 
            // btnAddSuper
            // 
            btnAddSuper.Cursor = Cursors.Hand;
            btnAddSuper.Location = new Point(346, 512);
            btnAddSuper.Name = "btnAddSuper";
            btnAddSuper.Size = new Size(63, 35);
            btnAddSuper.TabIndex = 10;
            btnAddSuper.Text = ">>";
            btnAddSuper.UseVisualStyleBackColor = true;
            btnAddSuper.Click += btnAddSuper_Click;
            // 
            // btnRemoveSuper
            // 
            btnRemoveSuper.Cursor = Cursors.Hand;
            btnRemoveSuper.Location = new Point(346, 586);
            btnRemoveSuper.Name = "btnRemoveSuper";
            btnRemoveSuper.Size = new Size(63, 35);
            btnRemoveSuper.TabIndex = 12;
            btnRemoveSuper.Text = "<<";
            btnRemoveSuper.UseVisualStyleBackColor = true;
            btnRemoveSuper.Click += btnRemoveSuper_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(483, 428);
            label9.Name = "label9";
            label9.Size = new Size(0, 23);
            label9.TabIndex = 15;
            // 
            // btnSaveForm
            // 
            btnSaveForm.Cursor = Cursors.Hand;
            btnSaveForm.Location = new Point(512, 687);
            btnSaveForm.Name = "btnSaveForm";
            btnSaveForm.Size = new Size(117, 37);
            btnSaveForm.TabIndex = 14;
            btnSaveForm.Text = "Сохранить";
            btnSaveForm.UseVisualStyleBackColor = true;
            btnSaveForm.Click += btnSaveForm_Click;
            // 
            // button1
            // 
            button1.Location = new Point(89, 687);
            button1.Name = "button1";
            button1.Size = new Size(242, 37);
            button1.TabIndex = 13;
            button1.Text = "Расчёт Квадрата Пифагора ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 756);
            Controls.Add(button1);
            Controls.Add(btnSaveForm);
            Controls.Add(label9);
            Controls.Add(btnRemoveSuper);
            Controls.Add(btnAddSuper);
            Controls.Add(lstSuperheroesTo);
            Controls.Add(lstSuperheroesFrom);
            Controls.Add(comboBox2);
            Controls.Add(tbMusicGroup);
            Controls.Add(cbZodiac);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(tbFood);
            Controls.Add(tbFullName);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Анкета";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private CheckBox checkBox1;
        private Label label6;
        private Label label8;
        private TextBox tbFullName;
        private TextBox tbFood;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbZodiac;
        private TextBox tbMusicGroup;
        private ComboBox comboBox2;
        private ListBox lstSuperheroesFrom;
        private ListBox lstSuperheroesTo;
        private Button btnAddSuper;
        private Button btnRemoveSuper;
        private Label label9;
        private Button btnSaveForm;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}