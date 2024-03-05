using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.BL;
using Coffee.DL;
using Coffee.UI;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            if(CoffeeCRUD.ReadFromFile())
            {
                Console.WriteLine("Data Read Succesfully");
            }
            while (true)
            {
                string op = MenuUI.menu();
                if (op == "1")
                {
                    MenuItem M = CoffeeUI.addMenuItem();
                    CoffeeCRUD.additemstoList(M);
                    CoffeeCRUD.StoreInFile(M);
                }
                else if (op == "2")
                {
                    CoffeeUI.cheapItem();

                }
                else if (op == "3")
                {
                    CoffeeUI.drinkonly();
                  
                }
                else if (op == "4")
                {
                    CoffeeUI.foodonly();
                }
                else if (op == "5")
                {
                    CoffeeUI.addOrder();
                }
                else if (op == "6")
                {
                    CoffeeUI.fulfilOrder();
                }
                else if (op == "7")
                {
                    CoffeeUI.orderList();
                }
                else if (op == "8")
                {
                    CoffeeUI.payable();
                }
                else if (op == "9")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input.....");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
