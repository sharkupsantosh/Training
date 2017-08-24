using System;

 namespace Assignments 
{
    class methodoverloading
    {
        public int addition(int x, int y)
        {
            int a;
            return a=x+y;
        }
        public int addition(int x, int y, int z)
        {
            int b;
            return b=x+y+z;
        }
    }
    class TataNano  
    {  
        public virtual void engine()  
        {  
            Console.WriteLine("Power of engine in TATA Nano is 26KW");  
			Console.WriteLine("RPM in TATA Nano is 5500");  
			Console.WriteLine("No. of cylinders in TATA Nano is 2");  
        }  
    }  
    class Suzuki : TataNano
    {  
        public override void engine()  
        {  
            Console.WriteLine("Power of engine in Suzuki is 23KW");  
			Console.WriteLine("RPM in Suzuki is 6000");  
			Console.WriteLine("No. of cylinders in Suzuki is 2");  
        }  
    }  
    public class Getset
    {
        int _number;
        public int Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
    }
    public interface ICar
   {
      void Engine();
      void Tyre();
	  void SoundSystem();
   }
   public class Car : ICar
   {
      private string Name;
      private double amount;  
      public Car(string N, double a)
      {
         Name = N;
         amount = a;
      }
      
      public void SoundSystem()
      {
         Console.WriteLine("SoundSystem is 6.1");
      }
      public void Tyre()
	  {
		  Console.WriteLine("MRF tyre is used");	  
	  }
      public void Engine()
      {
         Console.WriteLine("Engine Name: {0}", Name);
         Console.WriteLine("Amount: {0}", amount);
      }
   }
   public class Assignmentstat
   {
       public void assignment()
       {
            Console.WriteLine("Enter which day Assignment need to be displayed....");
            Console.WriteLine("1.Day 1 Assignment");
            Console.WriteLine("2.Day 2 Assignment");
            Console.WriteLine("3.Day 3 Assignment");
            Console.WriteLine("4.List of Assignments");
       }
       public void day1assignment()
       {
            Console.WriteLine("Enter the Assignment you want to display");
            Console.WriteLine("1.Fibonacci Series");
            Console.WriteLine("2.Insertion Sortng");
            Console.WriteLine("3.Sum of digits");
            Console.WriteLine("4.Students Information");
            Console.WriteLine("5.Read/Write Byte");
            Console.WriteLine("6.Exit");
       }
       public void day2assignment()
       {
            Console.WriteLine("Enter the Assignment you want to display");
            Console.WriteLine("1.NullReferenceException");
            Console.WriteLine("2.Copy array elements");
            Console.WriteLine("3.Reverse a string");
            Console.WriteLine("4.Overflow Exception");
            Console.WriteLine("5.Exit");
       }
       public void day3assignment()
       {
            Console.WriteLine("Enter the Assignment you want to display");
            Console.WriteLine("1.Function Overloading");
            Console.WriteLine("2.Function Overriding");
            Console.WriteLine("3.Store & Retrieve number using get set property");
            Console.WriteLine("4.Interface");
            Console.WriteLine("5.Exit");
       }

   }

}