using System.ComponentModel;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        //BindingList<CarReport> _carreports = new BindingList<CarReport>();
        BindingList<CarReport> _carreports = new();

        // DB操作を担当するRepository
        private readonly CarReportRepository _repository = new();

        //設定クラスのオブジェクトを生成
        //Settings settings = Settings.Instance;

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = _carreports;
            ReloadCarreports();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //背景色を設定する
            try {
                Settings.Instance.Load();
                BackColor = Color.FromArgb(Settings.Instance.MainFormBackColor);

            } catch (Exception ex) {
                tsslbMessage.Text = "設定ファイル読み込みエラー";
                MessageBox.Show(ex.Message);//←より具体的のエラーを出力

            }
        }

        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {
            tsslbMessage.Text = string.Empty; //メッセージ領域のクリア

            //ここに記録者と車名が未入力だった場合の処理を記述する
            //記録者と車名が未入力だった場合は追加しない

            if (string.IsNullOrWhiteSpace(cbAuthor.Text) || string.IsNullOrWhiteSpace(cbCarName.Text)) {
                tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }

            var carReport = new CarReport {
                Date = dtpDate.Value.Date,
                Author = cbAuthor.Text.Trim(),
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text.Trim(),
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            _repository.Add(carReport);
            ReloadCarreports();
            //_carreports.Add(carReport);

            SetCbAuthor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            dgvRecords.CurrentRow.Selected = false; //セルの選択を解除する

            InputitemusallClear(); //入力のクリアー
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
            InputitemusallClear();
        }

        private void InputitemusallClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
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


            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport) {
                return;
            }
            _repository.Delete(carReport.Id);
            _carreports.Remove(carReport);

            InputItemsUpdate(); //データグリッドビューを更新したら呼ぶメソッド
        }

        //データグリッドビューを更新したら呼ぶメソッド
        private void InputItemsUpdate() {
            if (dgvRecords.CurrentRow is null || !dgvRecords.CurrentRow.Selected) {
                InputitemusallClear();
            }
        }

        private void btModifyRecord_Click(object sender, EventArgs e) {

            if (dgvRecords.SelectedRows.Count == 0) {
                tsslbMessage.Text = "修正するレポートを選択してください";
                return;
            }

            if (string.IsNullOrWhiteSpace(cbAuthor.Text) || string.IsNullOrWhiteSpace(cbCarName.Text)) {
                tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }

            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport) {
                tsslbMessage.Text = "修正するレポートを選択してください";
                return;
            }

            //カーレポート管理用リストの該当する要素のデータを書き換える
            _carreports[dgvRecords.CurrentRow.Index].Date = dtpDate.Value.Date;
            _carreports[dgvRecords.CurrentRow.Index].Author = cbAuthor.Text.Trim();
            _carreports[dgvRecords.CurrentRow.Index].Maker = GetRadioButtonMaker();
            _carreports[dgvRecords.CurrentRow.Index].CarName = cbCarName.Text.Trim();
            _carreports[dgvRecords.CurrentRow.Index].Report = tbReport.Text;
            _carreports[dgvRecords.CurrentRow.Index].Picture = pbPicture.Image;

            SetCbAuthor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            dgvRecords.Refresh(); //データグリッドビューの更新
            tsslbMessage.Text = "レポートを修正しました";
            _repository.Update(carReport);

        }

        private void dgvRecords_SelectionChanged(object sender, EventArgs e) {

            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport || !dgvRecords.CurrentRow.Selected) {

                return;
            }

            dtpDate.Value = carReport.Date;
            cbAuthor.Text = carReport.Author;
            SetRadioButtonMaker(carReport.Maker);
            cbCarName.Text = carReport.CarName;
            tbReport.Text = carReport.Report;
            pbPicture.Image = carReport.Picture;

            InputItemsUpdate(); //データグリッドビューを更新したら呼ぶメソッド
        }

        //SQLiteから読み直す
        private void ReloadCarreports() {
            _carreports.Clear();

            foreach (var carReport in _repository.GetAll()) {
                _carreports.Add(carReport);

                SetCbAuthor(carReport.Author);
                SetCbCarName(carReport.CarName);
            }
            dgvRecords.ClearSelection();
        }


        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdcolor.ShowDialog() == DialogResult.OK) {
                BackColor = cdcolor.Color;

                //変色さえれた色の情報を保存
                Settings.Instance.MainFormBackColor = cdcolor.Color.ToArgb();
            }
        }
        //フォームが閉じたら呼ばれるイベントハンドラ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Settings.Instance.Save();
        }

        private readonly CarReportRepository repository = new CarReportRepository();
    }
}