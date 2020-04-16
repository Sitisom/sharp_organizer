using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_органайзер
{
    [Serializable]
    public class Organizer
    {
        public List<List<ToDoItem>> items;

        static Organizer _instance;

        public static Organizer GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Organizer();
            }
            return _instance;
        }

        public Organizer()
        {
            items = new List<List<ToDoItem>>();
            if(items.Count != 7)
            {
                for(int i = 0; i < 7; i++)
                {
                    items.Add(new List<ToDoItem>());
                }
            }
        }

        public void Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\organizer.txt", FileMode.OpenOrCreate, FileAccess.Read);
            Organizer organizer;
            if (stream.Length > 0)
            {
                organizer = (Organizer)formatter.Deserialize(stream);
            }
            else
            {
                organizer = Organizer.GetInstance();
            }
            stream.Close();

            this.items = organizer.items;
        }
        public string Post(int x, string name, DateTime time, string note)
        {
            ToDoItem todo = new ToDoItem(name, time, note);
            items[x].Add(todo);
            return todo.ToString();
        }
    }
    [Serializable]
    public class ToDoItem
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Note { get; set; }

        public ToDoItem(string name, DateTime time, string note)
        {
            this.Name = name;
            this.Time = time;
            this.Note = note;
        }

        public override string ToString()
        {
            return string.Format("Цель: {0}\nВремя: {1}\nЗаметка:{2}", Name, Time, Note);
        }
    }
}
