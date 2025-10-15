namespace LeetCode_3516
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter z");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("the Answer:");
            Console.WriteLine(FindClosest(a,b,c));

            //回傳值 int 1 or 2 ore gj輸入xyz
            int FindClosest(int x, int y, int z)
            {
                //1.输入
                //先算 xy到的距離
                int dx = x - z;
                int dY = y - z;

                //2.處理
                //距離的絕對值
                if (dx < 0) dx = -dx;

                if (dY < 0) dY = -dY;

                //3.輸出
                if (dx < dY)
                {
                    return 1;
                }
                else if (dx > dY)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }


            }








    }
    }
}
