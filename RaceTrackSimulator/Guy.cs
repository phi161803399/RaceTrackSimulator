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
            MyLabel.Text = MyBet.GetDescription();
            // radiobutton to show my cash "Joe has 43 bucks"
            MyRadioButton.Text = $"{Name} has {Cash} bucks";
        }

        public void ClearBet()
        {
            MyBet = new Bet()
            {
                Amount = 0,
                Bettor = this
            };
            UpdateLabels();
        }

        public bool PlaceBet(int amount, int greyhound)
        {
            bool succes = false;
            if (amount <= Cash)
            {
                succes = true;
                MyBet = new Bet()
                {
                    Amount = amount,
                    Dog = greyhound,
                    Bettor = this
                };
            }
            if (succes) UpdateLabels();            
            return succes; // if the guy had enough money to bet
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
        }

    }
}
