using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace program
{
     class EquipmentManager
    {
        public void menu()
        {
            Console.WriteLine(" !!!!!!!! WELCOME !!!!!!!");
            Console.WriteLine("-------- HERE IS YOUR DASHBOARD ---------");

            Console.WriteLine(" 1. VIEW INVENTORY: ");
            Console.WriteLine(" 2. ADD NEW STOCK: ");
            Console.WriteLine(" 3. RETURN ITEMS : ");
            Console.WriteLine(" 4. REPORT DAMAGED ITEMS: ");
            Console.WriteLine(" 5. REMOVE ITEM: ");
            Console.WriteLine(" 6. LOGOUT ");

            Console.WriteLine(" Enter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Viweing Inventory");
                    break;

                case 2:
                    Console.WriteLine(" Adding new Stock");
                    break;

                case 3:
                    Console.WriteLine(" Returning items");
                    break;

                case 4:
                    Console.WriteLine("Reporting damaged items");
                    break;

                case 5:
                    Console.WriteLine("Removing Itme ");
                    break;

                case 6:
                    Console.WriteLine("Logout");
                    break;
            }
        }
    }
}
