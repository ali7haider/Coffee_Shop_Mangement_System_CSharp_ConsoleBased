using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.BL
{
    class MenuItem
    {
        private string name;
        private string type;
        private int price;
        public MenuItem(string name,string type,int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public string getType()
        {
            return type;
        }
        public void setPrice(int price)
        {
            this.price=price;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
