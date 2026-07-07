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
            DateTime birth = dtpDate.Value;     //生まれた日付
            DateTime today = DateTime.Today;    //今日の日付

            //Form1.GetAge(birth, today);

            //int age = today.Year - birth.Year;
            //if(today < birth.AddYears(age)) {
            //    age--;
            //}
            tbOut.Text = $"あなたは{GetAge(birth, today)}歳です";

            TimeSpan ts = today.Date - birth.Date;
            tbOut2.Text = $"生まれてから{ts.Days}日目です";

            //tbOut3.Text = $"生まれた";
        }

        //年齢を求めるメソッド
        static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        //指定したひが第何週か求める
        static int NthWeek(DateTime date) {
            var firstDay = new DateTime(date.Year, date.Month, 1);
            var firstDayOfWeek = (int)(firstDay.DayOfWeek);
            return (date.Day + firstDayOfWeek - 1) / 7 + 1;
        }
    }
}
