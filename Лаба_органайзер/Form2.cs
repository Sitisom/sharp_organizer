using System;
using System.Drawing;
using System.Windows.Forms;

namespace Лаба_органайзер
{
    public partial class Form2 : Form
    {
        DataGridViewCell cell;
        Organizer organizer;
        Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public void DisplayForm(DataGridViewCell cell)
        {
            this.cell = cell;
            timePicker.Value = DateTime.Now;
            ShowDialog();
        }
        public void DisplayForm(DataGridViewCell cell, string name, DateTime time, string note)
        {
            this.cell = cell;

            this.Text = "Редактировать";
            this.AddButton.Text = "Редактировать";

            nameTextBox.Text = name;
            timePicker.Value = time;
            noteTextBox.Text = note;

            this.AddButton.Location = new Point(AddButton.Location.X - 53, AddButton.Location.Y);

            Button deleteButton = new Button();
            deleteButton.Text = "Удалить";
            deleteButton.Location = new Point(AddButton.Location.X + 100, AddButton.Location.Y);
            deleteButton.Size = this.AddButton.Size;
            this.Controls.Add(deleteButton);

            deleteButton.Click += DeleteButton_Click;

            ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            cell.Value = null;
            organizer.Delete(cell.RowIndex, cell.ColumnIndex);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            organizer = Organizer.GetInstance();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            DateTime time = timePicker.Value;
            string note = noteTextBox.Text;

            DataGridView data = form1.Controls["dataGridView1"] as DataGridView;

            (int row, string value) = organizer.Post(cell.ColumnIndex, name, time, note);

            data.Rows[row].Cells[cell.ColumnIndex].Value = value;

            if (cell.RowIndex == data.Rows.Count - 1)
            {
                data.Rows.Add();
            }

            data.Update();
            Close();
        }
    }
}
