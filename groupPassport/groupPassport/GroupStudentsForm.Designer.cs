
namespace groupPassport
{
    partial class GroupStudentsForm
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
            this.groupStudentsData = new System.Windows.Forms.DataGridView();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.AddExistStudentButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bookTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dropButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentsData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupStudentsData
            // 
            this.groupStudentsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupStudentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupStudentsData.Location = new System.Drawing.Point(13, 117);
            this.groupStudentsData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupStudentsData.Name = "groupStudentsData";
            this.groupStudentsData.RowHeadersWidth = 62;
            this.groupStudentsData.Size = new System.Drawing.Size(1098, 579);
            this.groupStudentsData.TabIndex = 0;
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Location = new System.Drawing.Point(12, 50);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(65, 20);
            this.groupNameLabel.TabIndex = 1;
            this.groupNameLabel.Text = "Группа ";
            // 
            // addStudentButton
            // 
            this.addStudentButton.AutoSize = true;
            this.addStudentButton.Location = new System.Drawing.Point(554, 736);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(154, 30);
            this.addStudentButton.TabIndex = 2;
            this.addStudentButton.Text = "Создать";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Location = new System.Drawing.Point(733, 736);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(154, 30);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Location = new System.Drawing.Point(957, 736);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AddExistStudentButton
            // 
            this.AddExistStudentButton.AutoSize = true;
            this.AddExistStudentButton.Location = new System.Drawing.Point(16, 736);
            this.AddExistStudentButton.Name = "AddExistStudentButton";
            this.AddExistStudentButton.Size = new System.Drawing.Size(169, 30);
            this.AddExistStudentButton.TabIndex = 5;
            this.AddExistStudentButton.Text = "Добавить студента";
            this.AddExistStudentButton.UseVisualStyleBackColor = true;
            this.AddExistStudentButton.Click += new System.EventHandler(this.AddExistStudentButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(883, 53);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nameTextBox.MinimumSize = new System.Drawing.Size(400, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(400, 26);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // bookTextBox
            // 
            this.bookTextBox.Location = new System.Drawing.Point(1138, 254);
            this.bookTextBox.Name = "bookTextBox";
            this.bookTextBox.Size = new System.Drawing.Size(202, 26);
            this.bookTextBox.TabIndex = 7;
            this.bookTextBox.TextChanged += new System.EventHandler(this.bookTextBox_TextChanged);
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(1138, 161);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.birthDateTimePicker.TabIndex = 8;
            this.birthDateTimePicker.ValueChanged += new System.EventHandler(this.birthDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1134, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1134, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер зачетной книжки";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(879, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ФИО";
            // 
            // dropButton
            // 
            this.dropButton.AutoSize = true;
            this.dropButton.BackColor = System.Drawing.SystemColors.Control;
            this.dropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dropButton.Image = global::groupPassport.Properties.Resources.refresh__1_;
            this.dropButton.Location = new System.Drawing.Point(1293, 45);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(47, 43);
            this.dropButton.TabIndex = 12;
            this.dropButton.UseVisualStyleBackColor = false;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // GroupStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 796);
            this.Controls.Add(this.dropButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.bookTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.AddExistStudentButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.groupNameLabel);
            this.Controls.Add(this.groupStudentsData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GroupStudentsForm";
            this.Text = "GroupStudentsForm";
            this.Load += new System.EventHandler(this.GroupStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView groupStudentsData;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button AddExistStudentButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox bookTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dropButton;
    }
}