using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizerApp.BL;

namespace OrganizerApp
{
    public class Presenter
    {
        private IEditForm _editView;
        private readonly IMainForm _mainView;
        private readonly IOrganizerManager _manager;
        private readonly IMessageService _messageService;

        private DataGridViewCell pressedCell;

        public Presenter(IMainForm mainView, IEditForm editView, IOrganizerManager manager, IMessageService messageService)
        {
            _mainView = mainView;
            _editView = editView;
            _manager = manager;
            _messageService = messageService;

            _mainView.DataCellClick += new DataGridViewCellEventHandler(_mainView_DataCellClick);
            _mainView.MainFormLoad += new EventHandler(_mainView_MainFormLoad);
            _mainView.MainFormClosing += new EventHandler(_mainView_MainFormClosing);
            _mainView.AddRowMenu += new EventHandler(_mainView_AddRowMenu);
            _mainView.DelLastRowMenu += new EventHandler(_mainView_DelLastRowMenu);
            _mainView.DelAllRowsMenu += new EventHandler(_mainView_DelAllRowsMenu);

            _editView.AddButtonClick += new EventHandler(_editView_AddButtonClick);
            _editView.DeleteButtonClick += new EventHandler(_editView_DeleteButtonClick);
        }

        //
        // MainForm events
        //

        private void _mainView_MainFormLoad(object sender, EventArgs e)
        {
            try
            {
                _mainView.SetData(_manager.GetItems());
            }
            catch (ArgumentNullException ex)
            {
                _messageService.ShowError(ex.ToString());
            }
        }

        private void _mainView_MainFormClosing(object sender, EventArgs e)
        {
            try
            {
                _manager.SaveData();
            }
            catch (AccessViolationException ex)
            {
                _messageService.ShowError(ex.ToString());
            }
        }

        private void _mainView_DataCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    pressedCell = _mainView.Data.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    if (pressedCell.Value == null)
                    {
                        _editView.Display(pressedCell);
                    }
                    else
                    {
                        Class item = _manager.GetItem(e.ColumnIndex, e.RowIndex);
                        _editView.Display(pressedCell, item.Subject, item.FromTime, item.ToTime, item.Teacher);
                    }
                }
            }
            catch(Exception ex)
            {
                _messageService.ShowError(ex.ToString());
            }
        }

        private void _mainView_AddRowMenu(object sender, EventArgs e)
        {
            _mainView.Data.Rows.Add();
        }

        private void _mainView_DelLastRowMenu(object sender, EventArgs e)
        {
            int row = _mainView.Data.Rows.Count - 1;

            try
            {
                _mainView.Data.Rows.RemoveAt(row);
                _manager.Delete(row);
            }
            catch(ArgumentOutOfRangeException)
            {
                _messageService.ShowError("Строки кончились!");
            }
        }

        private void _mainView_DelAllRowsMenu(object sender, EventArgs e)
        {
            _mainView.Data.Rows.Clear();
            _manager.Delete();
        }

        //
        // EditForm events
        //

        private void _editView_DeleteButtonClick(object sender, EventArgs e)
        {
            pressedCell.Value = null;
            _manager.Delete(pressedCell.RowIndex, pressedCell.ColumnIndex);
            (_editView as Form).Close();
        }

        private void _editView_AddButtonClick(object sender, EventArgs e)
        {
            string subject = _editView.SubjectBox;
            DateTime fromTime = _editView.FromTimeBox;
            DateTime toTime = _editView.ToTimeBox;
            string teacher = _editView.TeacherBox;

            DataGridView data = _mainView.Data;

            try
            {
                (int row, string value) = _manager.PostItem(pressedCell.RowIndex, pressedCell.ColumnIndex, subject, fromTime, toTime, teacher);

                data.Rows[row].Cells[pressedCell.ColumnIndex].Value = value;

                if (pressedCell.RowIndex == data.Rows.Count - 1)
                {
                    data.Rows.Add();
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowExclamation(ex.ToString());
            }

            data.Update();
            (_editView as Form).Close();
        }
    }
}
