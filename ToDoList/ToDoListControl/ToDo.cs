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

        string IntToPriority(int priority)
        {
            do
            {
                if (priority == 0)
                    return "Urgent";
                if (priority == 1)
                    return "High";
                if (priority == 2)
                    return "Medium";
                if (priority == 3)
                    return "Low";
                if (priority == 4)
                    return "Meh?";
            } while (true);
        }
        public int Id
        { get; set; }

        public bool Done
        { get; set; }

        String StringDone(bool done)
        {
            if (!done)
                return "Not Done";
            else return "Done";
        }

        public override string ToString()
        {
            return Task.PadRight(107 - Task.Length + 2) + DueDate.ToShortDateString() + "\t\t" + IntToPriority(Priority) + "\t\t" + StringDone(Done);
        }

    }

}
