// Dylan Smith, Spelling Bee Assignment
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingBee
{
    public partial class frmGame : Form
    {
        List<string> gameList; // Declare list of strings

        int size; //Declare variables
        string word;
        int numGuess = 0;
        int maxGuess = 5;

        public frmGame()
        {
            InitializeComponent();
            gameList = new List<string>() { "Lemur", "Monkey", "Penguin", "Ocean", "Trees" }; // Populate list
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            Random rdn = new Random(); // Pick a random string from the list 

            size = rdn.Next(gameList.Count);
            word = gameList[size];
                
            btnYes.Enabled = true; // Enables and disables certain buttons 
            btnNo.Enabled = true;
            btnPlay.Enabled = false;
            btnHint.Enabled = true;
            btnPlayAgain.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool vowelFound = true;
            foreach (char ch in txtAdd.Text) // Check each character in txtAdd and see if it contains any vowels
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++; // Add 1 to count for every vowel found in the entered word
                }                             
            }
            if (count < 2) // Set vowelFound equal to false if count is less than 2
            {
                vowelFound = false;
            }
            if (txtAdd.Text.Length >= 4 && txtAdd.Text.Length <= 8 && vowelFound) // Add txtAdd.Text to game list if it meets all these requirements
            {
                gameList.Add(txtAdd.Text);
            }

            else
            {
                MessageBox.Show("New words must be between 4 to 8 letters and contain at least 2 vowels. Try Again."); // Display message
            }        
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unlucky! The word was: " + word + ". Better luck next time! Press OK and then Play Again or Exit!");
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit application
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (numGuess >= maxGuess - 1) // If current guess is more than the max guesses allowed display an error message then restart application
            {
                DialogResult diaRestart = MessageBox.Show("You have reached the maximum number of guesses allowed: " + maxGuess + ". Press OK to restart game.");
                if (diaRestart == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else if (txtGuess.Text == word) // If user guesses correctly display message along with how many guesses it took
            {
                numGuess++;
                DialogResult diaCorrect = MessageBox.Show("Correct! The word was: " + word + ". You did it within: " + numGuess + " guess(es), Well Done!");
                if (diaCorrect == DialogResult.OK) // If user clicks OK on message box then enable the play button
                {
                    btnPlay.Enabled = true;
                }
            }
            else
            {
                string guessed = txtGuess.Text;
                string correct = "";

                if (guessed.Length == word.Length) // If guess contains the same number of letters as hidden word then check the word letter by letter and display any correct letters
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guessed[i])
                        {
                            correct += guessed[i];
                        }
                        else
                        {
                            correct += "*"; // Any letters not guessed will be replaced with a *
                        }
                    }
                    numGuess++;
                    MessageBox.Show("Wrong! Press ok to try again. You have used: " + numGuess + " out of your: " + maxGuess + " guesses. Correctly guessed letters: " + correct);
                }
                else
                {
                    numGuess++;
                    MessageBox.Show("You have entered either too many or not enough letters! Press OK to try again! You have used: " + numGuess + " out of your: " + maxGuess);
                }

            }       
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNo.Enabled = false;
            btnFinished.Enabled = true;
            btnYes.Enabled = false;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btnGiveUp.Enabled = true;
            btnGuess.Enabled = true;
            btnYes.Enabled = false;
            btnNo.Enabled = false;
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            btnGiveUp.Enabled = true;
            btnGuess.Enabled = true;
            btnAdd.Enabled = false;
            btnFinished.Enabled = false;
        }

        private void txtHint_Click(object sender, EventArgs e) // Hints for words already in the list if they're picked 
        {
            if (word == "Lemur")
            {
                MessageBox.Show("The word is an animal who lives in the trees of Madagascar! Begins with the letter L.");
            }
            else if (word == "Penguin")
            {
                MessageBox.Show("The word is an animal that is a flightless bird that are mostly found in cold climates!");
            }
            else if (word == "Ocean")
            {
                MessageBox.Show("Fish live here! 5 letter word.");
            }
            else if (word == "Trees")
            {
                MessageBox.Show("There is 390 billion of these in the Amazon! 5 letter word.");
            }
            else if (word == "Monkey")
            {
                MessageBox.Show("6 letter word. Normally live in tropical rainforests and begins with the letter M.");
            }
            else
            {
                int wordSize = word.Length; // Displays this hint for any words added by the user
                MessageBox.Show("Hint: The length of the current word is: " + wordSize + ", and the first letter of the word is: " + word[0]); // Length and first letter of current word
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            if (gameList.Count > 0) // If any words remain in the list pick another one at random
            {
                Random rdn = new Random();

                size = rdn.Next(0, gameList.Count);
                word = gameList[size];
                gameList.RemoveAt(size); // Remove previous word from list
                numGuess = 0; // Reset value of numGuess
            }
            else
            {
                DialogResult diaEndGame = MessageBox.Show("There are no more available words left. Press OK to exit the game. Thanks for playing!"); // Display error message if no words left in the list
                if (diaEndGame == DialogResult.OK)
                {
                    Application.Exit(); // Exit application when user hits OK on message box
                }
            }
        }

    }
}
