using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ShowDialog();
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

            string value = organizer.Post(cell.ColumnIndex, name, time, note);
            cell.Value = value;

            DataGridView data = form1.Controls["dataGridView1"] as DataGridView;
            if (cell.RowIndex == data.Rows.Count - 1)
            {
                data.Rows.Add();
            }
            
            

            data.Update();
            Close();
        }
    }
}
