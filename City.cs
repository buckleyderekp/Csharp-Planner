using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {

        private string _city;

        public string Mayor { get; set; }

        public int YearEstablished { get; set; }

        private List<Building> _buildings = new List<Building>();
        public void AddBuilding(Building newBuilding)
        {
            _buildings.Add(newBuilding);
        }

        public City(string cityName)
        {
            _city = cityName;
        }

        public List<Planner.Building> Buildings()
        {
            return _buildings;
        }
    }
}