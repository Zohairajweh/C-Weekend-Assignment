using System;
using System.Linq;
using System.IO;

namespace C__Weekend_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
              int counter = 0;
                            Console.WriteLine(" Please Enter Your file Name:");
            string FileName = Console.ReadLine();
 while (counter < 3){ 
                counter++;
                Console.WriteLine("step"+counter);
            if (counter == 1)
                {
          
            File.WriteAllText(FileName, " ");
            Console.WriteLine("Your file name is " + FileName);

                }
 if (counter == 2)
                {
               
            Console.WriteLine("Split inside file");
            string myContent = Console.ReadLine();
            string[] myContentArray = myContent.Split(" ");

            for (int pos = 0; pos < myContentArray.Length; pos++){
                File.WriteAllText(FileName,myContentArray[pos]);
                Console.WriteLine(myContentArray[pos]);
            }
 } }

   if (counter == 3)
                {
                Console.WriteLine("End Loop");

                    return;

                }


        }
    }
}
