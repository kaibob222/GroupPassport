
namespace groupPassport
{
    partial class AddExistStudentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.studentsComboBox = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Выбрать студента";
            // 
            // studentsComboBox
            // 
            this.studentsComboBox.FormattingEnabled = true;
            this.studentsComboBox.Location = new System.Drawing.Point(57, 101);
            this.studentsComboBox.Name = "studentsComboBox";
            this.studentsComboBox.Size = new System.Drawing.Size(292, 28);
            this.studentsComboBox.TabIndex = 11;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(57, 316);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(148, 31);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // AddExistStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentsComboBox);
            this.Name = "AddExistStudentForm";
            this.Text = "AddExistStudentForm";
            this.Load += new System.EventHandler(this.AddExistStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox studentsComboBox;
        private System.Windows.Forms.Button applyButton;
    }
}