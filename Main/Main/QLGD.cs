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
    public partial class QLGD : Form
    {
        public QLGD()
        {
            InitializeComponent();
        }
        Lop l = new Lop();
        MonHon mh = new MonHon();
        GiaoVien gv = new GiaoVien();
        CTGD ct = new CTGD();
        int selection = 0;

        public void SetNull()
        {
            txtTiet.Text = "";
            cboTenMon.Enabled = cboTenGV.Enabled = true;
        }

        private void QLGD_Load(object sender, EventArgs e)
        {
            
            cboTenLop.DisplayMember = "TenLop";
            cboTenLop.ValueMember = "MaLop";
            cboTenLop.SelectedValue = "MaLop";
            cboTenLop.SelectedIndex = 0;
          
            cboTenMon.DisplayMember = "TenMon";
            cboTenMon.ValueMember = "MaMon";
            cboTenMon.SelectedValue = "MaMon";
            cboTenMon.SelectedIndex = 0;
            cboTenMon.Enabled = cboTenGV.Enabled = txtTiet.Enabled = dateTimePicker1.Enabled = false;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < cboTenMon.Items.Count; i++)
            {
                cboTenMon.SelectedIndex = i;
                if (cboTenMon.Text == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) break;
            }
            for (int i = 0; i < cboTenGV.Items.Count; i++)
            {
                cboTenGV.SelectedIndex = i;
                if (cboTenGV.Text == dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) break;
            }
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTiet.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            SetNull();
            selection = 1;
            cboTenLop.Enabled = cboTenGV.Enabled = cboTenMon.Enabled = dateTimePicker1.Enabled = txtTiet.Enabled = true;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            cboTenMon.Enabled = cboTenGV.Enabled = true;
            cboTenLop.Enabled = false;
            txtTiet.Enabled = false;
            dateTimePicker1.Enabled = false;
            selection = 2;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cboTenMon.SelectedValue.ToString());
            ct.XoaCTGD(cboTenLop.Text, dateTimePicker1.Text, txtTiet.Text);
            dataGridView1.DataSource = ct.Show(cboTenMon.Text);
            MessageBox.Show("Xóa dữ liệu thành công");
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
