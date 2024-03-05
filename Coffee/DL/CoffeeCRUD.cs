using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Coffee.BL;
using Coffee.UI;

namespace Coffee.DL
{
    class CoffeeCRUD
    {
        public static List<MenuItem> menulist = new List<MenuItem>();
        public static List<string> orders = new List<string>();
        static public void additemstoList(MenuItem item)
        {
            menulist.Add(item);
        }
        static public string cheapestItem()
        {

            int cheapest= menulist[0].getPrice();
            string cheapestItem = menulist[0].getName();

            for (int i = 0; i < menulist.Count - 1; i++)
            {
                if(menulist[i+1].getPrice()<cheapest)
                {
                    cheapest = menulist[i + 1].getPrice();
                    cheapestItem = menulist[i + 1].getName();
                    
                }
            }
            return cheapestItem;
        }
        public static void StoreInFile(MenuItem M)
        {
            string path = "menuItems.txt";
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(M.getName() + "," + M.getType() + "," + M.getPrice());
            file.Flush();
            file.Close();
        }
        public static bool ReadFromFile()
        {
            string path = "menuItems.txt";
            StreamReader file = new StreamReader(path);
            string record = "";
            if(File.Exists(path))
            {
                while((record=file.ReadLine())!=null)
                {
                    string[] splittedRecord = record.Split(',');
                    string Name = splittedRecord[0];
                    string type = splittedRecord[1];
                    int price = int.Parse(splittedRecord[2]);
                    MenuItem M = new MenuItem(Name, type, price);
                    CoffeeCRUD.additemstoList(M);
                }
                file.Close();
                return true;
            }
            return false;
        }
        
    }
}
