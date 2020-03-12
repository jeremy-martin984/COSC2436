using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ToDoListControl
{
    public class ToDoData
    {

        public ToDo Add ( ToDo toDoTask)
        {
            var item = CloneList(toDoTask);
            item.Id = _id++;
            _toDoList.Add(item);

            return CloneList(item);
        }
        public void SaveList()
        {
            var writer = new XmlSerializer(typeof(List<ToDo>));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\todo.xml";
            var file = File.Create(path);
            writer.Serialize(file, _toDoList);
            file.Close();
        }

        public ToDo SaveTask (ToDo toDo)
        {
            var item = CloneList(toDo);
            item.Id = _id++;
            _toDoList.Add(item);
            return CloneList(item);
        }

        private ToDo CloneList(ToDo toDoList)
        {
            var item = new ToDo();
            CopyList(item, toDoList, true);

            return item;
        }

        private void CopyList(ToDo target, ToDo source, bool includeId)
        {
            if (includeId)
                target.Id = source.Id;
            target.Task = source.Task;
            target.DueDate = source.DueDate;
            target.Priority = source.Priority;
        }
        public ToDo[] GetAll()
        {
            //Clone objects
            var items = new ToDo[_toDoList.Count];
            var index = 0;
            foreach (var toDo in _toDoList)
            {
                items[index++] = CloneList(toDo);
            };

            return items;
        }
        public void LoadToon()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\todo.xml";
            if (!File.Exists(path))
                return;
            var reader = new XmlSerializer(typeof(List<ToDo>));
            var file = new StreamReader(path);
            _toDoList = (List<ToDo>)reader.Deserialize(file);
            _id = _toDoList.Count + 1;
            file.Close();
        }

        public void Delete(int id)
        {
            if (id <= 0)
                return;

            var toDo = FindById(id);
            if (toDo != null)
                _toDoList.Remove(toDo);
        }

        private ToDo FindById(int id)
        {
            foreach (var toDo in _toDoList)
            {
                if (toDo.Id == id)
                    return toDo;
            };

            return null;
        }
        private List<ToDo> _toDoList = new List<ToDo>();
        private int _id = 1;
    }
}
