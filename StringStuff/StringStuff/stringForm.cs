using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Stuff
{
    public partial class stringForm : Form
    {
        public stringForm()
        {
            InitializeComponent();
        }

        private string SwitchCase(string input)
        {
            //switches all lowercase letters to uppercase and vice versa

            //declare array of chars the length of the input string
            char[] letters = new char[input.Length];

            // increment through length of array,
            //   if char is lowercase, change to uppercase
            //   else if char is uppercase, change to lower

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    letters[i] = char.ToUpper(input[i]);
                }
                else if (char.IsUpper(input[i]))
                {
                    letters[i] = char.ToLower(input[i]);
                }
            }

            string output = new string(letters);
            return output;
        }

        private string Reverse(string input)
        {
            //reverses the string so that it is backwards


            int o; //decrementer for user input 
            int r; //incrementer for reversed array
            int length = input.Length; //need int to store length of input
            char[] back = new char[input.Length]; //init array named back that is the same length of input
            
            //start of reversed array, end of original, reversed index = original index, inc. reversed index, decrem. original index
            for (r = 0, o = length - 1; r < input.Length; o --, r++)
            {

                back[o] = input[(length - 1) - o];
            }

            //declares variable output that is a new string created from back array
            string output = new string(back);
            return output;
        }

        private string PigLatin(string input)
        {
            //if first letter is a vowel, add "yay" to end of word
            //else if first letter is consonant, take all letters prior to first vowel, add "ay" after it, and put the group at end of word

            

            //take user input string, convert to char array

            //push first letter to end of word


            string output = "";
            return output;
        }

        private string ShiftCypher(string input, int charsToShift)
        {
            //given a string shift the characters in the alphabet by an integer value
            string output = "";
            return output;
        }

        //substitute each char in given string with proper character based on position in alphabet
        private string SubCypher(string input, string charsToSub)
        {
            string output = "";
            return output;
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            switchCaseTextBox.Text = SwitchCase(input);
            reverseTextBox.Text = Reverse(input);

        }
    }
}
