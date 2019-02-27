using System;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {

            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 

            // TODO: When the loop is finished, output the sum of all previous values.

            int finalOutput = 0;

            Console.WriteLine("Enter a number: ");
            string numberInput = Console.ReadLine();
            numberInput = numberInput.Trim();

            int Input = int.Parse(numberInput);
           
                for (int i = 2; i < 21; i++)
                {
                    int individualOutput = i * Input;
                    Console.WriteLine(individualOutput);
                    finalOutput = individualOutput + finalOutput;
                }
            Console.WriteLine(finalOutput);
            Console.ReadLine();
        }
    }
}
