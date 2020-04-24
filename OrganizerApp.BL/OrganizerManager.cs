using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OrganizerApp.BL
{
    public interface IOrganizerManager
    {
        void SaveData();
        (int, string) PostItem(int x, int y, string name, DateTime fromTime, DateTime toTime, string note);
        string[][] GetItems();
        Class GetItem(int x, int y);
        void Delete();
        void Delete(int x);
        void Delete(int x, int y);
    }

    [Serializable]
    public class OrganizerManager : IOrganizerManager
    {
        List<List<Class>> items;

        public OrganizerManager()
        {
            items = new List<List<Class>>();
            LoadData();

            if(items.Count != 7)
            {
                
                for (int i = 0; i < 7; i++)
                {
                    items.Add(new List<Class>());
                }
            }
        }

        public string[][] GetItems()
        {
            string[][] data = new string[items.Count][];
            for(int i = 0; i < items.Count; i++)
            {
                string[] todos = new string[items[i].Count];
                for(int j = 0; j < items[i].Count; j++)
                {
                    todos[j] = items[i][j].ToString();
                }
                data[i] = todos;
            }
            return data;
        }

        public Class GetItem(int x, int y)
        {
            return items[x][y];
        }

        private void LoadData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\data.txt",
            FileMode.OpenOrCreate, FileAccess.Read);

            if (stream.Length > 0)
            {
                this.items = (List<List<Class>>)formatter.Deserialize(stream);
            }
            stream.Close();
        }

        public void SaveData()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\data.txt",
                FileMode.OpenOrCreate, FileAccess.Write);
            
            formatter.Serialize(stream, items);
            stream.Close();
        }

        public (int, string) PostItem(int x, int y, string subject, DateTime fromTime, DateTime toTime, string teacher)
        {
            Class todo = new Class(subject, fromTime, toTime, teacher);
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

        public void Delete()
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i].Clear();
            }
        }

        public void Delete(int x)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if(items[i].Count - 1 >= x)
                {
                    items[i].RemoveAt(x);
                }
            }
        }

        public void Delete(int x, int y)
        {
            items[y].RemoveAt(x);
        }
    }

    [Serializable]
    public class Class
    {
        public string Subject { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Teacher { get; set; }
        DateTime createdAt;

        public Class(string name, DateTime fromTime, DateTime toTime, string note)
        {
            this.Subject = name;
            this.FromTime = fromTime;
            this.ToTime = toTime;
            this.createdAt = DateTime.UtcNow;
            this.Teacher = note;
        }

        public override string ToString()
        {
            return string.Format(
                "{0}\n{1} - {2}\n{3}",
                Subject,
                FromTime.ToString("HH:mm"),
                ToTime.ToString("HH:mm"),
                Teacher
            );
        }
    }
}
