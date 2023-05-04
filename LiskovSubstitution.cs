using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class LiskovSubstitution
    {
        // In this code example, LSP allows the Mustang and Civic classes that derive from the 
        // Car abstract base class to override the method defined in this abstract class, 
        // and to be passed as a parameter to the DisplayCars method in the CarShowroom class, 
        // as long as they satisfy the LSP requirements. This enables the CarShowroom class
        // to display any type of car model and allows for the addition of new car models to the system 
        // based on customer demands, as long as the LSP is adhered to.

        // Define an abstract base class for the car
        public abstract class Car
        {
            // Property for the car's model
            public string Model { get; set; }

            // Property for the car's year of production
            public int Year { get; set; }

            // Method for accelerating the car
            public abstract void Accelerate();
        }

        // Define a class for a specific car model that inherits from the base car class
        public class Mustang : Car
        {
            // Override the base class method to implement specific acceleration logic for the Mustang
            public override void Accelerate()
            {
                // Implementation for accelerating the Mustang
            }
        }

        // Define another class for a different car model that also inherits from the base car class
        public class Civic : Car
        {
            // Override the base class method to implement specific acceleration logic for the Civic
            public override void Accelerate()
            {
                // Implementation for accelerating the Civic
            }
        }

        // Define a class for the car showroom that displays cars
        public class CarShowroom
        {
            // Method for displaying the cars in the showroom
            public void DisplayCars(List<Car> cars)
            {
                foreach (var car in cars)
                {
                    car.Accelerate();
                }
            }
        }
    }
}