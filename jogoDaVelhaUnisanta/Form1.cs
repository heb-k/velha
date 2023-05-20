using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoDaVelhaUnisanta
{
    public partial class Form1 : Form
    {
        
        string jogador = "X" ;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (btn1.Text == "X" || btn1.Text == "O")
            {
                MessageBox.Show("o botão já foi preenchido");
                //btn1.Enabled = false;
            }
            else
            {

                btn1.Text = jogador;
                if(jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }
                
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "X" || btn2.Text == "O")
            {
                MessageBox.Show("o botão já foi preenchido");
                //btn1.Enabled = false;
            }
            else
            {

                btn2.Text = jogador;
                if (jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "X" || btn3.Text == "O")
            {
                MessageBox.Show("o botão já foi preenchido");
                //btn1.Enabled = false;
            }
            else
            {

                btn3.Text = jogador;
                if (jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "X" || btn4.Text == "O")
            {
                MessageBox.Show("o botão já foi preenchido");
                //btn1.Enabled = false;
            }
            else
            {

                btn4.Text = jogador;
                if (jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "X" || btn5.Text == "O")
            {
                MessageBox.Show("o botão já foi preenchido");
                //btn1.Enabled = false;
            }
            else
            {

                btn5.Text = jogador;
                if (jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "X" || btn6.Text == "O")
            {
                MessageBox.Show("o botão já foi preenchido");
                //btn1.Enabled = false;
            }
            else
            {

                btn6.Text = jogador;
                if (jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "X" || btn7.Text == "O")
            {
                MessageBox.Show("o botão já foi preenchido");
                //btn1.Enabled = false;
            }
            else
            {

                btn7.Text = jogador;
                if (jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "X" || btn8.Text == "O")
            {
                MessageBox.Show("o botão já foi preenchido");
                //btn1.Enabled = false;
            }
            else
            {

                btn8.Text = jogador;
                if (jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "X" || btn9.Text == "O")
            {
                MessageBox.Show("o botão já foi preenchido");
                //btn1.Enabled = false;
            }
            else
            {

                btn9.Text = jogador;
                if (jogador == "X")
                {
                    jogador = "O";
                }
                else
                {
                    jogador = "X";
                }

            }
        }
    }
}
