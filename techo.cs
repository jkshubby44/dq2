using System;

namespace program
{
    class techo
    {
        public void menu()
        {
            bool teacherRunning = true;

            while (teacherRunning)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("!!!!! WELCOME !!!!!");
                Console.WriteLine("HERE IS YOUR DASHBOARD");
                Console.WriteLine("===========================");

                Console.WriteLine("1. VIEW MY STUDENTS");
                Console.WriteLine("2. MARK STUDENTS ATTENDANCE");
                Console.WriteLine("3. ENTER STUDENTS PERFORMANCE");
                Console.WriteLine("4. VIEW SCHEDULE");
                Console.WriteLine("5. CHECK NOTEBOOKS");
                Console.WriteLine("6. LOGOUT");

                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("VIEW MY STUDENTS");
                        break;

                    case 2:
                        Console.WriteLine("MARK STUDENTS ATTENDANCE");
                        break;

                    case 3:
                        Console.WriteLine("ENTER STUDENTS PERFORMANCE");
                        break;

                    case 4:
                        Console.WriteLine("VIEW SCHEDULE");
                        break;

                    case 5:
                        Console.WriteLine("CHECK NOTEBOOKS");
                        break;

                    case 6:
                        teacherRunning = false;
                        Console.WriteLine("Logging out...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}