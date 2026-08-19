using System;
using System.Collections.Generic;


namespace program
{
    class SportsManagement
{
    List<Sport> sports = new List<Sport>()
    {
        new Sport(101,"FOOTBALL","Mr. John"),
        new Sport(102,"BASEBALL", "Mr. Yash"),
        new Sport(103,"TENNIS","MRs. Riya")
    };
    public void Menu()
    {
        bool sportsRunning = true;

        while (sportsRunning)
        {
            Console.WriteLine("===========================");
            Console.WriteLine(" SPORTS MANAGEMENT ");
            Console.WriteLine("===========================");

            Console.WriteLine("1. View Sports");
            Console.WriteLine("2. Search Sports");
            Console.WriteLine("3. Add Sport");
            Console.WriteLine("4. Delete sport");
            Console.WriteLine("5. Back to Main Menu");

            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    SearchSportsByID();
                    break;

                case 2:
                    SearchSportsByName();
                    break;

                case 3:
                    AddSport();
                    break;

                case 4:
                    RemoveSport();
                    break;

                case 5:
                    sportsRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
     public void SearchSportsByID()
{
    Console.Write("Enter Sport ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    foreach (Sport sport in sports)
    {
        if (sport.id == id)
        {
            Console.WriteLine("Sport Found!");
            Console.WriteLine("ID: " + sport.id);
            Console.WriteLine("Name: " + sport.name);
            Console.WriteLine("Subject: " + sport.CoachName);
            return;
        }
    }

    Console.WriteLine("Sport not found.");
}

public void AddSport()
{
    Console.WriteLine("ENTER NEW SPORT ID : ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("ENTER NEW SPORT NAME : ");
    string name = Console.ReadLine();

    Console.WriteLine("ENTER COACH NAME: ");
    string CoachName = Console.ReadLine();

     Sport newSport = new Sport(id, name, CoachName);

     sports.Add(newSport);

     Console.WriteLine("New Sport Added");

}

 public void RemoveSport()
 {

     Console.WriteLine("ENTER SPORT ID : ");
     int id = Convert.ToInt32(Console.ReadLine());

     Sport sportToRemove = null;


     foreach (Sport sport in sports)
     {
         if (sport.id == id)
         {
             sportToRemove = sport;

             break;
         }
     }

     if (sportToRemove != null)
     {
         sports.Remove(sportToRemove);
         Console.WriteLine("=========REMOVED SUCCESSUFULLYY==========");
     }
     else
     {
         Console.WriteLine(" NO SPORT FOUND !! ");

     }

 }
   public void SearchSportsByName()
  {
      Console.Write("Enter Sport Name: ");
      string name = (Console.ReadLine());

      foreach (Sport sport in sports)
      {
          if (sport.name == name)
          {
              Console.WriteLine("Sport Found!");
              Console.WriteLine("ID: " + sport.id);
              Console.WriteLine("Name: " + sport.name);
              Console.WriteLine("Subject: " + sport.CoachName);
              return;
          }
      }

      Console.WriteLine("Sport not found.");
  }

}
}




