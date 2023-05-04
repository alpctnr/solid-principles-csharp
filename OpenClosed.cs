using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    //In this code, the Open-Closed Principle is applied by using an abstract base class for the car and allowing 
    //specific car models to inherit from it and override its methods. 
    //This allows new car models to be added to the system without modifying the existing code, 
    //making it open for extension but closed for modification. The CarShowroom class can then display 
    //any car model by calling its Accelerate method.
    
    
    // Define an abstract base class for the car
    public abstract class Car
    {
        // Property for the car's model
        public string Model { get; set; }

        // Property for the year of production
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