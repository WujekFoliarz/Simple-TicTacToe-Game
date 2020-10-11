using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeCsharp
{
    public partial class Form1 : Form
    {
        public string turn { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            turn = "O";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == "O")
            {
                button1.Text = "O";
                turn = "X";
                button1.Enabled = false;
            }
            else if (turn == "X")
            {
                button1.Text = "X";
                turn = "O";
                button1.Enabled = false;
            }
            winCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == "O")
            {
                button2.Text = "O";
                turn = "X";
                button2.Enabled = false;
            }
            else if (turn == "X")
            {
                button2.Text = "X";
                turn = "O";
                button2.Enabled = false;
            }
            winCheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == "O")
            {
                button3.Text = "O";
                turn = "X";
                button3.Enabled = false;
            }
            else if (turn == "X")
            {
                button3.Text = "X";
                turn = "O";
                button3.Enabled = false;
            }
            winCheck();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == "O")
            {
                button4.Text = "O";
                turn = "X";
                button4.Enabled = false;
            }
            else if (turn == "X")
            {
                button4.Text = "X";
                turn = "O";
                button4.Enabled = false;
            }
            winCheck();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn == "O")
            {
                button5.Text = "O";
                turn = "X";
                button5.Enabled = false;
            }
            else if (turn == "X")
            {
                button5.Text = "X";
                turn = "O";
                button5.Enabled = false;
            }
            winCheck();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn == "O")
            {
                button6.Text = "O";
                turn = "X";
                button6.Enabled = false;
            }
            else if (turn == "X")
            {
                button6.Text = "X";
                turn = "O";
                button6.Enabled = false;
            }
            winCheck();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn == "O")
            {
                button7.Text = "O";
                turn = "X";
                button7.Enabled = false;
            }
            else if (turn == "X")
            {
                button7.Text = "X";
                turn = "O";
                button7.Enabled = false;
            }
            winCheck();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn == "O")
            {
                button8.Text = "O";
                turn = "X";
                button8.Enabled = false;
            }
            else if (turn == "X")
            {
                button8.Text = "X";
                turn = "O";
                button8.Enabled = false;
            }
            winCheck();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn == "O")
            {
                button9.Text = "O";
                turn = "X";
                button9.Enabled = false;
            }
            else if (turn == "X")
            {
                button9.Text = "X";
                turn = "O";
                button9.Enabled = false;
            }
            winCheck();
        }

        private void winCheck()
        {
                // Horizontal check
                if(button1.Text=="O"&& button2.Text == "O"&& button3.Text == "O")
                {
                    playerOWon();
                }
                else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    playerXWon();
                }

                if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    playerOWon();
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    playerXWon();
                }

                if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    playerOWon();
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    playerXWon();
                }

                // Vertical check
                if(button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    playerOWon();
                }
                else if(button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    playerXWon();
                }

                if(button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    playerOWon();
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    playerXWon();
                }

                if(button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    playerOWon();
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    playerXWon();
                }

                // Cross check
                if(button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    playerOWon();
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    playerXWon();
                }

                if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    playerOWon();
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    playerXWon();
                }
        }

        private void playerXWon()
        {
            MessageBox.Show("Player X won!");
            gameRestart();
        }

        private void playerOWon()
        {
            MessageBox.Show("Player O won!");
            gameRestart();
        }

        private void gameRestart()
        {
            turn = "O";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameRestart();
        }
    }
}
