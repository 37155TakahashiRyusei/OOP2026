namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            cbAuthor = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            label4 = new Label();
            cbCarName = new ComboBox();
            label5 = new Label();
            dgvRecords = new DataGridView();
            tbReport = new TextBox();
            btNewInput = new Button();
            btDeletePicture = new Button();
            label6 = new Label();
            btOpenPicture = new Button();
            btAddRecord = new Button();
            btModifyRecord = new Button();
            btDeliteRecord = new Button();
            label7 = new Label();
            pbPicture = new PictureBox();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            ofdPicFileOpen = new OpenFileDialog();
            cdcolor = new ColorDialog();
            sfdReportFileSave = new SaveFileDialog();
            ofdReportFileOpen = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(27, 57);
            label1.Name = "label1";
            label1.Size = new Size(78, 41);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(127, 56);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(228, 47);
            dtpDate.TabIndex = 1;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(113, 135);
            cbAuthor.Margin = new Padding(3, 4, 3, 4);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(207, 40);
            cbAuthor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(9, 195);
            label2.Name = "label2";
            label2.Size = new Size(99, 41);
            label2.TabIndex = 0;
            label2.Text = "メーカー";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(8, 135);
            label3.Name = "label3";
            label3.Size = new Size(108, 41);
            label3.TabIndex = 0;
            label3.Text = "記録者";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(106, 185);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(429, 77);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(353, 29);
            rbOther.Margin = new Padding(3, 4, 3, 4);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(68, 24);
            rbOther.TabIndex = 5;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(270, 29);
            rbImport.Margin = new Padding(3, 4, 3, 4);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(75, 24);
            rbImport.TabIndex = 5;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(201, 29);
            rbSubaru.Margin = new Padding(3, 4, 3, 4);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(65, 24);
            rbSubaru.TabIndex = 5;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(134, 29);
            rbHonda.Margin = new Padding(3, 4, 3, 4);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(65, 24);
            rbHonda.TabIndex = 5;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(71, 29);
            rbNissan.Margin = new Padding(3, 4, 3, 4);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(60, 24);
            rbNissan.TabIndex = 5;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbToyota.Location = new Point(7, 29);
            rbToyota.Margin = new Padding(3, 4, 3, 4);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(61, 24);
            rbToyota.TabIndex = 5;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(29, 267);
            label4.Name = "label4";
            label4.Size = new Size(78, 41);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(106, 277);
            cbCarName.Margin = new Padding(3, 4, 3, 4);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(207, 40);
            cbCarName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(9, 384);
            label5.Name = "label5";
            label5.Size = new Size(104, 41);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(14, 505);
            dgvRecords.Margin = new Padding(3, 4, 3, 4);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(803, 269);
            dgvRecords.TabIndex = 5;
            dgvRecords.SelectionChanged += dgvRecords_SelectionChanged;
            // 
            // tbReport
            // 
            tbReport.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbReport.Location = new Point(106, 329);
            tbReport.Margin = new Padding(3, 4, 3, 4);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(346, 128);
            tbReport.TabIndex = 6;
            // 
            // btNewInput
            // 
            btNewInput.BackColor = Color.White;
            btNewInput.FlatStyle = FlatStyle.Flat;
            btNewInput.Location = new Point(449, 65);
            btNewInput.Margin = new Padding(3, 4, 3, 4);
            btNewInput.Name = "btNewInput";
            btNewInput.Size = new Size(86, 40);
            btNewInput.TabIndex = 7;
            btNewInput.Text = "新規入力";
            btNewInput.UseVisualStyleBackColor = false;
            btNewInput.Click += btNewInput_Click;
            // 
            // btDeletePicture
            // 
            btDeletePicture.BackColor = Color.FromArgb(255, 128, 128);
            btDeletePicture.FlatStyle = FlatStyle.Flat;
            btDeletePicture.Location = new Point(767, 77);
            btDeletePicture.Margin = new Padding(3, 4, 3, 4);
            btDeletePicture.Name = "btDeletePicture";
            btDeletePicture.Size = new Size(47, 31);
            btDeletePicture.TabIndex = 7;
            btDeletePicture.Text = "削除";
            btDeletePicture.UseVisualStyleBackColor = false;
            btDeletePicture.Click += btDeletePicture_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(567, 71);
            label6.Name = "label6";
            label6.Size = new Size(78, 41);
            label6.TabIndex = 0;
            label6.Text = "画像";
            // 
            // btOpenPicture
            // 
            btOpenPicture.BackColor = Color.FromArgb(128, 255, 128);
            btOpenPicture.FlatStyle = FlatStyle.Flat;
            btOpenPicture.Location = new Point(656, 71);
            btOpenPicture.Margin = new Padding(3, 4, 3, 4);
            btOpenPicture.Name = "btOpenPicture";
            btOpenPicture.Size = new Size(86, 43);
            btOpenPicture.TabIndex = 7;
            btOpenPicture.Text = "開く...";
            btOpenPicture.UseVisualStyleBackColor = false;
            btOpenPicture.Click += btOpenPicture_Click;
            // 
            // btAddRecord
            // 
            btAddRecord.BackColor = Color.MediumTurquoise;
            btAddRecord.Location = new Point(552, 435);
            btAddRecord.Margin = new Padding(3, 4, 3, 4);
            btAddRecord.Name = "btAddRecord";
            btAddRecord.Size = new Size(86, 63);
            btAddRecord.TabIndex = 7;
            btAddRecord.Text = "追加";
            btAddRecord.UseVisualStyleBackColor = false;
            btAddRecord.Click += btAddRecord_Click;
            // 
            // btModifyRecord
            // 
            btModifyRecord.BackColor = Color.LemonChiffon;
            btModifyRecord.Location = new Point(656, 435);
            btModifyRecord.Margin = new Padding(3, 4, 3, 4);
            btModifyRecord.Name = "btModifyRecord";
            btModifyRecord.Size = new Size(86, 63);
            btModifyRecord.TabIndex = 7;
            btModifyRecord.Text = "修正";
            btModifyRecord.UseVisualStyleBackColor = false;
            btModifyRecord.Click += btModifyRecord_Click;
            // 
            // btDeliteRecord
            // 
            btDeliteRecord.BackColor = Color.FromArgb(255, 128, 128);
            btDeliteRecord.Location = new Point(767, 435);
            btDeliteRecord.Margin = new Padding(3, 4, 3, 4);
            btDeliteRecord.Name = "btDeliteRecord";
            btDeliteRecord.Size = new Size(50, 49);
            btDeliteRecord.TabIndex = 7;
            btDeliteRecord.Text = "削除";
            btDeliteRecord.UseVisualStyleBackColor = false;
            btDeliteRecord.Click += btDeliteRecord_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(27, 464);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 0;
            label7.Text = "一覧";
            // 
            // pbPicture
            // 
            pbPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPicture.Location = new Point(553, 117);
            pbPicture.Margin = new Padding(3, 4, 3, 4);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(264, 309);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 8;
            pbPicture.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(831, 30);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator2, 色設定ToolStripMenuItem, toolStripSeparator1, 終了ToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(82, 24);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(224, 26);
            色設定ToolStripMenuItem.Text = "色設定";
            色設定ToolStripMenuItem.Click += 色設定ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            終了ToolStripMenuItem.Size = new Size(224, 26);
            終了ToolStripMenuItem.Text = "終了(&X)";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(79, 24);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(203, 26);
            このアプリについてToolStripMenuItem.Text = "このアプリについて...";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            statusStrip1.Location = new Point(0, 817);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(831, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 16);
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // ofdReportFileOpen
            // 
            ofdReportFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 839);
            Controls.Add(statusStrip1);
            Controls.Add(pbPicture);
            Controls.Add(btDeletePicture);
            Controls.Add(btDeliteRecord);
            Controls.Add(btModifyRecord);
            Controls.Add(btAddRecord);
            Controls.Add(btOpenPicture);
            Controls.Add(btNewInput);
            Controls.Add(tbReport);
            Controls.Add(dgvRecords);
            Controls.Add(groupBox1);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(dtpDate);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private ComboBox cbAuthor;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private RadioButton rbOther;
        private Label label4;
        private ComboBox cbCarName;
        private Label label5;
        private DataGridView dgvRecords;
        private TextBox tbReport;
        private Button btNewInput;
        private Button btDeletePicture;
        private Label label6;
        private Button btOpenPicture;
        private Button btAddRecord;
        private Button btModifyRecord;
        private Button btDeliteRecord;
        private Label label7;
        private PictureBox pbPicture;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslbMessage;
        private OpenFileDialog ofdPicFileOpen;
        private ColorDialog cdcolor;
        private SaveFileDialog sfdReportFileSave;
        private OpenFileDialog ofdReportFileOpen;
    }
}
