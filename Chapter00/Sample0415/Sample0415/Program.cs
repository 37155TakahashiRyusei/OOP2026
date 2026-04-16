namespace Sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            //入力
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[" + i + "]=");
                array[i] = int.Parse(Console.ReadLine());
            }

            //合計作業
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}

            //出力
            for (int i = 0; i < array.Length; i++)
            {
                //Console.Write("array[" + i + "]:");

                //アスタリスク出力
                astOut(array[i]);
            }

            //合計出力            LINKって機能↓  これの場合は偶数のみを集計
            Console.WriteLine("合計" + array.Where(n => n % 2 == 0).Sum());

            static void astOut(int num)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("*");
                }
                //改行用
                Console.WriteLine();
            }
        }
    }
}
