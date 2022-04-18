using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        /*
         * Imagine that we are working on a video game where the player can destoy stuff, but everything we destroy will have different behavior depending on what is destroyed
         * For example, destroying a chair will play some destruction sound and will spawn destroyed chair parts. But destroying a car will play an explosion sound, create fire and destroy othe objects 
         * nearby.For our game, we have the following classes, a chair that inherits from class furniture and the car that inherits from class vehicle.
         * In Csharp we can't have multiple base classes. So plus there is no concrete relationship between a car and a chair to share one base class anyways., because they're entirely different things.
         * If we implement normal methods called the destroy method, for example, in each of those classes that we have here, it will be hard to maintain. What if we decide to change the destruction system
         * entirely or add visual effects to our destructible objects in the future, it will be pain to actually go through each class and modify it.Imagine if we had 50 classes or 100 different classes
         * 100 different type of objects in your game, then you should go in every single of them and adjust the code accordingly. What we need is a way to enforce our destructible behavior on every class
         * that uses it, just like a contract. Interfaces are contracts that we can create. So the best approach on this case is to use an interface and we will call it IDestroyable and any class that 
         * implements this interface will be forced to follow our destruction requirements and customize it at the same time, depending on the class itself.
         * 
         * So basically interfaces allow us some sort of multi inheritance, even though it is not.
         * 
         * Interfaces are used for communication between two similar or non similar classes.
         * Interfaces provides us :
         *                          1) Code Readability
         *                          2) Code Semantics : seperating concepts
         *                          3) Code Maintainability
         *                          4) Design Patterns
         *                          5) Multiple Inheritance.
         */
        static void Main(string[] args)
        {
            // creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            // creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");

            // add the two chairs to the IDestroyable list of the car
            // so that when we destroy the car the destroyable objects
            // that are near the car will get destroyed as well.
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            // destroy the car
            damagedCar.Destroy();
        }
    }
}
