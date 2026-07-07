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
            DateTime birth = dtpDate.Value;     //ê∂Ç‹ÇÍÇΩì˙ït
            DateTime today = DateTime.Today;    //ç°ì˙ÇÃì˙ït

            //var bornDate = birth.AddYears(dtpBirth).AddMonths();
            // var nowDate = today.add

            //.AddMonths().ToString();
            //tbOut.Text = "Ç†Ç»ÇΩÇÕ" +  + "çŒÇ≈Ç∑";

            int age = today.Year - birth.Year;
            if(today < birth.AddYears(age)) {
                age--;
            }

            //tbOut2.Text = (today - birth).Days();


        }
    }
}
