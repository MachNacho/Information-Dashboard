namespace assignmentq2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TBusername = new TextBox();
            TBpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BtnConnect = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TBusername
            // 
            TBusername.Location = new Point(137, 218);
            TBusername.Name = "TBusername";
            TBusername.Size = new Size(380, 23);
            TBusername.TabIndex = 0;
            // 
            // TBpassword
            // 
            TBpassword.Location = new Point(137, 287);
            TBpassword.Name = "TBpassword";
            TBpassword.Size = new Size(380, 23);
            TBpassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 221);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 290);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(54, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // BtnConnect
            // 
            BtnConnect.BackgroundImage = Properties.Resources.login;
            BtnConnect.BackgroundImageLayout = ImageLayout.Stretch;
            BtnConnect.Location = new Point(156, 340);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new Size(347, 49);
            BtnConnect.TabIndex = 5;
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(629, 438);
            Controls.Add(BtnConnect);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBpassword);
            Controls.Add(TBusername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "LoginForm";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBusername;
        private TextBox TBpassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button BtnConnect;
    }
}