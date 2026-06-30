
using System.Collections.Specialized;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine(); //改行用
            Exercise2(text);
        }

        private static void Exercise1(string text) {
            var dict = new Dictionary<char, int>();
            foreach (var ch in text.ToUpper()) {
                if ('A' <= ch && ch <= 'Z') {
                    if (dict.ContainsKey(ch)) {
                        dict[ch]++;
                    } else {
                        dict[ch] = 1;
                    }
                }
            }

            foreach (var item in dict.OrderBy(x => x.Key)) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
            //var keydic = text.ToUpper().Replace(" ", "").OrderBy(x => x).ToArray();

            //var alphDicCount = Enumerable.Range('A', 26).
            //    ToDictionary(num => ((char)num), num => 0);

            //foreach (var c in keydic) {
            //    if (alphDicCount.ContainsKey(c))
            //        //登録されている場合
            //        alphDicCount[c]++;
            //}
            //foreach (var word in alphDicCount) {
            //    Console.WriteLine(word.Key + ":" + word.Value);
            //}
        }

        private static void Exercise2(string text) {
            var dict = new SortedDictionary<char, int>();
            foreach (var ch in text.ToUpper()) {
                if ('A' <= ch && ch <= 'Z') {
                    if (dict.ContainsKey(ch)) {
                        dict[ch]++;
                    } else {
                        dict[ch] = 1;
                    }
                }
            }

            foreach (var item in dict) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
    }
}
