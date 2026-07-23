using System.ComponentModel;
using static CarReportSystem.CarReport;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarReportSystem {
    public partial class Form1 : Form {

        int[] CustomColors;


        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();
        //BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = listCarReports;

            CustomColors = new int[] { 0x00FF0000, 0x0000FF00, 0x000000FF };
        }
        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {
            tsslbMessage.Text = string.Empty; //メッセージ領域のクリア

            //ここに記録者と車名が未入力だった場合の処理を記述する
            //記録者と車名が未入力だった場合は追加しない

            //if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
            //    tsslbMessage.Text = "記録者、または車名が未入力です";
            //    return;
            //} 
            if (string.IsNullOrWhiteSpace(cbAuthor.Text) || string.IsNullOrWhiteSpace(cbCarName.Text)) {
                tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }

            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };

            listCarReports.Add(carReport);

            SetCbAuthor(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);

            dgvRecords.CurrentRow.Selected = false; //セルの選択を解除する
            //dgvRecords.ClearSelection();  //セルの選択を解除する

            ImputitemusallClear(); //入力のクリアー
        }


        private MakerGroup GetRadioButtonMaker() {

            if (rbToyota.Checked)
                return MakerGroup.トヨタ;

            if (rbNissan.Checked)
                return MakerGroup.日産;

            if (rbHonda.Checked)
                return MakerGroup.ホンダ;

            if (rbSubaru.Checked)
                return MakerGroup.スバル;

            if (rbOther.Checked)
                return MakerGroup.輸入車;

            return MakerGroup.その他;

        }


        private void btOpenPicture_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void btNewInput_Click(object sender, EventArgs e) {
            dgvRecords.CurrentRow.Selected = false; //セルの選択を解除する
            ImputitemusallClear();
        }

        private void ImputitemusallClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
        }

        private void dgvRecords_Click(object sender, EventArgs e) {
            //if (dgvRecords.CurrentRow is null) {
            //    return;
            //}
            //if (dgvRecords.CurrentRow is null || !dgvRecords.CurrentRow.Selected) {
            //    return;
            //}

            //dtpDate.Value = (DateTime)dgvRecords.CurrentRow.Cells["Date"].Value;
            //cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;
            //SetRadioButtonMaker((MakerGroup)dgvRecords.CurrentRow.Cells["Maker"].Value);
            //cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            //tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            //pbPicture.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;

            //ImputItemUpdate();
        }

        private void SetRadioButtonMaker(MakerGroup targetMaker) {
            switch (targetMaker) {
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        //記録者の入力履歴を登録する（重複なし）
        private void SetCbAuthor(string author) {
            //未登録なら登録【登録済みなら何もしない】
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        //車名の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }

        }

        private void btDeletePicture_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDeliteRecord_Click(object sender, EventArgs e) {

            //選択されているインデックスを取得
            //RemoveAt(消したい場所の要素番号)
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
            listCarReports.RemoveAt(dgvRecords.CurrentRow.Index);
        }

        private void ImputItemUpdate() {
            if (dgvRecords.CurrentRow is null || !dgvRecords.CurrentRow.Selected) {
                return;
            }
        }

        private void btModifyRecord_Click(object sender, EventArgs e) {
            //カーレポート管理用リストの該当する要素のデータを書き換える
            listCarReports[dgvRecords.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvRecords.CurrentRow.Index].Author = cbAuthor.Text;
            listCarReports[dgvRecords.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvRecords.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvRecords.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvRecords.CurrentRow.Index].Picture = pbPicture.Image;

            dgvRecords.Refresh(); //データグリッドビューの更新
        }

        private void dgvRecords_SelectionChanged(object sender, EventArgs e) {

            if (dgvRecords.CurrentRow is null || !dgvRecords.CurrentRow.Selected) {
                return;
            }

            dtpDate.Value = (DateTime)dgvRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;
            SetRadioButtonMaker((MakerGroup)dgvRecords.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;

            ImputItemUpdate(); //データグリッドビューを更新したら呼ぶメソッド
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            // cdcolor.Color()
            using (ColorDialog colorDialog = new ColorDialog()) {

                //初期色の設定
                colorDialog.Color = this.BackColor;

                //カスタム色の設定
                colorDialog.CustomColors = CustomColors;

                //ColorDialogを表示
                if (colorDialog.ShowDialog() == DialogResult.OK) {

                    //選択された色でフォームの背景を変更
                    this.BackColor = colorDialog.Color;

                }

                // ダイアログでユーザーが作成したカスタム色を取得（保存や次回の使用のため）
                CustomColors = colorDialog.CustomColors;
            }

            
        }
    }
}
