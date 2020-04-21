using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Лаба_органайзер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Organizer organizer = Organizer.GetInstance();
            
            try
            {
                for (int i = 0; i < organizer.items.Count; i++)
                {
                    for(int j = 0; j < organizer.items[i].Count; j++)
                    {
                        if (j > dataGridView1.Rows.Count - 1) 
                            dataGridView1.Rows.Add();

                        dataGridView1.Rows[j].Cells[i].Value = organizer.items[i][j].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Organizer organizer = Organizer.GetInstance();
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\organizer.txt", FileMode.OpenOrCreate, FileAccess.Write);
                formatter.Serialize(stream, organizer);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Can't load a file" + exc.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                Form2 form2 = new Form2(this);
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == null)
                {
                    form2.DisplayForm(cell);
                }
                else
                {
                    string[] text = cell.Value.ToString().Split('\n');
                    form2.DisplayForm(cell, text[0], DateTime.Parse(text[1]), text[2]);
                }
            }
        }

        private void addRowStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void deleteLastRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.Rows.Count - 1;
            Organizer organizer = Organizer.GetInstance();

            dataGridView1.Rows.RemoveAt(row);
            organizer.DeleteRow(row);
        }

        private void deleteAllRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Organizer organizer = Organizer.GetInstance();

            dataGridView1.Rows.Clear();
            organizer.DeleteRow();
        }
    }
}
