using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
     class ADMIN
    {
        public void menu()
        {
            Console.WriteLine("      !!!!!! WELCOME !!!!!!" );
            Console.WriteLine("------- Here is your  Dashboard-------");


            Console.WriteLine("1. Manage Staff");
            Console.WriteLine("2. Manage Teacher");
            Console.WriteLine("3. Manage Student");
            Console.WriteLine("4. Manage Course");
            Console.WriteLine("5. View New Contracts :");
            Console.WriteLine("6. View new Tasks ");
            Console.WriteLine("7. View fee status :");


            Console.WriteLine(" Enter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Managing Staff");
                    break;

                case 2:
                    Console.WriteLine("Managing Teachers");
                    break;

                case 3:
                    Console.WriteLine("Managing Students");
                    break;

                case 4:
                    Console.WriteLine("Managing Courses");
                    break;

                case 5:
                    Console.WriteLine("Viewing New Contracts");
                    break;

                case 6:
                    Console.WriteLine("Viewing New Task");
                    break;
                case 7:
                    Console.WriteLine("Viewing Fee Status");
                    break;
            }
        }
    }
}
