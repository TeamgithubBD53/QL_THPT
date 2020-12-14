using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Main
{
    public partial class Giao_Vien : Form
    {
        public Giao_Vien()
        {
            InitializeComponent();
        }
        GiaoVien gv = new GiaoVien();
        int chon;
        TimKiem tk = new TimKiem();
        public void KhoiTao()
        {
            txtHoTenGV.Enabled = txtLuong.Enabled = txtSDT.Enabled = cbGTGV.Enabled = cbMonHoc.Enabled = txtDiaChi.Enabled = false;
            dtpNgaySinhGV.Enabled = false;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void Mo()
        {
            txtHoTenGV.Enabled = txtLuong.Enabled = txtSDT.Enabled = cbGTGV.Enabled = cbMonHoc.Enabled = txtDiaChi.Enabled = true;
            dtpNgaySinhGV.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        public void SetNull()
        {
            txtMaGV.Text = txtHoTenGV.Text = txtDiaChi.Text = txtLuong.Text = cbGTGV.Text = cbMonHoc.Text = cbTKGV.Text = txtTKGV.Text = txtSDT.Text = "";
            dtpNgaySinhGV.Text = DateTime.Now.ToShortDateString();
        }
    }
}
