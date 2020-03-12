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
            var result = MessageBox.Show("Are you sure? All unsaved changes will be lost.", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
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
                UpdateUI(_done);
                return;
                
            }while (true) ;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void UpdateUI(bool done)
        {
            lstTask.Items.Clear();

            var taskList = _toDo.GetAll();
            foreach (var task in taskList)
            {
                if (!done)
                {
                    lstTask.Items.Add(task);
                }
                else if (done)
                {
                    if (!task.Done)
                        lstTask.Items.Add(task);
                }
            };
        }


        private ToDo GetSelectedTask()
        {
            return lstTask.SelectedItem as ToDo;
        }
        ToDoData _toDo = new ToDoData();

        private void OnTskClick(object sender, EventArgs e)
        {
            _toDo.SortName();
            UpdateUI(_done);
        }

        private void OnBtnSortByDue(object sender, EventArgs e)
        {
            _toDo.SortDate();
            UpdateUI(_done);
        }

        private void OnBtnPriority(object sender, EventArgs e)
        {
            _toDo.SortPriority();
            UpdateUI(_done);
        }

        private void OnFilterComplete(object sender, EventArgs e)
        {
            if (!_done)
                _done = true;
            else if (_done)
                _done = false;
            UpdateUI(_done);
        }

        private bool _done = false;

        private void OnDelete(object sender, EventArgs e)
        {
            var task = GetSelectedTask();
            if (task == null)
                return;
            if (!DisplayConfirmation($"Are you sure you want to delete this task?", "Delete"))
                return;

            _toDo.Delete(task.Id);
            UpdateUI(_done);
        }
        
        private bool DisplayConfirmation(string message, string title)
        {
            //Display a confirmation dialog
            var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //Return true if user selected OK
            return result == DialogResult.OK;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            _toDo.SortComplete();
            UpdateUI(_done);
        }

        private void OnTaskEdit(object sender, EventArgs e)
        {
            var task = GetSelectedTask();
            if (task == null)
                return;

            var child = new AddTaskForm
            {
                ToDoTask = task
            };

            do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                // Save the movie
                var error = _toDo.Update(task.Id, child.ToDoTask);
                if (String.IsNullOrEmpty(error))
                {
                    UpdateUI(_done);
                    return;
                };

                DisplayError(error);
            } while (true);

        }

        private void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSave(object sender, EventArgs e)
        {
            var saveBox = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (saveBox.ShowDialog() == DialogResult.OK)
                _toDo.SaveList(saveBox.FileName);
            return;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var loadBox = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (loadBox.ShowDialog() == DialogResult.OK)
                _toDo.LoadList(loadBox.FileName);
            UpdateUI(_done);
        }
    }
}
