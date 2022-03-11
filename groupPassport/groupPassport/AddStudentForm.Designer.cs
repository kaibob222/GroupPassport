
namespace groupPassport
{
    partial class AddStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.mNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.dropButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные студента";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(231, 138);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(292, 26);
            this.fNameTextBox.TabIndex = 1;
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.Location = new System.Drawing.Point(231, 190);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(292, 26);
            this.sNameTextBox.TabIndex = 2;
            // 
            // mNameTextBox
            // 
            this.mNameTextBox.Location = new System.Drawing.Point(231, 243);
            this.mNameTextBox.Name = "mNameTextBox";
            this.mNameTextBox.Size = new System.Drawing.Size(292, 26);
            this.mNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(390, 664);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(148, 31);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // dropButton
            // 
            this.dropButton.Location = new System.Drawing.Point(602, 664);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(148, 31);
            this.dropButton.TabIndex = 8;
            this.dropButton.Text = "Сбросить";
            this.dropButton.UseVisualStyleBackColor = true;
            this.dropButton.Visible = false;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 733);
            this.Controls.Add(this.dropButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mNameTextBox);
            this.Controls.Add(this.sNameTextBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.TextBox mNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button dropButton;
    }
}