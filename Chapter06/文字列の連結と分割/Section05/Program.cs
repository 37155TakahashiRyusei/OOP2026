using System.Text;

namespace Section05 {
    internal class Program {
        static void Main(string[] args) {
            var languages = Getwords();
            //var sd = ", ";
            var result = String.Join(",", Getwords());
            Console.WriteLine(result);
            //foreach (var word in Getwords()) {
            //    Console.Write(word + sd);
            //}
        }

        private static IEnumerable<string> Getwords() {
            return ["Orange", "Lemon", "Strawberry"];
        }
    }
}
