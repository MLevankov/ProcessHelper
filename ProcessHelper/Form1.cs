using Microsoft.VisualBasic;

namespace ProcessHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Logging.Log("logs.log", "Process Helper runned", Logging.LogType.Info);
            UpdateProcessList();
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.KillProcess(listView1.SelectedItems[0].Text);
                Logging.Log("logs.log", $"Process {listView1.SelectedItems[0].Text} is successfully killed", Logging.LogType.Success);
            }
            catch (Exception ex)
            {
                Logging.Log("logs.log", ex.Message, Logging.LogType.Error);
                MessageBox.Show($"Error: {ex.Message}", "Process Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateProcessList.Stop();
            UpdateProcessList();
            updateProcessList.Start();
        }

        private void UpdateProcessList()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();

            foreach (string process in Utils.GetProcesses())
            {
                int pid = Utils.GetPID(process);

                ListViewItem item = new ListViewItem(process);
                item.SubItems.Add(pid.ToString());

                listView1.Items.Add(item);

                Application.DoEvents();
            }

            listView1.EndUpdate();
        }

        private void updateProcessList_Tick(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void disableUpdatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateProcessList.Enabled = false;
        }

        private void enableUpdatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateProcessList.Enabled = true;
        }

        private void suspendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.SuspendProcess(listView1.SelectedItems[0].Text);
                Logging.Log("logs.log", $"Process {listView1.SelectedItems[0].Text} is successfully suspended", Logging.LogType.Success);
            }
            catch (Exception ex)
            {
                Logging.Log("logs.log", ex.Message, Logging.LogType.Error);
                MessageBox.Show($"Error: {ex.Message}", "Process Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.ResumeProcess(listView1.SelectedItems[0].Text);
                Logging.Log("logs.log", $"Process {listView1.SelectedItems[0].Text} is successfully resumed", Logging.LogType.Success);
            }
            catch (Exception ex)
            {
                Logging.Log("logs.log", ex.Message, Logging.LogType.Error);
                MessageBox.Show($"Error: {ex.Message}", "Process Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Run().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enableCriticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.SetCritical(listView1.SelectedItems[0].Text, true);
                UpdateProcessList();
                Logging.Log("logs.log", $"Status critical on process {listView1.SelectedItems[0].Text} is successfully added", Logging.LogType.Success);
            }
            catch (Exception ex)
            {
                Logging.Log("logs.log", ex.Message, Logging.LogType.Error);
                MessageBox.Show($"Error: {ex.Message}", "Process Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disableCriticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.SetCritical(listView1.SelectedItems[0].Text, false);
                UpdateProcessList();
                Logging.Log("logs.log", $"Status critical on process {listView1.SelectedItems[0].Text} is successfully deleted", Logging.LogType.Success);
            }
            catch (Exception ex)
            {
                Logging.Log("logs.log", ex.Message, Logging.LogType.Error);
                MessageBox.Show($"Error: {ex.Message}", "Process Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void injectDLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utils.IsAdministrator())
                {
                    Logging.Log("logs.log", "Run Process Helper with administrator privileges", Logging.LogType.Error);
                    MessageBox.Show("Run Process Helper with administrator privileges", "Process Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string result = Interaction.InputBox("Enter path to DLL:", "Inject DLL");
                if (result != "")
                    Utils.InjectDLL(listView1.SelectedItems[0].Text, result);
            }
            catch (Exception ex)
            {
                Logging.Log("logs.log", ex.Message, Logging.LogType.Error);
                MessageBox.Show($"Error: {ex.Message}", "Process Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
