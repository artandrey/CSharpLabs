using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    internal class Smartphones
    {
        private List<SmartphoneShopItem> smartphoneShopItems = new List<SmartphoneShopItem>();
        
        public void Add(SmartphoneShopItem smartphone)
        {
            this.smartphoneShopItems.Add(smartphone);
        }

        public List<SmartphoneShopItem> PickDevicesByProperties(IPhoneProperties phoneProperties)
        {
            return smartphoneShopItems.FindAll(smartphone => smartphone.CheckIsSatisfies(phoneProperties));
        }

        public string[] GetAvailableColorsLiterals()
        {
            HashSet<string> colors = new HashSet<string>();
            foreach (SmartphoneShopItem smartphone in smartphoneShopItems)
            {
                foreach (ConsoleColor color in smartphone.AvailableColors.ToArray())
                {
                    colors.Add(color.ToString());
                }
  
            }
            return colors.ToArray();
        }

    }
}
