using System;
using System.Collections.Generic;

namespace StockMarketGame
{
    public abstract class Job
    {
        public List<int> payoutNumber = new List<int>();
        public abstract int Salary { get;}
    }


    public class PoliceMan : Job
    {
        public override int Salary
        {
            get
            {
                return 100;
            }
        }

        public PoliceMan()
        {
            payoutNumber.Add(5);
            payoutNumber.Add(9);
        }
    }

    public class Doctor : Job
    {
        public override int Salary
        {
            get
            {
                return 200;
            }
        }

        public Doctor()
        {
            payoutNumber.Add(4);
            payoutNumber.Add(10);
        }
    }

    public class DeepSeaDiver : Job
    {
        public override int Salary
        {
            get
            {
                return 300;
            }
        }

        public DeepSeaDiver()
        {
            payoutNumber.Add(3);
            payoutNumber.Add(11);
        }
    }

    public class Prospector : Job
    {
        public override int Salary
        {
            get
            {
                return 400;
            }
        }

        public Prospector()
        {
            payoutNumber.Add(2);
            payoutNumber.Add(12);
        }
    }
}