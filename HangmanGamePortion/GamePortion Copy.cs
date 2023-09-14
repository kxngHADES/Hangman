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
        string[] words = { "banana", "apple", "orange", "strawberry", "watermelon" }; //Array of words
        int iLives = 10; //Attempts Left
        int score = 0; //Score gain
        char[] guessedLetters; //Correctly guessed letters
        string challengeWord; //Word to be guessed
        List<char> wrongLetters = new List<char>();
        List<string> scoreList = new List<string>();
        public Game()
        {
            InitializeComponent();
            this.KeyPreview = true;
            InitializeGame();
        }
        private void InitializeGame()  //Here we let the game start creating 
        {
            Random random = new Random();
            challengeWord = words[random.Next(words.Length)]; //Sellect Random Word from array
            guessedLetters = new char[challengeWord.Length]; //Initialize Guess letters
            for (int i = 0; i < challengeWord.Length; i++)
            {
                guessedLetters[i] = '*';
            }
            score = score;
            iLives = 10; //Reset Lives/Attempts of players
            wrongLetters.Clear();//Clear list of wrong letters
            UpdateGame(); //Call game
        }
        private void UpdateGame()
        {
            lblWord.Text = new string(guessedLetters);//Display Current guessed word
            lblLives.Text = "Lives Left: " + iLives; //Shows attempts left
            lblWrong.Text = "Wrong Letters: " + string.Join(", ", wrongLetters);
            lblScore.Text = "Score: " + score;

            if (iLives == 0) 
            {
                MessageBox.Show("You have run out of Lives. The word was: " + challengeWord, "Game Over Mate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreList.Add("Score: " + score); //Add score to list
                score = 0; //reset score
                InitializeGame(); //Start New game
            }
        }

        private void CheckLetter(char guessedLetter)
        {
            bool LetterIsCoorect = false;
            for (int i = 0; i < challengeWord.Length; i++)
            {
                if (challengeWord[i] == guessedLetter)
                {
                    guessedLetters[i] = guessedLetter; //Update guessed letter array
                    score = score + 10;
                    LetterIsCoorect = true;
                }
            }
            if (!LetterIsCoorect)
            {
                iLives--; //Reduce Lives
                wrongLetters.Add(guessedLetter);
                score = score - 2;
            }

            if (new string(guessedLetters) == challengeWord)
            {
                score = score + 100;
                MessageBox.Show("Congrats!!! You guessed the word: " + challengeWord + " with a score of: " + score, "You WIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreList.Add("Score: " + score); //Add score to list
                InitializeGame();
            }

            UpdateGame(); //Update the User Interface
        }


        private void Game_Load(object sender, EventArgs e)
        {
            this.KeyPress += new KeyPressEventHandler(Game_KeyPress);
            this.Focus();
            tbxLetter.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbxLetter.Text.Length > 0) //Make sure user only inputs 1 letter
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
    }
}
