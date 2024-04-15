namespace assignmentq2
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BtnFaculty = new Button();
            BtnTuition = new Button();
            BtnDuration = new Button();
            progressBar1 = new ProgressBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            BTNsearch = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            CBchoice = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(212, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(47, 233);
            label1.Name = "label1";
            label1.Size = new Size(715, 54);
            label1.TabIndex = 1;
            label1.Text = "Eduvos 2023 Study Planner Interface";
            // 
            // BtnFaculty
            // 
            BtnFaculty.BackColor = Color.Navy;
            BtnFaculty.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFaculty.ForeColor = Color.White;
            BtnFaculty.Location = new Point(32, 368);
            BtnFaculty.Name = "BtnFaculty";
            BtnFaculty.Size = new Size(243, 75);
            BtnFaculty.TabIndex = 2;
            BtnFaculty.Text = "Faculty";
            BtnFaculty.UseVisualStyleBackColor = false;
            BtnFaculty.Click += BtnFaculty_Click;
            // 
            // BtnTuition
            // 
            BtnTuition.BackColor = Color.Navy;
            BtnTuition.Enabled = false;
            BtnTuition.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTuition.Location = new Point(281, 368);
            BtnTuition.Name = "BtnTuition";
            BtnTuition.Size = new Size(243, 75);
            BtnTuition.TabIndex = 3;
            BtnTuition.Text = "Tuition";
            BtnTuition.UseVisualStyleBackColor = false;
            BtnTuition.Click += BtnTuition_Click;
            // 
            // BtnDuration
            // 
            BtnDuration.BackColor = Color.Navy;
            BtnDuration.Enabled = false;
            BtnDuration.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDuration.Location = new Point(530, 368);
            BtnDuration.Name = "BtnDuration";
            BtnDuration.Size = new Size(243, 75);
            BtnDuration.TabIndex = 4;
            BtnDuration.Text = "Duration";
            BtnDuration.UseVisualStyleBackColor = false;
            BtnDuration.Click += BtnDuration_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(32, 303);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(741, 59);
            progressBar1.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(833, 553);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveBorder;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(BtnDuration);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(BtnFaculty);
            tabPage1.Controls.Add(BtnTuition);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(825, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveBorder;
            tabPage2.Controls.Add(BTNsearch);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(CBchoice);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(825, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // BTNsearch
            // 
            BTNsearch.BackColor = Color.Navy;
            BTNsearch.ForeColor = Color.White;
            BTNsearch.Location = new Point(314, 46);
            BTNsearch.Name = "BTNsearch";
            BTNsearch.Size = new Size(75, 23);
            BTNsearch.TabIndex = 3;
            BTNsearch.Text = "Search";
            BTNsearch.UseVisualStyleBackColor = false;
            BTNsearch.Click += BTNsearch_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(724, 18);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.Navy;
            richTextBox1.Location = new Point(37, 100);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(718, 340);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // CBchoice
            // 
            CBchoice.DropDownStyle = ComboBoxStyle.DropDownList;
            CBchoice.FormattingEnabled = true;
            CBchoice.Location = new Point(37, 47);
            CBchoice.Name = "CBchoice";
            CBchoice.Size = new Size(271, 23);
            CBchoice.TabIndex = 0;
            CBchoice.Click += CBchoice_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(833, 553);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Eduvos Planner Dashboard";
            Activated += Dashboard_Activated;
            FormClosed += Dashboard_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnFaculty;
        private Button BtnTuition;
        private Button BtnDuration;
        private ProgressBar progressBar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private ComboBox CBchoice;
        private Button button1;
        private Button BTNsearch;
    }
}