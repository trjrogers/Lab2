using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Average(int[] scores)
        {
            double average = 0;
            int total = 0;

            // Calculate the total of the
            // test score tokens.
            //increments through each score in scores array and adds score to running total
            foreach (int score in scores)
            {
                total += score;
            }

            // Calculate the average of these
            // test scores.
            average = (double)total / scores.Length;
            return average;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;  // To read the file
                string line;             // To hold a line from the file
                double average = 0;          // Test score average
                int count; 
                int student = 1; //counter later used for the string building operation for listBox

                // Create a delimiter array.
                char[] delim = { ',' };

                // Open the CSV file.
                inputFile = File.OpenText("..\\..\\Grades.csv");

                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file.
                    line = inputFile.ReadLine();

                    // Get the test scores as tokens.
                    //declare array to hold tokens, split line string and add delimiter to end of each item
                    string[] tokens = line.Split(delim);

                    //declare new array of ints the size of the tokens array
                    int[] scores = new int[tokens.Length];

                    for (count = 0; count < tokens.Length; count++)
                    {
                        //parse elements from string array into scores array
                        scores[count] = int.Parse(tokens[count]);
                    }
                        // calculate the average by calling the method Average on scores array
                        average = Average(scores);

                        // Display the average.
                        averagesListBox.Items.Add("The average for student " +
                            student + " is " + average.ToString("n1"));
                    student++;
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
