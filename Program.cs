using program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;




namespace program
{
    internal class DIKO
    {
        static void Main(string[] args)
        {
            bool isguest = true;

            while (isguest)
            {
                Console.WriteLine(" =========================== ");
                Console.WriteLine(" SCHOOL MANAGEMENT SYSTEM ");
                Console.WriteLine(" =========================== ");


                Console.WriteLine(" whats your choice : ");
                Console.WriteLine(" 1: Guest ");
                Console.WriteLine(" 2: Login ");
                Console.WriteLine(" 3: exit ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Guest gg = new Guest();
                        gg.menu();
                        break;

                    case 2:
                        login ll = new login();
                        ll.menu();
                        break;

                    case 3:
                        isguest = false;
                        break;

                    default:
                        Console.WriteLine("!!!!!!WRONG CHOICE!!!!!!!");
                        Console.WriteLine("try again ");
                        break;
                }
            }
        }

    }


}

       






