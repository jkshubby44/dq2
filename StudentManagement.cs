using System;
using System.Collections.Generic;



namespace program
{
    class StudentManagement
{
   public List<Student> students =  new List<Student>()
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


            Console.WriteLine("1. View all students");
            Console.WriteLine("2. Search Student by ID");
            Console.WriteLine("3. Search Student by Name");
            Console.WriteLine("4. Add Student");
            Console.WriteLine("5. Remove Student");
            Console.WriteLine("6. Back to Main Menu");

            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                
                 case 1:
                   ViewAllStudents();
                    break;

                case 2:
                    SearchStudentByID();
                    break;

                case 3:
                    SearchStudentByName();
                    break;

                case 4:
                    AddStudent();
                    break;

                case 5:
                    RemoveStudent();
                    break;

                case 6:
                    studentRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    
 public void ViewAllStudents()
    {
        Console.WriteLine("===========================");
        Console.WriteLine("       MY STUDENTS");
        Console.WriteLine("===========================");

        foreach (Student student in students)
        {
            Console.WriteLine(
                "ID: " + student.id +
                " | Name: " + student.name +
                " | Class: " + student.Class
            );
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

 public void AddStudent()
 {
     Console.WriteLine("=========Adding Student========");

     Console.WriteLine("Enter Student ID : ");
     int id = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("Enter student name : ");
     string name = Console.ReadLine();

     Console.WriteLine("Enter Student Class : ");
     int Class = Convert.ToInt32(Console.ReadLine());

     Student newstudent = new Student(id, name, Class);

     students.Add(newstudent);

     Console.WriteLine("NEW STUDENT ADDED !!");


 }

 public void SearchStudentByName()
 {
     Console.Write("Enter Student Name: ");
     string name = (Console.ReadLine());

     foreach (Student student in students)
     {
         if (student.name == name)
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
}
}
