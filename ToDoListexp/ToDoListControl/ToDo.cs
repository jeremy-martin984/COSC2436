using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListControl
{
    public class ToDo
    {
        public string Task
        {
            get { return _task ?? ""; }
            set { _task = value?.Trim(); }
        }
        private string _task;

        public DateTime DueDate;

        public int Priority
        { get; set; }

        public int Id
        { get; set; }

        public bool Done
        { get; set; }
    }

}
