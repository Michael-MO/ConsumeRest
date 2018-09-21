using System;

namespace ConsumeRest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RestConsumer consumer = new RestConsumer();
            consumer.Start();

            Console.ReadLine();
        }
    }
}
