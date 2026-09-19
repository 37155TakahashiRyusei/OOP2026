namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = ["C#", "Java", "Ruby", "PHP", "Python", "TypeScript", "JavaScript", "Swift", "Go"
                ];

            //Console.WriteLine("=== foreach ===");
            //foreach (string lang in langs) {
            //    if (lang.Contains("S")) {
            //        Console.WriteLine(lang);
            //    }
            //}

            //Console.WriteLine("\n=== for ===");
            //for (int i = 0; i < langs.Count; i++) {
            //    if (langs[i].Contains("S")) {
            //        Console.WriteLine(langs[i]);
            //    }
            //}

            //Console.WriteLine("\n=== while ===");
            //int index = 0;
            //while (index < langs.Count) {
            //    if (langs[index].Contains("S")) {
            //        Console.WriteLine(langs[index]);
            //    }
            //    index++;
            //}


            // Find は見つからない場合 null を返す
            string lang = langs.Find(x => x.Length >= 10);

            // null なら "unknown" を代入
            if (lang == null) {
                lang = "unknown";
            }

            Console.WriteLine(lang);
        }
    }
}
