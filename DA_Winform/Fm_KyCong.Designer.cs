
namespace DA_Winform
{
    partial class Fm_KyCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_KyCong));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.gridview_KC = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.maKCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytinhcongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycongtrongthangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kyCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_namKC = new System.Windows.Forms.ComboBox();
            this.cbb_thangKC = new System.Windows.Forms.ComboBox();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bt_themkycong = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bt_xemcongchitiet = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_KC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyCongBindingSource)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridview_KC
            // 
            this.gridview_KC.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridview_KC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_KC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_KC.AutoGenerateColumns = false;
            this.gridview_KC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_KC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_KC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_KC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_KC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_KC.ColumnHeadersHeight = 40;
            this.gridview_KC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKCDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.ngaytinhcongDataGridViewTextBoxColumn,
            this.ngaycongtrongthangDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn});
            this.gridview_KC.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridview_KC.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridview_KC.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridview_KC.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.gridview_KC.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridview_KC.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.gridview_KC.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gridview_KC.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.gridview_KC.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gridview_KC.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_KC.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.gridview_KC.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridview_KC.CurrentTheme.Name = null;
            this.gridview_KC.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.gridview_KC.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridview_KC.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridview_KC.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.gridview_KC.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridview_KC.DataSource = this.kyCongBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_KC.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_KC.EnableHeadersVisualStyles = false;
            this.gridview_KC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gridview_KC.HeaderBackColor = System.Drawing.Color.Teal;
            this.gridview_KC.HeaderBgColor = System.Drawing.Color.Empty;
            this.gridview_KC.HeaderForeColor = System.Drawing.Color.White;
            this.gridview_KC.Location = new System.Drawing.Point(2, 155);
            this.gridview_KC.Name = "gridview_KC";
            this.gridview_KC.ReadOnly = true;
            this.gridview_KC.RowHeadersVisible = false;
            this.gridview_KC.RowTemplate.Height = 40;
            this.gridview_KC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_KC.Size = new System.Drawing.Size(1113, 535);
            this.gridview_KC.TabIndex = 0;
            this.gridview_KC.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.gridview_KC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_KC_CellClick);
            // 
            // maKCDataGridViewTextBoxColumn
            // 
            this.maKCDataGridViewTextBoxColumn.DataPropertyName = "MaKC";
            this.maKCDataGridViewTextBoxColumn.HeaderText = "Mã kỳ công";
            this.maKCDataGridViewTextBoxColumn.Name = "maKCDataGridViewTextBoxColumn";
            this.maKCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng";
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            this.thangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaytinhcongDataGridViewTextBoxColumn
            // 
            this.ngaytinhcongDataGridViewTextBoxColumn.DataPropertyName = "ngaytinhcong";
            this.ngaytinhcongDataGridViewTextBoxColumn.HeaderText = "Ngày tính công";
            this.ngaytinhcongDataGridViewTextBoxColumn.Name = "ngaytinhcongDataGridViewTextBoxColumn";
            this.ngaytinhcongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaycongtrongthangDataGridViewTextBoxColumn
            // 
            this.ngaycongtrongthangDataGridViewTextBoxColumn.DataPropertyName = "ngaycongtrongthang";
            this.ngaycongtrongthangDataGridViewTextBoxColumn.HeaderText = "Ngày công trong tháng";
            this.ngaycongtrongthangDataGridViewTextBoxColumn.Name = "ngaycongtrongthangDataGridViewTextBoxColumn";
            this.ngaycongtrongthangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangthaiDataGridViewTextBoxColumn
            // 
            this.trangthaiDataGridViewTextBoxColumn.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewTextBoxColumn.Name = "trangthaiDataGridViewTextBoxColumn";
            this.trangthaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.trangthaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangthaiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // kyCongBindingSource
            // 
            this.kyCongBindingSource.DataSource = typeof(DA_Winform.KyCong);
            // 
            // cbb_namKC
            // 
            this.cbb_namKC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_namKC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_namKC.FormattingEnabled = true;
            this.cbb_namKC.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cbb_namKC.Location = new System.Drawing.Point(199, 57);
            this.cbb_namKC.Name = "cbb_namKC";
            this.cbb_namKC.Size = new System.Drawing.Size(246, 23);
            this.cbb_namKC.TabIndex = 1;
            // 
            // cbb_thangKC
            // 
            this.cbb_thangKC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_thangKC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_thangKC.FormattingEnabled = true;
            this.cbb_thangKC.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_thangKC.Location = new System.Drawing.Point(633, 58);
            this.cbb_thangKC.Name = "cbb_thangKC";
            this.cbb_thangKC.Size = new System.Drawing.Size(235, 23);
            this.cbb_thangKC.TabIndex = 2;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuGroupBox1.BorderRadius = 30;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.bt_themkycong);
            this.bunifuGroupBox1.Controls.Add(this.bt_xemcongchitiet);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel3);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel2);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel1);
            this.bunifuGroupBox1.Controls.Add(this.cbb_namKC);
            this.bunifuGroupBox1.Controls.Add(this.cbb_thangKC);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(2, 3);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(1113, 146);
            this.bunifuGroupBox1.TabIndex = 3;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Enter += new System.EventHandler(this.bunifuGroupBox1_Enter);
            // 
            // bt_themkycong
            // 
            this.bt_themkycong.AllowAnimations = true;
            this.bt_themkycong.AllowMouseEffects = true;
            this.bt_themkycong.AllowToggling = false;
            this.bt_themkycong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_themkycong.AnimationSpeed = 200;
            this.bt_themkycong.AutoGenerateColors = false;
            this.bt_themkycong.AutoRoundBorders = false;
            this.bt_themkycong.AutoSizeLeftIcon = true;
            this.bt_themkycong.AutoSizeRightIcon = true;
            this.bt_themkycong.BackColor = System.Drawing.Color.Transparent;
            this.bt_themkycong.BackColor1 = System.Drawing.Color.Teal;
            this.bt_themkycong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_themkycong.BackgroundImage")));
            this.bt_themkycong.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_themkycong.ButtonText = "Thêm kỳ công";
            this.bt_themkycong.ButtonTextMarginLeft = 0;
            this.bt_themkycong.ColorContrastOnClick = 45;
            this.bt_themkycong.ColorContrastOnHover = 45;
            this.bt_themkycong.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bt_themkycong.CustomizableEdges = borderEdges1;
            this.bt_themkycong.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_themkycong.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bt_themkycong.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_themkycong.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_themkycong.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bt_themkycong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themkycong.ForeColor = System.Drawing.Color.White;
            this.bt_themkycong.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_themkycong.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bt_themkycong.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bt_themkycong.IconMarginLeft = 11;
            this.bt_themkycong.IconPadding = 10;
            this.bt_themkycong.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_themkycong.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bt_themkycong.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bt_themkycong.IconSize = 25;
            this.bt_themkycong.IdleBorderColor = System.Drawing.Color.Teal;
            this.bt_themkycong.IdleBorderRadius = 30;
            this.bt_themkycong.IdleBorderThickness = 1;
            this.bt_themkycong.IdleFillColor = System.Drawing.Color.Teal;
            this.bt_themkycong.IdleIconLeftImage = null;
            this.bt_themkycong.IdleIconRightImage = null;
            this.bt_themkycong.IndicateFocus = false;
            this.bt_themkycong.Location = new System.Drawing.Point(916, 50);
            this.bt_themkycong.Name = "bt_themkycong";
            this.bt_themkycong.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bt_themkycong.OnDisabledState.BorderRadius = 30;
            this.bt_themkycong.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_themkycong.OnDisabledState.BorderThickness = 1;
            this.bt_themkycong.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_themkycong.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_themkycong.OnDisabledState.IconLeftImage = null;
            this.bt_themkycong.OnDisabledState.IconRightImage = null;
            this.bt_themkycong.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bt_themkycong.onHoverState.BorderRadius = 30;
            this.bt_themkycong.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_themkycong.onHoverState.BorderThickness = 1;
            this.bt_themkycong.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bt_themkycong.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bt_themkycong.onHoverState.IconLeftImage = null;
            this.bt_themkycong.onHoverState.IconRightImage = null;
            this.bt_themkycong.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.bt_themkycong.OnIdleState.BorderRadius = 30;
            this.bt_themkycong.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_themkycong.OnIdleState.BorderThickness = 1;
            this.bt_themkycong.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.bt_themkycong.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bt_themkycong.OnIdleState.IconLeftImage = null;
            this.bt_themkycong.OnIdleState.IconRightImage = null;
            this.bt_themkycong.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bt_themkycong.OnPressedState.BorderRadius = 30;
            this.bt_themkycong.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_themkycong.OnPressedState.BorderThickness = 1;
            this.bt_themkycong.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bt_themkycong.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bt_themkycong.OnPressedState.IconLeftImage = null;
            this.bt_themkycong.OnPressedState.IconRightImage = null;
            this.bt_themkycong.Size = new System.Drawing.Size(146, 30);
            this.bt_themkycong.TabIndex = 3;
            this.bt_themkycong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_themkycong.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_themkycong.TextMarginLeft = 0;
            this.bt_themkycong.TextPadding = new System.Windows.Forms.Padding(0);
            this.bt_themkycong.UseDefaultRadiusAndThickness = true;
            this.bt_themkycong.Click += new System.EventHandler(this.bt_themkycong_Click);
            // 
            // bt_xemcongchitiet
            // 
            this.bt_xemcongchitiet.AllowAnimations = true;
            this.bt_xemcongchitiet.AllowMouseEffects = true;
            this.bt_xemcongchitiet.AllowToggling = false;
            this.bt_xemcongchitiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_xemcongchitiet.AnimationSpeed = 200;
            this.bt_xemcongchitiet.AutoGenerateColors = false;
            this.bt_xemcongchitiet.AutoRoundBorders = false;
            this.bt_xemcongchitiet.AutoSizeLeftIcon = true;
            this.bt_xemcongchitiet.AutoSizeRightIcon = true;
            this.bt_xemcongchitiet.BackColor = System.Drawing.Color.Transparent;
            this.bt_xemcongchitiet.BackColor1 = System.Drawing.Color.Teal;
            this.bt_xemcongchitiet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_xemcongchitiet.BackgroundImage")));
            this.bt_xemcongchitiet.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_xemcongchitiet.ButtonText = "Xem bảng công";
            this.bt_xemcongchitiet.ButtonTextMarginLeft = 0;
            this.bt_xemcongchitiet.ColorContrastOnClick = 45;
            this.bt_xemcongchitiet.ColorContrastOnHover = 45;
            this.bt_xemcongchitiet.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bt_xemcongchitiet.CustomizableEdges = borderEdges2;
            this.bt_xemcongchitiet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_xemcongchitiet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bt_xemcongchitiet.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_xemcongchitiet.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_xemcongchitiet.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bt_xemcongchitiet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xemcongchitiet.ForeColor = System.Drawing.Color.White;
            this.bt_xemcongchitiet.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xemcongchitiet.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bt_xemcongchitiet.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bt_xemcongchitiet.IconMarginLeft = 11;
            this.bt_xemcongchitiet.IconPadding = 10;
            this.bt_xemcongchitiet.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xemcongchitiet.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bt_xemcongchitiet.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bt_xemcongchitiet.IconSize = 25;
            this.bt_xemcongchitiet.IdleBorderColor = System.Drawing.Color.Teal;
            this.bt_xemcongchitiet.IdleBorderRadius = 30;
            this.bt_xemcongchitiet.IdleBorderThickness = 1;
            this.bt_xemcongchitiet.IdleFillColor = System.Drawing.Color.Teal;
            this.bt_xemcongchitiet.IdleIconLeftImage = null;
            this.bt_xemcongchitiet.IdleIconRightImage = null;
            this.bt_xemcongchitiet.IndicateFocus = false;
            this.bt_xemcongchitiet.Location = new System.Drawing.Point(394, 101);
            this.bt_xemcongchitiet.Name = "bt_xemcongchitiet";
            this.bt_xemcongchitiet.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bt_xemcongchitiet.OnDisabledState.BorderRadius = 30;
            this.bt_xemcongchitiet.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_xemcongchitiet.OnDisabledState.BorderThickness = 1;
            this.bt_xemcongchitiet.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_xemcongchitiet.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_xemcongchitiet.OnDisabledState.IconLeftImage = null;
            this.bt_xemcongchitiet.OnDisabledState.IconRightImage = null;
            this.bt_xemcongchitiet.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bt_xemcongchitiet.onHoverState.BorderRadius = 30;
            this.bt_xemcongchitiet.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_xemcongchitiet.onHoverState.BorderThickness = 1;
            this.bt_xemcongchitiet.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bt_xemcongchitiet.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bt_xemcongchitiet.onHoverState.IconLeftImage = null;
            this.bt_xemcongchitiet.onHoverState.IconRightImage = null;
            this.bt_xemcongchitiet.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.bt_xemcongchitiet.OnIdleState.BorderRadius = 30;
            this.bt_xemcongchitiet.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_xemcongchitiet.OnIdleState.BorderThickness = 1;
            this.bt_xemcongchitiet.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.bt_xemcongchitiet.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bt_xemcongchitiet.OnIdleState.IconLeftImage = null;
            this.bt_xemcongchitiet.OnIdleState.IconRightImage = null;
            this.bt_xemcongchitiet.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bt_xemcongchitiet.OnPressedState.BorderRadius = 30;
            this.bt_xemcongchitiet.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_xemcongchitiet.OnPressedState.BorderThickness = 1;
            this.bt_xemcongchitiet.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bt_xemcongchitiet.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bt_xemcongchitiet.OnPressedState.IconLeftImage = null;
            this.bt_xemcongchitiet.OnPressedState.IconRightImage = null;
            this.bt_xemcongchitiet.Size = new System.Drawing.Size(254, 30);
            this.bt_xemcongchitiet.TabIndex = 4;
            this.bt_xemcongchitiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_xemcongchitiet.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_xemcongchitiet.TextMarginLeft = 0;
            this.bt_xemcongchitiet.TextPadding = new System.Windows.Forms.Padding(0);
            this.bt_xemcongchitiet.UseDefaultRadiusAndThickness = true;
            this.bt_xemcongchitiet.Click += new System.EventHandler(this.bt_xemcongchitiet_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(547, 58);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(37, 15);
            this.bunifuLabel3.TabIndex = 5;
            this.bunifuLabel3.Text = "Tháng:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(129, 58);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(29, 15);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "Năm:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(467, 9);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(77, 21);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "GHI CÔNG";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Fm_KyCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 690);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.gridview_KC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_KyCong";
            this.Load += new System.EventHandler(this.Fm_KyCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_KC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyCongBindingSource)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView gridview_KC;
        private System.Windows.Forms.ComboBox cbb_namKC;
        private System.Windows.Forms.ComboBox cbb_thangKC;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bt_themkycong;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bt_xemcongchitiet;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.BindingSource kyCongBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytinhcongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycongtrongthangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthaiDataGridViewTextBoxColumn;
    }
}