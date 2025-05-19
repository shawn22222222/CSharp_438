namespace Lab2
{
    internal class Lab2
    {
        static void Main(string[] args)
        {
            
            int n = 16;
            int[] arr = new int[n];
            Console.Write("{0, 10}", "ID:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write("{0, 5}", arr[i]);
            }
            Console.WriteLine();
            Console.Write("{0, 10}", "Contactee:");
            Random rng = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int j = rng.Next(i, n);
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                Console.Write("{0, 5}", arr[i]);
            }
            int target = 0;
            int current = target;
            Console.WriteLine();
            do
            {
                current = arr[current];
                Console.Write("{0, 3}", current);
            }
            while (current != target);

        }
    }
}




