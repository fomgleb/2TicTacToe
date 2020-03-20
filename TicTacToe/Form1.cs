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
        private int player;
        private string playerName1, playerName2;
        public Form1()
        {
            InitializeComponent();
            Restart();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                switch (player)
                {
                    case 1:
                        sender.GetType().GetProperty("Text").SetValue(sender, "X");
                        sender.GetType().GetProperty("ForeColor").SetValue(sender, Color.Green);
                        player = 0;
                        break;
                    case 0:
                        sender.GetType().GetProperty("Text").SetValue(sender, "O");
                        sender.GetType().GetProperty("ForeColor").SetValue(sender, Color.Red);
                        player = 1;
                        break;
                    default:
                        break;
                }
                Set_Label_NextMove();
                Checkwin();
            }
            
        }

        void Restart()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            player = 1;

            Set_playersNames();
            Set_Label_NextMove();
        }

        private void Button_restart_Click(object sender, EventArgs e)
        {
            Restart();
            Set_playersNames();
        }
    }
}
