using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u25630998_INF164_Practical_2._1
{
    public partial class frmTicTacToe : Form
    {

        // Global variables to manage the game state
        private bool turn = true; // True for Player X's turn, False for Player O's turn
        private int turn_count = 0;
        private bool gameIsOver = false;

        public frmTicTacToe()
        {
            InitializeComponent();
            
        }

        private void frmTicTacToe_Load(object sender, EventArgs e)
        {
            

            Random number = new Random();
            
            if(number.Next(0, 2) == 0)
            {
                turn = true;
                rdoX.Checked = Enabled;
            }
            else
            {
                turn = false;
                rdoO.Checked = Enabled;
            }
            rdoO.Enabled = false;
            rdoX.Enabled = false;
        }

        // This is a generic event handler for all 9 tic tac toe buttons
        private void btn_Click(object sender, EventArgs e)
        {
            // Use a try-catch block for basic error handling
            try
            {
                // Cast the sender object to a Button
                Button btn = (Button)sender;
                takeTurn(btn);

                // After each turn, check for a win or a draw
                checkWin();
                checkDraw();
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void takeTurn(Button btn)
        {
            // Only allow a move if the button is not already taken and the game is not over
            if (btn.Text == "" && !gameIsOver)
            {
                if (turn) // Player X's turn
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Red;
                    rdoO.Checked = true;
                }
                else // Player O's turn
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Blue;
                    rdoX.Checked = true;
                }
                btn.Enabled = false; // Disable the button after it's been used

                // Change the button's background color to red as requested
                btn.BackColor = Color.LightCoral;

                turn = !turn; // Switch the turn
                turn_count++; // Increment the turn counter
            }

        }

        private void checkWin()
        {
            // The checkWhoWon method will handle displaying the message
            string winner = checkWhoWon();
            if (!string.IsNullOrEmpty(winner))
            {
                // First, highlight winning buttons
                highlightWinningButtons(winner);
                // Then, show the message box
                MessageBox.Show($"{winner} has won the game!", "Winner Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                disableAllButtons();
                gameIsOver = true;
                // Automatically reset the game after the message box is closed
                resetGame();
            }
        }

        private void checkDraw()
        {
            // A draw occurs if all 9 turns have been taken and there's no winner
            if (turn_count == 9 && !gameIsOver)
            {
                MessageBox.Show("The game is a draw!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disableAllButtons();
                gameIsOver = true;
                // Automatically reset the game after the message box is closed
                resetGame();
            }
        }

        private void resetGame()
        {
            // Reset all global variables
            turn_count = 0;
            gameIsOver = false;

            // Reset all buttons
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name.StartsWith("btn") && control.Name != "btnReset")
                {
                    Button btn = (Button)control;
                    btn.Enabled = true;
                    btn.Text = "";
                    btn.BackColor = SystemColors.Control; // Reset to default background color
                }
            }

            // Randomly select a new starting player
            frmTicTacToe_Load(this, EventArgs.Empty);
        }

        private string checkWhoWon()
        {
            // Horizontal Checks
            if ((btnTopLeft.Text != "") && (btnTopLeft.Text == btnTopMiddle.Text) && (btnTopMiddle.Text == btnTopRight.Text))
            {
                return btnTopLeft.Text;
            }
            if ((btnMiddleLeft.Text != "") && (btnMiddleLeft.Text == btnMiddle.Text) && (btnMiddle.Text == btnMiddleRight.Text))
            {
                return btnMiddleLeft.Text;
            }
            if ((btnBottomLeft.Text != "") && (btnBottomLeft.Text == btnBottomMiddle.Text) && (btnBottomMiddle.Text == btnBottomRight.Text))
            {
                return btnBottomLeft.Text;
            }

            // Vertical Checks
            if ((btnTopLeft.Text != "") && (btnTopLeft.Text == btnMiddleLeft.Text) && (btnMiddleLeft.Text == btnBottomLeft.Text))
            {
                return btnTopLeft.Text;
            }
            if ((btnTopMiddle.Text != "") && (btnTopMiddle.Text == btnMiddle.Text) && (btnMiddle.Text == btnBottomMiddle.Text))
            {
                return btnTopMiddle.Text;
            }
            if ((btnTopRight.Text != "") && (btnTopRight.Text == btnMiddleRight.Text) && (btnMiddleRight.Text == btnBottomRight.Text))
            {
                return btnTopRight.Text;
            }

            // Diagonal Checks
            if ((btnTopLeft.Text != "") && (btnTopLeft.Text == btnMiddle.Text) && (btnMiddle.Text == btnBottomRight.Text))
            {
                return btnTopLeft.Text;
            }
            if ((btnTopRight.Text != "") && (btnTopRight.Text == btnMiddle.Text) && (btnMiddle.Text == btnBottomLeft.Text))
            {
                return btnTopRight.Text;
            }

            return ""; // No winner found
        }

        private void disableAllButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name.StartsWith("btn") && control.Name != "btnReset")
                {
                    control.Enabled = false;
                }
            }
        }

        private void highlightWinningButtons(string winner)
        {
            // This is a simplified check, you could make it more efficient
            // by storing the winning combination in a variable.

            // Horizontal
            if ((btnTopLeft.Text == winner) && (btnTopMiddle.Text == winner) && (btnTopRight.Text == winner))
            {
                btnTopLeft.BackColor = Color.Green;
                btnTopMiddle.BackColor = Color.Green;
                btnTopRight.BackColor = Color.Green;
            }
            if ((btnMiddleLeft.Text == winner) && (btnMiddle.Text == winner) && (btnMiddleRight.Text == winner))
            {
                btnMiddleLeft.BackColor = Color.Green;
                btnMiddle.BackColor = Color.Green;
                btnMiddleRight.BackColor = Color.Green;
            }
            if ((btnBottomLeft.Text == winner) && (btnBottomMiddle.Text == winner) && (btnBottomRight.Text == winner))
            {
                btnBottomLeft.BackColor = Color.Green;
                btnBottomMiddle.BackColor = Color.Green;
                btnBottomRight.BackColor = Color.Green;
            }

            // Vertical
            if ((btnTopLeft.Text == winner) && (btnMiddleLeft.Text == winner) && (btnBottomLeft.Text == winner))
            {
                btnTopLeft.BackColor = Color.Green;
                btnMiddleLeft.BackColor = Color.Green;
                btnBottomLeft.BackColor = Color.Green;
            }
            if ((btnTopMiddle.Text == winner) && (btnMiddle.Text == winner) && (btnBottomMiddle.Text == winner))
            {
                btnTopMiddle.BackColor = Color.Green;
                btnMiddle.BackColor = Color.Green;
                btnBottomMiddle.BackColor = Color.Green;
            }
            if ((btnTopRight.Text == winner) && (btnMiddleRight.Text == winner) && (btnBottomRight.Text == winner))
            {
                btnTopRight.BackColor = Color.Green;
                btnMiddleRight.BackColor = Color.Green;
                btnBottomRight.BackColor = Color.Green;
            }

            // Diagonal
            if ((btnTopLeft.Text == winner) && (btnMiddle.Text == winner) && (btnBottomRight.Text == winner))
            {
                btnTopLeft.BackColor = Color.Green;
                btnMiddle.BackColor = Color.Green;
                btnBottomRight.BackColor = Color.Green;
            }
            if ((btnTopRight.Text == winner) && (btnMiddle.Text == winner) && (btnBottomLeft.Text == winner))
            {
                btnTopRight.BackColor = Color.Green;
                btnMiddle.BackColor = Color.Green;
                btnBottomLeft.BackColor = Color.Green;
            }
        }


        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            takeTurn(btnTopLeft);
            checkDraw();
            checkWin();
        }


        private void btnTopMiddle_Click_1(object sender, EventArgs e)
        {
            takeTurn(btnTopMiddle);
            checkDraw();
            checkWin();
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            takeTurn(btnTopRight);
            checkDraw();
            checkWin();
        }

        private void btnMiddleLeft_Click(object sender, EventArgs e)
        {
            takeTurn(btnMiddleLeft);
            checkDraw();
            checkWin();

        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            takeTurn(btnMiddle);
            checkDraw();
            checkWin();
        }

        private void btnMiddleRight_Click(object sender, EventArgs e)
        {
            takeTurn(btnMiddleRight);
            checkDraw();
            checkWin();
        }

        private void btnBottomLeft_Click(object sender, EventArgs e)
        {
            takeTurn(btnBottomLeft);
            checkDraw();
            checkWin();
        }

        private void btnBottomMiddle_Click(object sender, EventArgs e)
        {
            takeTurn(btnBottomMiddle);
            checkDraw();
            checkWin();
        }

        private void btnBottomRight_Click(object sender, EventArgs e)
        {
            takeTurn(btnBottomRight);
            checkDraw();
            checkWin();
        }
    }
}
