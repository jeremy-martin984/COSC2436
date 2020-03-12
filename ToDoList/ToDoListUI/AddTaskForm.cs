using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListControl;

namespace ToDoList
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        public ToDo ToDoTask
        { get; set; }

        private void OnSave(object sender, EventArgs e)
        {
            var toDo = new ToDo
            {
                Task = txtTask.Text,
                DueDate = dateDuePicker.Value,
                Priority = PriorityToInt(ddlPriority.Text)
            };
            toDo.Done = chkComplete.Checked;
            DialogResult = DialogResult.OK;
            ToDoTask = toDo;
            Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (ToDoTask != null)
            {
                txtTask.Text = ToDoTask.Task;
                ddlPriority.Text = IntToPriority(ToDoTask.Priority);
                chkComplete.Checked = ToDoTask.Done;
                dateDuePicker.Value = ToDoTask.DueDate;
            }
        }

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
        private int PriorityToInt(string priority)
        {
            do
            {
                if (priority == "Urgent")
                    return 0;
                if (priority == "High")
                    return 1;
                if (priority == "Medium")
                    return 2;
                if (priority == "Low")
                    return 3;
                if (priority == "Meh?")
                    return 4;
            } while (true);
        }
       
    }
}
