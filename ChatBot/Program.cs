using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            string response;

            do
            {
                response = Console.ReadLine();


                //Verifica a resposta

                switch(response)
                {
                    case "How are you?":
                        Console.WriteLine("im good bro, and U?");
                        break;
                    case "Are u having fun?":
                        Console.WriteLine("Nah.");
                        break;
                    case "EXIT":
                        Console.WriteLine("Goobye bro.");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("WTF??");
                        break;
                }
            
            } while (true);

        }   
    }
}
