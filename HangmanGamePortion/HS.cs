/*******************************************
 * Author: Ndaedzo Mudau.                  *
 * Date: 13/09/2023                        *
 * Purpose: Only the default code is used  *
 * as this form is just to display the play*
 * highscore which is stored in access     *
 * *****************************************
*/


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
    public partial class HS : Form
    {
        public HS()
        {
            InitializeComponent();
        }

        private void HS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'highscoreData.Highscores' table. You can move, or remove it, as needed.
            this.highscoresTableAdapter.Fill(this.highscoreData.Highscores);

        }

        private void HS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
