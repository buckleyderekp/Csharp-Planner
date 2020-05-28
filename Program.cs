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

            Building OneZeroTwoEasy = new Building("102 Easy Street")
            {
                Stories = 10,
                Width = 7,
                Depth = 8,
            };
            OneZeroTwoEasy.Construct();
            OneZeroTwoEasy.Purchase("Kristen Howton");

            City Derekville = new City("Derekville");

            Derekville.AddBuilding(FiveOneTwoEighth);
            Derekville.AddBuilding(OneZeroTwoEasy);

            foreach (Building building in Derekville.Buildings())
            {
                building.BuildingReport();
            }
        }
    }
}