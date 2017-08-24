using System;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string cont;
            do
            {
                Assignmentstat obj = new Assignmentstat();
                obj.assignment();
                try 
                {
                    number = int.Parse(Console.ReadLine());
                    Assign obj1 = new Assign();
                    obj1.assign1(number);
                }catch(Exception)
                {
                    Console.WriteLine("Please choose the valid assignments as mentioned above..... ");
                }
                Console.WriteLine("Do you want continue to choose any other Day Assignments? Y/N:");
                cont = Console.ReadLine();
            }while(cont =="y" || cont =="Y");
        }
    }
}
