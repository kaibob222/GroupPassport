
namespace groupPassport
{
    partial class EditGroupForm
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
            this.label = new System.Windows.Forms.Label();
            this.groupName = new System.Windows.Forms.TextBox();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.groupFullNameLabel = new System.Windows.Forms.Label();
            this.groupFullName = new System.Windows.Forms.TextBox();
            this.drop = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(22, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(140, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Редактировать группу";
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(151, 80);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(125, 20);
            this.groupName.TabIndex = 1;
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Location = new System.Drawing.Point(22, 83);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(57, 13);
            this.groupNameLabel.TabIndex = 2;
            this.groupNameLabel.Text = "Название";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(22, 138);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(25, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Год";
            // 
            // groupFullNameLabel
            // 
            this.groupFullNameLabel.AutoSize = true;
            this.groupFullNameLabel.Location = new System.Drawing.Point(22, 111);
            this.groupFullNameLabel.Name = "groupFullNameLabel";
            this.groupFullNameLabel.Size = new System.Drawing.Size(96, 13);
            this.groupFullNameLabel.TabIndex = 4;
            this.groupFullNameLabel.Text = "Полное название";
            // 
            // groupFullName
            // 
            this.groupFullName.Location = new System.Drawing.Point(151, 108);
            this.groupFullName.Name = "groupFullName";
            this.groupFullName.Size = new System.Drawing.Size(275, 20);
            this.groupFullName.TabIndex = 5;
            // 
            // drop
            // 
            this.drop.AutoSize = true;
            this.drop.Location = new System.Drawing.Point(25, 226);
            this.drop.Name = "drop";
            this.drop.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.drop.Size = new System.Drawing.Size(75, 23);
            this.drop.TabIndex = 7;
            this.drop.Text = "Сбросить";
            this.drop.UseVisualStyleBackColor = true;
            this.drop.Click += new System.EventHandler(this.drop_Click);
            // 
            // apply
            // 
            this.apply.AutoSize = true;
            this.apply.Location = new System.Drawing.Point(151, 226);
            this.apply.Name = "apply";
            this.apply.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.apply.Size = new System.Drawing.Size(84, 23);
            this.apply.TabIndex = 8;
            this.apply.Text = "Применить";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(151, 135);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(121, 21);
            this.year.TabIndex = 9;
            // 
            // EditGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.year);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.drop);
            this.Controls.Add(this.groupFullName);
            this.Controls.Add(this.groupFullNameLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.groupNameLabel);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.label);
            this.Name = "EditGroupForm";
            this.Text = "EditGroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label groupFullNameLabel;
        private System.Windows.Forms.TextBox groupFullName;
        private System.Windows.Forms.Button drop;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.ComboBox year;
    }
}