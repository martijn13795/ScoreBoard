using System;
using System.Windows.Forms;
using ScoreTest;

namespace ScoreBord
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        private int thuisScore = 0;
        private int uitScore = 0;
        private bool tijd = false;
        private int m;
        private int s;
        private string team = "";
        private string uitTeam = "";
        private int teamWissel = 0;
        private int uitTeamWissel = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!((thuisScore < 99 && tijd == true) | (thuisScore < 99 && tijd == false && (m == 1 | m == 0) && s == 0)))
            return;
            thuisScore++;
            thuisScore.ToString();
            form2.label1Text = thuisScore.ToString();
            form3.label1Text = thuisScore.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!((uitScore < 99 && tijd == true) | (tijd == false && (m == 1 | m == 0) && s == 0))) return;
            uitScore++;
            uitScore.ToString();
            form2.label2Text = uitScore.ToString();
            form3.label2Text = uitScore.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (thuisScore <= 0) return;
            thuisScore--;
            thuisScore.ToString();
            form2.label1Text = thuisScore.ToString();
            form3.label1Text = thuisScore.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (uitScore <= 0) return;
            uitScore--;
            uitScore.ToString();
            form2.label2Text = uitScore.ToString();
            form3.label2Text = uitScore.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (form2.Visible | form2.IsDisposed)
            {
                if (numericUpDown1.Value > 0 && button5.Text == "Start de timer" && m >= 0)
                {
                    tijd = true;
                    timer1.Start();
                    button5.Text = "Stop de timer";
                }
                else
                {
                    tijd = false;
                    timer1.Stop();
                    button5.Text = "Start de timer";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            team = textBox2.Text;
            if (!string.IsNullOrEmpty(team) && team != "EKC 2000 ")
            {
                uitTeam = textBox1.Text;
                button1.Text = team;
                if (!string.IsNullOrEmpty(uitTeam))
                {
                    button2.Text = uitTeam;
                    if (radioButton1.Checked | radioButton2.Checked)
                    {
                        if (radioButton3.Checked | radioButton4.Checked)
                        {
                            if (numericUpDown1.Value > 1 && numericUpDown1.Value <= 60)
                            {
                                if (form2.IsDisposed)
                                {
                                    form2 = new Form2();
                                }
                                if (form3.IsDisposed)
                                {
                                    form3 = new Form3();
                                }
                                var i = 0;
                                Screen[] sc;
                                sc = Screen.AllScreens;
                                foreach(Screen element in sc)
                                {
                                    i++;
                                }
                                if(i > 1)
                                {
                                    form2.Location = sc[1].Bounds.Location;
                                }
                                if (i > 1)
                                {
                                    form3.Location = sc[0].Bounds.Location;
                                }
                                form2.Show();
                                form3.Show();
                                m = Convert.ToInt32(numericUpDown1.Value);
                                s = 0;
                                string mm = Convert.ToString(m);
                                string ss = s < 10 ? '0' + Convert.ToString(s) : Convert.ToString(s);
                                form2.label3Text = team;
                                form3.label3Text = team;
                                form2.label4Text = uitTeam;
                                form3.label4Text = uitTeam;
                                form2.label5Text = mm;
                                form2.label7Text = ss;
                                form3.label5Text = mm;
                                form3.label7Text = ss;
                                button1.Enabled = true;
                                button2.Enabled = true;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                button5.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Vul de speeltijd van ëën helft in", "Er ging iets mis");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geef aan of het de eerste of 2e helft is", "Er ging iets mis");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Laat de timer op 1 minuut of 0 seconden stoppen", "Er ging iets mis");
                    }
                }
                else
                {
                    MessageBox.Show("Vul de naam van het gast team in", "Er ging iets mis");
                }
            }
            else
            {
                MessageBox.Show("Vul de naam van het thuis team in", "Er ging iets mis");
            }
            if (radioButton3.Checked)
            {
                form2.label9Text = "1";
                form3.label9Text = "1";
            }
            if (radioButton4.Checked)
            {
                form2.label9Text = "2";
                form3.label9Text = "2";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;

            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if (m == 0 && s == 0 && radioButton2.Checked)
            {
                radioButton4.Checked = true;
                button5.Text = "Start de timer";
                tijd = false;
                timer1.Stop();
            }
            if (m == 1 && s == 0 && radioButton1.Checked)
            {
                radioButton4.Checked = true;
                button5.Text = "Start de timer";
                tijd = false;
                timer1.Stop();
            }

            string mm = Convert.ToString(m);
            string ss = s < 10 ? '0'+Convert.ToString(s) : Convert.ToString(s);

            form2.label5Text = mm;
            form2.label7Text = ss;
            form3.label5Text = mm;
            form3.label7Text = ss;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (teamWissel < 0 || teamWissel > 3) return;
            teamWissel++;
            form2.label12Text = teamWissel.ToString();
            form3.label12Text = teamWissel.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (uitTeamWissel < 0 || uitTeamWissel > 3) return;
            uitTeamWissel++;
            form2.label13Text = uitTeamWissel.ToString();
            form3.label13Text = uitTeamWissel.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (teamWissel < 1 || teamWissel > 4) return;
            teamWissel--;
            form2.label12Text = teamWissel.ToString();
            form3.label12Text = teamWissel.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (uitTeamWissel < 1 || uitTeamWissel > 4) return;
            uitTeamWissel--;
            form2.label13Text = uitTeamWissel.ToString();
            form3.label13Text = uitTeamWissel.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (AboutBox1 box = new AboutBox1())
            {
                box.ShowDialog(this);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tijd = false;
            timer1.Stop();
            textBox2.Text = "EKC 2000 ";
            textBox1.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            numericUpDown1.Value = 30;
            button5.Text = "Start de timer";
            button1.Text = "EKC 2000";
            button2.Text = "Gasten";
            form2.label1Text = "0";
            form2.label2Text = "0";
            form2.label3Text = "EKC 2000";
            form2.label4Text = "Gasten";
            form2.label5Text = "00";
            form2.label7Text = "00";
            form2.label9Text = "0";
            form3.label1Text = "0";
            form3.label2Text = "0";
            form3.label3Text = "EKC 2000";
            form3.label4Text = "Gasten";
            form3.label5Text = "00";
            form3.label7Text = "00";
            form3.label9Text = "0";
            thuisScore = 0;
            uitScore = 0;
            m = 0;
            s = 0;
            team = "";
            uitTeam = "";
            teamWissel = 0;
            uitTeamWissel = 0;
        }
    }
}
