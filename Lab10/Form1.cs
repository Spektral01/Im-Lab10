using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] team_lambda = new double[8];
        string[] teams = new string[8] { "Team1", "Team2", "Team3", "Team4", "Team5", "Team6", "Team7", "Team8" };
        private void genBtn_Click(object sender, EventArgs e)
        {
            teams = new string[8] { "Team1", "Team2", "Team3", "Team4", "Team5", "Team6", "Team7", "Team8" };

            grid_team.Rows.Clear();
            Random rnd = new Random();
            for (int i = 0; i < teams.Length; i++)
            {
                team_lambda[i] = (double)rnd.Next(991111) / 10000;
                grid_team.Rows.Add(teams[i], team_lambda[i]);
            }
            start = false;
            for (int i = 0; i < 8; i++)
            {
                string labelName = "pos" + (i + 1).ToString();
                Label label = (Label)Controls[labelName];
                label.Text = "";
            }
            pos12.Text = "";
            pos13.Text = "";
            pos15.Text = "";
            pos34.Text = "";
            pos56.Text = "";
            pos57.Text = "";
            pos78.Text = "";

        }

        public bool start = false;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.Gray, 2);
            Point p1 = new Point(315, 20);  
            Point p2 = new Point(380, 20);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(315, 125);
            p2 = new Point(380, 125);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(380, 20);
            p2 = new Point(380, 125);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(380, 72);
            p2 = new Point(450, 72);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(315, 270);
            p2 = new Point(380, 270);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(315, 410);
            p2 = new Point(380, 410);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(380, 410);
            p2 = new Point(380, 270);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(380, 340);
            p2 = new Point(450, 340);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(470, 72);
            p2 = new Point(510, 72);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(470, 340);
            p2 = new Point(510, 340);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(510, 72);
            p2 = new Point(510, 340);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(510, 206);
            p2 = new Point(540, 206);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(540, 206);
            p2 = new Point(690, 206);
            gr.DrawLine(p, p1, p2);

            ////left to mid complete

            p1 = new Point(690, 206);
            p2 = new Point(790, 206);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(790, 72);
            p2 = new Point(790, 340);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(790, 72);
            p2 = new Point(850, 72);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(790, 340);
            p2 = new Point(850, 340);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(880, 72);
            p2 = new Point(920, 72);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(380, 410);
            p2 = new Point(380, 270);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(380, 340);
            p2 = new Point(450, 340);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(470, 72);
            p2 = new Point(510, 72);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(880, 340);
            p2 = new Point(920, 340);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(920, 410);
            p2 = new Point(920, 270);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(920, 410);
            p2 = new Point(960, 410);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(920, 270);
            p2 = new Point(960, 270);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(920, 20);
            p2 = new Point(920, 125);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(920, 20);
            p2 = new Point(960, 20);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(920, 125);
            p2 = new Point(960, 125);
            gr.DrawLine(p, p1, p2);

            p1 = new Point(645, 20);
            p2 = new Point(645, 206);
            gr.DrawLine(p, p1, p2);

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (start)
            {
                MessageBox.Show("Перегенерируйте команды, пожалуйста!");
                start = false;
            }
            else start = true;

            SkillSort();

            
           
                for (int i = 0; i < 8; i++)
                {
                    string labelName = "pos" + (i + 1).ToString();
                    Label label = (Label)Controls[labelName];
                    label.Text = teams[i];
                }
          
                for(int i=0;i<3;i++)
                {
                    playGames(i);
                }

        }

        private void playGames(int i)
        {
            switch (i)
            {
                case 0:
                    playRound(team_lambda[0], team_lambda[1], 0, 1) ;
                    playRound(team_lambda[2], team_lambda[3], 2, 3) ;
                    playRound(team_lambda[4], team_lambda[5], 4, 5) ;
                    playRound(team_lambda[6], team_lambda[7], 6, 7) ;
                    break;
                case 1:
                    playRound(team_lambda[0], team_lambda[2], 0, 2);
                    playRound(team_lambda[4], team_lambda[6], 4, 6);
                    break;
                case 2:
                    playRound(team_lambda[0], team_lambda[4], 0, 4);
                    break;
                default:

                    break;
            }
        }

        private void playRound(double aParam, double bParam, int i, int j)
        {
            int a, b;
            
            Random rnd1 = new Random();
            a = getValue(aParam, rnd1);
            b = getValue(bParam, rnd1);

            if (a > b)
            {
                team_lambda[i] = team_lambda[i];
                teams[i] = teams[i];
                string labelName = "pos" + (i+1).ToString() + (j+1).ToString();
                Label label = (Label)Controls[labelName];
                label.Text = teams[i];
            }
            if (a < b)
            {
                team_lambda[i] = team_lambda[j];
                teams[i] = teams[j];
                string labelName = "pos" + (i+1).ToString() + (j+1).ToString();
                Label label = (Label)Controls[labelName];
                label.Text = teams[i];
            }
            if (a == b)
            {
                playRound(team_lambda[i], team_lambda[j], i, j);
            }
        }

        public int getValue(double lambda, Random rnd)
        {
            int x = 0;
            double sum = 0;

            while (sum > -lambda)
            {
                sum += Math.Log(rnd.NextDouble());
                x++;
            }
            x -= 1;

            return x;
        }

        private void SkillSort()
        {
            for (int i = 0; i < 8 - 1; i++)
            {
                for (int j = 0; j < 8 - i - 1; j++)
                {
                    if (team_lambda[j] > team_lambda[j + 1])
                    {
                        double temp = team_lambda[j];
                        team_lambda[j] = team_lambda[j + 1];
                        team_lambda[j + 1] = temp;

                        string strTemp = teams[j];
                        teams[j] = teams[j + 1];
                        teams[j + 1] = strTemp;
                    }
                }
            }
        }
    }
}
