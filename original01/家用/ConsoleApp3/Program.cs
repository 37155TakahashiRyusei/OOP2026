namespace ConsoleApp3 {
    internal class Program {
        static void Main(string[] args) {
            // 元の YearMonth 配列
            YearMonth[] yms =
            {
                new YearMonth(2023, 1),
                new YearMonth(2023, 12),
                new YearMonth(2024, 5)
            };

            // 1か月後の YearMonth を LINQ で生成
            var nextMonths = yms
                .Select(ym => ym.AddOneMonth())
                .ToArray();

            // 結果を順に表示
            foreach (var ym in nextMonths) {
                Console.WriteLine(ym);
            }
        }
    }

    // YearMonth クラス
    public class YearMonth {
        public int Year { get; }
        public int Month { get; }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        // 1か月後を返すメソッド
        public YearMonth AddOneMonth() {
            if (Month == 12) {
                return new YearMonth(Year + 1, 1);
            }
            return new YearMonth(Year, Month + 1);
        }

        public override string ToString() {
            return $"{Year}年{Month}月";
        }
    }
}
