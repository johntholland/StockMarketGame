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
        List<SpaceGui> Spaces;

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

            this.Spaces = new List<SpaceGui>();

            var activeSpace = this.GameState.Board.StartSpace1;
            var coordinates = new Point(0, 0);
            var rectangleSize = new Size(50, 50);

            //while (true)
            for (int i = 0; i < 13; i++)
            {

                this.Spaces.Add(new SpaceGui(activeSpace, Color.Black, new Rectangle(coordinates, rectangleSize)));
                coordinates.X += 50;
                activeSpace = activeSpace.Right;
            }
            coordinates.X = 0;

            for (int i = 0; i < 12; i++)
            {
                coordinates.Y += 50;
                this.Spaces.Add(new SpaceGui(activeSpace, Color.Black, new Rectangle(coordinates, rectangleSize)));

                activeSpace = activeSpace.Right;
            }

            for (int i = 0; i < 12; i++)
            {
                coordinates.X += 50;
                this.Spaces.Add(new SpaceGui(activeSpace, Color.Black, new Rectangle(coordinates, rectangleSize)));

                activeSpace = activeSpace.Right;
            }

            for (int i = 0; i < 11; i++)
            {
                coordinates.Y -= 50;
                this.Spaces.Add(new SpaceGui(activeSpace, Color.Black, new Rectangle(coordinates, rectangleSize)));

                activeSpace = activeSpace.Right;
            }
        }

        private void BoardScreen_Load(object sender, EventArgs e)
        {

        }

        private void BoardScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (var space in this.Spaces)
            {
                e.Graphics.DrawRectangle(new Pen(space.Color), space.Bounds);
            }
        }
    }
}
