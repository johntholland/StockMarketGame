using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarketGame
{
    public partial class BoardScreen : Form
    {
        StockMarketGameState GameState;
        List<SpaceGui> Spaces = new List<SpaceGui>();
        List<ShareHolderGui> ShareHolderSpaces = new List<ShareHolderGui>();

        public BoardScreen()
        {
            InitializeComponent();
            this.GameState = new StockMarketGameState(
                new List<Player>()
                {
                    new Player("Player 1"),
                    new Player("Player 2"),
                    new Player("Player 3"),
                    new Player("Player 4")
                }, new Board());


            var activeSpace = this.GameState.Board.StartSpace1.Right.Right.Right.Right.Right.Right;
            var coordinates = new Point(0, 0);
            var rectangleSize = new Size(60, 60);
            var heightOffset = rectangleSize.Height;
            var shareHolderHeightOffset = rectangleSize.Height / 2;
            var widthOffset = rectangleSize.Width;
            var squareColor = Color.White;

            //Create First Corner;
            this.Spaces.Add(new SpaceGui(activeSpace, squareColor, SpaceRegion.TopLeftCorner, new Rectangle(coordinates, rectangleSize)));
            coordinates.X += widthOffset;
            activeSpace = activeSpace.Left;


            for (int i = 0; i < 11; i++)
            {
                var stockSpace = activeSpace as IStockSpace;
                if (stockSpace != null)
                {
                    squareColor = _getStockColor(stockSpace.Stock.Name);
                }
                else
                {
                    squareColor = Color.White;
                }

                this.Spaces.Add(new SpaceGui(activeSpace, squareColor, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));

                coordinates.X += widthOffset;
                activeSpace = activeSpace.Left;
            }

            //Create Second Corner
            squareColor = Color.White;
            this.Spaces.Add(new SpaceGui(activeSpace, squareColor, SpaceRegion.TopRightCorner, new Rectangle(coordinates, rectangleSize)));
            activeSpace = activeSpace.Left;

            for (int i = 0; i < 11; i++)
            {
                var stockSpace = activeSpace as IStockSpace;
                if (stockSpace != null)
                {
                    squareColor = _getStockColor(stockSpace.Stock.Name);
                }
                else
                {
                    squareColor = Color.White;
                }

                coordinates.Y += heightOffset;
                this.Spaces.Add(new SpaceGui(activeSpace, squareColor, SpaceRegion.RightRow, new Rectangle(coordinates, rectangleSize)));

                activeSpace = activeSpace.Left;
            }

            //Create Third Corner
            coordinates.Y += heightOffset;
            squareColor = Color.White;
            this.Spaces.Add(new SpaceGui(activeSpace, squareColor, SpaceRegion.BottomRightCorner, new Rectangle(coordinates, rectangleSize)));
            activeSpace = activeSpace.Left;

            for (int i = 0; i < 11; i++)
            {
                var stockSpace = activeSpace as IStockSpace;
                if (stockSpace != null)
                {
                    squareColor = _getStockColor(stockSpace.Stock.Name);
                }
                else
                {
                    squareColor = Color.White;
                }
                coordinates.X -= widthOffset;
                this.Spaces.Add(new SpaceGui(activeSpace, squareColor, SpaceRegion.BottomRow, new Rectangle(coordinates, rectangleSize)));

                activeSpace = activeSpace.Left;
            }

            //Create Fourth Corner
            coordinates.X -= widthOffset;
            squareColor = Color.White;
            this.Spaces.Add(new SpaceGui(activeSpace, squareColor, SpaceRegion.BottomLeftCorner, new Rectangle(coordinates, rectangleSize)));
            activeSpace = activeSpace.Left;

            for (int i = 0; i < 11; i++)
            {
                var stockSpace = activeSpace as IStockSpace;
                if (stockSpace != null)
                {
                    squareColor = _getStockColor(stockSpace.Stock.Name);
                }
                else
                {
                    squareColor = Color.White;
                }
                coordinates.Y -= heightOffset;
                this.Spaces.Add(new SpaceGui(activeSpace, squareColor, SpaceRegion.LeftRow, new Rectangle(coordinates, rectangleSize)));

                activeSpace = activeSpace.Left;
            }

            #region Alcoa/Woolsworth ShareHolder Meeting
            rectangleSize = new Size(rectangleSize.Width, shareHolderHeightOffset);
            coordinates = new Point(widthOffset * 3, heightOffset *1);
            ShareHolderMeetingEntrance alcoaEntrance = GameState.Board.StartSpace1.Right.Right.Right as ShareHolderMeetingEntrance;
            ShareHolderSpace currentShareHolderSpace = alcoaEntrance.ShareHolderSpace;

            ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
            currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
            coordinates.Y += shareHolderHeightOffset;

            for (int i = 0; i < 7; i++)
            {
                ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
                currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
                coordinates.X += widthOffset;
            }
            coordinates.X -= widthOffset;
            coordinates.Y -= shareHolderHeightOffset;
            ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
            currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
            #endregion

            #region Int.Shoe/GeneralMills ShareHolder Meeting
            rectangleSize = new Size(shareHolderHeightOffset, rectangleSize.Width);
            coordinates.Y += heightOffset * 2;
            coordinates.X += shareHolderHeightOffset * 5;

            ShareHolderMeetingEntrance intShoeEntrance = GameState.Board.StartSpace2.Right.Right.Right as ShareHolderMeetingEntrance;
            currentShareHolderSpace = intShoeEntrance.ShareHolderSpace;

            ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
            currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
            coordinates.X -= shareHolderHeightOffset;

            for (int i = 0; i < 7; i++)
            {
                ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
                currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
                coordinates.Y += widthOffset;
            }
            coordinates.Y -= heightOffset;
            coordinates.X += shareHolderHeightOffset;
            ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
            currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
            #endregion

            #region J.I.Case/Maytag ShareHolder Meeting
            rectangleSize = new Size(shareHolderHeightOffset, heightOffset);
            coordinates.Y -= heightOffset * 6;
            coordinates.X -= shareHolderHeightOffset * 21;

            ShareHolderMeetingEntrance jiCaseEntrance = GameState.Board.StartSpace4.Right.Right.Right as ShareHolderMeetingEntrance;
            currentShareHolderSpace = jiCaseEntrance.ShareHolderSpace;

            ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
            currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
            coordinates.X += shareHolderHeightOffset;

            for (int i = 0; i < 7; i++)
            {
                ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
                currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
                coordinates.Y += widthOffset;
            }
            coordinates.Y -= heightOffset;
            coordinates.X -= shareHolderHeightOffset;
            ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
            currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
            #endregion

            #region WesternPub/AmericanMotors ShareHolder Meeting
            rectangleSize = new Size(widthOffset, shareHolderHeightOffset);
            
            coordinates.X += widthOffset * 2;
            coordinates.Y += (heightOffset * 2) + shareHolderHeightOffset;
            ShareHolderMeetingEntrance westernPubEntrance = GameState.Board.StartSpace3.Right.Right.Right as ShareHolderMeetingEntrance;
            currentShareHolderSpace = alcoaEntrance.ShareHolderSpace;

            ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
            currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
            coordinates.Y -= shareHolderHeightOffset;

            for (int i = 0; i < 7; i++)
            {
                ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
                currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
                coordinates.X += widthOffset;
            }
            coordinates.X -= widthOffset;
            coordinates.Y += shareHolderHeightOffset;
            ShareHolderSpaces.Add(new ShareHolderGui(currentShareHolderSpace, Color.Black, SpaceRegion.TopRow, new Rectangle(coordinates, rectangleSize)));
            currentShareHolderSpace = currentShareHolderSpace.Right as ShareHolderSpace;
            #endregion

        }

        private Color _getStockColor(string name)
        {
            switch (name)
            {
                case "Woolsworth":
                    return Color.DarkOrange;
                case "Alcoa":
                    return Color.Red;
                case "Western Publishing":
                    return Color.GreenYellow;
                case "Maytag":
                    return Color.Green;
                case "General Mills":
                    return Color.CornflowerBlue;
                case "International Shoe":
                    return Color.DeepPink;
                case "J.I. Case":
                    return Color.Goldenrod;
                case "American Motors":
                    return Color.Yellow;
                default:
                    return Color.White;
            }
        }

        private void BoardScreen_Load(object sender, EventArgs e)
        {

        }

        private void BoardScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (var space in this.Spaces)
            {
                e.Graphics.FillRectangle(new SolidBrush(space.Color), space.Bounds);

                string text = "";

                var stockPurchaseSpace = space.Space as StockSpace;

                if (stockPurchaseSpace != null)
                {
                    text += "Div. $" + stockPurchaseSpace.Stock.Dividend + "\n";
                }

                var sellAllSpace = space.Space as SellAllSpace;

                if (sellAllSpace != null)
                {
                    text += "Sell All\n" ;
                }

                var stockSpace = space.Space as IStockSpace;

                if (stockSpace != null)
                {
                    text += stockSpace.Stock.Name+"\n";
                }

                var directionArrow = GetDirectionArrow(space.Space.Direction, space.SpaceRegion);

                text += directionArrow + "\n";
                 
                text += GetPlusMinusSign(space.Space.MarketMovement) +
                    space.Space.MarketMovement.ToString();

                using (Font font = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point))
                {
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    RectangleF rectangle = new RectangleF(space.Bounds.X, space.Bounds.Y, space.Bounds.Width, space.Bounds.Height);
                    e.Graphics.DrawString(text, font, Brushes.Black, rectangle, stringFormat);
                }
            }

            foreach (var space in ShareHolderSpaces)
            {
                e.Graphics.FillRectangle(new SolidBrush(space.Color), space.Bounds);

                using (Font font = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point))
                {
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    RectangleF rectangle = new RectangleF(space.Bounds.X, space.Bounds.Y, space.Bounds.Width, space.Bounds.Height);
                    e.Graphics.DrawString(space.Space.Multiplier + " For 1", font, Brushes.White, rectangle, stringFormat);
                }
            }
        }
        private string GetPlusMinusSign(int number)
        {
            if (number < 0)
            {
                return "";//will already have a negative sign if negative
            }
            else if (number > 0)
            {
                return "+";
            }
            else
            {
                return "";
            }
        }

        private string GetDirectionArrow(Direction direction, SpaceRegion region)
        {
            if (region == SpaceRegion.BottomRow)
            {
                if (direction == Direction.Left)
                {
                    return "←";
                }
                else if (direction == Direction.Right)
                {
                    return "→";
                }
                else
                {
                    return "↔";
                }
            }

            if (region == SpaceRegion.TopRow)
            {
                if (direction == Direction.Left)
                {
                    return "→";
                }
                else if (direction == Direction.Right)
                {
                    return "←";
                }
                else
                {
                    return "↔";
                }
            }

            if (region == SpaceRegion.LeftRow)
            {
                if (direction == Direction.Left)
                {
                    return "↑";
                }
                else if (direction == Direction.Right)
                {
                    return "↓";
                }
                else
                {
                    return "↕";
                }
            }

            if (region == SpaceRegion.RightRow)
            {
                if (direction == Direction.Left)
                {
                    return "↓";
                }
                else if (direction == Direction.Right)
                {
                    return "↑";
                }
                else
                {
                    return "↕";
                }
            }

            if (region == SpaceRegion.TopLeftCorner)
            {
                return "←↓";
            }
            if (region == SpaceRegion.TopRightCorner)
            {
                return "↑←";
            }
            if (region == SpaceRegion.BottomLeftCorner)
            {
                return "↓→";
            }
            if (region == SpaceRegion.BottomRightCorner)
            {
                return "→↑";
            }

            return "↔";
        }
    }
}
