namespace Test01_01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要：
        private static IEnumerable<Student> ReadScore(string filePath) {
            var student = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');  //カンマで区切り分割
                var students = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2]),
                };
                student.Add(students);
            }
            return student;
        }

        //メソッドの概要：
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var scores in _score) {
                //既に生徒名が辞書のキーに登録されているか？
                if (dict.ContainsKey(scores.Subject))
                    //登録されている場合
                    dict[scores.Subject] += scores.Score; //点数を足しこみ
                else
                    //未登録の場合
                    dict[scores.Subject] = scores.Score; //新規に点数を登録
            }
            return dict;
        }
    }
}
