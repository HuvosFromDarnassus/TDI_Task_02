using System;

namespace TDI_Task_02
{
    class Program
    {
        static void Main()
        {
            string question;

            Random rand = new Random();
            int fate;

            bool isContinue = true;
            string continueAnswer;

            while (isContinue)
            {
                Console.Write("Enter your question: ");
                question = Console.ReadLine();

                fate = rand.Next(0, 19);

                switch(fate)
                {
                    case 0:
                        Console.Write("It is certain\n");
                        break;
                    case 1:
                        Console.Write("It is decidedly so\n");
                        break;
                    case 2:
                        Console.Write("Without a doubt\n");
                        break;
                    case 3:
                        Console.Write("Yes — definitely\n");
                        break;
                    case 4:
                        Console.Write("You may rely on it\n");
                        break;

                    case 5:
                        Console.Write("As I see it, yes\n");
                        break;
                    case 6:
                        Console.Write("Most likely\n");
                        break;
                    case 7:
                        Console.Write("Outlook good\n");
                        break;
                    case 8:
                        Console.Write("Signs point to yes\n");
                        break;
                    case 9:
                        Console.Write("Yes\n");
                        break;

                    case 10:
                        Console.Write("Reply hazy, try again\n");
                        break;
                    case 11:
                        Console.Write("Ask again later\n");
                        break;
                    case 12:
                        Console.Write("Better not tell you now\n");
                        break;
                    case 13:
                        Console.Write("Cannot predict now\n");
                        break;
                    case 14:
                        Console.Write("Concentrate and ask again\n");
                        break;

                    case 15:
                        Console.Write("Don’t count on it\n");
                        break;
                    case 16:
                        Console.Write("My reply is no\n");
                        break;
                    case 17:
                        Console.Write("My sources say no\n");
                        break;
                    case 18:
                        Console.Write("Outlook not so good\n");
                        break;
                    case 19:
                        Console.Write("Very doubtful\n");
                        break;;
                }
                
                Console.Write("Continue ? [Yes / Exit]\n");
                continueAnswer = Console.ReadLine();

                //Условие выхода
                if (continueAnswer == "Exit" || continueAnswer == "exit")
                {
                    isContinue = false;
                }
            }
        }
    }
}
