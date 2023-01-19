using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj05
{
    public class Program
    {
        public static void Main()
        {
            CoffeeMaker myCoffeeMachine = new CoffeeMaker();


            myCoffeeMachine.SetBrandName("Keuregano");
            myCoffeeMachine.SetTankCapacityInOunces(124.62);
            myCoffeeMachine.SetFilterContainerInPlace(false);
            myCoffeeMachine.SetPowerOn(true);


            myCoffeeMachine.BrewCoffee();

            System.Console.ReadLine();
        }
    }
}
