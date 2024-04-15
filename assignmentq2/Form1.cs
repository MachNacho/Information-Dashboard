using System.Windows.Forms;

namespace assignmentq2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        Dashboard dashy = new Dashboard();

        private void button1_Click(object sender, EventArgs e)
        {
            string sUsername = " ";   //holds username
            string sPassword = " ";   //holds passwords
            int StrLength = 0;      //holds the username length
            bool Namevalid = false;     //helps to validate the username


            // password: lowercase, uppercase, symbol, numbers
            bool passLow = false; //password lowercase
            bool passHigh = false; //password upercase
            bool passSym = false;   //password Symbol
            bool passNum = false;   //password number

            sUsername = TBusername.Text;
            sPassword = TBpassword.Text;
            StrLength = sUsername.Length;




            try // try catch method for length of string
            {
                if (sUsername != "@vossie.net")// checks if username is more than just @vossie.net
                {
                    if (sUsername.Substring((StrLength - 11), 11) == "@vossie.net") //checks if string contains vossie.net at the end.
                    {
                        Namevalid = true;
                    }
                }
                
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Incorrect Username/Password");
            }


            if (sPassword.Length > 8) // checks if the password length is bigger then 8 and if it contains a lowercase,uppercase,symbol and number
            {
                passLow = sPassword.Any(Char.IsLower);
                passHigh = sPassword.Any(Char.IsUpper);
                passSym = sPassword.Any(c => !Char.IsLetterOrDigit(c));
                passNum = sPassword.Any(char.IsDigit);
            }

            if ((passNum == true) && (passSym == true) && (passLow == true) && (passHigh == true) && (Namevalid == true))// if information is correct it wil move to the next form
            {
                MessageBox.Show("Access Granted");
                dashy.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);// will terminate the program
        }

    }
}