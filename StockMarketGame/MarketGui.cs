using System.Drawing;

namespace StockMarketGame
{
    public class MarketGui
    {
        public Stock Stock { get; set; }
        public Color Color { get; set; }
        public Rectangle Bounds { get; set; }
        public uint Price { get; set; }

        public MarketGui(Stock stock, uint price, Color color, Rectangle bounds)
        {
            this.Stock = stock;
            this.Color = color;
            this.Bounds = bounds;
            this.Price = price;
        }
    }
}