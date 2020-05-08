using System;
using System.Linq;
using System.IO;

namespace C__Weekend_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Please Enter Your file Name:");
            string FileName = Console.ReadLine();
            File.WriteAllText(FileName, " ");
            Console.WriteLine("Your file name is " + FileName);

            Console.WriteLine("Split inside file");
            string myContent = Console.ReadLine();
            string[] myContentArray = myContent.Split(" ");
            foreach (string element in myContentArray)
            {
                File.WriteAllText(FileName,element);
                Console.WriteLine(element);

            }


        
               int counter = 0; 

                do { //A do while loop will ensure the code executes at least once before condition is checked
                    counter++;
                    Console.WriteLine(counter);
                     if (counter == 3) {
return;
                } 
                } 
                
                while (counter <3);

              

        }
    }
}
