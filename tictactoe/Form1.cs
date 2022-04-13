using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        Button[,] dokmeha;
        int ply;
        public Form1()
        {
            InitializeComponent();
            ply = 1;

            dokmeha = new Button[3, 3] {{button1,button2,button3},
                                                 {button4,button5,button6},
                                                 {button7,button8,button9}};

            new_game();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (ply == 1)
                {
                    this_button.Text = "❌";
                    this_button.ForeColor = Color.Green;
                    this_button.BackColor = Color.LightGreen;
                    ply = 2;
                }
                else if (ply == 2)
                {
                    this_button.Text = "🔵";
                    this_button.ForeColor = Color.Red;
                    this_button.BackColor = Color.Pink;
                    ply = 1;
                }
                check_game();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new_game();

        }
        private void new_game()
        {
            ply = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                    dokmeha[i, j].Text = "";
                }
            }

        }
        private void check_game()
        {
            if (dokmeha[0, 0].Text == "❌" && dokmeha[0, 1].Text == "❌" && dokmeha[0, 2].Text == "❌")
            {
                MessageBox.Show("بازیکن ۱ برنده شد");
                new_game();
            }
            if (dokmeha[1, 0].Text == "❌" && dokmeha[1, 1].Text == "❌" && dokmeha[1, 2].Text == "❌")
            {
                MessageBox.Show("بازیکن ۱ برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "❌" && dokmeha[2, 1].Text == "❌" && dokmeha[2, 2].Text == "❌")
            {
                MessageBox.Show("بازیکن ۱ برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "❌" && dokmeha[1, 0].Text == "❌" && dokmeha[2, 0].Text == "❌")
            {
                MessageBox.Show("بازیکن ۱ برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "❌" && dokmeha[1, 1].Text == "❌" && dokmeha[2, 1].Text == "❌")
            {
                MessageBox.Show("بازیکن ۱ برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "❌" && dokmeha[1, 2].Text == "❌" && dokmeha[2, 2].Text == "❌")
            {
                MessageBox.Show("بازیکن ۱ برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "❌" && dokmeha[1, 1].Text == "❌" && dokmeha[2, 2].Text == "❌")
            {
                MessageBox.Show("بازیکن ۱ برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "❌" && dokmeha[1, 1].Text == "❌" && dokmeha[2, 0].Text == "❌")
            {
                MessageBox.Show("بازیکن ۱ برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "🔵" && dokmeha[0, 1].Text == "🔵" && dokmeha[0, 2].Text == "🔵")
            {
                MessageBox.Show("بازیکن ۲ برنده شد");
                new_game();
            }
            if (dokmeha[1, 0].Text == "🔵" && dokmeha[1, 1].Text == "🔵" && dokmeha[1, 2].Text == "🔵")
            {
                MessageBox.Show("بازیکن ۲ برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "🔵" && dokmeha[2, 1].Text == "🔵" && dokmeha[2, 2].Text == "🔵")
            {
                MessageBox.Show("بازیکن ۲ برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "🔵" && dokmeha[1, 0].Text == "🔵" && dokmeha[2, 0].Text == "🔵")
            {
                MessageBox.Show("بازیکن ۲ برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "🔵" && dokmeha[1, 1].Text == "🔵" && dokmeha[2, 1].Text == "🔵")
            {
                MessageBox.Show("بازیکن ۲ برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "🔵" && dokmeha[1, 2].Text == "🔵" && dokmeha[2, 2].Text == "🔵")
            {
                MessageBox.Show("بازیکن ۲ برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "🔵" && dokmeha[1, 1].Text == "🔵" && dokmeha[2, 2].Text == "🔵")
            {
                MessageBox.Show("بازیکن ۲ برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "🔵" && dokmeha[1, 1].Text == "🔵" && dokmeha[2, 0].Text == "🔵")
            {
                MessageBox.Show("بازیکن ۲ برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text != "" && dokmeha[0, 1].Text != "" && dokmeha[0, 2].Text != "" &&
               dokmeha[1, 0].Text != "" && dokmeha[1, 1].Text != "" && dokmeha[1, 2].Text != "" &&
               dokmeha[2, 0].Text != "" && dokmeha[2, 1].Text != "" && dokmeha[2, 2].Text != "")
            {
                MessageBox.Show("بازی مساوی شد!");
                new_game();

            }
        }
    }
}


