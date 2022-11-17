using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BLL;

namespace GUI
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        BLL_nhanvien nv = new BLL_nhanvien();
        public string TenDN { get; set; }
        int checkeyprocessbar;
        
        public string phanquyen{ get; set; }
        private void tsdoanhthu_Click(object sender, EventArgs e)
        {
            reportdoanhthu rpdt = new reportdoanhthu();
            rpdt.Show();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            frm_khachhang frkh = new frm_khachhang();
            frkh.phanquyen = phanquyen;
            frkh.Show();
        }

        private void pckhachhang_Click(object sender, EventArgs e)
        {
            frm_khachhang frkh = new frm_khachhang();
            frkh.phanquyen = phanquyen;
            frkh.tendn = TenDN;
            frkh.Show();
        }

        private void pthoadon_Click(object sender, EventArgs e)
        {
            frm_chitiethoadon frcthd = new frm_chitiethoadon();
            frcthd.phanquyen = phanquyen;
            frcthd.Show();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            frm_chitiethoadon frcthd = new frm_chitiethoadon();
            frcthd.phanquyen = phanquyen;
            frcthd.Show();
        }

        private void ptsanpham_Click(object sender, EventArgs e)
        {
            frm_hanghoa frhh = new frm_hanghoa();
            frhh.phanquyen = phanquyen;
            frhh.Show();

        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            frm_hanghoa frhh = new frm_hanghoa();
            frhh.phanquyen = phanquyen;
            frhh.Show();
        }

        private void ptnhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien frnv = new frm_nhanvien();
            
            frnv.Show();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien frnv = new frm_nhanvien();
            frnv.Show();
        }

        private void ptkhohang_Click(object sender, EventArgs e)
        {
            reportkhohang rpkh = new reportkhohang();
            
            rpkh.Show();
        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            reportkhohang rpkh = new reportkhohang();
            rpkh.Show();
        }

        private void pcdoanhthu_Click(object sender, EventArgs e)
        {
            reportdoanhthu rpdt = new reportdoanhthu();
            rpdt.Show();
        }

        private void tsdangxuat_Click(object sender, EventArgs e)
        {
            frmlogin frlg = new frmlogin();
            frlg.Show();
            this.Hide();
        }

        private void tskhachhang_Click(object sender, EventArgs e)
        {
            frm_khachhang kh = new frm_khachhang();
            kh.phanquyen = phanquyen;
            kh.Show();
            
        }

        private void tssanpham_Click(object sender, EventArgs e)
        {
            frm_hanghoa hh = new frm_hanghoa();
            hh.phanquyen = phanquyen;
            hh.Show();
        }

        private void tsnhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien nv = new frm_nhanvien();
            nv.Show();
        }

        private void tshoadon_Click(object sender, EventArgs e)
        {
            frm_chitiethoadon cthd = new frm_chitiethoadon();
            cthd.phanquyen = phanquyen;
            cthd.Show();
        }

        private void tskhohang_Click(object sender, EventArgs e)
        {
            reportkhohang kh = new reportkhohang();
            kh.Show();
        }

        private void tschangepass_Click(object sender, EventArgs e)
        {
            
            frm_changepass cpass = new frm_changepass();
            cpass.TenDN = TenDN;
            cpass.phanquyen = phanquyen;
            cpass.Show();
        }

        private void tscthd_Click(object sender, EventArgs e)
        {
            frm_chitiethoadon frmcthd = new frm_chitiethoadon();
            frmcthd.phanquyen = phanquyen;
            frmcthd.Show();
        }

        private void sthdb_Click(object sender, EventArgs e)
        {
            frm_hoadon frmhd = new frm_hoadon();
            frmhd.phanquyen = phanquyen;
            frmhd.Show();
        }

        private void toolSdangxuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolSdangxuaticon_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn tắt ứng dụng không ?", "Thông Báo", MessageBoxButtons.OKCancel);
            if(traloi == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void tssaoluu_Click(object sender, EventArgs e)
        {
            
            timermain.Start();
            checkeyprocessbar = 1;
           
        }

        public void saoluu()
        {
            string path = "";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F10VF04\SQLEXPRESS;Initial Catalog=Quanlyvatlieuxaydung;Integrated Security=True");
            FolderBrowserDialog dgl = new FolderBrowserDialog();


            if (dgl.ShowDialog() == DialogResult.OK)
            {
                path = dgl.SelectedPath;
                String database = con.Database.ToString();
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + path + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Bạn đã sao lưu thành công");
                con.Close();
            }
        }
        private void tskhoiphuc_Click(object sender, EventArgs e)
        {
            timermain.Start();
            checkeyprocessbar = 2;
           
        }

        public void khoiphuc()
        {
            string path = "";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F10VF04\SQLEXPRESS;Initial Catalog=Quanlyvatlieuxaydung;Integrated Security=True");
            string data = con.Database.ToString();
            con.Open();
            OpenFileDialog dgl = new OpenFileDialog();
            dgl.Filter = "Restore file (*.bak)|*.bak";
            if (dgl.ShowDialog() == DialogResult.OK)
            {
                path = dgl.FileName;
                string database = con.Database.ToString();
                try
                {
                    string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    cmd1.ExecuteNonQuery();

                    string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + path + "' WITH REPLACE;");
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();

                    string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Bạn đã khôi phục thành công");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }




            }
        }

        private void timermain_Tick(object sender, EventArgs e)
        {
            tspbmain.Maximum = 100;
            if (tspbmain.Value < 100)
            {
                tspbmain.Value += 10;
                tslbpbar.Text = tspbmain.Value.ToString() + "%";
            }
            else
            {
                
                if(checkeyprocessbar  == 1)
                {
                    timermain.Dispose();
                    tspbmain.Value = 0;
                    tslbpbar.Text = "0 %";
                    saoluu();
                } else if(checkeyprocessbar == 2)
                {
                    timermain.Dispose();
                    tspbmain.Value = 0;
                    tslbpbar.Text = "0 %";
                    khoiphuc();
                }
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string admin = "AD";
            string member = "NV";
            if(phanquyen.CompareTo(admin)== 0)
            {
                btnnhanvien.Enabled = true;
                ptnhanvien.Enabled = true;
                tsnhanvien.Enabled = true;
                btnkhohang.Enabled = true;
                tskhohang.Enabled = true;
                btndoanhthu.Enabled = true;
                pcdoanhthu.Enabled = true;
                tsdoanhthu.Enabled = true;
                tssaoluu.Enabled = true;
                tskhoiphuc.Enabled = true;
                string cmdtennhanvien = "select TenNV from NHANVIEN WHERE MaNV = '" + TenDN + "' ";
                string cmdchucvunhanvien = "select ChucVu from CHUCVU where MaChucVu = '"+phanquyen+"' ";
                tstendn.Text = nv.gettenNV(cmdtennhanvien);
                tsmaphanuyen.Text = nv.getchucvu(cmdchucvunhanvien);
                


            }
            else if(phanquyen.CompareTo(member)== 0)
            {
                btnnhanvien.Enabled = false;
                nhânViênToolStripMenuItem.Enabled = false;
                ptnhanvien.Enabled = false;

                tsnhanvien.Enabled = false;
                btnkhohang.Enabled = false;
                tồnKhoToolStripMenuItem.Enabled = false;
                tskhohang.Enabled = false;
                btndoanhthu.Enabled = false;
                doanhThuToolStripMenuItem.Enabled = false;
               
                pcdoanhthu.Enabled = false;
                tssaoluu.Enabled = false;
                saoLưuToolStripMenuItem.Enabled = false;
                tskhoiphuc.Enabled = false;
                khôiPhụcToolStripMenuItem.Enabled = false;
                tsdoanhthu.Enabled = false;
                
                tstendn.Text = TenDN;
                tsmaphanuyen.Text= phanquyen;
                string cmdtennhanvien = "select TenNV from NHANVIEN WHERE MaNV = '" + TenDN + "' ";
                string cmdchucvunhanvien = "select ChucVu from CHUCVU where MaChucVu = '" + phanquyen + "' ";
                tstendn.Text = nv.gettenNV(cmdtennhanvien);
                tsmaphanuyen.Text = nv.getchucvu(cmdchucvunhanvien);

            }
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QLVLXDhelp.chm");
        }

        private void tspbmain_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss tt");
            tsgio.Text = s;
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timermain.Start();
            checkeyprocessbar = 1;
        }

        private void khôiPhụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timermain.Start();
            checkeyprocessbar = 2;
        }

        private void hướngDẫnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QLVLXDhelp.chm");
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_changepass cpass = new frm_changepass();
            cpass.TenDN = this.TenDN;
            cpass.phanquyen = this.phanquyen;
            cpass.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin frlg = new frmlogin();
            frlg.Show();
            this.Hide();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhanvien nv = new frm_nhanvien();
            nv.Show();
        }

        private void hóaĐơnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_hoadon frmhd = new frm_hoadon();
            frmhd.phanquyen = phanquyen;
            frmhd.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_chitiethoadon frmcthd = new frm_chitiethoadon();
            frmcthd.phanquyen = phanquyen;
            frmcthd.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_hanghoa hh = new frm_hanghoa();
            hh.phanquyen = phanquyen;
            hh.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_khachhang kh = new frm_khachhang();
            kh.phanquyen = phanquyen;
            kh.Show();
        }
    }
}
