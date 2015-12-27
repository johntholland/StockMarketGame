using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class StockMarketGameState
    {
        public enum TurnState
        {
            PreRoll,
            DirectionChoice,
            PostRoll
        }

        public List<Player> Players { get; set; }

        public Board Board { get; set; }

        public Player ActivePlayer { get; set;}

        public Market Market { get; set; }

        public StockMarketGameState(List<Player> players, Board board)
        {
            this.Players = players;
            this.Board = board;
            this.ActivePlayer = players[0];
            this.Market = new Market();
        }

        public void SellStock_PreRoll(Stock stock, uint quantity)
        {
            ActivePlayer.Sell(stock, quantity, Market.Price(stock));
        }

        public void SellStock_PostRoll(Stock stock, uint quantity)
        {
            ActivePlayer.Sell(stock, quantity, stock.Prices[0]);
        }


        // A Turn:

        //preroll (can sell stock)
        //roll (rolls the dice)
        //move (begin by checking for StockHolderEntrance, if yes then have user choose route, else move to next based on direction [or start space])
        //postroll (pay penalties, move market, allow purchases)

        //When can you go back to Job?

    }
}
