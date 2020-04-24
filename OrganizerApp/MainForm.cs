using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace OrganizerApp
{
    public interface IMainForm
    {
        DataGridView Data { get; }
        void SetData(string[][] items);

        event DataGridViewCellEventHandler DataCellClick;
        event EventHandler MainFormLoad;
        event EventHandler MainFormClosing;
        event EventHandler AddRowMenu;
        event EventHandler DelLastRowMenu;
        event EventHandler DelAllRowsMenu;
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;
            this.data.CellClick += Data_CellClick;
            this.addRowMenu.Click += new EventHandler(AddRowMenu_Click);
            this.delLastRowMenu.Click += DelLastRowMenu_Click;
            this.delAllRowsMenu.Click += DelAllRowsMenu_Click;
        }

        //
        // DataGridView Events
        //

        private void Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataCellClick?.Invoke(this, e);
        }

        //
        // MainForm Events
        //

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFormLoad?.Invoke(this, EventArgs.Empty);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFormClosing?.Invoke(this, EventArgs.Empty);
        }

        //
        // Context Menu Events
        //

        private void AddRowMenu_Click(object sender, EventArgs e)
        {
            AddRowMenu?.Invoke(this, EventArgs.Empty);
        }

        private void DelLastRowMenu_Click(object sender, EventArgs e)
        {
            DelLastRowMenu?.Invoke(this, EventArgs.Empty);
        }

        private void DelAllRowsMenu_Click(object sender, EventArgs e)
        {
            DelAllRowsMenu?.Invoke(this, EventArgs.Empty);
        }

        public DataGridView Data
        {
            get { return data; }
        }

        public event DataGridViewCellEventHandler DataCellClick;
        public event EventHandler MainFormLoad;
        public event EventHandler MainFormClosing;
        public event EventHandler AddRowMenu;
        public event EventHandler DelLastRowMenu;
        public event EventHandler DelAllRowsMenu;

        public void SetData(string[][] items)
        {            
            for (int i = 0; i < items.Length; i++)
            {
                for(int j = 0; j < items[i].Length; j++)
                {
                    if (j > Data.Rows.Count - 1) 
                        Data.Rows.Add();

                    Data.Rows[j].Cells[i].Value = items[i][j];
                }
            }
        }
    }
}
