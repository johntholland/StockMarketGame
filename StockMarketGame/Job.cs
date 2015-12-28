using System;
using System.Collections.Generic;

namespace StockMarketGame
{
    public abstract class Job
    {
        public List<int> payoutNumber = new List<int>();
        public abstract int Salary { get;}
        public string Name { get; set; }
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
            this.Name = "PoliceMan";
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
            this.Name = "Doctor";
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
            this.Name = "DeepSeaDiver";
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
            this.Name = "Prospector";
        }
    }
}