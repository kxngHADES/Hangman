/*******************************************
 * Author: Ndaedzo Mudau.                  *
 * Date: 13/09/2023                        *
 * Purpose: This form is the menu which    *
 * Links all the forms together            *
 *                                         *
 *                                         *
 * *****************************************
*/

using HangmanGamePortion.HighscoreDataTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace HangmanGamePortion
{
    public partial class Menu : Form
    {
        string player;
        public Menu()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string databasePath = @"C:\Users\Rudzani SCHOOL Work\Documents\Hangman Project\HangmanGamePortion\HangmanGamePortion\Highscores.accdb";
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";
            player = InputBox("", "Name");

            if (player != "")
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create a parameterized query to insert data into the database
                        string insertQuery = "INSERT INTO Highscores (sName, tDate) VALUES (?, ?)";
                        OleDbCommand command = new OleDbCommand(insertQuery, connection);

                        // Add parameters for player name and current date/time
                        command.Parameters.AddWithValue("sName", player);
                        string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        command.Parameters.AddWithValue("tDate", formattedDateTime); // Current date and time

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Player name and date inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert player name and date.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                new Game { PlayerName = player }.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Insert Player name please");
            }
        }


        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new HS().Show();
            this.Hide();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
        #region popUpInputBox
        public static string InputBox(string prompt, string title)
        {
            Form promptForm = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label label = new Label() { Left = 20, Top = 20, Text = prompt };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 250 };
            Button confirmButton = new Button() { Text = "OK", Left = 200, Width = 70, Top = 70, DialogResult = DialogResult.OK };
            promptForm.AcceptButton = confirmButton;

            confirmButton.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(label);
            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(confirmButton);

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        #endregion
    }
}
