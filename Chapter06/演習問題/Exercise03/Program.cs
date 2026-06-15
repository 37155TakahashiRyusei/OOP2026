
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {

            var count = text.Count(c => c == ' ');
            Console.WriteLine(count);
            Console.WriteLine();//改行用
        }

        private static void Exercise2(string text) {
            //p142参考
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
            Console.WriteLine();//改行用
        }

        private static void Exercise3(string text) {
            var words = text.Split(' ');
            var array = text.ToArray();
            var sb = new StringBuilder();
            foreach (var word in array) {
                Console.Write(word);
            }


            Console.WriteLine();//改行用
        }

        private static void Exercise4(string text) {
            var word = text.Split(' ');
            Console.WriteLine(word.Length);
            Console.WriteLine();//改行用
        }

        private static void Exercise5(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var item in words) {
                Console.WriteLine(item);
            }

            //text.Split(' ').Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine);即時実行しても良い時の書き方

            //for (int i = 0; i < text.Length; i++) {
            //    if (words[i] <= 4) {
            //        Console.WriteLine(words);
            //    }
            //}
            Console.WriteLine();//改行用
        }

        //アルファベットの数をカウントして表示する
        private static void Exercise6(string text) {
            var str = text.ToLower().Replace(" ", "");

            //辞書（ディクショナリ）を使った集計
            var alphDicCount = Enumerable.Range('a', 26).
                ToDictionary(num => ((char)num), num => 0);

            //var dict = new SortedDictionary<char, int>();
            foreach (var c in str) {
                if (alphDicCount.ContainsKey(c))
                    //登録されている場合
                    alphDicCount[c]++; 
            }
            foreach (var word in alphDicCount) {
                Console.WriteLine(word.Key + ":" + word.Value);
            }

            Console.WriteLine();//改行用

            //配列を用いた集計
            var array = Enumerable.Repeat(0, 26).ToArray();
            foreach (var alph in str) {
                array[alph - 'a']++;
            }
            for (char ch = 'a'; ch <= 'z'; ch++) {
                Console.WriteLine($"{ ch}: {array[ch - 'a']}");
            }

            Console.WriteLine();//改行用

            //'a'から順にカウントして集計
            for (char ch = 'a'; ch <= 'z'; ch++) {
                Console.WriteLine($"{ch}:{str.Count(c => c == ch)}");
                //Console.WriteLine($"{ch}:{str.Count(ch.Equals)}");
            }
        }
    }
}
