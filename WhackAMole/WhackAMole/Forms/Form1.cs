using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhackAMole.Class;

namespace WhackAMole
{


    public partial class Form1 : Form
    {
        public static Stopwatch sw = new Stopwatch();
        Random random = new Random();

        //stats to keep track, just for fun
        int showtime = 0;
        int Lives = 3;
        int Hits = 0;
        int Score = 0;
        int Misses = 0;
        int TimeMiss = 0;
        int FakeHit = 0;
        int checkpoint = 10000;

        //game logic values that change
        int multiplier = 1;
        int penalty = 1500;
        int debounce = 0;
        int frequencybounce = 5000;



        //since freqbounc is at 5000, every checkpoint minus -500 and a minimum of 1000
        //the default levels can be set at 8
        //after wards it'll be random colors

        //Color of Levels
        Color level1 = Color.FromArgb(20, 29, 38);
        Color level2 = Color.FromArgb(32, 40, 66);
        Color level3 = Color.FromArgb(32, 58, 66);
        Color level4 = Color.FromArgb(59, 86, 112);
        Color level5 = Color.FromArgb(65, 82, 135);
        Color level6 = Color.FromArgb(65, 119, 135);
        Color level7 = Color.FromArgb(95, 120, 199);
        Color level8 = Color.FromArgb(93, 135, 176);
        List<Color> levelcolors = new List<Color>();

        Color levelrandom = Color.FromArgb(100,120,180);

        List<Scorecard> ScoreKeep = new List<Scorecard>();
        List<Panel> PanelList = new List<Panel>();
        int pageIndex = 1;

        public Form1()
        {
            InitializeComponent();

            //level addition
            levelcolors.Add(level1);
            levelcolors.Add(level2);
            levelcolors.Add(level3);
            levelcolors.Add(level4);
            levelcolors.Add(level5);
            levelcolors.Add(level6);
            levelcolors.Add(level7);
            levelcolors.Add(level8);

            //add panels
            PanelList.Add(pn_Main);
            PanelList.Add(pn_ScoreList);

            //add dummie scores
            Scorecard score1 = new Scorecard(560000, "ABC");
            Scorecard score2 = new Scorecard(120000, "DEF");
            Scorecard score3 = new Scorecard(50000, "GHI");
            Scorecard score4 = new Scorecard(12000, "JKL");
            Scorecard score5 = new Scorecard(100, "MNO");

            ScoreKeep.Add(score1);
            ScoreKeep.Add(score2);
            ScoreKeep.Add(score3);
            ScoreKeep.Add(score4);
            ScoreKeep.Add(score5);

            updateHighscoreList();

            //adjust the panel
            this.Size = new Size(850, 500);
        }

        //reset game
        private void ResetGame()
        {
            sw.Stop();
            sw.Restart();
            showtime = 0;
            Lives = 3;
            Hits = 0;
            Score = 0;
            Misses = 0;
            TimeMiss = 0;
            FakeHit = 0;
            checkpoint = 10000;

            multiplier = 1;
            penalty = 1500;
            debounce = 0;
            frequencybounce = 5000;

            btn_GameButton.Visible = false;
            btn_FakeButton.Visible = false;
            updateHighscoreList();

            sw.Stop();

        }

        //Move Item

        private void MoveMole(Button mole)
        {
            int edgepadding = 10;
            Point newLocation = new Point(random.Next(edgepadding, this.pn_PlayArea.Width - btn_GameButton.Width) - edgepadding, random.Next(edgepadding, pn_PlayArea.Height - btn_GameButton.Height) - edgepadding);
            mole.Location = newLocation;
        }

        //Score Keep
        private void updateHighscoreList()
        {
            //sort out the score, this is based on a lambda expression I made for C#1 inventory project
            ScoreKeep.Sort((a,b)=> b.Score.CompareTo(a.Score));

            //remove items
            var scrub = pn_ScoreList.Controls.OfType<Label>();
            foreach (var item in scrub)
            {
                if (item.Tag!=null)
                {
                    if (item.Tag.Equals("Scoresystem"))
                    {
                        pn_ScoreList.Controls.Remove(item);
                    }
                }
            }

            //creating elements for the panel list
            for (int i = 0; i < ScoreKeep.Count; i++)
            {
                if (i < 5)
                {
                    Label rank = new Label();
                    Label name = new Label();
                    Label points = new Label();

                    rank.Text = (i + 1) + ".";
                    name.Text = ScoreKeep[i].UserName;
                    points.Text = String.Format("{0:n0}", ScoreKeep[i].Score);

                    rank.AutoSize = true;
                    name.AutoSize = true;
                    points.AutoSize = true;


                    rank.Location = new Point(lb_ScoreRank.Location.X, lb_ScoreRank.Location.Y + 20 + (i * 30));
                    name.Location = new Point(lb_ScoreName.Location.X, lb_ScoreName.Location.Y + 20 + (i * 30));
                    points.Location = new Point(lb_Points.Location.X, lb_Points.Location.Y + 20 + (i * 30));


                    rank.Tag = "Scoresystem";
                    name.Tag = "Scoresystem";
                    points.Tag = "Scoresystem";

                    pn_ScoreList.Controls.Add(rank);
                    pn_ScoreList.Controls.Add(name);
                    pn_ScoreList.Controls.Add(points);
                }
                else
                {
                    //remove anything after nth
                    //ScoreKeep.RemoveAt(i);
                }
            }
        }


        //

        private void GameUpdates()
        {
            switch (Lives)
            {
                case 0:
                    sw.Stop();
                    sw.Restart();
                    piB_Life1.Visible = false;
                    piB_Life2.Visible = false;
                    piB_Life3.Visible = false;
                    break;
                case 1:
                    piB_Life1.Visible = true;
                    piB_Life2.Visible = false;
                    piB_Life3.Visible = false;

                    piB_Life1.BorderStyle = BorderStyle.None;
                    piB_Life2.BorderStyle = BorderStyle.None;
                    piB_Life3.BorderStyle = BorderStyle.None;
                    break;
                case 2:
                    piB_Life1.Visible = true;
                    piB_Life2.Visible = true;
                    piB_Life3.Visible = false;

                    piB_Life1.BorderStyle = BorderStyle.None;
                    piB_Life2.BorderStyle = BorderStyle.None;
                    piB_Life3.BorderStyle = BorderStyle.None;
                    break;
                case 3:
                    piB_Life1.Visible = true;
                    piB_Life2.Visible = true;
                    piB_Life3.Visible = true;

                    piB_Life1.BorderStyle = BorderStyle.None;
                    piB_Life2.BorderStyle = BorderStyle.None;
                    piB_Life3.BorderStyle = BorderStyle.None;
                    break;

                    //after default
                case 4:
                    piB_Life1.Visible = true;
                    piB_Life2.Visible = true;
                    piB_Life3.Visible = true;

                    piB_Life1.BorderStyle = BorderStyle.FixedSingle;
                    piB_Life2.BorderStyle = BorderStyle.None;
                    piB_Life3.BorderStyle = BorderStyle.None;

                    break;
                case 5:
                    piB_Life1.Visible = true;
                    piB_Life2.Visible = true;
                    piB_Life3.Visible = true;

                    piB_Life1.BorderStyle = BorderStyle.FixedSingle;
                    piB_Life2.BorderStyle = BorderStyle.FixedSingle;
                    piB_Life3.BorderStyle = BorderStyle.None;
                    break;
                case 6:
                    piB_Life1.Visible = true;
                    piB_Life2.Visible = true;
                    piB_Life3.Visible = true;

                    piB_Life1.BorderStyle = BorderStyle.FixedSingle;
                    piB_Life2.BorderStyle = BorderStyle.FixedSingle;
                    piB_Life3.BorderStyle = BorderStyle.FixedSingle;
                    break;
                //
                case 7:
                    piB_Life1.Visible = true;
                    piB_Life2.Visible = true;
                    piB_Life3.Visible = true;

                    piB_Life1.BorderStyle = BorderStyle.Fixed3D;
                    piB_Life2.BorderStyle = BorderStyle.FixedSingle;
                    piB_Life3.BorderStyle = BorderStyle.FixedSingle;

                    break;
                case 8:
                    piB_Life1.Visible = true;
                    piB_Life2.Visible = true;
                    piB_Life3.Visible = true;

                    piB_Life1.BorderStyle = BorderStyle.Fixed3D;
                    piB_Life2.BorderStyle = BorderStyle.Fixed3D;
                    piB_Life3.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case 9:
                    piB_Life1.Visible = true;
                    piB_Life2.Visible = true;
                    piB_Life3.Visible = true;

                    piB_Life1.BorderStyle = BorderStyle.Fixed3D;
                    piB_Life2.BorderStyle = BorderStyle.Fixed3D;
                    piB_Life3.BorderStyle = BorderStyle.Fixed3D;
                    break;
                    // Don't have a special border anymore for after 9 lives
                default:
                    break;
            }

            if (multiplier-1 < levelcolors.Count)
            {
                pn_PlayArea.BackColor = levelcolors[multiplier-1];
                btn_GameButton.BackColor = pn_PlayArea.BackColor;
                btn_FakeButton.BackColor = pn_PlayArea.BackColor;

            }
            else
            {
                pn_PlayArea.BackColor = levelrandom;
                btn_GameButton.BackColor = pn_PlayArea.BackColor;
                btn_FakeButton.BackColor = pn_PlayArea.BackColor;
            }

            if (Lives == 0)
            {
                btn_ScoreSubmit.Visible = true;
                tb_Username.Visible = true;
            }else if (Lives > 0)
            {
                btn_ScoreSubmit.Visible = false;
                tb_Username.Visible = false;
            }

            if (sw.IsRunning)
            {
                this.btn_Start.Visible = false;
                this.btn_Pause.Visible = true;

            }
            else if (!sw.IsRunning)
            {
                this.btn_Start.Visible = true;

                this.btn_Pause.Visible = false;
            }

            //Update Numbers
            lb_FakeHitsNum.Text = String.Format("{0:n0}", FakeHit);
            lb_HitsNum.Text = String.Format("{0:n0}", Hits);
            lb_MisclickNum.Text = String.Format("{0:n0}", Misses);
            lb_ScoreNum.Text = String.Format("{0:n0}", Score);
            lb_TimeMissNum.Text = String.Format("{0:n0}", TimeMiss);
            lb_CheckpointNum.Text = String.Format("{0:n0}", checkpoint);
            lb_LivesLeftNum.Text = String.Format("{0:n0}", Lives);

            lb_CheckpointText.Text = "Checkpoint: "+ String.Format("{0:n0}",multiplier);

        }

        private void GameStart()
        {
            GameButtonUpdate();
        }

        private void GameButtonUpdate()
        {
            btn_GameButton.Visible = true;
            showtime = frequencybounce + (int)sw.ElapsedMilliseconds;
            MoveMole(btn_FakeButton);
            MoveMole(btn_GameButton);
            int fakechance = random.Next(0, 100);
            if (fakechance < 10)
            {
                btn_FakeButton.Visible = true;
            }
            else
            {
                btn_FakeButton.Visible = false;
            }
        }

        //Listeners

        private void Buttonclicked(object sender, EventArgs e)
        {
            Button sus = sender as Button;
            //Start, Pause and Restart butotn

            //Button for Start
            if (sus.Equals(this.btn_Start))
            {
                if (!sw.IsRunning)
                {
                    sw.Start();
                    if (Score == 0)
                    {
                        GameStart();
                    }
                }
            }

            //Button for pause
            else if (sus.Equals(this.btn_Pause))
            {
                if (sw.IsRunning)
                {
                    sw.Stop();
                }
            }

            //Button for restart
            else if (sus.Equals(this.btn_Restart))
            {
                sw.Reset();

                //reset all the parameters
                ResetGame();

            }

            //Submit score
            else if (sus.Equals(this.btn_ScoreSubmit))
            {
                if (Lives == 0)
                {
                    //can submit scores
                    if (tb_Username.Text!= "Enter Username")
                    {
                        if (tb_Username.Text.Length==3)
                        {
                            Scorecard newscore = new Scorecard(Score, tb_Username.Text);
                            btn_ScoreSubmit.Text = "Submitted " + tb_Username.Text + " score";

                            ScoreKeep.Add(newscore);
                            updateHighscoreList();
                            ResetGame();
                        }
                        else
                        {
                            btn_ScoreSubmit.Text = "Please enter a 3 letter username";
                        }
                    }else if (tb_Username.Text.Equals("Enter Username"))
                    {
                        btn_ScoreSubmit.Text = "Please enter a 3 letter username";
                    }
                }
            }

        }

        private void GameButton(object sender, EventArgs e)
        {
            //dont have to worry about checking running status because it'll be invisible anyways
            if (Lives != 0)
            {
                Score += (int)((showtime - sw.ElapsedMilliseconds) +(1500-frequencybounce))*multiplier;
                Hits++;
                if (Score > checkpoint)
                {
                    Lives++;
                    //tried *= 2.5 but guess that didn't work out properly
                    multiplier++;
                    //checkpoint = checkpoint+(checkpoint * (multiplier / 2);
                    checkpoint = checkpoint + (checkpoint/2);

                    if (frequencybounce-500 > 1000)
                    {
                        frequencybounce -= 500;
                    }
                    else
                    {
                        frequencybounce = random.Next(750,999);
                    }
                    if (multiplier > levelcolors.Count)
                    {
                        levelrandom = Color.FromArgb(random.Next(50,150), random.Next(50, 150), random.Next(80, 225));
                    }
                }
                btn_GameButton.Visible = false;
                btn_FakeButton.Visible = false;
                debounce = (int)sw.ElapsedMilliseconds;

                //GameButtonUpdate();
            }
        }

        private void LifeHurt(object sender, EventArgs e)
        {
            if (sw.IsRunning&&Lives > 0)
            {
                //minus the lives
                if (Lives - 1 <= 0)
                {
                    Lives = 0;
                    Score -= penalty * multiplier;
                }
                else
                {
                    Lives--;
                    Score -= penalty*multiplier;
                }

                //check what kind of stat to increase
                if (sender is Panel)
                {
                    Misses++;
                    btn_GameButton.Visible = false;
                    btn_FakeButton.Visible = false;
                }
                else if (sender is Button)
                {
                    Button sus = (Button)sender;
                    if (sus.Equals(btn_FakeButton))
                    {
                        FakeHit++;
                        //GameButtonUpdate();
                        btn_GameButton.Visible = false;
                        btn_FakeButton.Visible = false;
                    }
                }

            }
        }


        private void GameTicks(object sender, EventArgs e)
        {
            GameUpdates();
            if (sw.IsRunning)
            {
                if (btn_GameButton.Visible)
                {
                    btn_GameButton.Text = (showtime - sw.ElapsedMilliseconds)+"";
                    if (showtime - sw.ElapsedMilliseconds <=0)
                    {
                        GameButtonUpdate();
                        Lives--;
                        TimeMiss++;
                        Score -= penalty*multiplier;
                    }
                }
                else
                {
                    //wait a little bit 
                    if (debounce+frequencybounce/2 <= sw.ElapsedMilliseconds)
                    {
                        GameButtonUpdate();                        
                    }
                }
            }
        }

        private void UsernameSub(object sender, EventArgs e)
        {
            if (tb_Username.Text.Equals("Enter Username"))
            {
                tb_Username.Text = "";

                tb_Username.ForeColor = Color.FromArgb(200, 200, 200);
            }
            else if (tb_Username.Text.Equals(""))
            {
                tb_Username.Text = "Enter Username";

                tb_Username.ForeColor = Color.FromArgb(80, 80, 100);
            }
        }

        private void MenuChange(object sender, EventArgs e)
        {
            PanelList[pageIndex].BringToFront();
            PanelList[pageIndex].Location = new Point(10, 58);
            ResetGame();
            var parent = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            for (int i = 0; i < PanelList.Count; i++)
            {
                if (i!=pageIndex)
                {
                    PanelList[i].Visible = false;
                }
                else
                {
                    PanelList[i].Visible = true;
                }
            }
            if (pageIndex + 1 >= PanelList.Count)
            {
                pageIndex = 0;
            }
            else
            {
                pageIndex++;
            }
            btn_Menu.BackgroundImage = new Bitmap(parent + "\\Icons\\" + PanelList[pageIndex].Tag + ".png");
        }

    }
}
