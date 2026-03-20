using System.Diagnostics;

namespace ProcessHelper
{
    public partial class Run : Form
    {
        public Run()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = textBox1.Text.Split(" ");
                string args = "";

                for (int i = 1; i < parts.Length; i++)
                    args += parts[i];

                Process.Start(parts[0], args);
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("the system cannot find the file specified"))
                    MessageBox.Show($"File {textBox1.Text} isn't found", "Run", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Error: {ex.Message}", "Run", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Logging.Log("logs.log", $"Program {textBox1.Text} is successfully runned", Logging.LogType.Success);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length > 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            browseDialog.ShowDialog();
            if (browseDialog.FileName != "")
                textBox1.Text = browseDialog.FileName;
        }
    }
}
