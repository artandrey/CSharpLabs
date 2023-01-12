using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    struct PhoneSearchStruct : IPhoneProperties
    {

        public int CamerasCount {get;}

        public int YearOfCreation {get;}

        public float Price {get;}

        public ConsoleColor[] AvailableColors { get; }


        public PhoneSearchStruct(ConsoleColor[] availableColors, int camerasCount, int yearOfCreation, float price)
        {
            CamerasCount = camerasCount;
            YearOfCreation = yearOfCreation;
            Price = price;
            AvailableColors = availableColors;
        }

    }
    internal class SmartphoneShopItem : IPhoneProperties
    {
        public ConsoleColor[] AvailableColors { get; set; }
        public int YearOfCreation { get; set; }
        public float Price { get; set; }
        public int CamerasCount { get; set; }


        public SmartphoneShopItem(ConsoleColor[] availableColors, int yearOfCreation, float price, int camerasCount)
        {
            this.AvailableColors = availableColors;
            this.YearOfCreation = yearOfCreation;
            this.Price = price;
            this.CamerasCount = camerasCount;
        }

        public bool CheckIsSatisfies(IPhoneProperties phoneProperties)
        {
            bool satisfies = false;

            foreach (ConsoleColor color in this.AvailableColors)

            {
                if (phoneProperties.AvailableColors.Contains(color))
                {
                    satisfies = true;
                    break;
                }
            }

            if (!satisfies) return false;

            satisfies = (this.YearOfCreation == phoneProperties.YearOfCreation);

            if (!satisfies) return false;

            satisfies = (this.Price < phoneProperties.Price);

            if (!satisfies) return false;

            satisfies = (this.CamerasCount == phoneProperties.CamerasCount);

            return satisfies;
        }

        private string GetColorsString()
        {
            string result = "";
            foreach (ConsoleColor color in AvailableColors)
            {
                result += "* " + color.ToString() + "\n";
            }
            return result;
        }

        public override string ToString()
        {
            string separetor = new string('-', 20);
            return $"{separetor} \nModel\n\nColors:\n{GetColorsString()}\nYear of creation: {YearOfCreation}\nPrice: {Price}$\nCameras Count: {CamerasCount}\n{separetor}";
        }

    }
}
