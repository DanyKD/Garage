using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Vehicle
    {        
            private string _registration;
            private string _color;
            private int _numberOfWheels;
            private double _weight;
            private string _model;
            public Vehicle(string registration, string color, int numberOfWheels, double weight, string model)
            {
                _registration = registration;
                _color = color;
                _numberOfWheels = numberOfWheels;
                _weight = weight;
                _model = model;           
            }
        public string Registration
        {
            get
            {
                return Registration;
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
                return Color;
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
                return NumberOfWheels;
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
                return Weight;
            }
            set
            {
                Weight = _weight;
            }
        }
        public string Model
        {
            get
            {
                return Model;
            }
            set
            {
                Model = _model;
            }
        }
    }
}
