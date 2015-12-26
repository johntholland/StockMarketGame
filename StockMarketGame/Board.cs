using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class Board
    {
        public PoliceMan PoliceMan = new PoliceMan();
        public Doctor Doctor = new Doctor();
        public DeepSeaDiver DeepSeaDiver = new DeepSeaDiver();
        public Prospector Prospector = new Prospector();

        public ISpace StartSpace1 { get; set; }
        public ISpace StartSpace2 { get; set; }
        public ISpace StartSpace3 { get; set; }
        public ISpace StartSpace4 { get; set; }

        public Board()
        {
            this.StartSpace1 = new StartSpace();
            this.StartSpace2 = new StartSpace();
            this.StartSpace3 = new StartSpace();
            this.StartSpace4 = new StartSpace();

            //Alcoa ShareHolder's Meeting

            ISpace alcoaCurrent = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 1);

            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 2);
            alcoaCurrent = alcoaCurrent.Left;

            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 1);
            alcoaCurrent = alcoaCurrent.Left;

            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 3);
            alcoaCurrent = alcoaCurrent.Left;

            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 1);
            alcoaCurrent = alcoaCurrent.Left;

            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 2);
            alcoaCurrent = alcoaCurrent.Left;

            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 1);
            alcoaCurrent = alcoaCurrent.Left;
            //


            ISpace activeSpace = StartSpace1;

            activeSpace.Right = new StockSpace(Stock.Alcoa, -1, Direction.Left, false);
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.Woolsworth, +2, Direction.Left, false);
            activeSpace = activeSpace.Right;

            //...

            StartSpace1.Left = activeSpace;


        }
    }
}
