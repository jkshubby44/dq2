using System;
using System.Collections.Generic;


namespace program
{
    class TeacherManagement
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(101,"Divya","Maths"),
            new Teacher(102,"Priya", "CS"),
        new Teacher(103,"Akash","Physcis")
    };
    
    
    public void Menu()
    {
        bool teacherRunning = true;

        while (teacherRunning)
        {
            Console.WriteLine("===========================");
            Console.WriteLine(" TEACHER MANAGEMENT ");
            Console.WriteLine("===========================");

            Console.WriteLine("1. Search Teacher by ID");
            Console.WriteLine("2. Search Teacher by Name");
            Console.WriteLine("3. Add Teacher");
            Console.WriteLine("4. Remove Teacher");
            Console.WriteLine("5. Back to Main Menu");

            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    SearchTeacherByID();
                    break;

                case 2:
                    Console.WriteLine("Search by Name selected");
                    break;

                case 3:
                    Console.WriteLine("Add Teacher selected");
                    break;

                case 4:
                    Console.WriteLine("Remove Teacher selected");
                    break;

                case 5:
                    teacherRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
   public void SearchTeacherByID()
{
    Console.Write("Enter Teacher ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    foreach (Teacher teacher in teachers)
    {
        if (teacher.id == id)
        {
            Console.WriteLine("Teacher Found!");
            Console.WriteLine("ID: " + teacher.id);
            Console.WriteLine("Name: " + teacher.name);
            Console.WriteLine("Subject: " + teacher.subject);
            return;
        }
    }

    Console.WriteLine("Teacher not found.");
}
    


}
}