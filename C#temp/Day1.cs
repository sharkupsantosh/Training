using System;
using System.IO;


namespace Assignments
{
    struct Student
    {
        public string name;
        public int roll;
        public string classname;
        public string universityname;
        public int age;
    }
    class Day1
    {
        public void day01(int number1)
        {
            switch(number1)
            {
                case 1:
                    try 
                    {
                        int f, count, f1 = 0, f2 = 1, f3 = 0;
                        Console.Write("Enter the Limit : ");
                        count = int.Parse(Console.ReadLine());
                        NumberToWord obj4 = new NumberToWord();
                        Console.WriteLine(obj4.convert(f1));
                        Console.WriteLine(obj4.convert(f2));
                        for (f = 0; f <= count; f++)
                        {
                            f3 = f1 + f2;    
                            f1 = f2;
                            f2 = f3;
                            Console.WriteLine(obj4.convert(f3));
                        }
                    }catch(Exception)
                    {
                        Console.WriteLine("Please enter only integer value...");
                    }                   
                break;
                case 2:
                    try
                    {
                        int n;
                        Console.WriteLine("Enter the number of elements");
                        n = Convert.ToInt32(Console.ReadLine());
                        int[] numbers = new int[n] ;
                        Console.WriteLine("Enter the numbers");
                        for(int i=0;i<n;i++)
                        {
                            numbers[i]=Convert.ToInt16(Console.ReadLine());
                        }
                        Console.WriteLine("\nOriginal Array Elements :");
                        PrintIntegerArray(numbers);           
                        Console.WriteLine("\nSorted Array Elements :");
                        PrintIntegerArray(InsertionSort(numbers));
                        Console.WriteLine("\n");
                        int[] InsertionSort(int[] inputArray)
                        {
                            for (int i = 0; i < inputArray.Length - 1; i++)
                            {
                                for (int j = i + 1; j > 0; j--)
                                {
                                    if (inputArray[j - 1] > inputArray[j])
                                    {
                                        int temp = inputArray[j - 1];
                                        inputArray[j - 1] = inputArray[j];
                                        inputArray[j] = temp;
                                    }
                                }
                            }
                        return inputArray;         
                        }
                        void PrintIntegerArray(int[] array)
                        {
                            foreach (int i in array)
                            {
                                Console.Write(i.ToString() + "  ");
                            }
                        }
                    }catch(Exception)
                    {
                        Console.WriteLine("Please enter only integer value to perform insertion sorting...");
                    }
                break;
                case 3:
                    try
                    {
                        int No, sum = 0, rem;
                        Console.WriteLine("Enter a Number : ");
                        No = int.Parse(Console.ReadLine());
                        while (No != 0)
                        {
                            rem = No % 10;
                            No = No / 10;
                            sum = sum + rem;
                        }
                        Console.WriteLine("Sum of Digits of the Number : "+sum);
                        Console.ReadLine();
                    }catch(Exception)
                    {
                        Console.WriteLine("Please enter only integer value to find the sum of sorting....");
                    }
                break;
                case 4:
                    try
                    {   
                        int n;    
                        Console.WriteLine("Enter the number of Students information you want to display... ");
                        n = Convert.ToInt16(Console.ReadLine());
                        Student[] s = new Student[n];
                        for (int p = 0; p < s.Length; p++)
                        {
                            Console.Write("Enter Name: ",n);
                            s[p].name = Console.ReadLine();
                            Console.Write("Enter Roll No.: ",n);
                            s[p].roll =Convert.ToInt16(Console.ReadLine());
                            Console.Write("Enter className: ",n);
                            s[p].classname=Console.ReadLine();
                            Console.Write("Enter universityName: ",n);
                            s[p].universityname=Console.ReadLine();
                            Console.Write("Enter age: ",n);
                            s[p].age=Convert.ToInt16(Console.ReadLine());
                        }
                        Console.Write("\n\nNAME\t\tROLL NO.\t\tCLASSNAME\t\tUNIVERSITYNAME\t\tAGE\n");
                        for (int p = 0; p < s.Length; p++)
                        {
                            Console.WriteLine(s[p].name + "\t\t" + s[p].roll + "\t\t" + s[p].classname +"\t\t" + s[p].universityname + "\t\t" + s[p].age);
                        }
                    }catch(Exception)
                    {
                        Console.WriteLine("Please enter the proper information...");
                    }
                break;
                case 5:
                        string line,lines;
                        Console.WriteLine("Enter the file location you want to Write.");
                        StreamWriter sr = File.AppendText(Console.ReadLine());
                        Console.WriteLine("Enter any text to want to write in a file....");
                        line = Console.ReadLine();                     
                        sr.Write(line);
                        sr.Flush();
                        sr.Close();
                        try
                       { 
                            Console.WriteLine("Enter the file you want to read");
                            StreamReader sr1 = new StreamReader(Console.ReadLine());                       
                            while ((lines = sr1.ReadLine()) != null)
                            {
                                Console.WriteLine(lines);
                            }
                            sr1.Close();
                        }
                        catch (Exception )
                        {
                        
                            Console.WriteLine("The file could not be read:");
                        }
                break;
                case 6:
                break;
                default:Console.WriteLine("Please choose the correct Assignment.....");
                break;
            }
        }
    }
}