using OrganizerApp.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizerApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            EditForm editForm = new EditForm();
            MessageService message = new MessageService();
            OrganizerManager manager = new OrganizerManager();

            Presenter presenter = new Presenter(mainForm, editForm, manager, message);
            
            Application.Run(mainForm);
        }
    }
}
