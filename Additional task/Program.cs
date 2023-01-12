using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphones shop = new Smartphones();

            shop.Add(new SmartphoneShopItem(
                availableColors: new ConsoleColor[] {ConsoleColor.Black, ConsoleColor.Blue},
                yearOfCreation: 2020,
                price: 1000.20f,
                camerasCount: 1
            ));
            shop.Add(new SmartphoneShopItem(
                availableColors: new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Red },
                yearOfCreation: 2020,
                price: 1500.20f,
                camerasCount: 1
            ));
            shop.Add(new SmartphoneShopItem(
                availableColors: new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.DarkBlue },
                yearOfCreation: 2019,
                price: 2200.40f,
                camerasCount: 1
            ));
            shop.Add(new SmartphoneShopItem(
                availableColors: new ConsoleColor[] { ConsoleColor.DarkGray, ConsoleColor.White },
                yearOfCreation: 2022,
                price: 5000f,
                camerasCount: 2
            ));
            shop.Add(new SmartphoneShopItem(
                availableColors: new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Yellow },
                yearOfCreation: 2018,
                price: 4000.50f,
                camerasCount: 3
            ));

            while(true)
            {


                ConsoleColor colorValue = Dialog.AskColor(shop.GetAvailableColorsLiterals());
                int year = Dialog.AskYear();
                float price = Dialog.AskPrice();
                int camerasCount = Dialog.AskCamerasCount();

                

                PhoneSearchStruct phoneSearchStruct = new PhoneSearchStruct(new ConsoleColor[] {colorValue}, camerasCount, year, price);

                List<SmartphoneShopItem> filteredItems = shop.PickDevicesByProperties(phoneSearchStruct);

                if (filteredItems.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nItems not founds!!!\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (SmartphoneShopItem item in filteredItems)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.ResetColor();

            }
        }
    }
}
