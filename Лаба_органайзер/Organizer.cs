using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
                _instance.Get();
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

        public void Get()
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

        public (int, string) Post(int x, int y, string name, DateTime time, string note)
        {
            ToDoItem todo = new ToDoItem(name, time, note);
            int id;
            if(items[y].Count <= x)
            {
                items[y].Add(todo);
                id = items[y].Count - 1;
            }
            else
            {
                items[y][x] = todo;
                id = x;
            }
            return (id, todo.ToString());
        }

        public void Delete(int x, int y)
        {
            items[y].RemoveAt(x);
        }

        public void DeleteRow()
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i].Clear();
            }
                
        }

        public void DeleteRow(int x)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if(items[i].Count - 1 >= x)
                {
                    items[i].RemoveAt(x);
                }
            }
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
            return string.Format("{0}\n{1}\n{2}", Name, Time.TimeOfDay, Note);
        }
    }
}
