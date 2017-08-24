using System;

namespace Assignments
{
    class Day3
    {
        public void day03(int number3)
        {
            switch(number3)
            {
                case 1:
                    methodoverloading method = new methodoverloading();
                    Console.WriteLine("The addition of two numbers "+ method.addition(2,3));
		            Console.WriteLine("The addition of two numbers "+ method.addition(2,3,4));
                    break;
                case 2:
                    TataNano a1 = new TataNano();  
                    a1.engine();  
                    Suzuki b1 = new Suzuki();  
                    b1.engine();  
                    TataNano a2 = new Suzuki();  
                    a2.engine();  
                break;
                case 3:
                    try
                    {
                        Getset gs = new Getset();
                        Console.WriteLine("Enter any number");
                        gs.Number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Entered number is : ");;
                        Console.WriteLine(gs.Number); 
                    }catch(Exception)
                    {
                        Console.WriteLine("Please enter only integer value...");
                    }
                
                break;
                case 4:
                    Car c1 = new Car("Hyndai santroEngine",30000);
                    Car c2 = new Car("MPFI",31000);
                    c2.Tyre();
                    c2.SoundSystem();
                    c1.Engine();
                    c2.Engine();
                    Console.ReadLine();
                break;
                case 5:
                break;
                default: Console.WriteLine("Please choose the correct Assignment.....");
                break;
            }
        }
    }
}