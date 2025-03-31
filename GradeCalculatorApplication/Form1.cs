using System;
using System.Drawing;
using System.Windows.Forms;

namespace GradeCalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calculateButton.Click += CalculateButton_Click;
            clearButton.Click += ClearButton_Click;
            clearButton.Enabled = false; // Initially disabled
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string input = inputScore.Text.Trim();
            clearButton.Enabled = true;
            if (!IsValidInput(input, out double score))
            {
                resultLabel.Text = "Invalid input! Enter a number (0-100).";
                resultLabel.ForeColor = Color.Red;
                return;
            }


            string letterGrade;
            double gradePoints;
            string feedback;
            Color gradeColor;

            if (score >= 90)
            {
                letterGrade = "A";
                gradePoints = 4.0;
                feedback = "Excellent!";
                gradeColor = Color.Green;
            }
            else if (score >= 80)
            {
                letterGrade = "B";
                gradePoints = 3.0;
                feedback = "Good job!";
                gradeColor = Color.Blue;
            }
            else if (score >= 70)
            {
                letterGrade = "C";
                gradePoints = 2.0;
                feedback = "Average";
                gradeColor = Color.Orange;
            }
            else if (score >= 60)
            {
                letterGrade = "D";
                gradePoints = 1.0;
                feedback = "Below average";
                gradeColor = Color.Orange;
            }
            else
            {
                letterGrade = "F";
                gradePoints = 0.0;
                feedback = "Failed - Needs improvement";
                gradeColor = Color.Red;
            }

            // Display in Label
            resultLabel.Text = $"Grade: {letterGrade}\nPoints: {gradePoints}\n{feedback}";
            resultLabel.ForeColor = gradeColor;

        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            inputScore.Clear();
            resultLabel.Text = "";
            clearButton.Enabled = false; // Disable Clear button again
        }

        private bool IsValidInput(string input, out double score)
        {
            if (double.TryParse(input, out score) && score >= 0 && score <= 100)
                return true;

            score = 0;
            return false;
        }
    }
}
