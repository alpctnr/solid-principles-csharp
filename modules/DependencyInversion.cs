using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class DependencyInversion
    {
        // In this example, we have an IEngine interface that defines two methods: 
        // Start and Stop. We then have two classes, GasolineEngine and ElectricEngine, 
        // that implement this interface and provide their own implementations of the Start and Stop methods.

        // Finally, we have a Car class that depends on the IEngine interface through its constructor. 
        // This class has its own Start and Stop methods that simply delegate to the corresponding methods 
        // on the injected engine instance. By doing this, we are following the Dependency Inversion Principle, 
        // as the Car class depends on the abstraction (the IEngine interface) rather than on a specific implementation of it. 
        // This allows us to easily swap out the engine implementation without having to modify the Car class itself.
        
        
        // In this example, the ICar interface provides a contract for cars and allows different cars to
        public interface IEngine
        {
           void Start();
           void Stop();
        }

        public class GasolineEngine : IEngine
        {
           public void Start()
           {
               Console.WriteLine("Gasoline engine started.");
           }

           public void Stop()
           {
               Console.WriteLine("Gasoline engine stopped.");
           }
        }

        public class ElectricEngine : IEngine
        {
           public void Start()
           {
               Console.WriteLine("Electric engine started.");
           }

           public void Stop()
           {
               Console.WriteLine("Electric engine stopped.");
           }
        }


        public class Car
        {
            private readonly IEngine _engine;

            public Car(IEngine engine)
            {
                _engine = engine;
            }

            public void Start()
            {
                _engine.Start();
            }

            public void Stop()
            {
                _engine.Stop();
            }
        }
    }
}