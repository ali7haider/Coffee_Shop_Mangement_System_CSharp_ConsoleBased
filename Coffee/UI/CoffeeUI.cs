using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.BL;
using Coffee.DL;

namespace Coffee.UI
{
    class CoffeeUI
    {
        
        static public MenuItem addMenuItem()
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Type(Drink or Food) : ");
            string type = Console.ReadLine();
            Console.Write("Enter price : ");
            int price = int.Parse(Console.ReadLine());
            MenuItem I = new MenuItem(name, type, price);
            Console.Clear();
            return I;
        }
       public static void cheapItem()
        {
            if (CoffeeCRUD.menulist.Count > 0)
            {
                string cheapItem = CoffeeCRUD.cheapestItem();
                Console.WriteLine("Cheapest Item Is : " + cheapItem);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("No Item Availabe");
                Console.ReadKey();
            }
            Console.Clear();
        }
        public static void drinkonly()
        {
            if (CoffeeCRUD.menulist.Count > 0)
            {
                Console.WriteLine("Drinks Items are : ");
                foreach (MenuItem I in CoffeeCRUD.menulist)
                {
                    if (I.getType() == "Drink")
                    {
                        
                        Console.Write(I.getName() + " ,  ");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Drink Item Availabe");
               
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void foodonly()
        {
            if (CoffeeCRUD.menulist.Count > 0)
            {
                Console.WriteLine("Food Items are : ");
                foreach (MenuItem I in CoffeeCRUD.menulist)
                {
                    if (I.getType() == "Food")
                    {
                        Console.Write(I.getName() + " ,  ");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Food Item Availabe");

            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void addOrder()
        {
            if (CoffeeCRUD.menulist.Count > 0)
            {
                Console.Write("Enter Order Name : ");
                string order = Console.ReadLine();
                check(order);
            }
            else
            {
                Console.WriteLine("No Such Item Availabe");

            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void check(string order)
        {
            foreach(MenuItem I in CoffeeCRUD.menulist)
            {
                if(order==I.getName())
                {
                    Console.WriteLine("Order Placed Succesfully");
                    CoffeeCRUD.orders.Add(order);
                }
            }
        }
        public static void orderList()
        {
            if (CoffeeCRUD.orders.Count > 0)
            {
                foreach (var o in CoffeeCRUD.orders)
                {
                    Console.Write(o + " , ");
                }
            }
            else
            {
                Console.WriteLine("No Pending Order");

            }
            Console.ReadKey();
            Console.Clear();
        }
        public static int totalamount()
        {
            int sum = 0;
            bool flag = false;
            if (CoffeeCRUD.orders.Count > 0)
            {
                foreach (var o in CoffeeCRUD.orders)
                {
                    flag = true;
                    sum = sum + amount(o);
                }
            }
           
           
            return sum;
        }
        static public int amount(string order)
        {
            foreach (MenuItem M in CoffeeCRUD.menulist)
            {
                if (order == M.getName())
                {
                    return M.getPrice();
                }
            }
            return 0;
        }
        public static void fulfilOrder()
        {
            if (CoffeeCRUD.orders.Count > 0)
            {
                foreach (var o in CoffeeCRUD.orders)
                {
                    Console.WriteLine("The " + o + " Is Ready");
                    
                }
                CoffeeCRUD.orders.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("All Orders have been Fulfiled");

            }
            
            Console.ReadKey();
            Console.Clear();
        }
        public static void payable()
        {
            int total = CoffeeUI.totalamount();
            Console.WriteLine("Total Payable Amount Is : " + total);
            Console.ReadKey();
            Console.Clear();

        }



    }
}