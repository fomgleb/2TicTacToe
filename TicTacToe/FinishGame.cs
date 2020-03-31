using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    public partial class Form1
    {
        private void Checkwin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                WinMessage(button1.Text, button1, button2, button3);
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                WinMessage(button4.Text, button4, button5, button6);
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                WinMessage(button7.Text, button7, button8, button9);
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                WinMessage(button1.Text, button1, button4, button7);
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                WinMessage(button2.Text, button2, button5, button8);
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                WinMessage(button3.Text, button3, button6, button9);
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                WinMessage(button1.Text, button1, button5, button9);
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                WinMessage(button3.Text, button3, button5, button7);
            }
            NothingWinner();
        }

        void SetBackColor(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Yellow;
            b2.BackColor = Color.Yellow;
            b3.BackColor = Color.Yellow;
        }

        void WinMessage(string btn_text, Button b1, Button b2, Button b3)
        {
            if (btn_text != "")
            {
                SetBackColor(b1, b2, b3);
                if (player == 1)
                    MessageBox.Show($"{playerName2} 'O' победил");
                else
                    MessageBox.Show($"{playerName1} 'X' победил");
                Restart();
            }
        }

        void NothingWinner()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" 
             && button4.Text != "" && button5.Text != "" && button6.Text != "" 
             && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                string tmp;
                tmp = TextBox_PlayerName1.Text;
                TextBox_PlayerName1.Text = TextBox_PlayerName2.Text;
                TextBox_PlayerName2.Text = tmp;
                MessageBox.Show("Ничья");
                Restart();
            }
        }
    }
}
