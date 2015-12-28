using System.Drawing;

namespace StockMarketGame
{
    public class JobGui
    {
        public Job Job { get; set; }
        public Rectangle Bounds { get; set; }

        public JobGui(Job job, Rectangle bounds)
        {
            this.Job = job;
            this.Bounds = bounds;
        }
    }
}