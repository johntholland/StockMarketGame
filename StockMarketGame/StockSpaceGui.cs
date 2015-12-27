using System.Drawing;

namespace StockMarketGame
{
    public class SpaceGui
    {
        public Rectangle Bounds { get; set; }
        public Color Color { get; set; }
        public ISpace Space { get; set; }

        public SpaceGui(ISpace space, Color color, Rectangle bounds = new Rectangle())
        {
            this.Space = space;
            this.Color = color;
            this.Bounds = bounds;
        }
    }
}