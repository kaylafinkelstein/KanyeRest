using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    public class Program
    {
      
        public static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            Console.WriteLine("And now: a funny but accurate way to describe life with quotes from Kanye West and Ron Swanson");

            Console.WriteLine("------------------------");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye said: {quote.KanyeQuote()}");

                Console.WriteLine("------------------------");

                Console.WriteLine($"Ron said: {quote.RonQuote()}");

                Console.WriteLine("------------------------");


            }
        }
    }  
}
