using System;
using System.Collections.Generic;


namespace program
{
    class TeacherManagement
    {
        List<TeacherConsoleModel> teachers = new List<TeacherConsoleModel>()
        {
            new TeacherConsoleModel(101,"Divya","Maths"),
            new TeacherConsoleModel(102,"Priya", "CS"),
            new TeacherConsoleModel(103,"Akash","Physcis")
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
                    SearchTeacherByName();
                    break;

                case 3:
                    AddTeacher();
                    break;

                case 4:
                    RemoveTeacher();
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

    foreach (TeacherConsoleModel teacher in teachers)
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
    




public void AddTeacher()
{
    Console.WriteLine("=========ADDING TEACHER==========");

    Console.WriteLine("ENTER TEACHER ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("ENTER TEACHER NAME : ");
    string name = Console.ReadLine();

    Console.WriteLine("ENTER THE SUBJECT :");
    string subject = Console.ReadLine();

    TeacherConsoleModel teacher = new TeacherConsoleModel(id, name, subject);
    teachers.Add(teacher);

    Console.WriteLine("NEW TEACHER ADDED :");

}
 public void RemoveTeacher()
 {

     Console.WriteLine("ENTER TEACHER ID : ");
     int id = Convert.ToInt32(Console.ReadLine());

     TeacherConsoleModel teacherToRemove = null;


     foreach (TeacherConsoleModel teacher in teachers)
     {
         if (teacher.id == id)
         {
             teacherToRemove = teacher;

             break;
         }
     }

     if (teacherToRemove != null)
     {
         teachers.Remove(teacherToRemove);
         Console.WriteLine("=========REMOVED SUCCESSUFULLYY==========");
     }
     else
     {
         Console.WriteLine(" NO TEACHER FOUND !! ");

     }

}
public void SearchTeacherByName()
{
    Console.Write("Enter Teacher Name : ");
    string name = (Console.ReadLine());

    foreach (TeacherConsoleModel teacher in teachers)
    {
        if (teacher.name == name)
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