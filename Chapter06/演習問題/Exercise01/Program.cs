using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("入力1:");
            string str1 = Console.ReadLine();

            Console.Write("入力2:");
            string str2 = Console.ReadLine();

            if ( String.Compare(str1, str2,ignoreCase:true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
        }
    }
}
