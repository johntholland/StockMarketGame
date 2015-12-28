using System.Drawing;

namespace StockMarketGame
{
    public enum SpaceRegion
    {
        TopRow,
        BottomRow,
        LeftRow,
        RightRow,
        TopLeftCorner,
        TopRightCorner,
        BottomLeftCorner,
        BottomRightCorner
    }

    public class SpaceGui
    {
        public Rectangle Bounds { get; set; }
        public Color Color { get; set; }
        public ISpace Space { get; set; }
        public SpaceRegion SpaceRegion { get; set; }

        public SpaceGui(ISpace space, Color color, SpaceRegion spaceRegion, Rectangle bounds = new Rectangle())
        {
            this.Space = space;
            this.Color = color;
            this.Bounds = bounds;
            this.SpaceRegion = spaceRegion;
        }
    }

    public class ShareHolderGui
    {
        public Rectangle Bounds { get; set; }
        public Color Color { get; set; }
        public ShareHolderSpace Space { get; set; }
        public SpaceRegion SpaceRegion { get; set; }

        public ShareHolderGui(ShareHolderSpace space, Color color, SpaceRegion spaceRegion, Rectangle bounds = new Rectangle())
        {
            this.Space = space;
            this.Color = color;
            this.Bounds = bounds;
            this.SpaceRegion = spaceRegion;
        }
    }
}