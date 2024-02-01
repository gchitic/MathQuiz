namespace MathQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        public void StartTheQuiz()
        {
            //Setting the timer
            textBoxTimeLeft.Text = timer1.ToString();
            //Setting the numbers randomly and converting to string
            lblPlusLeft.Text = randomizer.Next(0, 50).ToString();
            lblPlusRight.Text = randomizer.Next(0, 50).ToString();

            lblMinLeft.Text = randomizer.Next(0, 50).ToString();
            lblMinRight.Text = randomizer.Next(0, 50).ToString();

            lblMultLeft.Text = randomizer.Next(0, 50).ToString();
            lblMultRight.Text = randomizer.Next(0, 50).ToString();

            lblDevLeft.Text = randomizer.Next(0, 50).ToString();
            lblDevRight.Text = randomizer.Next(1, 20).ToString();
        }

        private bool checkTheAnswer()
        {
            if(Convert.ToDouble(numericUpDown1.Text) == Convert.ToDouble(lblPlusLeft.Text)+ Convert.ToDouble(lblPlusRight.Text))
                return true;
            else 
                return false;
     
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            btnStart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
            }
        }
    }
}
