namespace ToDoList
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnDue = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lstTask = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.deleteTaskToolStripMenuItem,
            this.editTaskToolStripMenuItem,
            this.saveListToolStripMenuItem,
            this.loadListToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.newTaskToolStripMenuItem.Text = "&New Task";
            this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.OnAddTask);
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.deleteTaskToolStripMenuItem.Text = "&Delete Task";
            this.deleteTaskToolStripMenuItem.Click += new System.EventHandler(this.OnDelete);
            // 
            // editTaskToolStripMenuItem
            // 
            this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.editTaskToolStripMenuItem.Text = "&Edit Task";
            this.editTaskToolStripMenuItem.Click += new System.EventHandler(this.OnTaskEdit);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.saveListToolStripMenuItem.Text = "&Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.OnSave);
            // 
            // loadListToolStripMenuItem
            // 
            this.loadListToolStripMenuItem.Name = "loadListToolStripMenuItem";
            this.loadListToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.loadListToolStripMenuItem.Text = "&Load List";
            this.loadListToolStripMenuItem.Click += new System.EventHandler(this.OnLoad);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterCompleteToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.filterToolStripMenuItem.Text = "&Filter";
            // 
            // filterCompleteToolStripMenuItem
            // 
            this.filterCompleteToolStripMenuItem.Name = "filterCompleteToolStripMenuItem";
            this.filterCompleteToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.filterCompleteToolStripMenuItem.Text = "&Filter Complete";
            this.filterCompleteToolStripMenuItem.Click += new System.EventHandler(this.OnFilterComplete);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(0, 36);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(484, 38);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "Task Name";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.OnTskClick);
            // 
            // btnDue
            // 
            this.btnDue.Location = new System.Drawing.Point(480, 36);
            this.btnDue.Name = "btnDue";
            this.btnDue.Size = new System.Drawing.Size(144, 38);
            this.btnDue.TabIndex = 3;
            this.btnDue.Text = "Due Date";
            this.btnDue.UseVisualStyleBackColor = true;
            this.btnDue.Click += new System.EventHandler(this.OnBtnSortByDue);
            // 
            // btnPriority
            // 
            this.btnPriority.Location = new System.Drawing.Point(620, 36);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(144, 38);
            this.btnPriority.TabIndex = 4;
            this.btnPriority.Text = "Priority";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.OnBtnPriority);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(760, 36);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(144, 38);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Status";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lstTask
            // 
            this.lstTask.FormattingEnabled = true;
            this.lstTask.ItemHeight = 20;
            this.lstTask.Location = new System.Drawing.Point(0, 80);
            this.lstTask.Name = "lstTask";
            this.lstTask.Size = new System.Drawing.Size(901, 504);
            this.lstTask.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 598);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.btnDue);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.lstTask);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ToDoListMaker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnDue;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCompleteToolStripMenuItem;
        private System.Windows.Forms.ListBox lstTask;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadListToolStripMenuItem;
    }
}

