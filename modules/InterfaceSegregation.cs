using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class InterfaceSegregation
    {
        // In this example, the ICar interface provides a contract for cars and allows different cars to 
        // implement different functions. The fuel consumption property is defined only as a property 
        // in the interface and is only implemented by the relevant cars. This is a design example that 
        // adheres to the ISP principle, where functionality in a car's interface is clearly 
        // separated and implemented as required.


        // Cars interface
        public interface ICar
        {
            // Car model property
            string Model { get; set; }

            // Car production year property
            int Year { get; set; }

            // Car acceleration method
            void Accelerate();

            // Car brake method
            void Brake();

            // Car fuel consumption method
            double GetFuelConsumption();
        }


        // Ford Mustang car class
        public class Mustang : ICar
        {
            public string Model { get; set; }
            public int Year { get; set; }

            public void Accelerate()
            {
                // Ford Mustang acceleration method
            }

            public void Brake()
            {
                // Ford Mustang brake method
            }

            public double GetFuelConsumption()
            {
                // Ford Mustang fuel consumption method
                return 10.5;
            }
        }

        // Honda Civic car class
        public class Civic : ICar
        {
            public string Model { get; set; }
            public int Year { get; set; }

            public void Accelerate()
            {
                // Honda Civic acceleration method
            }

            public void Brake()
            {
                // Honda Civic brake method
            }

            public double GetFuelConsumption()
            {
                // Honda Civic fuel consumption method
                return 7.8;
            }
        }
    }
}