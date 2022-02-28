
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
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentsData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupStudentsData
            // 
            this.groupStudentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupStudentsData.Location = new System.Drawing.Point(12, 63);
            this.groupStudentsData.Name = "groupStudentsData";
            this.groupStudentsData.Size = new System.Drawing.Size(776, 375);
            this.groupStudentsData.TabIndex = 0;
            // 
            // GroupStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupStudentsData);
            this.Name = "GroupStudentsForm";
            this.Text = "GroupStudentsForm";
            this.Load += new System.EventHandler(this.GroupStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView groupStudentsData;
    }
}