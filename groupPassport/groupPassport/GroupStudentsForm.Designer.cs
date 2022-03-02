
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
            this.groupStudentsData.Size = new System.Drawing.Size(1164, 579);
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
            this.addStudentButton.Location = new System.Drawing.Point(657, 736);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(154, 30);
            this.addStudentButton.TabIndex = 2;
            this.addStudentButton.Text = "Добавить";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Location = new System.Drawing.Point(832, 736);
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
            this.deleteButton.Location = new System.Drawing.Point(1023, 736);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // GroupStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 796);
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
    }
}