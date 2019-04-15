using System.Windows.Forms;

namespace RaceTrackSimulator
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            // set my label to my bet's description, and the label on my
            // radiobutton to show my cash "Joe has 43 bucks"
        }

        public void ClearBet()
        {
            // reset my bet so it's zero
        }

        public bool PlaceBet()
        {
            // place a new bet and store it in my bet field
            return true; // if the guy had enough money to bet
        }

        public void Collect(int Winner)
        {
            // ask my bet to pay out, clear my bet, and update my labels
        }

    }
}
