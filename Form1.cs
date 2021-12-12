using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool againstComp;
        bool turn = true; //true - x turn, false - o turn
        int turnCount = 0, xCount=0, oCount=0, drawCount=0;
        public Form1(bool against)
        {
            InitializeComponent();
            againstComp = against;
            playWithComputer();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tПрограма розроблена студенткою групи КН19001\n\tВасиленко Оксаною у 2021 році", "Про програму");
        }
        public void playWithComputer()
        {
            if (againstComp)
                lbl_2Player.Text = "Комп'ютер (О):";
            else
                lbl_2Player.Text = "Гравець 2 (О):";
        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
                button.Text = "X";
            else
                button.Text = "O";
            turn = !turn;
            button.Enabled = false;
            turnCount++;
            checkWinner();

            if ((!turn) && (againstComp))
                computerMove();
        }
        private void computerMove()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = winOrBlock("O"); //look for win
            if (move == null)
            {
                move = winOrBlock("X"); //look for block
                if (move == null)
                {
                    move = findCorner();
                    if (move == null)
                        move = findOpenSpace();
                }
            }
            move.PerformClick();
        }
        private Button findOpenSpace()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }

        private Button findCorner()
        {
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        private Button winOrBlock(string mark)
        {
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }
        private void checkWinner()
        {
            bool winner = false;
            //horizontal 
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))           
                winner = true;           
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))            
                winner = true;

            //vertical
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            //diagonal
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                winner = true;

            if (winner)
            {
                disableButtons();

                String winnerName = "";

                if (turn)
                {
                    winnerName = "O";
                    oCount++;
                    o_winCount.Text = oCount.ToString();
                }
                else
                {
                    winnerName = "X";
                    xCount++;
                    x_winCount.Text = xCount.ToString();
                }
                MessageBox.Show(winnerName + " переміг!", "Вітання!");
                resetGame();
            }
            else
            {
                if (turnCount == 9)
                {
                    drawCount++;
                    darw_Count.Text = drawCount.ToString();
                    MessageBox.Show("Нічия!", "Вітання!");
                    resetGame();
                }
            }

        }

        private void disableButtons()
        {
            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
           
        }
        private void resetGame()
        {
            turn = true;
            turnCount = 0;
            foreach (Component c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void граПротиКомпютераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (againstComp)
                MessageBox.Show("Ви вже граєте проти комп'ютера", "Хммм..");
            else
            {
                againstComp = true;
                xCount = oCount = drawCount = 0;
                x_winCount.Text = o_winCount.Text = darw_Count.Text = xCount.ToString();
                resetGame();
                playWithComputer();
            }
        }

        private void гра1На1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!againstComp)
                MessageBox.Show("Ви вже граєте один проти одного", "Хммм..");
            else
            {
                againstComp = false;
                xCount = oCount = drawCount = 0;
                x_winCount.Text = o_winCount.Text = darw_Count.Text = xCount.ToString();
                resetGame();
                playWithComputer();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
            xCount = oCount = drawCount = 0;
            x_winCount.Text = o_winCount.Text = darw_Count.Text = xCount.ToString();
        }

        private void button_mouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_mouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }
    }
}
