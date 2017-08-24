using System;

namespace Assignments
{
    class Assign
    {
        public void assign1(int number)
        {
           switch(number)
           {
               case 1:
                    int number1;
                    string cont1;
                    do
                    {
                        Assignmentstat obj = new Assignmentstat();
                        obj.day1assignment();
                        number1 = int.Parse(Console.ReadLine());
                        Day1 obj1 = new Day1();
                        obj1.day01(number1);
                        Console.WriteLine("Do you want continue Day1 Assignments? Y/N:");
                        cont1 = Console.ReadLine();
                    }while(cont1 =="Y" || cont1 == "y");
                        
                break;
                case 2:
                    int number2;
                    string cont2;
                    do
                    {
                        Assignmentstat obj = new Assignmentstat();
                        obj.day2assignment();
                        number2 = int.Parse(Console.ReadLine());
                        Day2 obj1 = new Day2();
                        obj1.day02(number2);
                        Console.WriteLine("Do you want continue Day2 Assignments? Y/N:");
                        cont2 = Console.ReadLine();
                    }while(cont2 =="y" || cont2 == "Y");
                break;
                case 3:
                    int number3;
                    string cont3;
                    do
                    {
                        Assignmentstat obj = new Assignmentstat();
                        obj.day3assignment();
                        number3 = int.Parse(Console.ReadLine());
                        Day3 obj1 = new Day3();
                        obj1.day03(number3);
                        Console.WriteLine("Do you want continue Day3 Assignments? Y/N:");
                        cont3 = Console.ReadLine();
                    }while(cont3 =="Y" || cont3 == "y");
                break;
                case 4:
                    Assignmentstat obj3 = new Assignmentstat();
                    Console.WriteLine("Day1 Assignments");
                    obj3.day1assignment();
                    Console.WriteLine("Day2 Assignments");
                    obj3.day2assignment();
                    Console.WriteLine("Day3 Assignments");
                    obj3.day3assignment();
                break;
                default:Console.WriteLine("Please Choose the correct day assignment....");
                break;
           } 
        }
    }
}
