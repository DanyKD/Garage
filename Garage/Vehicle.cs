using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Vehicle
    {
            private string _vehicle;
            private string _registration;
            private string _color;
            private int _numberOfWheels;
            private double _weight;
        
        public Vehicle(string vehicle)
        {
            _vehicle = vehicle;
        }

        public Vehicle(string vehicle,string registration, string color, int numberOfWheels, double weight)
            {
                _registration = registration;
                _color = color;
                _numberOfWheels = numberOfWheels;
                _weight = weight;
                _vehicle = vehicle;
            }
        public string VehicleN
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
        public string Registration
        {
            get
            {
                return _registration;
            }
            set
            {
                Registration = _registration;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                Color = _color;
            }
        }
        public int NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }
            set
            {
                NumberOfWheels = _numberOfWheels;
            }
        }
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                Weight = _weight;
            }
        }
        
    }
}
