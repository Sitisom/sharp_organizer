namespace OrganizerApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.teacherTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.toDateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher:";
            // 
            // fromDateTimeBox
            // 
            this.fromDateTimeBox.CustomFormat = "HH:mm";
            this.fromDateTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimeBox.Location = new System.Drawing.Point(88, 77);
            this.fromDateTimeBox.Name = "fromDateTimeBox";
            this.fromDateTimeBox.ShowUpDown = true;
            this.fromDateTimeBox.Size = new System.Drawing.Size(96, 22);
            this.fromDateTimeBox.TabIndex = 4;
            this.fromDateTimeBox.Value = new System.DateTime(2020, 4, 9, 10, 39, 44, 0);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(88, 31);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(244, 22);
            this.subjectTextBox.TabIndex = 5;
            // 
            // teacherTextBox
            // 
            this.teacherTextBox.Location = new System.Drawing.Point(88, 124);
            this.teacherTextBox.Name = "teacherTextBox";
            this.teacherTextBox.Size = new System.Drawing.Size(244, 22);
            this.teacherTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(31, 170);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 42);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // toDateTimeBox
            // 
            this.toDateTimeBox.CustomFormat = "HH:mm";
            this.toDateTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimeBox.Location = new System.Drawing.Point(219, 77);
            this.toDateTimeBox.Name = "toDateTimeBox";
            this.toDateTimeBox.ShowUpDown = true;
            this.toDateTimeBox.Size = new System.Drawing.Size(113, 22);
            this.toDateTimeBox.TabIndex = 8;
            this.toDateTimeBox.Value = new System.DateTime(2020, 4, 9, 10, 39, 44, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "---";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(184, 170);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 42);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 224);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDateTimeBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.teacherTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.fromDateTimeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fromDateTimeBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker toDateTimeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton;
    }
}