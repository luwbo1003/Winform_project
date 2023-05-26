
namespace DA_Winform
{
    partial class Fm_ReportBangCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_ReportBangCong));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbb_phongbanrp = new System.Windows.Forms.ComboBox();
            this.cbb_namrp = new System.Windows.Forms.ComboBox();
            this.cbb_thangrp = new System.Windows.Forms.ComboBox();
            this.bt_bangcongtheophongban = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bt_nhomphongban = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(2, 131);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1101, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbb_phongbanrp
            // 
            this.cbb_phongbanrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_phongbanrp.FormattingEnabled = true;
            this.cbb_phongbanrp.Location = new System.Drawing.Point(133, 35);
            this.cbb_phongbanrp.Name = "cbb_phongbanrp";
            this.cbb_phongbanrp.Size = new System.Drawing.Size(121, 21);
            this.cbb_phongbanrp.TabIndex = 1;
            // 
            // cbb_namrp
            // 
            this.cbb_namrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_namrp.FormattingEnabled = true;
            this.cbb_namrp.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cbb_namrp.Location = new System.Drawing.Point(332, 35);
            this.cbb_namrp.Name = "cbb_namrp";
            this.cbb_namrp.Size = new System.Drawing.Size(121, 21);
            this.cbb_namrp.TabIndex = 2;
            // 
            // cbb_thangrp
            // 
            this.cbb_thangrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_thangrp.FormattingEnabled = true;
            this.cbb_thangrp.Items.AddRange(new object[] {
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
            this.cbb_thangrp.Location = new System.Drawing.Point(529, 35);
            this.cbb_thangrp.Name = "cbb_thangrp";
            this.cbb_thangrp.Size = new System.Drawing.Size(121, 21);
            this.cbb_thangrp.TabIndex = 3;
            // 
            // bt_bangcongtheophongban
            // 
            this.bt_bangcongtheophongban.AllowAnimations = true;
            this.bt_bangcongtheophongban.AllowMouseEffects = true;
            this.bt_bangcongtheophongban.AllowToggling = false;
            this.bt_bangcongtheophongban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_bangcongtheophongban.AnimationSpeed = 200;
            this.bt_bangcongtheophongban.AutoGenerateColors = false;
            this.bt_bangcongtheophongban.AutoRoundBorders = false;
            this.bt_bangcongtheophongban.AutoSizeLeftIcon = true;
            this.bt_bangcongtheophongban.AutoSizeRightIcon = true;
            this.bt_bangcongtheophongban.BackColor = System.Drawing.Color.Transparent;
            this.bt_bangcongtheophongban.BackColor1 = System.Drawing.Color.Teal;
            this.bt_bangcongtheophongban.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_bangcongtheophongban.BackgroundImage")));
            this.bt_bangcongtheophongban.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_bangcongtheophongban.ButtonText = "Bảng công theo phòng ban tự chọn";
            this.bt_bangcongtheophongban.ButtonTextMarginLeft = 0;
            this.bt_bangcongtheophongban.ColorContrastOnClick = 45;
            this.bt_bangcongtheophongban.ColorContrastOnHover = 45;
            this.bt_bangcongtheophongban.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bt_bangcongtheophongban.CustomizableEdges = borderEdges1;
            this.bt_bangcongtheophongban.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_bangcongtheophongban.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bt_bangcongtheophongban.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_bangcongtheophongban.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_bangcongtheophongban.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bt_bangcongtheophongban.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bangcongtheophongban.ForeColor = System.Drawing.Color.White;
            this.bt_bangcongtheophongban.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_bangcongtheophongban.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bt_bangcongtheophongban.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bt_bangcongtheophongban.IconMarginLeft = 11;
            this.bt_bangcongtheophongban.IconPadding = 10;
            this.bt_bangcongtheophongban.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_bangcongtheophongban.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bt_bangcongtheophongban.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bt_bangcongtheophongban.IconSize = 25;
            this.bt_bangcongtheophongban.IdleBorderColor = System.Drawing.Color.Teal;
            this.bt_bangcongtheophongban.IdleBorderRadius = 30;
            this.bt_bangcongtheophongban.IdleBorderThickness = 1;
            this.bt_bangcongtheophongban.IdleFillColor = System.Drawing.Color.Teal;
            this.bt_bangcongtheophongban.IdleIconLeftImage = null;
            this.bt_bangcongtheophongban.IdleIconRightImage = null;
            this.bt_bangcongtheophongban.IndicateFocus = false;
            this.bt_bangcongtheophongban.Location = new System.Drawing.Point(781, 12);
            this.bt_bangcongtheophongban.Name = "bt_bangcongtheophongban";
            this.bt_bangcongtheophongban.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bt_bangcongtheophongban.OnDisabledState.BorderRadius = 30;
            this.bt_bangcongtheophongban.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_bangcongtheophongban.OnDisabledState.BorderThickness = 1;
            this.bt_bangcongtheophongban.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_bangcongtheophongban.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_bangcongtheophongban.OnDisabledState.IconLeftImage = null;
            this.bt_bangcongtheophongban.OnDisabledState.IconRightImage = null;
            this.bt_bangcongtheophongban.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bt_bangcongtheophongban.onHoverState.BorderRadius = 30;
            this.bt_bangcongtheophongban.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_bangcongtheophongban.onHoverState.BorderThickness = 1;
            this.bt_bangcongtheophongban.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bt_bangcongtheophongban.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bt_bangcongtheophongban.onHoverState.IconLeftImage = null;
            this.bt_bangcongtheophongban.onHoverState.IconRightImage = null;
            this.bt_bangcongtheophongban.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.bt_bangcongtheophongban.OnIdleState.BorderRadius = 30;
            this.bt_bangcongtheophongban.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_bangcongtheophongban.OnIdleState.BorderThickness = 1;
            this.bt_bangcongtheophongban.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.bt_bangcongtheophongban.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bt_bangcongtheophongban.OnIdleState.IconLeftImage = null;
            this.bt_bangcongtheophongban.OnIdleState.IconRightImage = null;
            this.bt_bangcongtheophongban.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bt_bangcongtheophongban.OnPressedState.BorderRadius = 30;
            this.bt_bangcongtheophongban.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_bangcongtheophongban.OnPressedState.BorderThickness = 1;
            this.bt_bangcongtheophongban.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bt_bangcongtheophongban.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bt_bangcongtheophongban.OnPressedState.IconLeftImage = null;
            this.bt_bangcongtheophongban.OnPressedState.IconRightImage = null;
            this.bt_bangcongtheophongban.Size = new System.Drawing.Size(239, 28);
            this.bt_bangcongtheophongban.TabIndex = 4;
            this.bt_bangcongtheophongban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_bangcongtheophongban.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_bangcongtheophongban.TextMarginLeft = 0;
            this.bt_bangcongtheophongban.TextPadding = new System.Windows.Forms.Padding(0);
            this.bt_bangcongtheophongban.UseDefaultRadiusAndThickness = true;
            this.bt_bangcongtheophongban.Click += new System.EventHandler(this.bt_bangcongtheophongban_Click);
            // 
            // bt_nhomphongban
            // 
            this.bt_nhomphongban.AllowAnimations = true;
            this.bt_nhomphongban.AllowMouseEffects = true;
            this.bt_nhomphongban.AllowToggling = false;
            this.bt_nhomphongban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_nhomphongban.AnimationSpeed = 200;
            this.bt_nhomphongban.AutoGenerateColors = false;
            this.bt_nhomphongban.AutoRoundBorders = false;
            this.bt_nhomphongban.AutoSizeLeftIcon = true;
            this.bt_nhomphongban.AutoSizeRightIcon = true;
            this.bt_nhomphongban.BackColor = System.Drawing.Color.Transparent;
            this.bt_nhomphongban.BackColor1 = System.Drawing.Color.Teal;
            this.bt_nhomphongban.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_nhomphongban.BackgroundImage")));
            this.bt_nhomphongban.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_nhomphongban.ButtonText = "Bảng công theo nhóm phòng ban";
            this.bt_nhomphongban.ButtonTextMarginLeft = 0;
            this.bt_nhomphongban.ColorContrastOnClick = 45;
            this.bt_nhomphongban.ColorContrastOnHover = 45;
            this.bt_nhomphongban.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bt_nhomphongban.CustomizableEdges = borderEdges2;
            this.bt_nhomphongban.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_nhomphongban.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bt_nhomphongban.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_nhomphongban.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_nhomphongban.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bt_nhomphongban.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhomphongban.ForeColor = System.Drawing.Color.White;
            this.bt_nhomphongban.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_nhomphongban.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bt_nhomphongban.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bt_nhomphongban.IconMarginLeft = 11;
            this.bt_nhomphongban.IconPadding = 10;
            this.bt_nhomphongban.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_nhomphongban.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bt_nhomphongban.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bt_nhomphongban.IconSize = 25;
            this.bt_nhomphongban.IdleBorderColor = System.Drawing.Color.Teal;
            this.bt_nhomphongban.IdleBorderRadius = 30;
            this.bt_nhomphongban.IdleBorderThickness = 1;
            this.bt_nhomphongban.IdleFillColor = System.Drawing.Color.Teal;
            this.bt_nhomphongban.IdleIconLeftImage = null;
            this.bt_nhomphongban.IdleIconRightImage = null;
            this.bt_nhomphongban.IndicateFocus = false;
            this.bt_nhomphongban.Location = new System.Drawing.Point(747, 62);
            this.bt_nhomphongban.Name = "bt_nhomphongban";
            this.bt_nhomphongban.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bt_nhomphongban.OnDisabledState.BorderRadius = 30;
            this.bt_nhomphongban.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_nhomphongban.OnDisabledState.BorderThickness = 1;
            this.bt_nhomphongban.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_nhomphongban.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_nhomphongban.OnDisabledState.IconLeftImage = null;
            this.bt_nhomphongban.OnDisabledState.IconRightImage = null;
            this.bt_nhomphongban.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bt_nhomphongban.onHoverState.BorderRadius = 30;
            this.bt_nhomphongban.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_nhomphongban.onHoverState.BorderThickness = 1;
            this.bt_nhomphongban.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bt_nhomphongban.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bt_nhomphongban.onHoverState.IconLeftImage = null;
            this.bt_nhomphongban.onHoverState.IconRightImage = null;
            this.bt_nhomphongban.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.bt_nhomphongban.OnIdleState.BorderRadius = 30;
            this.bt_nhomphongban.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_nhomphongban.OnIdleState.BorderThickness = 1;
            this.bt_nhomphongban.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.bt_nhomphongban.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bt_nhomphongban.OnIdleState.IconLeftImage = null;
            this.bt_nhomphongban.OnIdleState.IconRightImage = null;
            this.bt_nhomphongban.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bt_nhomphongban.OnPressedState.BorderRadius = 30;
            this.bt_nhomphongban.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bt_nhomphongban.OnPressedState.BorderThickness = 1;
            this.bt_nhomphongban.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bt_nhomphongban.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bt_nhomphongban.OnPressedState.IconLeftImage = null;
            this.bt_nhomphongban.OnPressedState.IconRightImage = null;
            this.bt_nhomphongban.Size = new System.Drawing.Size(302, 28);
            this.bt_nhomphongban.TabIndex = 5;
            this.bt_nhomphongban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_nhomphongban.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_nhomphongban.TextMarginLeft = 0;
            this.bt_nhomphongban.TextPadding = new System.Windows.Forms.Padding(0);
            this.bt_nhomphongban.UseDefaultRadiusAndThickness = true;
            this.bt_nhomphongban.Click += new System.EventHandler(this.bt_nhomphongban_Click);
            // 
            // Fm_ReportBangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 604);
            this.Controls.Add(this.bt_nhomphongban);
            this.Controls.Add(this.bt_bangcongtheophongban);
            this.Controls.Add(this.cbb_thangrp);
            this.Controls.Add(this.cbb_namrp);
            this.Controls.Add(this.cbb_phongbanrp);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Fm_ReportBangCong";
            this.Text = "Báo cáo bảng công của nhân viên";
            this.Load += new System.EventHandler(this.Fm_ReportBangCong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbb_phongbanrp;
        private System.Windows.Forms.ComboBox cbb_namrp;
        private System.Windows.Forms.ComboBox cbb_thangrp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bt_bangcongtheophongban;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bt_nhomphongban;
    }
}