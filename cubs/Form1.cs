using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cubs
{
    public partial class Form1 : Form
    {
        int HowManyPop = 5,
            UserScore = 0,
            VertScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void CUBs(int cub, PictureBox PB)
            {
            switch (cub)
            {
                case 1:
                    PB.Image = Image.FromFile("cub1.png");
                    break;
                case 2:
                    PB.Image = Image.FromFile("cub2.png");
                    break;
                case 3:
                    PB.Image = Image.FromFile("cub3.png");
                    break;
                case 4:
                    PB.Image = Image.FromFile("cub4.png");
                    break;
                case 5:
                    PB.Image = Image.FromFile("cub5.png");
                    break;
                case 6:
                    PB.Image = Image.FromFile("cub6.png");
                    break;
            }
        }

        private void gameCOM_Click_1(object sender, EventArgs e)
        {
            gameCOM.Text = "ERROR";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HowManyPop = 5;
            label4.Text = "осталось попыток: " + HowManyPop;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            for (int i = 1; i < 6; i++)
            {
                PictureBox PB1 = groupBox1.Controls["UserPB" + i] as PictureBox;
                PictureBox PB2 = groupBox1.Controls["VertPB" + i] as PictureBox;
                PB1.Image = null;
                PB2.Image = null;
                UserScore = 0;
                VertScore = 0;
                label6.Text = "Игрок: 0";
                label7.Text = "Комп: 0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (HowManyPop > 0)
            {
                Random R = new Random();
                int USERcub = R.Next(1, 7),
                    VERTcub = R.Next(1, 7);
                CUBs(USERcub, pictureBox1);
                CUBs(VERTcub, pictureBox2);
                PictureBox UserBox = groupBox1.Controls["UserPB" + HowManyPop] as PictureBox;
                PictureBox VertBox = groupBox1.Controls["VertPB" + HowManyPop] as PictureBox;
                CUBs(USERcub, UserBox);
                CUBs(VERTcub, VertBox);
                HowManyPop--;
                UserScore += USERcub;
                label6.Text = "Игрок: " + UserScore;
                VertScore += VERTcub;
                label7.Text = "Комп: " + VertScore;
                label4.Text = "осталось попыток: " + HowManyPop;
            }
            else
            {
                string WhoWin = "";
                if (VertScore > UserScore)
                {
                    WhoWin = "Комп победил со счётом" + VertScore;
                }
                else if (VertScore < UserScore)
                {
                    WhoWin = "Игрок победил со счётом" + UserScore;
                }
                else
                {

                }
                DialogResult RES = MessageBox.Show("Попытки закончились\n" +
                    "Хотите ли вы начать новую игру\n" + WhoWin, "Game over",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    button1.PerformClick();
                }   
            }
        }  
    }
}
