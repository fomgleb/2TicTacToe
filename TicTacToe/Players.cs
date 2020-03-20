using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public partial class Form1
    {
        void Set_playersNames()
        {
            if (TextBox_PlayerName1.Text != "")
            {
                playerName1 = TextBox_PlayerName1.Text;
            }
            else
            {
                TextBox_PlayerName1.Text = "Витя";
                playerName1 = TextBox_PlayerName1.Text;
            }
            if (TextBox_PlayerName2.Text != "")
            {
                playerName2 = TextBox_PlayerName2.Text;
            }
            else
            {
                TextBox_PlayerName2.Text = "Максим";
                playerName2 = TextBox_PlayerName2.Text;
            }
        }

        void Set_Label_NextMove()
        {
            if (player == 0)
            {
                Label_NextMove.Text = $"{playerName2} 'O'";
            }
            else
            {
                Label_NextMove.Text = $"{playerName1} 'X'";
            }
        }
    }
}
