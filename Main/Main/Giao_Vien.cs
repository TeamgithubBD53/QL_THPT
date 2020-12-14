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

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTenGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGTGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinhGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLuong.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbMonHoc.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch
            {

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            txtTKGV.Enabled = cbTKGV.Enabled = true;
            chon = 1;
        }
    }
}
