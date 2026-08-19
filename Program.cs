    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using System.Linq.Expressions;




    namespace program
    {
    internal class HelloWorld
        {
        static void Main(string[] args)
        {
            
            bool isrunning = true;
            
            while( isrunning  )
            {
            Console.WriteLine(" =========================== ");
            Console.WriteLine(" SCHOOL MANAGEMENT SYSTEM ");
            Console.WriteLine(" =========================== ");
            
            Console.WriteLine(" we have : ");
            Console.WriteLine(" 1 : Dashboard");
            Console.WriteLine(" 2 : Teacher Management ");
            Console.WriteLine(" 3 : Student Management ");
            Console.WriteLine(" 4 : Sports Management ");
            Console.WriteLine(" 5 : About School");
            Console.WriteLine(" 6 : --- Exit ---");
            
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter your choice ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            
            
            switch(choice)
            {



                case 1:
                Console.WriteLine("Dashboard selected");
                break;

                case 2:
                TeacherManagement teacher = new TeacherManagement();
                teacher.Menu();
                break;
                
                case 3:
                StudentManagement student = new StudentManagement();
                student.Menu();
                break;
                
                case 4:
                SportsManagement sports = new SportsManagement();
                sports.Menu();
                break;
                
                case 5:
                AboutSchool about = new AboutSchool();
                about.menu();
                break;
                
                case 6:
                isrunning = false;
                Console.WriteLine("---SYSTEM IS OFF--- ");
                break;
                
                default:
                Console.WriteLine(" !!!INVALID CHOICE!!! ");
                Console.WriteLine("  -----TRY AGAIN----- ");
                break;
            }
        
        }
        }
    }
    }




