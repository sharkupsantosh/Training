using System;

namespace Assignments
{
    class Day2
    {
        public void day02(int number2)
        {
            switch(number2)
            {
                case 1:
                    try
                    {
                        string v = null;
                        if(v.Length == 0)
                        {
                            Console.Write(v);
                        }
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Object reference not set to an instance of an object");
                    }
                break;
                case 2:
                    try
                    {
                        int[] arr1 = new int[100];
                        int[] arr2 = new int[100];
                        int c, o;                 
                        Console.Write("Enter the number of elements to be stored in the array :");
                        o = Convert.ToInt32(Console.ReadLine()); 
                        Console.Write("Input the {0} elements in the array :\n",o);
                        for(c=0;c<o;c++)
                        {
                            Console.Write("THe element in- {0} index : ",c);
                            arr1[c] = Convert.ToInt32(Console.ReadLine());  
                        }
                        /* Copy elements of first array into second array.*/ 
                        for(c=0; c<o; c++)
                        {
                            arr2[c] = arr1[c];
                        }

                        /* Prints the elements of first array   */
                        Console.Write("\nThe elements stored in the first array are :\n");
                        for(c=0; c<o; c++)
                        {
                            Console.Write("{0}  ", arr1[c]);
                        }

                        /* Prints the elements copied into the second array. */
                        Console.Write("\n\nThe elements copied into the second array are :\n");
                        for(c=0; c<o; c++)
                        {
                            Console.Write("{0}  ", arr2[c]);
                        }
                        Console.Write("\n\n");
                    }catch(Exception)
                    {
                        Console.WriteLine("Please enter only integer value...");
                    }

                break;
                case 3:
                try
                {
                    Console.WriteLine("Enter any name"); 
                    string s ; 
                    s = Console.ReadLine();
                    for(int r = s.Length-1; r>=0 ; r--)
                    {
                         Console.Write(s[r]);
                        
                    }
                    Console.WriteLine("\n\n");
                }catch(Exception)
                {
                    Console.WriteLine("Please enter proper name...");
                }                  
                break;
                case 4:
                    try
                    {
                        int num1, num2;
                        long result;
                        num1 = 30;
                        num2 = 60;
                        result = Convert.ToByte(num1 * num2);
                        Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                        Console.ReadLine();
                    }
                    catch(Exception)
                    {
                        Console.Write("Value is either too large or too short for an unsigned byte");
                    }
                break;
                case 5:
                break;
                default:
                    Console.WriteLine("Please choose the correct Assignment.....");
                break;
            }
        }
    }
}