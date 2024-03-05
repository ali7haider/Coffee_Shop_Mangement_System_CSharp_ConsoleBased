using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.UI
{
    class MenuUI
    {
        static public void header()
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("                                                        ");
            Console.WriteLine("            Welcome to the Tesha's Coffee               ");
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("                                                        ");
        }
        static public string menu()
        {
            header();
            Console.WriteLine("[1]- Add a Menu Item");
            Console.WriteLine("[2]- View the Cheapest Item in the Menu");
            Console.WriteLine("[3]- View the Drink Menu");
            Console.WriteLine("[4]- View the Food Menu");
            Console.WriteLine("[5]- Add Order");
            Console.WriteLine("[6]- Fulfil the Order");
            Console.WriteLine("[7]- View the Order List");
            Console.WriteLine("[8]- Total Payable Amount");
            Console.WriteLine("[9]- Exit");
            Console.Write("Your Option....");
            string o = Console.ReadLine();
            return o;
        }
    }
}
