using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookListView
{
    public partial class frmBooks : Form
    {
        // ── 書本資料 ─────────────────────────────────────────────
        private struct BookInfo
        {
            public string Name;
            public string Author;
            public string Kind;
            public string ImageFile;
            public BookInfo(string name, string author, string kind, string img)
            { Name = name; Author = author; Kind = kind; ImageFile = img; }
        }

        private readonly BookInfo[] books =
        {
            // 中國經典
            new BookInfo("三國演義",   "羅貫中",          "章回小說", "book1.jpg"),
            new BookInfo("西遊記",     "吳承恩",          "章回小說", "book2.jpg"),
            new BookInfo("唐詩三百首", "孫洙",            "詩選",     "book3.jpg"),
            new BookInfo("楚辭",       "劉向",            "詩歌",     "book4.jpg"),
            new BookInfo("西廂記",     "王實甫",          "戲曲",     "book5.jpg"),
            new BookInfo("水滸傳",     "施耐庵",          "章回小說", "book6.jpg"),
            new BookInfo("紅樓夢",     "曹雪芹",          "章回小說", "book7.jpg"),
            new BookInfo("牡丹亭",     "湯顯祖",          "戲曲",     "book8.jpg"),
            // 世界文學
            new BookInfo("唐吉訶德",   "塞萬提斯",        "西洋小說", "book9.jpg"),
            new BookInfo("悲慘世界",   "維克多·雨果",     "西洋小說", "book10.jpg"),
            new BookInfo("戰爭與和平", "托爾斯泰",        "西洋小說", "book11.jpg"),
            new BookInfo("罪與罰",     "杜斯妥也夫斯基",  "西洋小說", "book12.jpg"),
            new BookInfo("傲慢與偏見", "珍·奧斯汀",      "西洋小說", "book13.jpeg"),
            new BookInfo("大亨小傳",   "費茲傑羅",        "西洋小說", "book14.jpg"),
            new BookInfo("百年孤寂",   "馬奎斯",          "西洋小說", "book15.jpg"),
            new BookInfo("奧德賽",     "荷馬",            "古典詩歌", "book16.jpg"),
            new BookInfo("哈姆雷特",   "莎士比亞",        "戲曲",     "book17.jpg"),
            new BookInfo("神曲",       "但丁",            "古典詩歌", "book18.jpg"),
        };

        private List<int> filteredIndices = new List<int>();

        // ── 建構子 ───────────────────────────────────────────────
        public frmBooks()
        {
            InitializeComponent();
        }

        // ── 載入 ─────────────────────────────────────────────────
        private void frmBooks_Load(object sender, EventArgs e)
        {
            LoadImages();

            // ListView 欄位（詳細資料模式用）
            lvwBooks.Columns.Add("書名", 160);
            lvwBooks.Columns.Add("作者", 130);
            lvwBooks.Columns.Add("類別", 110);

            // 檢視方式下拉
            cmbView.Items.AddRange(new object[]
            { "大圖示", "詳細資料", "小圖示", "清單", "大圖示加詳細資料" });
            cmbView.SelectedIndex = 0;

            // 類別篩選下拉
            cmbCategory.Items.Add("全部類別");
            foreach (string k in books.Select(b => b.Kind).Distinct().OrderBy(x => x))
                cmbCategory.Items.Add(k);
            cmbCategory.SelectedIndex = 0;

            RefreshList();
        }

        // ── 載入圖片 ─────────────────────────────────────────────
        private void LoadImages()
        {
            string coverPath = Path.Combine(Application.StartupPath, "書籍封面");

            imgL.ImageSize = new Size(100, 140);
            imgS.ImageSize = new Size(32,  44);

            for (int i = 0; i < books.Length; i++)
            {
                Image img = null;
                string fullPath = Path.Combine(coverPath, books[i].ImageFile);

                if (File.Exists(fullPath))
                {
                    try { img = Image.FromFile(fullPath); }
                    catch { /* 載入失敗則使用佔位圖 */ }
                }

                if (img == null)
                    img = CreatePlaceholder(books[i].Name);

                imgL.Images.Add(img);
                imgS.Images.Add(img);
            }
        }

        /// <summary>當封面圖片遺失時產生佔位圖</summary>
        private Image CreatePlaceholder(string title)
        {
            var bmp = new Bitmap(100, 140);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // 背景漸層
                using (var br = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Rectangle(0, 0, 100, 140),
                    Color.FromArgb(60, 90, 130),
                    Color.FromArgb(35, 55, 90),
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical))
                    g.FillRectangle(br, 0, 0, 100, 140);

                // 邊框
                using (var pen = new Pen(Color.FromArgb(120, 160, 210), 2))
                    g.DrawRectangle(pen, 1, 1, 97, 137);

                // 書名
                using (var font = new Font("微軟正黑體", 9f, FontStyle.Bold))
                {
                    var sf = new StringFormat
                    {
                        Alignment     = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center,
                        Trimming      = StringTrimming.Word
                    };
                    g.DrawString(title, font, Brushes.White,
                        new RectangleF(6, 20, 88, 100), sf);
                }
            }
            return bmp;
        }

        // ── 重新載入清單 ─────────────────────────────────────────
        private void RefreshList()
        {
            string raw      = txtSearch.Text.Trim();
            string keyword  = (raw == PlaceholderText) ? "" : raw.ToLower();
            string category = cmbCategory.SelectedIndex > 0
                              ? cmbCategory.SelectedItem.ToString()
                              : null;

            filteredIndices.Clear();
            for (int i = 0; i < books.Length; i++)
            {
                bool matchKw = string.IsNullOrEmpty(keyword)
                    || books[i].Name.ToLower().Contains(keyword)
                    || books[i].Author.ToLower().Contains(keyword)
                    || books[i].Kind.ToLower().Contains(keyword);

                bool matchCat = category == null || books[i].Kind == category;

                if (matchKw && matchCat)
                    filteredIndices.Add(i);
            }

            lvwBooks.BeginUpdate();
            lvwBooks.Items.Clear();
            foreach (int idx in filteredIndices)
            {
                var lvi = new ListViewItem(books[idx].Name);
                lvi.SubItems.Add(books[idx].Author);
                lvi.SubItems.Add(books[idx].Kind);
                lvi.ImageIndex = idx;
                lvi.Tag        = idx;  // 記錄原始索引
                lvwBooks.Items.Add(lvi);
            }
            lvwBooks.EndUpdate();

            // 狀態列
            if (string.IsNullOrEmpty(keyword) && category == null)
                lblStatus.Text = $"共 {books.Length} 本書";
            else
                lblStatus.Text = $"搜尋結果：{filteredIndices.Count} / {books.Length} 本";
        }

        // ── 事件：檢視方式 ───────────────────────────────────────
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbView.SelectedIndex)
            {
                case 0: lvwBooks.View = View.LargeIcon; break;
                case 1: lvwBooks.View = View.Details;   break;
                case 2: lvwBooks.View = View.SmallIcon; break;
                case 3: lvwBooks.View = View.List;      break;
                case 4: lvwBooks.View = View.Tile;      break;
            }
        }

        // ── 事件：搜尋框 Placeholder 模擬 ───────────────────────
        private const string PlaceholderText = "搜尋書名、作者、類別…";

        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == PlaceholderText)
            {
                txtSearch.Text      = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text      = PlaceholderText;
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // ── 事件：搜尋框輸入 ─────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        // ── 事件：類別篩選 ───────────────────────────────────────
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        // ── 事件：清除搜尋 ───────────────────────────────────────
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbCategory.SelectedIndex = 0;
        }

        // ── 事件：雙擊書本 → 借書 ───────────────────────────────
        private void lvwBooks_ItemActivate(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedItems.Count == 0) return;

            int    idx      = (int)lvwBooks.SelectedItems[0].Tag;
            string bookName = books[idx].Name;

            // 已在清單中
            if (lstBorrow.Items.Contains(bookName))
            {
                MessageBox.Show($"《{bookName}》已在借書清單中！",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 詢問是否借閱
            DialogResult dr = MessageBox.Show(
                $"確定要借閱《{bookName}》嗎？",
                "借書確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                lstBorrow.Items.Add(bookName);
                UpdateBorrowCount();
            }
        }

        // ── 事件：還書按鈕 ───────────────────────────────────────
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstBorrow.SelectedIndex < 0)
            {
                MessageBox.Show("請先在借書清單中選取要歸還的書。",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string bookName = lstBorrow.SelectedItem.ToString();
            DialogResult dr = MessageBox.Show(
                $"確定歸還《{bookName}》嗎？",
                "還書確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                lstBorrow.Items.RemoveAt(lstBorrow.SelectedIndex);
                UpdateBorrowCount();
            }
        }

        // ── 更新借書數量顯示 ─────────────────────────────────────
        private void UpdateBorrowCount()
        {
            int cnt = lstBorrow.Items.Count;
            lblBorrowCount.Text = cnt == 0 ? "尚未借書" : $"已借 {cnt} 本";
        }
    }
}
