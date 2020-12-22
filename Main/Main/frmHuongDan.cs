using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Main
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void GetFileAll(string tenfile)
        {
            StreamReader doc = File.OpenText("../../../Resource/"+ tenfile);
            string s = doc.ReadToEnd();
            txtGioiThieu.Text = s;
        }


        private void GetImgAll(string tenimg)
        {
            Image img = Image.FromFile("../../../Resource/"+ @tenimg);
            pictureBox1.BackgroundImage = img;
        }


        private void trViewGioiThieu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "gtPhanMem")
            {
                GetFileAll("GioiThieuChung.txt");
                GetImgAll(@"1_Ngaykhaigiang.jpg");
            }
            else if (e.Node.Name == "gtDangNhap")
            {
                GetFileAll("PhanDangNhap.txt");
                GetImgAll(@"b2 dang nhap.png");
            }
            else if (e.Node.Name == "gtManHinhChinh")
            {
                GetFileAll("PhanMain.txt");
                GetImgAll(@"b2 main.png");
            }
            else if (e.Node.Name == "gtGiaoVien")
            {
                GetFileAll("PhanQuanLyGiaoVien.txt");
                GetImgAll(@"b2 giao vien.png");
            }
            else  if (e.Node.Name == "gtHocSinh")
            {
                GetFileAll("PhanQuanLyHocSinh.txt");
                GetImgAll(@"b2 hoc sinh.png");
            }
            else if (e.Node.Name == "gtQLGD")
            {
                GetFileAll("PhanQuanLyQLGD.txt");
                GetImgAll(@"b2 ttgd.png");
            }
        }

        private void frmHuongDan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
