using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp
{
    public class Menu
    {
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public Dictionary<string, List<MenuItems>>ItemsByCategory { get; set; } 
        public DateTime LastRevised { get; set; }

        public Menu(string restaurantName, string address, Dictionary<string, List<MenuItems>> itemsByCategory,DateTime lastRevised)
        {
            RestaurantName = restaurantName;
            Address = address;
            ItemsByCategory = itemsByCategory;
            LastRevised = lastRevised;
        }
        public void printMenu (string )
       
        }
    }

