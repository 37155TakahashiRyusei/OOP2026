using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime date = dtpDate.Value;
            tbOut.Text = date.AddDays((double)nudDay.Value).ToString();
        }

        private void btBirthCalc_Click(object sender, EventArgs e) {
            DateTime birth = dtpDate.Value.Date;     //生まれた日付
            DateTime today = DateTime.Today;    //今日の日付

            //int age = today.Year - birth.Year;
            //if(today < birth.AddYears(age)) {
            //    age--;
            //}

            tbOut.Text = $"あなたは{GetAge(birth, today)}歳です";

            TimeSpan ts = today - birth;
            tbOut2.Text = $"生まれてから{ts.Days}日目です";

            var culture = new CultureInfo("ja-JP");
            var dayOfWeek = culture.DateTimeFormat.GetDayName(birth.DayOfWeek);

            tbOut3.Text = $"生まれた{birth.Month}月{birth.Day}日は" +
                $"第{NthWeek(birth)}週の{dayOfWeek}です";

            //次の誕生日までの日数を求めて表示する　誕生日は今年？来年？
            //今日が誕生日なら「誕生日は今日です」と表示する
           
            if (today.Day - birth.Day == 0) {
                tbOut4.Text = $"今日はあなたの誕生日です";
            }else if (today.Day - birth.Day >= 0) {
                tbOut4.Text = $"誕生日までの残り{today.Day - birth.Day}日です";
            } else {
                tbOut4.Text = $"誕生日までの残り{(today.Day - birth.Day) - (today.Day - birth.Day) * 2}日です";
            }
        }

        //年齢を求めるメソッド
        static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        //指定した日が第何週か求める
        static int NthWeek(DateTime date) {
            var firstDay = new DateTime(date.Year, date.Month, 1);
            var firstDayOfWeek = (int)(firstDay.DayOfWeek);
            return (date.Day + firstDayOfWeek - 1) / 7 + 1;
        }
    }
}
