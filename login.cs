using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class login
    {
        public void menu()
        {
            bool islogin = true;

            string Staffname = "admin";
            int staffpass = 1234;

            string Teachername = "teacher";
            int teacherpass = 1233;

            string EMname = "jezo";
            int EMnamepass = 1211;

            string role = "";

            while (islogin)
            {
                Console.WriteLine(" ENTER YOUR NAME ");
                string name = Console.ReadLine();

                Console.WriteLine(" ENTER YOUR PASSWORD ");
                int pass = Convert.ToInt32(Console.ReadLine());

                if (name == Staffname && pass == staffpass)
                {
                    Console.WriteLine(" !!!Matched!!!");
                    

                    role = "ADMIN";

                    islogin = false;
                }
                else if (name == Teachername && pass == teacherpass)
                {
                    Console.WriteLine(" !!!Matched!!!");
                    
                    role = "Teacher ";
                    islogin = false;
                }
                else if (name == EMname && pass == EMnamepass)
                {
                    Console.WriteLine(" !!!Matched!!!");
                    

                    role = "Equipment manager";
                    islogin = false;

                }
                else
                {
                    Console.WriteLine("!!!wrong password!!!");
                }



            }

            switch (role)
            {
                case "ADMIN":

                    ADMIN aa = new ADMIN();
                    aa.menu();
                    break;

                case "Teacher":
                    techo tf = new techo();
                    tf.menu();
                    break;

                case "Equipment Manager":

                    EquipmentManager ekk = new EquipmentManager();
                    ekk.menu();
                    break;

            }
        }
    }
}
