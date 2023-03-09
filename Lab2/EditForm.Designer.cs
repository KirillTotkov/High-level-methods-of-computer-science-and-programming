namespace Lab2
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtTechnologyStack = new TextBox();
            txtAcademicDegree = new TextBox();
            txtProgrammingLangs = new TextBox();
            txtDevelopmentEnvironments = new TextBox();
            txtFullName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            btnСancel = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTechnologyStack);
            panel1.Controls.Add(txtAcademicDegree);
            panel1.Controls.Add(txtProgrammingLangs);
            panel1.Controls.Add(txtDevelopmentEnvironments);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 227);
            panel1.TabIndex = 0;
            // 
            // txtTechnologyStack
            // 
            txtTechnologyStack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTechnologyStack.Location = new Point(299, 170);
            txtTechnologyStack.Name = "txtTechnologyStack";
            txtTechnologyStack.Size = new Size(646, 34);
            txtTechnologyStack.TabIndex = 14;
            // 
            // txtAcademicDegree
            // 
            txtAcademicDegree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAcademicDegree.Location = new Point(299, 47);
            txtAcademicDegree.Name = "txtAcademicDegree";
            txtAcademicDegree.Size = new Size(646, 34);
            txtAcademicDegree.TabIndex = 13;
            // 
            // txtProgrammingLangs
            // 
            txtProgrammingLangs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProgrammingLangs.Location = new Point(299, 90);
            txtProgrammingLangs.Name = "txtProgrammingLangs";
            txtProgrammingLangs.Size = new Size(646, 34);
            txtProgrammingLangs.TabIndex = 12;
            // 
            // txtDevelopmentEnvironments
            // 
            txtDevelopmentEnvironments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDevelopmentEnvironments.Location = new Point(299, 130);
            txtDevelopmentEnvironments.Name = "txtDevelopmentEnvironments";
            txtDevelopmentEnvironments.Size = new Size(646, 34);
            txtDevelopmentEnvironments.TabIndex = 11;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(299, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(646, 34);
            txtFullName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 6;
            label2.Text = "Ученая степень";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(259, 28);
            label3.TabIndex = 7;
            label3.Text = "Языки программирования";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 130);
            label4.Name = "label4";
            label4.Size = new Size(183, 28);
            label4.TabIndex = 8;
            label4.Text = "Среды разработки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 170);
            label5.Name = "label5";
            label5.Size = new Size(163, 28);
            label5.TabIndex = 9;
            label5.Text = "Стек технологий";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 5;
            label1.Text = "ФИО";
            // 
            // btnСancel
            // 
            btnСancel.DialogResult = DialogResult.Cancel;
            btnСancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnСancel.Location = new Point(796, 245);
            btnСancel.Name = "btnСancel";
            btnСancel.Size = new Size(161, 59);
            btnСancel.TabIndex = 1;
            btnСancel.Text = "Отмена";
            btnСancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(629, 245);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 59);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnСancel;
            ClientSize = new Size(972, 316);
            Controls.Add(btnSave);
            Controls.Add(btnСancel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Изменить";
            Load += EditForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox txtTechnologyStack;
        private TextBox txtAcademicDegree;
        private TextBox txtProgrammingLangs;
        private TextBox txtDevelopmentEnvironments;
        private TextBox txtFullName;
        private Button btnСancel;
        private Button btnSave;
    }
}