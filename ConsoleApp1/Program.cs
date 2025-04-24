namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  計算圓面積
            //int r = 10;
            //double area = r * r * 3.14;
            //Console.WriteLine(area);
            #endregion

            #region double計算
            //double x = 1 / 2;  // 輸出0
            //Console.WriteLine(x);
            #endregion

            #region 手動輸入圓半徑計算面積
            //Console.WriteLine("輸入圓半徑");
            //uint v;
            //bool r = uint.TryParse(Console.ReadLine(), out v);
            //double A = v * v * 3.14;
            //Console.WriteLine(A);
            #endregion

            #region 產生兩個隨機數相加 (0~9)
            Random rng = new Random();
            int x = rng.Next(10);
            int y = rng.Next(10);
            Console.WriteLine("{0} + {1} = ?", x, y);

            int num = int.Parse(Console.ReadLine());
            if (num == x + y)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("wrong. It is {0}", x+y);
            }
            #endregion

        }
    }
}
