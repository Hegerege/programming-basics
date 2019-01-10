using System;

namespace if_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Käyttäjää pyydetään kirjoittamaan ohjelmalle 1 luku. Ohjelma tulostaa positiivinen, negatiivinen tai nolla");
           
            Console.WriteLine("Anna joku luku");
            string userInput = Console.ReadLine();
            int muuttuja = int.Parse(userInput);

            if (muuttuja == 0)
                Console.WriteLine("Tulos on nolla");
            else if (muuttuja < 0)
                Console.WriteLine("Tulos on negatiivinen");
            else
                Console.WriteLine("Tulos on positiivinen");
          

         
         

        }
    }
}
