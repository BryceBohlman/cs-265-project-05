using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj05
{
    public class CoffeeMaker
    {
        private string brandName;
        private double tankCapacityInOunces;
        private bool filterContainerInPlace;
        private bool powerOn;

        #region CONSTRUCTORS
        public CoffeeMaker()
        {
            brandName = string.Empty;
            tankCapacityInOunces = 0;
            filterContainerInPlace = false;
            powerOn = false;
        }

        public CoffeeMaker(string brand, double capacity, bool basketPresent, bool isOn)
        {
            brandName = brand;
            tankCapacityInOunces = capacity;
            filterContainerInPlace = basketPresent;
            powerOn = isOn;
        }
        #endregion

        #region SETTERS
        public void SetBrandName(string inputBrandName)
        {
            brandName = inputBrandName;
        }
        public void SetTankCapacityInOunces(double inputTankCapacityInOunces)
        {
            tankCapacityInOunces = inputTankCapacityInOunces;
        }
        public void SetFilterContainerInPlace(bool inputFilterContainerInPlace)
        {
            filterContainerInPlace = inputFilterContainerInPlace;
        }
        public void SetPowerOn(bool inputPowerOn)
        {
            powerOn = inputPowerOn;
        }
        #endregion

        #region GETTERS
        public string GetBrandName()
        {
            return brandName;
        }
        public double GetTankCapacityInOunces()
        {
            return tankCapacityInOunces;
        }
        public bool GetFilterContainerInPlace()
        {
            return filterContainerInPlace;
        }
        public bool GetPowerOn()
        {
            return powerOn;
        }
        #endregion

        public void BrewCoffee()
        {
            System.Console.WriteLine($"Machine brand is: {GetBrandName()}");
            System.Console.WriteLine($"Reservoir Capacity is: {GetTankCapacityInOunces()}");
            System.Console.WriteLine($"Switch is: {GetPowerOn()}");
            System.Console.WriteLine($"Basket is: {GetFilterContainerInPlace()}\n");

            if (filterContainerInPlace && powerOn)
            {
                System.Console.WriteLine($"Brewing coffee using {GetTankCapacityInOunces()} ounces of water.");
            }
            else
            {
                System.Console.WriteLine($"Cannot brew coffee!!! BASKET: {GetFilterContainerInPlace()} SWITCH: {GetPowerOn()}");//In the example, there was no colon after SWITCH, 
            }                                                                                                                   //however, I included one anyway because its absence 
        }                                                                                                                       //bothered me and I assumed it was an oversight
    }
}
