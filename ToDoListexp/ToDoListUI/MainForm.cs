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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnAddTask(object sender, EventArgs e)
        {
            var task = new AddTaskForm();

            do
            {
                if (task.ShowDialog(this) != DialogResult.OK)
                    return;

                var toDo = _toDo.Add(task.ToDoTask);
                UpdateUI();
                return;
                
            }while (true) ;

        }

        private void UpdateUI()
        {
            //lstTask.Items.Clear();
            lstTask.Items.Clear();
            var taskList = _toDo.GetAll();
            ListViewItem item = new ListViewItem();
            foreach (var task in taskList)
            {
                lstTask.Items.Add(task.);
            };
        }
        ToDoData _toDo = new ToDoData();
    }
}
