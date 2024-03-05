using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.DL;
using Coffee.UI;

namespace Coffee.BL
{
    class CoffeeShop
    {
        private string name;
        List<MenuItem> menu = new List<MenuItem>();
        
        public CoffeeShop(string name,List<MenuItem> menu)
        {
            this.name = name;
            this.menu = menu;
            
        }
       
    }
}
