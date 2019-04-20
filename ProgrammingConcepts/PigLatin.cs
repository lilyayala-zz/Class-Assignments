# Pig-Latin-c-
Application that accepts a sentence as input and converts each word to Pig Latin..


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Variables
            string userSentence = "";

            //Call the method
            userSentence = PigLatinConvert(txtString.Text);

            //Asign variable to user input from textbox
            lblPigLatin.Text = userSentence.ToLower();

           
           
        }

        //Conver to PigLatin Method
        private string PigLatinConvert(string words)
        {
            string firstLetter = "";
            string space = " ";
            string extraLetter = "";
            string pigLatin = "";
            int position = 0;

            //Constants
            const string PigLatinConst = "ay";

            //Split the string
            string[] userSentence = words.Split();

            // We go through the array 
            foreach (string isWord in userSentence)
            {
                //we make it to start at position one
                if (position != 0)
                {
                    pigLatin = pigLatin + space;
                }
                else
                {
                    position = 1;
                }

                // Select the first charcater of the word
                firstLetter = isWord.Substring(0, 1);

                // Get the remaining characters after the first one
                extraLetter = isWord.Substring(1, isWord.Length - 1);

                //Arrange the words into pig latin and concatenate "ay" to the end of each word
                pigLatin = pigLatin + extraLetter + firstLetter + PigLatinConst;

               
            }

            //Return 
            return pigLatin.ToString();



        }

    }
}

