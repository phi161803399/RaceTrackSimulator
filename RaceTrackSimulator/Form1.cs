﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrackSimulator
{
    public partial class Form1 : Form
    {
        public Random MyRandomizer = new Random();

        public Form1()
        {    
            InitializeComponent();

            Greyhound[] GreyhoundArray = new Greyhound[3];
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = MyRandomizer
            };
        }
    }
}
