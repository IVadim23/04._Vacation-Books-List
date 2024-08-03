using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add page:");
            int page = int.Parse(Console.ReadLine());
            Console.WriteLine("Add numbers of page per hours:");
            int pagePerHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Add nubmers of days:");
            int days = int.Parse(Console.ReadLine());
            int totalHours = page / pagePerHours;
            int hoursPerDay = totalHours / days;
            Console.WriteLine("Numbers of hours per day \n {0:f2}",hoursPerDay);
        }
    }
}
