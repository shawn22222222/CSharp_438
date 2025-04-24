namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(0, 99)?");
            int guess;
            Random num = new Random();
            int gameNum = num.Next(100);
            int lowerNum = 0;
            int upperNum = 99;


            while (true)
            {
                guess = int.Parse(Console.ReadLine());
                if(guess < 0)
                {
                    Console.WriteLine("Out of range. Try again?");
                    continue;
                }
                if (guess < lowerNum || guess > upperNum)
                {
                    Console.WriteLine("Out of range. Try again?");
                    continue;
                }
               
                if (guess > gameNum)
                {
                    upperNum = guess - 1;
                }
                else if (guess < gameNum)
                {
                    lowerNum = guess + 1;
                }
                else
                {
                    Console.WriteLine("Bingo.");
                    break;
                }
                if (lowerNum == upperNum)
                {
                    Console.WriteLine("GG.");
                    break;
                }
                Console.WriteLine("({0},{1})", lowerNum, upperNum);

            }

        }
    }
}

