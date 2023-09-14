using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGamePortion
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

/* using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGamePart
{
    public partial class frmGame : Form
    {
        string[] words = { "banana", "apple", "orange", "strawberry", "watermelon" }; //Array of words
        int iLives = 9; //Attempts Left
        char[] guessedLetter; //Correctly guessed letters
        string challengeWord; //Word to be guessed
        public frmGame()
        {
            InitializeComponent();

        }

        private void InitializeGame()  //Here we let the game start creating 
        {
            Random random = new Random();
            challengeWord = words[random.Next(words.Length)]; //Sellect Random Word from array
            guessedLetter = new char[challengeWord.Length]; //Initialize Guess letters
            for (int i = 0; i < guessedLetter.Length; i++)
            {
                guessedLetter[i] = '*';
            }
            iLives = 9; //Reset Lives/Attempts of players
            UpdateGame(); //Call game
        }

        private void UpdateGame()
        {
            lblWords.Text = new string(guessedLetter);//
        }
    }
}
*/
