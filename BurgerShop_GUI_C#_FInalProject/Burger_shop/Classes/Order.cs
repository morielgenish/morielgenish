using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_shop
{
    public class Order
    {
        private string[] options;

        //Constructor
        public Order()
        {
            options = new string[4]; 
        }

        //Get
        public string[] GetOptions()
        {
            return options;
        }

        //Methods
        public void AddToCategory(string category, string option)
        {
            int index = GetCategoryIndex(category);
            if (index != -1)
            {
                options[index] += option + ", ";
            }
        }

        public void RemoveFromCategory(string category, string option)
        {
            int index = GetCategoryIndex(category);
            if (index != -1)
            {
                options[index] = options[index].Replace(option + ", ", "");
            }
        }

        private int GetCategoryIndex(string category)
        {
            switch (category)
            {
                case "Hamburger":
                    return 0;
                case "Extras":
                    return 1;
                case "Drinks":
                    return 2;
                case "Sauces":
                    return 3;
                default:
                    return -1;
            }
        }
    }
}
