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

        public ShareHolderSpace AlcoaFirstShareHolderSquare { get; set; }
        public ShareHolderSpace WoolsworthFirstShareHolderSquare { get; set; }
        public ShareHolderSpace MaytagFirstShareHolderSquare { get; set; }
        public ShareHolderSpace JICaseFirstShareHolderSquare { get; set; }
        public ShareHolderSpace GeneralMillsFirstShareHolderSquare { get; set; }
        public ShareHolderSpace InterShoeFirstShareHolderSquare { get; set; }
        public ShareHolderSpace WesterPubFirstShareHolderSquare { get; set; }
        public ShareHolderSpace AmericanMotorsFirstShareHolderSquare { get; set; }

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
            AlcoaFirstShareHolderSquare = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 1);
            ISpace alcoaCurrent = AlcoaFirstShareHolderSquare;
            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 2);
            alcoaCurrent = alcoaCurrent.Left;
            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 1);
            alcoaCurrent = alcoaCurrent.Left;
            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 2);
            alcoaCurrent = alcoaCurrent.Left;
            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 3);
            alcoaCurrent = alcoaCurrent.Left;
            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 2);
            alcoaCurrent = alcoaCurrent.Left;
            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 1);
            alcoaCurrent = alcoaCurrent.Left;
            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 2);
            alcoaCurrent = alcoaCurrent.Left;
            alcoaCurrent.Left = new ShareHolderSpace(Stock.Alcoa, Direction.Left, 1);
            alcoaCurrent = alcoaCurrent.Left;
            #endregion

            #region Woolsworth ShareHolders Meeting

            WoolsworthFirstShareHolderSquare = new ShareHolderSpace(Stock.Woolsworth, Direction.Right, 1);

            ISpace woolsWorthCurrent = WoolsworthFirstShareHolderSquare;
            woolsWorthCurrent.Right = new ShareHolderSpace(Stock.Woolsworth, Direction.Right, 2);
            woolsWorthCurrent = woolsWorthCurrent.Right;
            woolsWorthCurrent.Right = new ShareHolderSpace(Stock.Woolsworth, Direction.Right, 1);
            woolsWorthCurrent = woolsWorthCurrent.Right;
            woolsWorthCurrent.Right = new ShareHolderSpace(Stock.Woolsworth, Direction.Right, 2);
            woolsWorthCurrent = woolsWorthCurrent.Right;
            woolsWorthCurrent.Left = new ShareHolderSpace(Stock.Woolsworth, Direction.Right, 3);
            woolsWorthCurrent = woolsWorthCurrent.Right;
            woolsWorthCurrent.Right = new ShareHolderSpace(Stock.Woolsworth, Direction.Right, 2);
            woolsWorthCurrent = woolsWorthCurrent.Right;
            woolsWorthCurrent.Right = new ShareHolderSpace(Stock.Woolsworth, Direction.Right, 1);
            woolsWorthCurrent = woolsWorthCurrent.Right;
            woolsWorthCurrent.Right = new ShareHolderSpace(Stock.Woolsworth, Direction.Right, 2);
            woolsWorthCurrent = woolsWorthCurrent.Right;
            woolsWorthCurrent.Right = new ShareHolderSpace(Stock.Woolsworth, Direction.Right, 1);
            woolsWorthCurrent = woolsWorthCurrent.Right;
            #endregion

            #region Maytag ShareHolders Meeting

            MaytagFirstShareHolderSquare = new ShareHolderSpace(Stock.Maytag, Direction.Left, 1);
            ISpace maytagCurrent = MaytagFirstShareHolderSquare;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 2);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 3);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 2);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 3);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 2);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 3);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 2);
            maytagCurrent = maytagCurrent.Left;
            maytagCurrent.Left = new ShareHolderSpace(Stock.Maytag, Direction.Left, 1);
            maytagCurrent = maytagCurrent.Left;
            #endregion

            #region Western Publishing ShareHolders Meeting

            WesterPubFirstShareHolderSquare = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 1);
            ISpace westernPubCurrent = WesterPubFirstShareHolderSquare;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 2);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 3);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 2);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 1);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 2);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 3);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 2);
            westernPubCurrent = westernPubCurrent.Left;
            westernPubCurrent.Left = new ShareHolderSpace(Stock.WesternPublishing, Direction.Left, 1);
            westernPubCurrent = westernPubCurrent.Left;
            #endregion

            #region General Mills ShareHolders Meeting

            GeneralMillsFirstShareHolderSquare = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 1);
            ISpace generalMillsCurrent = GeneralMillsFirstShareHolderSquare;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 3);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 2);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 3);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 2);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 3);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 2);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 3);
            generalMillsCurrent = generalMillsCurrent.Left;
            generalMillsCurrent.Left = new ShareHolderSpace(Stock.GeneralMills, Direction.Left, 1);
            generalMillsCurrent = generalMillsCurrent.Left;
            #endregion

            #region International ShareHolders Meeting

            InterShoeFirstShareHolderSquare = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 1);
            ISpace internationalShoeCurrent = InterShoeFirstShareHolderSquare;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 3);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 2);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 3);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 2);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 3);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 2);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 3);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            internationalShoeCurrent.Left = new ShareHolderSpace(Stock.InternationalShoe, Direction.Left, 1);
            internationalShoeCurrent = internationalShoeCurrent.Left;
            #endregion

            #region American Motors ShareHolders Meeting

            AmericanMotorsFirstShareHolderSquare = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 1);
            ISpace americanMotorsCurrent = AmericanMotorsFirstShareHolderSquare;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 2);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 3);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 2);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 1);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 2);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 3);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 2);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            americanMotorsCurrent.Left = new ShareHolderSpace(Stock.AmericanMotors, Direction.Left, 1);
            americanMotorsCurrent = americanMotorsCurrent.Left;
            #endregion

            #region J.I.Case ShareHolders Meeting
            JICaseFirstShareHolderSquare = new ShareHolderSpace(Stock.JICase, Direction.Left, 1);
            ISpace jiCaseCurrent = JICaseFirstShareHolderSquare;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 2);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 3);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 2);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 3);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 2);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 3);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 2);
            jiCaseCurrent = jiCaseCurrent.Left;
            jiCaseCurrent.Left = new ShareHolderSpace(Stock.JICase, Direction.Left, 1);
            jiCaseCurrent = jiCaseCurrent.Left;
            #endregion
            #endregion

            #region Main Squares
            ISpace activeSpace = StartSpace1;
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.Maytag, +1, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.GeneralMills, -2, Direction.Left));

            var alcoaEntrance = new ShareHolderMeetingEntrance(Stock.Alcoa, +3, Direction.Right);
            alcoaEntrance.ShareHolderSpace = AlcoaFirstShareHolderSquare as ShareHolderSpace;
            woolsWorthCurrent.Right = alcoaEntrance;
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, alcoaEntrance);

            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.AmericanMotors, -4, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new SellAllSpace(Stock.Woolsworth, +5, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new CornerSpace(+20, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new SellAllSpace(Stock.Maytag, -5, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.GeneralMills, +4, Direction.Left));

            var jiCaseEntrance = new ShareHolderMeetingEntrance(Stock.JICase, -3, Direction.Left);
            jiCaseEntrance.ShareHolderSpace = JICaseFirstShareHolderSquare as ShareHolderSpace;
            maytagCurrent.Right = jiCaseEntrance;
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, jiCaseEntrance);


            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.AmericanMotors, +2, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.Alcoa, -1, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, StartSpace2);
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.Woolsworth, -1, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.WesternPublishing, +2, Direction.Left));


            var maytagEntrance = new ShareHolderMeetingEntrance(Stock.Maytag, -3, Direction.Right);
            maytagEntrance.ShareHolderSpace = MaytagFirstShareHolderSquare as ShareHolderSpace;
            jiCaseCurrent.Right = maytagEntrance;
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, maytagEntrance);

            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.InternationalShoe, +4, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new SellAllSpace(Stock.JICase, -5, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new CornerSpace(-20, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new SellAllSpace(Stock.WesternPublishing, +5, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.Alcoa, -4, Direction.Left));


            var americanMotorsEntrance = new ShareHolderMeetingEntrance(Stock.AmericanMotors, +3, Direction.Left);
            americanMotorsEntrance.ShareHolderSpace = AmericanMotorsFirstShareHolderSquare as ShareHolderSpace;
            westernPubCurrent.Right = americanMotorsEntrance;
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, americanMotorsEntrance);

            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.Maytag, -2, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.GeneralMills, +1, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, StartSpace3);
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.InternationalShoe, +1, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.JICase, -2, Direction.Left));


            var westernPubEntrance = new ShareHolderMeetingEntrance(Stock.WesternPublishing, +3, Direction.Right);
            westernPubEntrance.ShareHolderSpace = WesterPubFirstShareHolderSquare as ShareHolderSpace;
            americanMotorsCurrent.Right = westernPubEntrance;
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, westernPubEntrance);

            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.Woolsworth, -4, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new SellAllSpace(Stock.AmericanMotors, +5, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new CornerSpace(+20, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new SellAllSpace(Stock.InternationalShoe, -5, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.Maytag, +4, Direction.Left));

            var genMillEntrance = new ShareHolderMeetingEntrance(Stock.GeneralMills, -3, Direction.Left);
            genMillEntrance.ShareHolderSpace = GeneralMillsFirstShareHolderSquare as ShareHolderSpace;
            internationalShoeCurrent.Right = genMillEntrance;
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, genMillEntrance);

            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.Alcoa, +2, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.AmericanMotors, -1, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, StartSpace4);
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.WesternPublishing, -1, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.Woolsworth, +2, Direction.Left));

            var intShoeEntrance = new ShareHolderMeetingEntrance(Stock.InternationalShoe, -3, Direction.Right);
            intShoeEntrance.ShareHolderSpace = InterShoeFirstShareHolderSquare as ShareHolderSpace;
            generalMillsCurrent.Right = intShoeEntrance;
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, intShoeEntrance);

            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.JICase, +4, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new SellAllSpace(Stock.GeneralMills, -5, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new CornerSpace(-20, Direction.Right));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new SellAllSpace(Stock.Alcoa, +5, Direction.Left));
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.WesternPublishing, -4, Direction.Left));
            
            var woolsworthEntrance = new ShareHolderMeetingEntrance(Stock.Woolsworth, +3, Direction.Left);
            woolsworthEntrance.ShareHolderSpace = WoolsworthFirstShareHolderSquare as ShareHolderSpace;
            alcoaCurrent.Right = woolsworthEntrance;
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, woolsworthEntrance);
            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.InternationalShoe, -2, Direction.Left));

            activeSpace = AddSpaceToRightAndAdvance(activeSpace, new StockSpace(Stock.JICase, +1, Direction.Left));

            activeSpace.Right = StartSpace1;
            StartSpace1.Left = activeSpace;
            #endregion
        }


        public ISpace AddSpaceToRightAndAdvance(ISpace activeSpace, ISpace newSpace)
        {
            activeSpace.Right = newSpace;
            newSpace.Left = activeSpace;
            activeSpace = activeSpace.Right;

            return activeSpace;
        }
    }
}
