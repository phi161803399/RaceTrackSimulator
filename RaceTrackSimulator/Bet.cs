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
            return string.Empty;
        }

        public int PayOut(int Winner)
        {
            // the parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of 
            // the amount bet
            return 0;
        }
    }
}