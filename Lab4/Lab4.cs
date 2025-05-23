namespace Lab4
{
    abstract class Player
    {
        public abstract int Next(int low, int high);
    }
    class RandomGuess : Player
    {
        public override int Next(int low, int high)
        {
            return new Random().Next(low, high+1);
        }
    }
    class HumanPlayer : Player
    {
        public override int Next(int low, int high)
        {
            return int.Parse(Console.ReadLine());
        }
    }
    class BinarySearch : Player
    {
        public override int Next(int low, int high)
        {
            return (low + high) / 2;
        }
    }
    class SuperAI : Player
    {
        public override int Next(int low, int high)
        {
            return low;
        }
    }

    class Game
    {
        int low, high, number;
        Player player;
        public Game(Player player)
        {
            Random rng = new Random();
            number = rng.Next(100);
            low = 0;
            high = 99;
            this.player = player;
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("({0},{1})?", low, high);
                int guess = player.Next(low, high);
                Console.WriteLine(guess);
                if (guess > number)
                {
                    high = guess - 1;
                }
                else if (guess < number)
                {
                    low = guess + 1;
                }
                else
                {
                    Console.WriteLine("Bingo.");
                    break;
                }
                if (low == high)
                {
                    Console.WriteLine("GG.");
                    break;
                }
            }
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                new Game(new SuperAI()).Run();
            }
        }
    }

