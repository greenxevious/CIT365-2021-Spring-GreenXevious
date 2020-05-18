using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timemath
{

    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // 2 variables started.
        int add1;
        int add2;

        //time for problem
        int timeLeft;
        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;
        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        public Form1()
        {
            InitializeComponent();

        }

        public void StartTheQuiz()
        {
      
        // Generate two random numbers to add.
        // Store the values in the variables 'addend1' and 'addend2'.
        add1 = randomizer.Next(51);
    add2 = randomizer.Next(51);
            minuend = randomizer.Next(1, 101);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = add1.ToString();
            plusRightLabel.Text = add2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            // Fill in the varaiables for subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Start the timer.
            timeLeft = 300;
            timeLabel.Text = "You have 5 mins";
            timer1.Start();
          

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startSounds();
            startButton.Enabled = false;
        }


        //correct answer true incorrect false
        private bool CheckTheAnswer()
        {

            if ((add1 + add2 == sum.Value) && (minuend - subtrahend == difference.Value) && (dividend / divisor == quotient.Value))
                return true;
            else 
                return false;

          //  if ((add1 + add2 == sum.Value) && (minuend - subtrahend == difference.Value) && (dividend / divisor == quotient.Value))
             //   return true;
        }
        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }
        public void startSounds()
        {
            SoundPlayer start = new SoundPlayer(@"c:\Windows\Media\tada.wav");
            start.Play();
        }
        public void playSounds()
        {
            SoundPlayer Sound = new SoundPlayer(@"c:\Windows\Media\ding.wav");
            Sound.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }

            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = add1 + add2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }

            if (timeLeft <= 60)
            {
                timeLabel.BackColor = Color.Yellow;
                playSounds();

            }

            //color change at 5 seconds
            if (timeLeft <= 5) {
                timeLabel.BackColor = Color.Red;            
            }

            if (timeLeft >= 30)
            {
                timeLabel.BackColor = Color.White;
            }

            }

        private void answer_Enter(object sender, EventArgs e)
        {
            // fix with NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {
        
        }

        private void date_MouseMove(object sender, MouseEventArgs e)
        {
            DateTime Date = DateTime.Now;
            Console.WriteLine(Date);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
