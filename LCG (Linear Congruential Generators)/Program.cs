using System;

namespace LCG__Linear_Congruential_Generators_
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator(5,3,16,7);
            double[] randomArray = generator.LCG_Generators();

            Console.WriteLine("Array");
            foreach (double item in randomArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        
        
       
    }
}
