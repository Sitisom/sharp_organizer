namespace Лаба_органайзер
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnDay0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDay4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDay5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDay6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRowStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLastRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDay0,
            this.columnDay1,
            this.columnDay2,
            this.columnDay3,
            this.columnDay4,
            this.columnDay5,
            this.columnDay6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 572);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // columnDay0
            // 
            this.columnDay0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDay0.DefaultCellStyle = dataGridViewCellStyle10;
            this.columnDay0.Frozen = true;
            this.columnDay0.HeaderText = "Понедельник";
            this.columnDay0.MinimumWidth = 6;
            this.columnDay0.Name = "columnDay0";
            this.columnDay0.ReadOnly = true;
            this.columnDay0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDay0.Width = 163;
            // 
            // columnDay1
            // 
            this.columnDay1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDay1.DefaultCellStyle = dataGridViewCellStyle11;
            this.columnDay1.HeaderText = "Вторник";
            this.columnDay1.MinimumWidth = 6;
            this.columnDay1.Name = "columnDay1";
            this.columnDay1.ReadOnly = true;
            this.columnDay1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDay1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnDay1.Width = 93;
            // 
            // columnDay2
            // 
            this.columnDay2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDay2.DefaultCellStyle = dataGridViewCellStyle12;
            this.columnDay2.HeaderText = "Среда";
            this.columnDay2.MinimumWidth = 6;
            this.columnDay2.Name = "columnDay2";
            this.columnDay2.ReadOnly = true;
            this.columnDay2.Width = 97;
            // 
            // columnDay3
            // 
            this.columnDay3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDay3.DefaultCellStyle = dataGridViewCellStyle13;
            this.columnDay3.HeaderText = "Четверг";
            this.columnDay3.MinimumWidth = 6;
            this.columnDay3.Name = "columnDay3";
            this.columnDay3.ReadOnly = true;
            this.columnDay3.Width = 116;
            // 
            // columnDay4
            // 
            this.columnDay4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDay4.DefaultCellStyle = dataGridViewCellStyle14;
            this.columnDay4.HeaderText = "Пятница";
            this.columnDay4.MinimumWidth = 6;
            this.columnDay4.Name = "columnDay4";
            this.columnDay4.ReadOnly = true;
            this.columnDay4.Width = 118;
            // 
            // columnDay5
            // 
            this.columnDay5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDay5.DefaultCellStyle = dataGridViewCellStyle15;
            this.columnDay5.HeaderText = "Суббота";
            this.columnDay5.MinimumWidth = 6;
            this.columnDay5.Name = "columnDay5";
            this.columnDay5.ReadOnly = true;
            this.columnDay5.Width = 115;
            // 
            // columnDay6
            // 
            this.columnDay6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDay6.DefaultCellStyle = dataGridViewCellStyle16;
            this.columnDay6.HeaderText = "Воскресенье";
            this.columnDay6.MinimumWidth = 6;
            this.columnDay6.Name = "columnDay6";
            this.columnDay6.ReadOnly = true;
            this.columnDay6.Width = 158;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // addRowStripMenuItem
            // 
            this.addRowStripMenuItem.Name = "addRowStripMenuItem";
            this.addRowStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addRowStripMenuItem.Text = "Добавить строку";
            this.addRowStripMenuItem.Click += new System.EventHandler(this.addRowStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLastRowToolStripMenuItem,
            this.deleteAllRowToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Удалить";
            // 
            // deleteLastRowToolStripMenuItem
            // 
            this.deleteLastRowToolStripMenuItem.Name = "deleteLastRowToolStripMenuItem";
            this.deleteLastRowToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.deleteLastRowToolStripMenuItem.Text = "Последнюю строку";
            this.deleteLastRowToolStripMenuItem.Click += new System.EventHandler(this.deleteLastRowToolStripMenuItem_Click);
            // 
            // deleteAllRowToolStripMenuItem
            // 
            this.deleteAllRowToolStripMenuItem.Name = "deleteAllRowToolStripMenuItem";
            this.deleteAllRowToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.deleteAllRowToolStripMenuItem.Text = "Все строки";
            this.deleteAllRowToolStripMenuItem.Click += new System.EventHandler(this.deleteAllRowToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 572);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDay0;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDay3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDay4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDay5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDay6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRowStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLastRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllRowToolStripMenuItem;
    }
}

