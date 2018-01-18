using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Boat:Vehicle
    {
        private string _vehicle;
        private double _length;

        public Boat(string boat, double length, string registration, string color, int numberOfWheels, double weight)
            : base(boat, registration, color, numberOfWheels, weight)
        {
            _vehicle = boat;
            _length = length;
        }
        public Boat(string boat)
           : base(boat)
        {
            _vehicle = boat;
        }


        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public string Vehicle
        {
            get
            {
                return _vehicle;
            }
            set
            {
                _vehicle = value;
            }
        }
    }
}
