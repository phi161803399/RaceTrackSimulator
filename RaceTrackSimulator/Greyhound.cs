using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrackSimulator
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            bool hasWon = false;
            // Move forward either 1, 2, 3 or 4 spaces at random
            Location = Randomizer.Next(1, 4);
            // Update position of MyPictureBox
            MyPictureBox.Left = StartingPosition + Location;
            // return true if I won the race
            return hasWon;
        }

        public void TakeStartingPosition()
        {
            // Reset my location to 0 and my PictureBox to starting position
            Location = 0;
            StartingPosition = Location;
        }
    }
}
