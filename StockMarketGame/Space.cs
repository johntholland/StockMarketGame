using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public enum Direction
    {
        Left,
        Right,
        None
    }

    public interface ISpace
    {
        int MarketMovement { get; }
        Direction Direction { get; }

        ISpace Left { get; set; }
        ISpace Right { get; set; }
    }

    public class StockSpace : ISpace
    {
        public ISpace Left { get; set; }
        public ISpace Right { get; set; }

        public Direction Direction { get; set; }
        public bool PurchaseLimit { get; set; }
        public Stock Stock { get; set; }
        public int MarketMovement { get; set; }


        public StockSpace(Stock stock, int marketMovement, Direction direction, bool purchaseLimit = false)
        {
            this.Direction = direction;
            this.MarketMovement = marketMovement;
            this.PurchaseLimit = purchaseLimit;
            this.Stock = stock;
        }

        //public void LandedOn(Player player, Market market)
        //{
        //    int shareQuantity = player.ShareQuantities[Stock];

        //    if (shareQuantity != 0)
        //    {
        //        player.Cash += shareQuantity * Stock.Dividend;
        //    }

        //    market.Move(this.MarketMovement);
        //}
    }

    public class SellAllSpace :ISpace
    {
        public ISpace Left { get; set; }
        public ISpace Right { get; set; }

        public Direction Direction { get; set; }
        public Stock Stock { get; set; }
        public int MarketDirection { get; set; }


        public int MarketMovement
        {
            get
            {
                return MarketDirection;
            }
        }

        public SellAllSpace(Stock stock, int marketMovement, Direction direction)
        {
            this.Stock = stock;
            this.Direction = direction;

        }

        //public override void LandedOn(Player player, Market market)
        //{
        //    int shareQuantity = player.ShareQuantities[Stock];

        //    if (shareQuantity != 0)
        //    {
        //        player.ShareQuantities[Stock] = 0;
        //        player.Cash += shareQuantity * Stock.BottomPrice;
        //    }

        //    market.Move(this.MarketMovement);
        //}
    }

    public class CornerSpace : ISpace
    {

        public ISpace Left { get; set; }
        public ISpace Right { get; set; }

        public int MarketMovement { get; set; }
        public Direction Direction { get; set; }
        public int FineFactor { get { return 10; } }

        public CornerSpace(int marketMovement, Direction direction )
        {
            this.MarketMovement = marketMovement;
            this.Direction = direction;
        }

        //public override void LandedOn(Player player, Market market)
        //{
        //    int shareQuantity = 0;

        //    foreach (var shares in player.ShareQuantities)
        //    {
        //        shareQuantity += shares.Value;
        //    }

        //    //

        //    market.Move(this.MarketMovement);
        //}
    }

    public class StartSpace : ISpace
    {
        public int Fine { get { return 100; } }

        public ISpace Left { get; set; }
        public ISpace Right { get; set; }

        public Direction Direction
        {
            get
            {
                return Direction.None;
                //int diceRoll = 0;
                //if (diceRoll % 2 == 0)
                //{
                //    return StockMarketGame.Direction.Right;
                //}
                //return StockMarketGame.Direction.Left;
            }
        }

        public int MarketMovement
        {
            get
            {
                return 0;
            }
        }
    }

    public class ShareHolderSpace: ISpace
    {
        private ISpace _next { get; set; }

        public ISpace Left { get { return _next; } set { _next = value; } }
        public ISpace Right { get { return _next; } set { _next = value; } }

        public int Multiplier { get; set; }
        public Stock Stock { get; set; }
        public Direction Direction { get; set; }

        public int MarketMovement
        {
            get
            {
                return 0;
            }
        }

        public ShareHolderSpace(Stock stock, Direction direction, int multiplier)
        {
            this.Stock = stock;
            this.Direction = direction;
            this.Multiplier = multiplier;
        }
    }
}
