/*******************************************
 * Author: Ndaedzo Mudau.                  *
 * Date: 13/09/2023                        *
 * Purpose: This form will run the game.   *
 * It will take the users input and when   *
 * enter is clicked it will run code to    *
 * if the letter entered is correct        *
 * *****************************************
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGamePortion
{
    public partial class Game : Form
    {
        string[] words = 
        {
            "apple", "banana", "car", "dog", "elephant",
            "flower", "guitar", "hat", "ice", "jacket",
            "kite", "lamp", "mountain", "notebook", "ocean",
            "pencil", "quilt", "rainbow", "sun", "tree",
            "pizza", "burger", "spaghetti", "salad", "soup",
            "cake", "cookie", "juice", "chocolate", "cheese",
            "alacrity", "cacophony", "defenestration", "ebullient", "facetious",
            "garrulous", "hirsute", "iconoclast", "jejune", "kaleidoscope",
            "labyrinthine", "mellifluous", "nadir", "obfuscate", "peregrinate",
            "quixotic", "recumbent", "serendipity", "taciturn", "ubiquitous",
            "verisimilitude", "wanderlust"
        };//Here is 52 words that the user has to guess from

        int iLives = 10; //Attempts Left
        int score = 0; //Score gain
        char[] guessedLetters; //Correctly guessed letters
        string challengeWord; //Word to be guessed
        List<char> wrongLetters = new List<char>(); //Store all incorrect letters entered
        List<string> scoreList = new List<string>(); //Keep track of user score
        int iRound = 1;

        public string PlayerName { get; set; }
        public Game()
        {
            InitializeComponent(); 
            this.KeyPreview = true;
            InitializeGame(); //Starts the game
        }
        private void InitializeGame()  //Here we let the game start creating 
        {
            Random random = new Random(); //Random identifier is declared and
            challengeWord = words[random.Next(words.Length)]; //Sellect Random Word from array
            guessedLetters = new char[challengeWord.Length]; //Initialize Guess letters
            for (int i = 0; i < challengeWord.Length; i++)
            {
                guessedLetters[i] = '*';//Use * as a place holder for the letters that are hidden
            }
            iLives = 10; //Reset Lives/Attempts of players
            wrongLetters.Clear();//Clear list of wrong letters
            lblCorrect.Text = "Correct Letters: ";
            UpdateGame(); //Call game
        }
        private void UpdateGame() //Called after check letter event
        {
            lblWord.Text = new string(guessedLetters);//Display Current guessed word
            lblLives.Text = "Lives Left: " + iLives; //Shows attempts left
            lblWrong.Text = "Wrong Letters: " + string.Join(", ", wrongLetters); //Add incorret letter
            lblScore.Text = "Score: " + score; //Writes the score at the current moment
            lblRounds.Text = "Round: " + iRound;

            if (iLives == 0) 
            {
                MessageBox.Show("You have run out of Lives. The word was: " +
                    challengeWord, "Game Over Mate", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                scoreList.Add("Score: " + score); //Add score to list
                score = 0; //reset score
                InitializeGame(); //Start New game
            }
        }

        //check letter
        private void CheckLetter(char guessedLetter) 
        {
            bool letterIsCorrect = false;
            bool letterIsAlreadyGuessed = false;

            for (int i = 0; i < challengeWord.Length; i++) //loops to check every letter
            {
                if (challengeWord[i] == guessedLetter)//Checks if letter inserted is correct
                {
                    if (guessedLetters[i] == '*') // Check if the letter is already correctly guessed
                    {
                        guessedLetters[i] = guessedLetter; // Update guessed letter array
                        score += 10;
                        letterIsCorrect = true;
                        lblCorrect.Text = lblCorrect.Text + string.Join(", ", guessedLetter);
                    }
                    else
                    {
                        letterIsAlreadyGuessed = true;
                    }
                }
            }

            if (!letterIsCorrect)
            {
                // Check if the letter has already been guessed incorrectly
                if (!wrongLetters.Contains(guessedLetter))
                {
                    iLives--; // Reduce Lives
                    score -= 2;
                    wrongLetters.Add(guessedLetter);
                }
                else
                {
                    letterIsAlreadyGuessed = true;
                }
            }

            if (new string(guessedLetters) == challengeWord)
            {
                score += 100;
                MessageBox.Show("Congrats!!! You guessed the word: " + challengeWord + " with a score of: " + score, "You WIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreList.Add("Score: " + score); // Add score to list
                iRound = iRound + 1;
                InitializeGame();
            }

            if (letterIsAlreadyGuessed && !letterIsCorrect)
            {
                MessageBox.Show("The letter '" + guessedLetter + "' has already been guessed incorrectly.", "Letter Already Guessed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            UpdateGame(); // Update the User Interface
        }



        private void Game_Load(object sender, EventArgs e)
        {
            this.KeyPress += new KeyPressEventHandler(Game_KeyPress);
            this.Focus();
            tbxLetter.Focus();

            lblName.Text = PlayerName;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbxLetter.Text.Length > 0) //Makes sure user only inputs 1 letter
            {
                char guessedLetter = char.ToLower(tbxLetter.Text[0]);
                CheckLetter(guessedLetter);
                tbxLetter.Clear(); //Clear input
            } 
        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                char guessedLetter = char.ToLower(e.KeyChar);
                CheckLetter(guessedLetter);
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void Game_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            tbxLetter.Text = "" + e.KeyChar;
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void lblWord_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
