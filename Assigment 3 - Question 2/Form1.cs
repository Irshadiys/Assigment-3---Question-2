using System;

namespace Assigment_3___Question_2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int secret;
        int attempts = 0;
        string allValues = "";

        public Form1()
        {
            InitializeComponent();
            secret = random.Next(1, 1001);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out int guess))
            {
                attempts++;

                if (guess == secret)
                {
                    if (attempts < 10)
                        labelShowResult.Text = "Either you know the secret or you got lucky!";
                    else
                        labelShowResult.Text = "You know the secret!";

                    btnGuess.Enabled = false;
                }
                else if (attempts == 10)
                {
                    labelShowResult.Text = "You should be able to do better!";
                    btnGuess.Enabled = false;
                }
                else if (guess < secret)
                {
                    labelShowResult.Text = "Too Low, Try Again";
                }
                else if (guess > secret)
                {
                    labelShowResult.Text = "Too High, Try Again";
                }
            }
            else
            {
                labelShowResult.Text = "Enter a valid number";
            }

            allValues = txtGuess.Text;
            richTextBoxAnswer.Text = allValues;
            txtGuess.Clear();
        }

        private void butAnswer_Click(object sender, EventArgs e)
        {
            labelShowResult.Text = secret.ToString();
        }
    }
}
