using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;
using DTO;
using BLL;

namespace GUI
{
    public partial class frm_hoadon : Form
    {
        public frm_hoadon()
        {
            InitializeComponent();
        }

        BLL_hoadon bllhoadon = new BLL_hoadon();
        int check;
        writelogactivities wr = new writelogactivities();
        public string phanquyen { get; set; }
        private void frm_hoadon_Load(object sender, EventArgs e)
        {
            wr.WriteLog("", "Bảng Hóa Đơn", "Truy cập", "");
            loaddata();
            buttonmacdinh();
            loadbtnclickdg();
            btnphanquyen();
        }

        public void btnphanquyen()
        {
            string admin = "AD";
            string member = "NV";
            if (phanquyen.CompareTo(admin) == 0)
            {

                
            }
            else if (phanquyen.CompareTo(member) == 0)
            {
                btnsua.Enabled = false;
            }
        }

        public void buttonmacdinh()
        {
            txttimkiem.Enabled = true;
            btntimkiem.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmaHD.Enabled = false;
            txttongtien.Enabled = false;
            cbkhachhang.Enabled = false;
            cbnhanvien.Enabled = false;
            dtngayban.Enabled = false;



        }

        public void distextbox()
        {
            txttongtien.Enabled = false;
            txtmaHD.Enabled = false;
            cbnhanvien.Enabled = false;
            cbkhachhang.Enabled = false;
            dtngayban.Enabled = false;
        }
        public void enbtextbox()
        {
            txtmaHD.Enabled = true;
            txttongtien.Enabled = true;
            cbkhachhang.Enabled = true;
            cbnhanvien.Enabled = true;
            dtngayban.Enabled = true;

        }
        public void loadbtnclickdg()
        {
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btntimkiem.Enabled = true;
            txttimkiem.Enabled = true;
        }

        public void cleartextbox()
        {
            txttongtien.Clear();
            txtmaHD.Clear();
            dtngayban.Text = DateTime.Now.ToShortDateString();


        }

        public void btnthemxoasua()
        {
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btntimkiem.Enabled = true;
        }
        public void loadbtnclickadd()
        {
            cleartextbox();
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnxoa.Enabled = false;
            btntimkiem.Enabled = true;
            btnsua.Enabled = false;


        }
        public void saukhiclick()
        {
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnxoa.Enabled = false;
            btntimkiem.Enabled = true;
            btnsua.Enabled = false;
            btnthem.Enabled = false;
            txttimkiem.Enabled = true;
        }

        private void loaddata()
        {
            string cmd = "";
            dgHoadon.DataSource = bllhoadon.readdatadg(cmd);
            cbkhachhang.DataSource = bllhoadon.readdataKH(cmd);
            cbnhanvien.DataSource = bllhoadon.readdataNV(cmd);

            if (dgHoadon.Rows.Count > 0)
            {
                dgHoadon.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
                dgHoadon.Columns["MaHD"].Width = 100;
                dgHoadon.Columns["MaNV"].Width = 100;
                dgHoadon.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
                dgHoadon.Columns["MaKH"].Width = 110;
                dgHoadon.Columns["MaKH"].HeaderText = "Mã Khách hàng";
                dgHoadon.Columns["NgayBan"].Width = 110;
                dgHoadon.Columns["NgayBan"].HeaderText = "Ngày Bán";
                dgHoadon.Columns["TongTienBan"].Width = 110;
                dgHoadon.Columns["TongTienBan"].HeaderText = "Tổng Tiền Bán";
                dgHoadon.AllowUserToAddRows = false;
                dgHoadon.EditMode = DataGridViewEditMode.EditProgrammatically;

            }

            if (cbnhanvien != null)
            {

                cbnhanvien.DisplayMember = "TenNV";
                cbnhanvien.ValueMember = "MaNV";
                dgHoadon.AllowUserToAddRows = false;
                dgHoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

            if (cbkhachhang != null)
            {

                cbkhachhang.DisplayMember = "TenKH";
                cbkhachhang.ValueMember = "MaKH";
                dgHoadon.AllowUserToAddRows = false;
                dgHoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        }

        public Boolean kiemtrarong()
        {
            bool kiemtra;
            if (txtmaHD.Text == " " || txttongtien.Text == " ")
            {
                kiemtra = false;
            }
            else
            {
                kiemtra = true;
            }
            return kiemtra;
        }

        private void dgHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgHoadon.CurrentRow.Index;
            txtmaHD.Text = dgHoadon.Rows[i].Cells[0].Value.ToString();
            cbnhanvien.SelectedValue = dgHoadon.Rows[i].Cells[1].Value.ToString();
            cbkhachhang.SelectedValue = dgHoadon.Rows[i].Cells[2].Value.ToString();
            dtngayban.Text = dgHoadon.Rows[i].Cells[3].Value.ToString();
            txttongtien.Text = dgHoadon.Rows[i].Cells[4].Value.ToString();
            loadbtnclickdg();
            btnphanquyen();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            loadbtnclickadd();
            btnthem.Enabled = false;
            check = 1;
            enbtextbox();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            saukhiclick();
            check = 3;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            check = 2;
            saukhiclick();
            enbtextbox();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            loaddata();
            buttonmacdinh();
            btnthemxoasua();
            txttimkiem.Clear();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                txttongtien.Text = "0";
                DTO_hoadon dtohoadon = new DTO_hoadon(txtmaHD.Text, cbnhanvien.SelectedValue.ToString(), cbkhachhang.SelectedValue.ToString(), dtngayban.Text, txttongtien.Text);
                string cmd = " ";
                if (kiemtrarong() == false)
                {
                    wr.WriteLog("", "Bảng Hóa Đơn", "Thêm", "");
                    MessageBox.Show("Bạn đã để trống hãy kiểm tra ", "Thông Báo");
                }
                else
                {
                    if (bllhoadon.them(cmd, dtohoadon) == true)
                    {
                        loaddata();
                        saukhiclick();
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        btnphanquyen();

                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm được !!!!", "Thông báo");
                    }
                }



            }
            if (check == 2)
            {
                DTO_hoadon dtohoadon = new DTO_hoadon(txtmaHD.Text, cbnhanvien.SelectedValue.ToString(), cbkhachhang.SelectedValue.ToString(), dtngayban.Text, txttongtien.Text);
                string cmd = " ";
                if (bllhoadon.sua(cmd, dtohoadon) == true)
                {
                    loaddata();
                    saukhiclick();
                    wr.WriteLog("", "Bảng Hóa Đơn", "Sửa", "");
                    MessageBox.Show("Sửa Thông Tin Thành Công", "Thông Báo");
                    btnphanquyen();
                }
                else
                {
                    MessageBox.Show("Không thể sửa Thông Tin !!!!", "Thông báo");
                }
            }

            if (check == 3)
            {

                DTO_hoadon dtohoadon = new DTO_hoadon(txtmaHD.Text, cbnhanvien.SelectedValue.ToString(), cbkhachhang.SelectedValue.ToString(), dtngayban.Text, txttongtien.Text);
                string cmd = " ";
                if (bllhoadon.xoa(cmd, dtohoadon) == true)
                {
                    wr.WriteLog("", "Bảng Hóa Đơn", "Xóa", "");
                    loaddata();
                    saukhiclick();
                    MessageBox.Show("Xóa  Thành Công", "Thông Báo");
                    btnphanquyen();
                }
                else
                {
                    MessageBox.Show("Không Xoá Được !!!!", "Thông báo");
                }
            }

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string cmd = " ";
            btnhuy.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            btnphanquyen();
            if (txttimkiem.Text == "")
            {
                MessageBox.Show("Hãy nhập tên sản phẩm cần tìm", "Thông báo");

            }
            else
            {
                DTO_hoadon dtohoadon = new DTO_hoadon(txtmaHD.Text, cbnhanvien.SelectedValue.ToString(), cbkhachhang.SelectedValue.ToString(), dtngayban.Text, txttongtien.Text);
                DataTable dt = bllhoadon.timkiem(cmd, dtohoadon);
                wr.WriteLog("", "Bảng Hóa Đơn", "Tìm kiếm", "");
                if (dt == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Thông báo");
                }
                dgHoadon.DataSource = dt;
            }
        }

        private void dgHoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            frm_chitiethoadon frcthd = new frm_chitiethoadon();
            int  i = dgHoadon.CurrentRow.Index;
            frcthd.MaHD = dgHoadon.Rows[i].Cells[0].Value.ToString();
            frcthd.phanquyen = this.phanquyen;
            frcthd.Show();
        }
    }
}
