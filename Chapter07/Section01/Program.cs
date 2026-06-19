namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };

            var books = Books.GetBooks();

            var priceAverage = books.Average(x => x.Price);
            var pageSum = books.Sum(x => x.Pages);
            var maxPrice = books.Max(x => x.Price);

            Console.WriteLine("平均金額:" + priceAverage);
            Console.WriteLine("合計ページ:" + pageSum);
            Console.WriteLine("高価な本:" + maxPrice);

            Console.WriteLine();//改行用
            Console.WriteLine("--- 500円以上のタイトル ---");
            var money = books.Where(x => x.Price >= 500);
            foreach (var item in money) {
                Console.WriteLine(item.Title);
            }

            Console.WriteLine();//改行用
            //本のページが250ページ以上の上位3冊を出力
            Console.WriteLine("--- 本のページが250ページ以上の上位3冊 ---");

            var top3 = books.Where(x => x.Pages >= 250).Take(3);
            foreach (var top3Book in top3) {
                Console.WriteLine(top3Book.Title);
            }
        }
    }
}
