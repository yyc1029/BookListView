namespace BookListView
{
    partial class frmBooks
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.imgS = new System.Windows.Forms.ImageList(this.components);

            // ── 左側主體 ──────────────────────────────────────────
            this.pnlLeft         = new System.Windows.Forms.Panel();
            this.pnlHeader       = new System.Windows.Forms.Panel();
            this.lblTitle        = new System.Windows.Forms.Label();
            this.pnlSearch       = new System.Windows.Forms.Panel();
            this.lblSearchIcon   = new System.Windows.Forms.Label();
            this.txtSearch       = new System.Windows.Forms.TextBox();
            this.lblCategoryLbl  = new System.Windows.Forms.Label();
            this.cmbCategory     = new System.Windows.Forms.ComboBox();
            this.btnClearSearch  = new System.Windows.Forms.Button();
            this.lvwBooks        = new System.Windows.Forms.ListView();
            this.pnlStatus       = new System.Windows.Forms.Panel();
            this.lblStatus       = new System.Windows.Forms.Label();

            // ── 右側工具 ──────────────────────────────────────────
            this.pnlRight        = new System.Windows.Forms.Panel();
            this.grpView         = new System.Windows.Forms.GroupBox();
            this.lblViewLbl      = new System.Windows.Forms.Label();
            this.cmbView         = new System.Windows.Forms.ComboBox();
            this.grpBorrow       = new System.Windows.Forms.GroupBox();
            this.lstBorrow       = new System.Windows.Forms.ListBox();
            this.pnlBorrowBottom = new System.Windows.Forms.Panel();
            this.btnReturn       = new System.Windows.Forms.Button();
            this.lblBorrowCount  = new System.Windows.Forms.Label();

            this.pnlLeft.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpView.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.pnlBorrowBottom.SuspendLayout();
            this.SuspendLayout();

            // ── ImageList ─────────────────────────────────────────
            this.imgL.ColorDepth       = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgL.ImageSize        = new System.Drawing.Size(100, 140);
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;

            this.imgS.ColorDepth       = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgS.ImageSize        = new System.Drawing.Size(32, 44);
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;

            // ── pnlHeader ─────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 45, 80);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 68;
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.Text      = "📚  圖書管理系統";
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(220, 195, 140);
            this.lblTitle.Font      = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Padding   = new System.Windows.Forms.Padding(16, 0, 0, 0);

            // ── pnlSearch ─────────────────────────────────────────
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(240, 236, 228);
            this.pnlSearch.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height    = 62;
            this.pnlSearch.Padding   = new System.Windows.Forms.Padding(10, 10, 10, 6);
            this.pnlSearch.Controls.Add(this.btnClearSearch);
            this.pnlSearch.Controls.Add(this.cmbCategory);
            this.pnlSearch.Controls.Add(this.lblCategoryLbl);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearchIcon);

            this.lblSearchIcon.Text      = "🔍";
            this.lblSearchIcon.Font      = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblSearchIcon.Location  = new System.Drawing.Point(12, 13);
            this.lblSearchIcon.Size      = new System.Drawing.Size(34, 34);
            this.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.txtSearch.Font        = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtSearch.Location    = new System.Drawing.Point(48, 14);
            this.txtSearch.Size        = new System.Drawing.Size(240, 34);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.BackColor   = System.Drawing.Color.White;
            this.txtSearch.ForeColor   = System.Drawing.Color.Gray;
            this.txtSearch.Text        = "搜尋書名、作者、類別…";
            this.txtSearch.GotFocus   += new System.EventHandler(this.txtSearch_GotFocus);
            this.txtSearch.LostFocus  += new System.EventHandler(this.txtSearch_LostFocus);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblCategoryLbl.Text      = "類別：";
            this.lblCategoryLbl.Font      = new System.Drawing.Font("微軟正黑體", 11F);
            this.lblCategoryLbl.Location  = new System.Drawing.Point(300, 15);
            this.lblCategoryLbl.Size      = new System.Drawing.Size(58, 32);
            this.lblCategoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.cmbCategory.Font             = new System.Drawing.Font("微軟正黑體", 11F);
            this.cmbCategory.Location         = new System.Drawing.Point(360, 14);
            this.cmbCategory.Size             = new System.Drawing.Size(160, 34);
            this.cmbCategory.DropDownStyle    = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);

            this.btnClearSearch.Text      = "清除";
            this.btnClearSearch.Font      = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnClearSearch.Location  = new System.Drawing.Point(530, 14);
            this.btnClearSearch.Size      = new System.Drawing.Size(70, 34);
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(26, 45, 80);
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);

            // ── lvwBooks ──────────────────────────────────────────
            this.lvwBooks.BackColor               = System.Drawing.Color.FromArgb(253, 250, 244);
            this.lvwBooks.Font                    = new System.Drawing.Font("微軟正黑體", 11F);
            this.lvwBooks.Dock                    = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.LargeImageList          = this.imgL;
            this.lvwBooks.SmallImageList          = this.imgS;
            this.lvwBooks.HideSelection           = false;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.ItemActivate           += new System.EventHandler(this.lvwBooks_ItemActivate);

            // ── pnlStatus ─────────────────────────────────────────
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(230, 225, 215);
            this.pnlStatus.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Height    = 30;
            this.pnlStatus.Controls.Add(this.lblStatus);

            this.lblStatus.Text      = "";
            this.lblStatus.Font      = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(80, 70, 55);
            this.lblStatus.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Padding   = new System.Windows.Forms.Padding(10, 0, 0, 0);

            // ── pnlLeft ───────────────────────────────────────────
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Controls.Add(this.lvwBooks);
            this.pnlLeft.Controls.Add(this.pnlStatus);
            this.pnlLeft.Controls.Add(this.pnlSearch);
            this.pnlLeft.Controls.Add(this.pnlHeader);

            // ── grpView ───────────────────────────────────────────
            this.grpView.Text      = "檢視方式";
            this.grpView.Font      = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.grpView.ForeColor = System.Drawing.Color.FromArgb(26, 45, 80);
            this.grpView.BackColor = System.Drawing.Color.FromArgb(248, 244, 236);
            this.grpView.Dock      = System.Windows.Forms.DockStyle.Top;
            this.grpView.Height    = 110;
            this.grpView.Padding   = new System.Windows.Forms.Padding(10);
            this.grpView.Controls.Add(this.lblViewLbl);
            this.grpView.Controls.Add(this.cmbView);

            this.lblViewLbl.Text      = "顯示模式";
            this.lblViewLbl.Font      = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblViewLbl.ForeColor = System.Drawing.Color.FromArgb(100, 85, 65);
            this.lblViewLbl.Location  = new System.Drawing.Point(12, 30);
            this.lblViewLbl.Size      = new System.Drawing.Size(80, 28);
            this.lblViewLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.cmbView.Font          = new System.Drawing.Font("微軟正黑體", 11F);
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.Location      = new System.Drawing.Point(12, 62);
            this.cmbView.Size          = new System.Drawing.Size(250, 34);
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);

            // ── grpBorrow ─────────────────────────────────────────
            this.grpBorrow.Text      = "借書清單";
            this.grpBorrow.Font      = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.grpBorrow.ForeColor = System.Drawing.Color.FromArgb(26, 45, 80);
            this.grpBorrow.BackColor = System.Drawing.Color.FromArgb(248, 244, 236);
            this.grpBorrow.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.grpBorrow.Padding   = new System.Windows.Forms.Padding(8);
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Controls.Add(this.pnlBorrowBottom);

            this.lstBorrow.Font           = new System.Drawing.Font("微軟正黑體", 11F);
            this.lstBorrow.Dock           = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrow.ItemHeight     = 36;
            this.lstBorrow.BackColor      = System.Drawing.Color.FromArgb(253, 250, 244);
            this.lstBorrow.BorderStyle    = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBorrow.SelectionMode  = System.Windows.Forms.SelectionMode.One;

            // ── pnlBorrowBottom ───────────────────────────────────
            this.pnlBorrowBottom.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorrowBottom.Height    = 52;
            this.pnlBorrowBottom.BackColor = System.Drawing.Color.FromArgb(248, 244, 236);
            this.pnlBorrowBottom.Padding   = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlBorrowBottom.Controls.Add(this.btnReturn);
            this.pnlBorrowBottom.Controls.Add(this.lblBorrowCount);

            this.btnReturn.Text      = "✖  還書";
            this.btnReturn.Font      = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnReturn.Location  = new System.Drawing.Point(8, 6);
            this.btnReturn.Size      = new System.Drawing.Size(110, 38);
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(180, 60, 55);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.Click    += new System.EventHandler(this.btnReturn_Click);

            this.lblBorrowCount.Text      = "尚未借書";
            this.lblBorrowCount.Font      = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblBorrowCount.ForeColor = System.Drawing.Color.FromArgb(100, 85, 65);
            this.lblBorrowCount.Location  = new System.Drawing.Point(128, 6);
            this.lblBorrowCount.Size      = new System.Drawing.Size(140, 38);
            this.lblBorrowCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── pnlRight ──────────────────────────────────────────
            this.pnlRight.Dock      = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Width     = 290;
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(235, 230, 218);
            this.pnlRight.Padding   = new System.Windows.Forms.Padding(4);
            this.pnlRight.Controls.Add(this.grpBorrow);
            this.pnlRight.Controls.Add(this.grpView);

            // ── Form ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(235, 230, 218);
            this.ClientSize          = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Font                = new System.Drawing.Font("微軟正黑體", 10F);
            this.MinimumSize         = new System.Drawing.Size(900, 600);
            this.Name                = "frmBooks";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "圖書管理系統";
            this.Load               += new System.EventHandler(this.frmBooks_Load);

            this.pnlLeft.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.grpView.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.pnlBorrowBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ImageList imgS;

        private System.Windows.Forms.Panel    pnlLeft;
        private System.Windows.Forms.Panel    pnlHeader;
        private System.Windows.Forms.Label    lblTitle;
        private System.Windows.Forms.Panel    pnlSearch;
        private System.Windows.Forms.Label    lblSearchIcon;
        private System.Windows.Forms.TextBox  txtSearch;
        private System.Windows.Forms.Label    lblCategoryLbl;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button   btnClearSearch;
        private System.Windows.Forms.ListView lvwBooks;
        private System.Windows.Forms.Panel    pnlStatus;
        private System.Windows.Forms.Label    lblStatus;

        private System.Windows.Forms.Panel     pnlRight;
        private System.Windows.Forms.GroupBox  grpView;
        private System.Windows.Forms.Label     lblViewLbl;
        private System.Windows.Forms.ComboBox  cmbView;
        private System.Windows.Forms.GroupBox  grpBorrow;
        private System.Windows.Forms.ListBox   lstBorrow;
        private System.Windows.Forms.Panel     pnlBorrowBottom;
        private System.Windows.Forms.Button    btnReturn;
        private System.Windows.Forms.Label     lblBorrowCount;

        public System.Windows.Forms.Panel pnlView => pnlLeft; // 相容性保留
    }
}
