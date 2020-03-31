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

            button1.BackColor = Color.Empty;
            button2.BackColor = Color.Empty;
            button3.BackColor = Color.Empty;
            button4.BackColor = Color.Empty;
            button5.BackColor = Color.Empty;
            button6.BackColor = Color.Empty;
            button7.BackColor = Color.Empty;
            button8.BackColor = Color.Empty;
            button9.BackColor = Color.Empty;

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
