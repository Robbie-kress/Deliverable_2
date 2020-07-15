using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            string input;
            string message = "";
            int checksum = 0;
            
            Console.Write("What is your message? ");
            input = Console.ReadLine();            
            input = input.ToUpper();  
            
            for (int t = 0; t < input.Length; t++)
            {
                checksum += (int)input[t];
                if (t < input.Length - 1) {                                 
                    message += ((int)input[t] - 64) + "-";
                }
                else {
                    message += (int)input[t] - 64; }
            }           
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);

        }
    }
}