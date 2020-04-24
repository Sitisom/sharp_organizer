using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrganizerApp
{
    public interface IEditForm
    {
        string SubjectBox { get; set; }
        DateTime FromTimeBox { get; set; }
        DateTime ToTimeBox { get; set; }
        string TeacherBox { get; set; }

        void Display(DataGridViewCell cell);
        void Display(DataGridViewCell cell, string subject, DateTime fromTime, DateTime toTime, string teacher);

        event EventHandler AddButtonClick;
        event EventHandler DeleteButtonClick;
    }

    public partial class EditForm : Form, IEditForm
    {
        DataGridViewCell cell;

        public EditForm()
        {
            InitializeComponent();
            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
            fromDateTimeBox.ValueChanged += FromDateTimeBox_ValueChanged;
        }

        private void FromDateTimeBox_ValueChanged(object sender, EventArgs e)
        {
            toDateTimeBox.Value = fromDateTimeBox.Value.AddMinutes(90);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonClick?.Invoke(this, EventArgs.Empty);
        }

        public string SubjectBox
        {
            get { return subjectTextBox.Text; }
            set { subjectTextBox.Text = value;  }
        }
        
        public DateTime FromTimeBox
        {
            get { return fromDateTimeBox.Value; }
            set { fromDateTimeBox.Value = value; }
        }

        public DateTime ToTimeBox
        {
            get { return toDateTimeBox.Value; }
            set { toDateTimeBox.Value = value; }
        }

        public string TeacherBox
        {
            get { return teacherTextBox.Text; }
            set { teacherTextBox.Text = value; }
        }

        public event EventHandler AddButtonClick;
        public event EventHandler DeleteButtonClick;

        public void Display(DataGridViewCell cell)
        {
            this.Text = "Добавить";
            this.addButton.Text = "Добавить";

            this.cell = cell;
            FromTimeBox = DateTime.Now;

            deleteButton.Visible = false;

            addButton.Location = new Point(80, addButton.Location.Y);

            ShowDialog();
        }

        public void Display(DataGridViewCell cell, string subject, DateTime fromTime, DateTime toTime, string teacher)
        {
            this.Text = "Редактировать";
            this.addButton.Text = "Редактировать";

            this.cell = cell;

            deleteButton.Visible = true;

            SubjectBox = subject;
            FromTimeBox = fromTime;
            ToTimeBox = toTime;
            TeacherBox = teacher;

            addButton.Location = new Point(25, addButton.Location.Y);

            ShowDialog();
        }
    }
}
