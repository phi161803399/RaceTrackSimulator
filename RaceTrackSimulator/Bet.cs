namespace RaceTrackSimulator
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            // return a string that says who placed the bet, ow much
            // cash was bet, and which dog he bet on ("Joe bets 8 on
            // dog #4"). If the amount is zero, no bet was placed
            // ("Joe hasn't placed a bet").
            if (Amount == 0)
            {
                return $"{Bettor.Name} hasn't placed a bet";
            }
            else
            {
                return $"{Bettor.Name} bets {Amount} on dog #{Bettor.MyBet.Dog}";
            }
        }

        public int PayOut(int Winner)
        {
            // the parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of 
            // the amount bet
            int amount = 0;
            if (Winner == Dog)
            {
                amount = Amount;
            }
            else
            {
                amount = -Amount;
            }
            return amount;
        }
    }
}