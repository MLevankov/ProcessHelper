namespace ProcessHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            killToolStripMenuItem1 = new ToolStripMenuItem();
            suspendToolStripMenuItem1 = new ToolStripMenuItem();
            resumeToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem1 = new ToolStripMenuItem();
            disableUpdatingToolStripMenuItem1 = new ToolStripMenuItem();
            enableUpdatingToolStripMenuItem1 = new ToolStripMenuItem();
            runToolStripMenuItem1 = new ToolStripMenuItem();
            enableCriticalToolStripMenuItem1 = new ToolStripMenuItem();
            disableCriticalToolStripMenuItem1 = new ToolStripMenuItem();
            injectDLLToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            processToolStripMenuItem = new ToolStripMenuItem();
            killToolStripMenuItem = new ToolStripMenuItem();
            suspendToolStripMenuItem = new ToolStripMenuItem();
            resumeToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            disableUpdatingToolStripMenuItem = new ToolStripMenuItem();
            enableUpdatingToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            enableCriticalToolStripMenuItem = new ToolStripMenuItem();
            disableCriticalToolStripMenuItem = new ToolStripMenuItem();
            injectDLLToolStripMenuItem = new ToolStripMenuItem();
            updateProcessList = new System.Windows.Forms.Timer(components);
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 24);
            listView1.Margin = new Padding(2, 3, 2, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(948, 573);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PID";
            columnHeader2.Width = 100;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { killToolStripMenuItem1, suspendToolStripMenuItem1, resumeToolStripMenuItem1, updateToolStripMenuItem1, disableUpdatingToolStripMenuItem1, enableUpdatingToolStripMenuItem1, runToolStripMenuItem1, enableCriticalToolStripMenuItem1, disableCriticalToolStripMenuItem1, injectDLLToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(164, 224);
            // 
            // killToolStripMenuItem1
            // 
            killToolStripMenuItem1.Name = "killToolStripMenuItem1";
            killToolStripMenuItem1.Size = new Size(163, 22);
            killToolStripMenuItem1.Text = "Kill";
            killToolStripMenuItem1.Click += killToolStripMenuItem_Click;
            // 
            // suspendToolStripMenuItem1
            // 
            suspendToolStripMenuItem1.Name = "suspendToolStripMenuItem1";
            suspendToolStripMenuItem1.Size = new Size(163, 22);
            suspendToolStripMenuItem1.Text = "Suspend";
            suspendToolStripMenuItem1.Click += suspendToolStripMenuItem_Click;
            // 
            // resumeToolStripMenuItem1
            // 
            resumeToolStripMenuItem1.Name = "resumeToolStripMenuItem1";
            resumeToolStripMenuItem1.Size = new Size(163, 22);
            resumeToolStripMenuItem1.Text = "Resume";
            resumeToolStripMenuItem1.Click += resumeToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem1
            // 
            updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            updateToolStripMenuItem1.Size = new Size(163, 22);
            updateToolStripMenuItem1.Text = "Update";
            updateToolStripMenuItem1.Click += updateToolStripMenuItem_Click;
            // 
            // disableUpdatingToolStripMenuItem1
            // 
            disableUpdatingToolStripMenuItem1.Name = "disableUpdatingToolStripMenuItem1";
            disableUpdatingToolStripMenuItem1.Size = new Size(163, 22);
            disableUpdatingToolStripMenuItem1.Text = "Disable updating";
            disableUpdatingToolStripMenuItem1.Click += disableUpdatingToolStripMenuItem_Click;
            // 
            // enableUpdatingToolStripMenuItem1
            // 
            enableUpdatingToolStripMenuItem1.Name = "enableUpdatingToolStripMenuItem1";
            enableUpdatingToolStripMenuItem1.Size = new Size(163, 22);
            enableUpdatingToolStripMenuItem1.Text = "Enable updating";
            enableUpdatingToolStripMenuItem1.Click += enableUpdatingToolStripMenuItem_Click;
            // 
            // runToolStripMenuItem1
            // 
            runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            runToolStripMenuItem1.Size = new Size(163, 22);
            runToolStripMenuItem1.Text = "Run";
            runToolStripMenuItem1.Click += runToolStripMenuItem_Click;
            // 
            // enableCriticalToolStripMenuItem1
            // 
            enableCriticalToolStripMenuItem1.Name = "enableCriticalToolStripMenuItem1";
            enableCriticalToolStripMenuItem1.Size = new Size(163, 22);
            enableCriticalToolStripMenuItem1.Text = "Enable critical";
            enableCriticalToolStripMenuItem1.Click += enableCriticalToolStripMenuItem_Click;
            // 
            // disableCriticalToolStripMenuItem1
            // 
            disableCriticalToolStripMenuItem1.Name = "disableCriticalToolStripMenuItem1";
            disableCriticalToolStripMenuItem1.Size = new Size(163, 22);
            disableCriticalToolStripMenuItem1.Text = "Disable critical";
            disableCriticalToolStripMenuItem1.Click += disableCriticalToolStripMenuItem_Click;
            // 
            // injectDLLToolStripMenuItem1
            // 
            injectDLLToolStripMenuItem1.Name = "injectDLLToolStripMenuItem1";
            injectDLLToolStripMenuItem1.Size = new Size(163, 22);
            injectDLLToolStripMenuItem1.Text = "Inject DLL";
            injectDLLToolStripMenuItem1.Click += injectDLLToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, processToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(948, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // processToolStripMenuItem
            // 
            processToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { killToolStripMenuItem, suspendToolStripMenuItem, resumeToolStripMenuItem, updateToolStripMenuItem, disableUpdatingToolStripMenuItem, enableUpdatingToolStripMenuItem, runToolStripMenuItem, enableCriticalToolStripMenuItem, disableCriticalToolStripMenuItem, injectDLLToolStripMenuItem });
            processToolStripMenuItem.Name = "processToolStripMenuItem";
            processToolStripMenuItem.Size = new Size(59, 20);
            processToolStripMenuItem.Text = "Process";
            // 
            // killToolStripMenuItem
            // 
            killToolStripMenuItem.Name = "killToolStripMenuItem";
            killToolStripMenuItem.Size = new Size(180, 22);
            killToolStripMenuItem.Text = "Kill";
            killToolStripMenuItem.Click += killToolStripMenuItem_Click;
            // 
            // suspendToolStripMenuItem
            // 
            suspendToolStripMenuItem.Name = "suspendToolStripMenuItem";
            suspendToolStripMenuItem.Size = new Size(180, 22);
            suspendToolStripMenuItem.Text = "Suspend";
            suspendToolStripMenuItem.Click += suspendToolStripMenuItem_Click;
            // 
            // resumeToolStripMenuItem
            // 
            resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            resumeToolStripMenuItem.Size = new Size(180, 22);
            resumeToolStripMenuItem.Text = "Resume";
            resumeToolStripMenuItem.Click += resumeToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(180, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // disableUpdatingToolStripMenuItem
            // 
            disableUpdatingToolStripMenuItem.Name = "disableUpdatingToolStripMenuItem";
            disableUpdatingToolStripMenuItem.Size = new Size(180, 22);
            disableUpdatingToolStripMenuItem.Text = "Disable updating";
            disableUpdatingToolStripMenuItem.Click += disableUpdatingToolStripMenuItem_Click;
            // 
            // enableUpdatingToolStripMenuItem
            // 
            enableUpdatingToolStripMenuItem.Name = "enableUpdatingToolStripMenuItem";
            enableUpdatingToolStripMenuItem.Size = new Size(180, 22);
            enableUpdatingToolStripMenuItem.Text = "Enable updating";
            enableUpdatingToolStripMenuItem.Click += enableUpdatingToolStripMenuItem_Click;
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(180, 22);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // enableCriticalToolStripMenuItem
            // 
            enableCriticalToolStripMenuItem.Name = "enableCriticalToolStripMenuItem";
            enableCriticalToolStripMenuItem.Size = new Size(180, 22);
            enableCriticalToolStripMenuItem.Text = "Enable critical";
            enableCriticalToolStripMenuItem.Click += enableCriticalToolStripMenuItem_Click;
            // 
            // disableCriticalToolStripMenuItem
            // 
            disableCriticalToolStripMenuItem.Name = "disableCriticalToolStripMenuItem";
            disableCriticalToolStripMenuItem.Size = new Size(180, 22);
            disableCriticalToolStripMenuItem.Text = "Disable critical";
            disableCriticalToolStripMenuItem.Click += disableCriticalToolStripMenuItem_Click;
            // 
            // injectDLLToolStripMenuItem
            // 
            injectDLLToolStripMenuItem.Name = "injectDLLToolStripMenuItem";
            injectDLLToolStripMenuItem.Size = new Size(180, 22);
            injectDLLToolStripMenuItem.Text = "Inject DLL";
            injectDLLToolStripMenuItem.Click += injectDLLToolStripMenuItem_Click;
            // 
            // updateProcessList
            // 
            updateProcessList.Enabled = true;
            updateProcessList.Interval = 5000;
            updateProcessList.Tick += updateProcessList_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 597);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Process Helper";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem processToolStripMenuItem;
        private ToolStripMenuItem killToolStripMenuItem;
        private ToolStripMenuItem suspendToolStripMenuItem;
        private ToolStripMenuItem resumeToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Timer updateProcessList;
        private ToolStripMenuItem disableUpdatingToolStripMenuItem;
        private ToolStripMenuItem enableUpdatingToolStripMenuItem;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem enableCriticalToolStripMenuItem;
        private ToolStripMenuItem disableCriticalToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem killToolStripMenuItem1;
        private ToolStripMenuItem suspendToolStripMenuItem1;
        private ToolStripMenuItem resumeToolStripMenuItem1;
        private ToolStripMenuItem updateToolStripMenuItem1;
        private ToolStripMenuItem disableUpdatingToolStripMenuItem1;
        private ToolStripMenuItem enableUpdatingToolStripMenuItem1;
        private ToolStripMenuItem runToolStripMenuItem1;
        private ToolStripMenuItem enableCriticalToolStripMenuItem1;
        private ToolStripMenuItem disableCriticalToolStripMenuItem1;
        private ToolStripMenuItem injectDLLToolStripMenuItem;
        private ToolStripMenuItem injectDLLToolStripMenuItem1;
    }
}
