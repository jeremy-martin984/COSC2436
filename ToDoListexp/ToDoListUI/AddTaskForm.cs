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
            var toDo = new ToDo();
            toDo.Task = txtTask.Text;
            toDo.DueDate = dateDuePicker.Value;
            if (chkComplete.Checked)
                toDo.Done = true;
            toDo.Priority = PriorityToInt(ddlPriority.Text);
            DialogResult = DialogResult.OK;
            ToDoTask = toDo;
            Close();
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
