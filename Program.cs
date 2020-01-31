using System;

namespace UserInputTylerGunnells
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Tyler Gunnells! \n");

            Console.WriteLine("Please type your name in the space below and hit enter.\n");

            string nameresponse = (Console.ReadLine());

            Console.WriteLine("\n" + nameresponse+ ",");

            Console.WriteLine("Please type your question and hit enter.\n");

            string response = (Console.ReadLine());

            Console.WriteLine("\n" + "You responded, " + response);

            Console.WriteLine("\n" + "If this response is correct type YES, if not, type NO." + "\n");

            string confirmation = (Console.ReadLine());
            {
                if (confirmation == "YES")
                {
                    Console.WriteLine("\n" + "OutPut Confirmation" + "\n" + "Name:" + nameresponse + "\n" + "Question:" + response);

                    Console.WriteLine("\n" + "We will be responding to your invoice shortly.");
                }
                else if (confirmation == "NO")
                {
                    Console.WriteLine("\n" + "Please restart form from beginning");
                }
      
            }


        }
    }
}
