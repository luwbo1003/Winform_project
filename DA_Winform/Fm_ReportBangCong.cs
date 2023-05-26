using DA_Winform.BLL;
using DA_Winform.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_Winform
{
    public partial class Fm_ReportBangCong : Form
    {
        List<KyCongChiTietDTO> listnnn;
        public Fm_ReportBangCong()
        {
            InitializeComponent();
        }

        private void Fm_ReportBangCong_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            List<PhongBanDTO> listPhongban = PhongBanBLL.EF_GetAll();
            cbb_phongbanrp.DataSource = listPhongban;
            cbb_phongbanrp.DisplayMember = "TenPB";
            cbb_phongbanrp.ValueMember = "MaPB";

        }

        private void bt_bangcongtheophongban_Click(object sender, EventArgs e)
        {
            reportViewer1.Clear();

            PhongBanDTO lpb = (PhongBanDTO)cbb_phongbanrp.SelectedItem;
            listnnn = KyCongChiTietBLL.EF_GetWithSpecial(lpb.MaPB.Trim(), int.Parse(cbb_namrp.Text), int.Parse(cbb_thangrp.Text));

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_Winform.rptBangCongTheoPhongBan.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSBC", listnnn));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paTenPhongBan", lpb.TenPB, false));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paNam", cbb_namrp.Text, false));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paThang", cbb_thangrp.Text, false));
            reportViewer1.RefreshReport();
        }

        private void bt_nhomphongban_Click(object sender, EventArgs e)
        {
            List<PhongBanDTO> ds = new List<PhongBanDTO>();
            ds = PhongBanBLL.EF_GetAll();
            reportViewer1.LocalReport.ReportEmbeddedResource = "DA_Winform.rptBangCongGroup.rdlc";
            reportViewer1.LocalReport.SubreportProcessing += new Microsoft.Reporting.WinForms.SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DSBCGroup", ds));
            reportViewer1.RefreshReport();
        }
        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            string strMaPB = e.Parameters["paMaPhongBan"].Values[0];
            e.DataSources.Add(new ReportDataSource("DSBCSub", KyCongChiTietBLL.EF_GetWithSpecial(strMaPB, int.Parse(cbb_namrp.Text), int.Parse(cbb_thangrp.Text))));
        }
    }
}
