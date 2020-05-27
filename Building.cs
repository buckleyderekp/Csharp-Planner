using System;

namespace Planner
{
    class Building
    {
        private string _designer = "Derek";

        private DateTime _dateConstructed;

        private string _address;

        private string _owner;

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building(string newBuilding)
        {
            _address = newBuilding;
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }

        public string showAddress()
        {
            return _address;
        }
    }
}