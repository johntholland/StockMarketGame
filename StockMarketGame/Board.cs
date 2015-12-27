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
            #region StartSpaces

            this.StartSpace1 = new StartSpace();
            this.StartSpace2 = new StartSpace();
            this.StartSpace3 = new StartSpace();
            this.StartSpace4 = new StartSpace();

            #endregion

            #region ShareHolders Meetings
            #region Alcoa ShareHolders Meeting
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
            #endregion

            #region Woolsworth ShareHolders Meeting
            ISpace woolsWorthCurrent = new ShareHolderSpace(Stock.Woolsworth, Direction.Left, 1);
            woolsWorthCurrent.Left = new ShareHolderSpace(Stock.Woolsworth, Direction.Left, 2);
            woolsWorthCurrent = woolsWorthCurrent.Left;
            woolsWorthCurrent.Left = new ShareHolderSpace(Stock.Woolsworth, Direction.Left, 1);
            woolsWorthCurrent = woolsWorthCurrent.Left;
            woolsWorthCurrent.Left = new ShareHolderSpace(Stock.Woolsworth, Direction.Left, 3);
            woolsWorthCurrent = woolsWorthCurrent.Left;
            woolsWorthCurrent.Left = new ShareHolderSpace(Stock.Woolsworth, Direction.Left, 1);
            woolsWorthCurrent = woolsWorthCurrent.Left;
            woolsWorthCurrent.Left = new ShareHolderSpace(Stock.Woolsworth, Direction.Left, 2);
            woolsWorthCurrent = woolsWorthCurrent.Left;
            woolsWorthCurrent.Left = new ShareHolderSpace(Stock.Woolsworth, Direction.Left, 1);
            woolsWorthCurrent = woolsWorthCurrent.Left;
            #endregion

            #region Maytag ShareHolders Meeting
            ISpace maytagCurrent = new ShareHolderSpace(Stock.Maytag, Direction.Left, 1);
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 2);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 1);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 3);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 1);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 2);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 1);
            maytagCurrent = maytagCurrent.Left;
            #endregion

            #region Western Publishing ShareHolders Meeting
            ISpace westernPubCurrent = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 1);
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 2);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 1);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 3);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 1);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 2);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 1);
            westernPubCurrent = westernPubCurrent.Left;
            #endregion

            #region General Mills ShareHolders Meeting
            ISpace generalMillsCurrent = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 1);
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 2);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 1);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 3);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 1);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 2);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 1);
            generalMillsCurrent = generalMillsCurrent.Left;
            #endregion

            #region International ShareHolders Meeting
            ISpace internationalShoeCurrent = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 1);
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 2);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 1);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 3);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 1);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 2);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 1);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            #endregion

            #region American Motors ShareHolders Meeting
            ISpace americanMotorsCurrent = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 1);
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 2);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 1);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 3);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 1);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 2);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 1);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            #endregion

            #region J.I.Case ShareHolders Meeting
            ISpace jiCaseCurrent = new ShareHolderSpace(Stock.JICase, Direction.Left, 1);
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 2);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 1);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 3);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 1);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 2);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 1);
            jiCaseCurrent = jiCaseCurrent.Left;
            #endregion
            #endregion

            //main squares
            ISpace activeSpace = StartSpace1;
            activeSpace.Right = new StockSpace(Stock.Maytag, +1, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.GeneralMills, -2, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;

            var alcoaEntrance = new ShareHolderMeetingEntrance(Stock.Alcoa, +3, Direction.Right);
            alcoaEntrance.ShareHolderSpace = alcoaCurrent as ShareHolderSpace;
            activeSpace.Right = alcoaEntrance;
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;

            activeSpace.Right = new StockSpace(Stock.AmericanMotors, -4, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new SellAllSpace(Stock.Woolsworth, +5, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new CornerSpace(+20, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new SellAllSpace(Stock.Maytag, -5, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.GeneralMills, +4, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;

            var jiCaseEntrance = new ShareHolderMeetingEntrance(Stock.JICase, -3, Direction.Left);
            jiCaseEntrance.ShareHolderSpace = jiCaseCurrent as ShareHolderSpace;
            activeSpace.Right = jiCaseEntrance;
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;

            activeSpace.Right = new StockSpace(Stock.AmericanMotors, +2, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.Alcoa, -1, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = StartSpace2;
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.Woolsworth, -1, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.WesternPublishing, +2, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;


            var maytagEntrance = new ShareHolderMeetingEntrance(Stock.Maytag, -3, Direction.Right);
            maytagEntrance.ShareHolderSpace = maytagCurrent as ShareHolderSpace;
            activeSpace.Right = maytagEntrance;
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;

            activeSpace.Right = new StockSpace(Stock.InternationalShoe, +4, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new SellAllSpace(Stock.JICase, -5, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new CornerSpace(-20, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new SellAllSpace(Stock.WesternPublishing, +5, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.Alcoa, -4, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;


            var americanMotorsEntrance = new ShareHolderMeetingEntrance(Stock.AmericanMotors, +3, Direction.Left);
            americanMotorsEntrance.ShareHolderSpace = americanMotorsCurrent as ShareHolderSpace;
            activeSpace.Right = americanMotorsEntrance;
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;

            activeSpace.Right = new StockSpace(Stock.Maytag, -2, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.GeneralMills, +1, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = StartSpace3;
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.InternationalShoe, +1, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.JICase, -2, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;


            var westernPubEntrance = new ShareHolderMeetingEntrance(Stock.WesternPublishing, +3, Direction.Right);
            westernPubEntrance.ShareHolderSpace = westernPubCurrent as ShareHolderSpace;
            activeSpace.Right = westernPubEntrance;

            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.Woolsworth, -4, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new SellAllSpace(Stock.AmericanMotors, +5, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new CornerSpace(+20, Direction.Right);

            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;


            activeSpace.Right = new SellAllSpace(Stock.InternationalShoe, -5, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.Maytag, +4, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;


            var genMillEntrance = new ShareHolderMeetingEntrance(Stock.GeneralMills, -3, Direction.Left);
            genMillEntrance.ShareHolderSpace = generalMillsCurrent as ShareHolderSpace;
            activeSpace.Right = genMillEntrance;
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;


            activeSpace.Right = new StockSpace(Stock.Alcoa, +2, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.AmericanMotors, -1, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = StartSpace4;
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.WesternPublishing, -1, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.Woolsworth, +2, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;

            var intShoeEntrance = new ShareHolderMeetingEntrance(Stock.InternationalShoe, -3, Direction.Right);
            intShoeEntrance.ShareHolderSpace = internationalShoeCurrent as ShareHolderSpace;
            activeSpace.Right = intShoeEntrance;
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;

            activeSpace.Right = new StockSpace(Stock.JICase, +4, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new SellAllSpace(Stock.GeneralMills, -5, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new CornerSpace(-20, Direction.Right);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new SellAllSpace(Stock.Alcoa, +5, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.WesternPublishing, -4, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;


            
            var woolsworthEntrance = new ShareHolderMeetingEntrance(Stock.Woolsworth, +3, Direction.Left);
            woolsworthEntrance.ShareHolderSpace = woolsWorthCurrent as ShareHolderSpace;
            activeSpace.Right = woolsworthEntrance;

            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.InternationalShoe, -2, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = new StockSpace(Stock.JICase, +1, Direction.Left);
            activeSpace.Right.Left = activeSpace;
            activeSpace = activeSpace.Right;
            activeSpace.Right = StartSpace1;
            StartSpace1.Left = activeSpace;


        }
    }
}
