using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton1_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            //tbOut1.Text = today.Date.ToString();
            tbOut1.Text = today.ToString("yyyy/MM/dd HH:mm");
        }

        private void btButton2_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            tbOut2.Text = today.ToString("yyyy”NMMŒŽdd“ú HHŽžmm•ªss•b");
            // tbOut2.Text = $"{today.Year.ToString()}”N{today.Month}ŒŽ{today.Day}“ú{today.ToString()}";
        }

        private void btButton3_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayOfWeek = culture.DateTimeFormat.GetDayName(today.DayOfWeek);

            tbOut3.Text = today.ToString( "gy”N" + " " + "MŒŽ" + " " + "d“ú" + "(" + dayOfWeek + ")", culture);
        }
    }
}
