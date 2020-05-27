using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEighth = new Building("512 8th street")
            {
                Stories = 3,
                Width = 5,
                Depth = 10,

            };
            FiveOneTwoEighth.Construct();
            FiveOneTwoEighth.Purchase("Thomas Long");
            FiveOneTwoEighth.BuildingReport();
        }
    }
}