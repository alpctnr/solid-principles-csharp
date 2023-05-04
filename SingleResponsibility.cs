using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    // In this code, the Single Responsibility Principle is applied by separating 
    // the car's braking system and engine into separate classes, with each class responsible 
    // for performing only specific functions related to its respective component. 
    // The class names and method names are named according to their respective responsibilities, 
    //and the comments describe the purpose of each method.

    // Define a class for the braking system
    public class BrakeSystem
    {
        // Method for applying the brakes
        public void ApplyBrakes()
        {
            // Implementation for applying the brakes
        }

        // Method for checking the brake status
        public void CheckBrakeStatus()
        {
            // Implementation for checking the brake status
        }
    }

    // Define a class for the car's engine
    public class Engine
    {
        // Method for starting the engine
        public void Start()
        {
            // Implementation for starting the engine
        }

        // Method for stopping the engine
        public void Stop()
        {
            // Implementation for stopping the engine
        }
    }
}