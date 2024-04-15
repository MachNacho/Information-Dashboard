using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using System.Text;

namespace assignmentq2
{

    public partial class Dashboard : Form
    {
        public string sChoice = " ";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 formy = new();
            formy.Show();
        }

        private void BtnFaculty_Click(object sender, EventArgs e)// button click for facu;ty
        {
            progressBar1.Value = 50;
            BtnTuition.ForeColor = Color.White;
            BtnTuition.Enabled = true;
            tabControl1.SelectedTab = tabPage2;

            CBchoice.Items.Clear();
            CBchoice.Items.AddRange(new object[] { "Commerce and Law", "Applied Science", "Technology", "Humanities and Arts" });
            sChoice = "F";
        }

        private void BtnTuition_Click(object sender, EventArgs e)// button click for Tuition
        {
            progressBar1.Value = 100;
            BtnDuration.ForeColor = Color.White;
            BtnDuration.Enabled = true;
            tabControl1.SelectedTab = tabPage2;
            richTextBox1.Clear();
            CBchoice.Items.Clear();
            CBchoice.Items.AddRange(new object[] { "Commerce and Law", "Applied Science", "Technology", "Humanities and Arts" });
            richTextBox1.AppendText("Tutition:\r\n");
            sChoice = "T";
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(0, 1);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDuration_Click(object sender, EventArgs e)// button click for duration
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Duration:\r\n");
            CBchoice.Items.Clear();
            tabControl1.SelectedTab = tabPage2;
            CBchoice.Items.Clear();
            CBchoice.Items.AddRange(new object[] { "High Certificate", "Bachelors Degree", "Honours Degree" });
            sChoice = "D";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            CBchoice.Text = "Please make a choice:";
        }

        private void CBchoice_Click(object sender, EventArgs e)
        {

        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            if (sChoice == "F")
            {
                switch (CBchoice.SelectedIndex)
                {
                    case 0:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Degrees:\r\n");
                        richTextBox1.AppendText("Bachelor of Business Administration \r\n");
                        richTextBox1.AppendText("Bachelor of Commerce Law \r\n");
                        break;
                    case 1:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Degrees:\r\n");
                        richTextBox1.AppendText("Bachelor of Science in Biomedicine \r\n");
                        richTextBox1.AppendText("Bachelor of Science in Biotechnology Management\r\n");
                        break;
                    case 2:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Degrees:\r\n");
                        richTextBox1.AppendText("Bachelor of Science in Computer Science \r\n");
                        richTextBox1.AppendText("Bachelor of Science in nformation Technology \r\n");
                        break;
                    case 3:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Degrees:\r\n");
                        richTextBox1.AppendText("Bachelor of Arts General \r\n");
                        richTextBox1.AppendText("Bachelor of Arts in Graphic Design \r\n");
                        break;

                }
            }
            else if (sChoice == "D")
            {
                switch (CBchoice.SelectedIndex)
                {
                    case 0:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Duration:\r\n");
                        richTextBox1.AppendText("Default: 1 year Full Time\r\n");
                        richTextBox1.AppendText("Extended: +1 more year Part Time\r\n");
                        break;
                    case 1:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Duration:\r\n");
                        richTextBox1.AppendText("Default: 3 year Full Time\r\n");
                        richTextBox1.AppendText("Extended: +1 more year Part Time\r\n");
                        break;
                    case 2:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Duration:\r\n");
                        richTextBox1.AppendText("Default: 1 year Full Time\r\n");
                        richTextBox1.AppendText("Extended: +1 more year Part Time\r\n");
                        break;
                }
            }
            else
            if (sChoice == "T")
            {
                switch (CBchoice.SelectedIndex)
                {
                    case 0:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Tutition:\r\n");
                        richTextBox1.AppendText("Higher Certificate: R55 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 1 year \r\n");
                        richTextBox1.AppendText("  \r\n");
                        richTextBox1.AppendText("Bachelors Degree: R65 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 3 year \r\n");
                        richTextBox1.AppendText("  \r\n");
                        richTextBox1.AppendText("Honours Degree: R50 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 1 year \r\n");
                        break;
                    case 1:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Tutition:\r\n");
                        richTextBox1.AppendText("Higher Certificate: R60 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 1 year \r\n");
                        richTextBox1.AppendText("  \r\n");
                        richTextBox1.AppendText("Bachelors Degree: R65 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 3 year \r\n");
                        richTextBox1.AppendText("  \r\n");
                        richTextBox1.AppendText("Honours Degree: R70 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 1 year \r\n");

                        break;
                    case 2:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Tutition:\r\n");
                        richTextBox1.AppendText("Higher Certificate: R75 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 1 year \r\n");
                        richTextBox1.AppendText("  \r\n");
                        richTextBox1.AppendText("Bachelors Degree: R65 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 3 year \r\n");
                        richTextBox1.AppendText("  \r\n");
                        richTextBox1.AppendText("Honours Degree: R80 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 1 year \r\n");

                        break;
                    case 3:
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Tutition:\r\n");
                        richTextBox1.AppendText("Higher Certificate: R45 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 1 year \r\n");
                        richTextBox1.AppendText("  \r\n");
                        richTextBox1.AppendText("Bachelors Degree: R55 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 3 year \r\n");
                        richTextBox1.AppendText("  \r\n");
                        richTextBox1.AppendText("Honours Degree: R60 000 per year \r\n");
                        richTextBox1.AppendText("Duration: 1 year \r\n");
                        break;

                }
            }
        }
    }
}
