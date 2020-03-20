using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1
    {
        private void Checkwin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                WinMessage(button1.Text);
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                WinMessage(button4.Text);
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                WinMessage(button7.Text);
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                WinMessage(button1.Text);
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                WinMessage(button2.Text);
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                WinMessage(button3.Text);
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                WinMessage(button1.Text);
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                WinMessage(button3.Text);
            }
            NothingWinner();
        }

        void WinMessage(string btn_text)
        {
            if (btn_text != "")
            {
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
