using System;
using System.Linq; 
using System.IO; 

namespace C__Weekend_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prompt: Please Enter Your file Name:");
            string FileName = Console.ReadLine();
            File.WriteAllText(FileName, "welcome"+ " "+FileName); 
            Console.WriteLine("Your file name is "+ FileName);
         

        }
    }
}
