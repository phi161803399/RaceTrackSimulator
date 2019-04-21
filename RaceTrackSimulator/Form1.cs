using System;
using System.Windows.Forms;

namespace RaceTrackSimulator
{
    public partial class Form1 : Form
    {
        public Random MyRandomizer = new Random();
        Greyhound[] GreyhoundArray;
        Guy[] GuyArray;
        int Winner;

        public Form1()
        {    
            InitializeComponent();
            timer1.Enabled = false;
            lblMinimumBet.Text = $"Minimum bet: {numBetAmount.Minimum} bucks";

            // initialize array with greyhound
            GreyhoundArray = new Greyhound[4];
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox4.Width,
                Randomizer = MyRandomizer
            };

            // initialize array with guy
            GuyArray = new Guy[3];
            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyLabel = lblJoeBet,
                MyRadioButton = joeRadioButton
            };
            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyLabel = lblBobBet,
                MyRadioButton = bobRadioButton
            };
            GuyArray[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyLabel = lblAlBet,
                MyRadioButton = alRadioButton
            };

            foreach (Guy guy in GuyArray)
            {
                guy.ClearBet();
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            foreach (Guy guy in GuyArray)
            {
                if (guy.MyRadioButton.Checked)
                {
                    guy.PlaceBet((int)numBetAmount.Value, (int)numGreyhoundNumber.Value);
                }
            }
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnBet.Enabled = false;
            btnStartRace.Enabled = false;
            numBetAmount.Enabled = false;
            numGreyhoundNumber.Enabled = false; 
            foreach (Guy guy in GuyArray)
            {
                guy.Collect(Winner);
            }

            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                GreyhoundArray[i].TakeStartingPosition();
            }
            //btnBet.Enabled = true;
            //btnStartRace.Enabled = true;
            //numBetAmount.Enabled = true;
            //numGreyhoundNumber.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show($"Dog #{i+1} won the race!", "We have a winner");
                    Winner = i;
                }
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked) lblName.Text = GuyArray[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bobRadioButton.Checked) lblName.Text = GuyArray[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (alRadioButton.Checked) lblName.Text = GuyArray[2].Name;
        }
    }
}
