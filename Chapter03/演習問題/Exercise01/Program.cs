
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise4(numbers);
        }

        private static void Exercise1(List<int> numbers) {
            Console.WriteLine("---3.1.1---");
            var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            if (exists == true) {
                Console.WriteLine("存在しています");
            } else {
                Console.WriteLine("存在していません");
            }
        }

        private static void Exercise2(List<int> numbers) {
            Console.WriteLine("---3.1.2---");
            numbers.ForEach(s => Console.WriteLine(s / 2.0));
        }

        private static void Exercise3(List<int> numbers) {
            Console.WriteLine("---3.1.3---");
            var query = numbers.Where(s => 50 <= s);
            foreach (var item in query) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise4(List<int> numbers) {
            Console.WriteLine("---3.1.4---");
            var exist2 = numbers.Select(s => s * 2);
            foreach (var item in exist2) {
                Console.WriteLine(item);
            }
        }
    }
}
