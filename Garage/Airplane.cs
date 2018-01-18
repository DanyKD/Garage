using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Airplane:Vehicle
    {
        private string _vehicle;
        private int _numberOfSeats;
        public Airplane(string airplane, int numberOfSeats, string registration, string color, int numberOfWheels, double weight)
            : base(airplane, registration, color, numberOfWheels, weight)
        {
            _vehicle = airplane;
            _numberOfSeats = numberOfSeats;
        }
        public Airplane(string airplane):base(airplane)
        {
            _vehicle = airplane;
        }
        public int NumberOfSeats
        {
            get
            {
                return _numberOfSeats;
            }
            set
            {
                _numberOfSeats= value;
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
