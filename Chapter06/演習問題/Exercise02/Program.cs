namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("整数文字列：");
            string str = Console.ReadLine();

            if (int.TryParse(str, out var result)) {
                var str2 = result.ToString("#,0");
                Console.WriteLine(str2);
            }
        }
    }
}
