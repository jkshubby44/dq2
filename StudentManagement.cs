using System;
using System.Collections.Generic;



namespace program
{
    class StudentManagement
{
    List<Student> students = new List<Student>()
    {
        new Student(101,"Saroj",12),
        new Student(102,"Jai", 10),
        new Student(103,"Shubh",9)
    };
    
    public void Menu()
    {
        bool studentRunning = true;

        while (studentRunning)
        {
            Console.WriteLine("===========================");
            Console.WriteLine(" STUDENT MANAGEMENT ");
            Console.WriteLine("===========================");

            Console.WriteLine("1. Search Student by ID");
            Console.WriteLine("2. Search Student by Name");
            Console.WriteLine("3. Add Student");
            Console.WriteLine("4. Remove Student");
            Console.WriteLine("5. Back to Main Menu");

            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    SearchStudentByID();
                    break;

                case 2:
                    Console.WriteLine("Search by Name selected");
                    break;

                case 3:
                    Console.WriteLine("Add Student selected");
                    break;

                case 4:
                    RemoveStudent();
                    break;

                case 5:
                    studentRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    
     public void SearchStudentByID()
{
    Console.Write("Enter Student ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    foreach (Student student in students)
    {
        if (student.id == id)
        {
            Console.WriteLine("Student Found!");
            Console.WriteLine("ID: " + student.id);
            Console.WriteLine("Name: " + student.name);
            Console.WriteLine("Subject: " + student.Class);
            return;
        }
    }

    Console.WriteLine("Student not found.");
}
 public void RemoveStudent()
 {

     Console.WriteLine("ENTER STUDENT ID : ");
     int id = Convert.ToInt32(Console.ReadLine());

     Student studentToRemove = null;


     foreach (Student student in students)
     {
         if (student.id == id)
         {
             studentToRemove = student;

             break;
         }
     }

     if (studentToRemove != null)
     {
         students.Remove(studentToRemove);
         Console.WriteLine("=========REMOVED SUCCESSUFULLYY==========");
     }
     else
     {
         Console.WriteLine(" NO Student FOUND !! ");

     }

}
}
}
