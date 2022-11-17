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
using System.Data.SqlClient;
using DTO;
using BLL;

namespace GUI
{
    public partial class frm_hanghoa : Form
    {
        public frm_hanghoa()
        {
            InitializeComponent();
        }
        public string phanquyen { get; set; }
        BLL_hanghoa bllhanghoa = new BLL_hanghoa();
        int check;
        writelogactivities wr = new writelogactivities();
        private void frm_hanghoa_Load(object sender, EventArgs e)
        {
            wr.WriteLog("", "Bảng Hàng Hóa", "Truy Cập", "");
            loaddata();
            buttonmacdinh();
            btnphanquyen();
        }

        public void btnphanquyen()
        {
            string admin = "AD";
            string member = "NV";
            if (phanquyen.CompareTo(admin) == 0)
            {
                return;
            }
            else if (phanquyen.CompareTo(member) == 0)
            {
                btnsua.Enabled = false;
            }
        }
        public void buttonmacdinh()
        {
            txttimkiem.Enabled = false;
            btntimkiem.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmasp.Enabled = false;
            txttensp.Enabled = false;
            txtdonvitinh.Enabled = false;
            txtgiaban.Enabled = false;
            cbtennhom.Enabled = false;
            txtgianhap.Enabled = false;
            cbnhacungcap.Enabled = false;
            txtsoluong.Enabled = false;


        }

        public void distextbox()
        {
            txtmasp.Enabled = false;
            txttensp.Enabled = false;
            txtdonvitinh.Enabled = false;
            txtsoluong.Enabled = false;
            cbnhacungcap.Enabled = false;
            cbtennhom.Enabled = false;
            txtgianhap.Enabled = false;
            txtgiaban.Enabled = false;
        }
        public void enbtextbox()
        {
            txtmasp.Enabled = true;
            txttensp.Enabled = true;
            txtsoluong.Enabled = true;
            txtgiaban.Enabled = true;
            cbtennhom.Enabled = true;
            txtgianhap.Enabled = true;
            txtdonvitinh.Enabled = true;
            cbnhacungcap.Enabled = true;

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
            txtmasp.Clear();
            txtgiaban.Clear();
            txtgianhap.Clear();
            txtdonvitinh.Clear();
            txttensp.Clear();
            txtsoluong.Clear();

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
        }

        private void loaddata()
        {
            string cmd = "";
            dgnhanvien.DataSource = bllhanghoa.readdataHH(cmd);
            cbnhacungcap.DataSource = bllhanghoa.readdataNCC(cmd);
            cbtennhom.DataSource = bllhanghoa.readdataNhom(cmd);
            if (dgnhanvien.Rows.Count > 0)
            {
                dgnhanvien.Columns["MaSP"].HeaderText = "Mã sản phẩm";
                dgnhanvien.Columns["MaSP"].Width = 100;
                dgnhanvien.Columns["MaNhom"].Width = 100;
                dgnhanvien.Columns["MaNhom"].HeaderText = "Mã nhóm";
                dgnhanvien.Columns["TenSP"].Width = 110;
                dgnhanvien.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
                dgnhanvien.Columns["DonViTinh"].Width = 110;
                dgnhanvien.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
                dgnhanvien.Columns["SLTon"].Width = 90;
                dgnhanvien.Columns["SLTon"].HeaderText = "Số Lượng Tồn";
                dgnhanvien.Columns["GiaBan"].Width = 50;
                dgnhanvien.Columns["GiaBan"].HeaderText = "Giá Bán";
                dgnhanvien.Columns["GiaNhap"].Width = 160;
                dgnhanvien.Columns["GiaNhap"].HeaderText = "Giá Nhập";
                dgnhanvien.Columns["MaNCC"].Width = 160;
                dgnhanvien.Columns["MaNCC"].HeaderText = "Mã Nhà Cung Cấp";

                dgnhanvien.AllowUserToAddRows = false;
                dgnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;

            }
            if (cbnhacungcap != null)
            {

                cbnhacungcap.DisplayMember = "TenNCC";
                cbnhacungcap.ValueMember = "MaNCC";
                dgnhanvien.AllowUserToAddRows = false;
                dgnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

            if (cbtennhom != null)
            {

                cbtennhom.DisplayMember = "TenNhom";
                cbtennhom.ValueMember = "MaNhom";
                dgnhanvien.AllowUserToAddRows = false;
                dgnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        public Boolean kiemtrarong()
        {
            bool kiemtra;
            if (txtmasp.Text == " " || txttensp.Text == " " || txtsoluong.Text == " " || txtdonvitinh.Text == " " || txtgiaban.Text == " " || txtgianhap.Text == "")
            {
                kiemtra = false;
            }
            else
            {
                kiemtra = true;
            }
            return kiemtra;
        }
        private void dgnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgnhanvien.CurrentRow.Index;


            txtmasp.Text = dgnhanvien.Rows[i].Cells[0].Value.ToString();
            cbtennhom.SelectedValue = dgnhanvien.Rows[i].Cells[1].Value.ToString();
            txttensp.Text = dgnhanvien.Rows[i].Cells[2].Value.ToString();
            txtdonvitinh.Text = dgnhanvien.Rows[i].Cells[3].Value.ToString();
            txtsoluong.Text = dgnhanvien.Rows[i].Cells[4].Value.ToString();

            txtgianhap.Text = dgnhanvien.Rows[i].Cells[5].Value.ToString();
            txtgiaban.Text = dgnhanvien.Rows[i].Cells[6].Value.ToString();
            cbnhacungcap.SelectedValue = dgnhanvien.Rows[i].Cells[7].Value.ToString();

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
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                DTO_hanghoa dtohanghoa = new DTO_hanghoa(txtmasp.Text, cbtennhom.SelectedValue.ToString(), txttensp.Text, txtdonvitinh.Text, txtsoluong.Text, txtgiaban.Text, txtgianhap.Text, cbnhacungcap.SelectedValue.ToString());
                string cmd = " ";
                if (kiemtrarong() == false)
                {
                    MessageBox.Show("Bạn đã để trống hãy kiểm tra ", "Thông Báo");
                }
                else
                {
                    if (bllhanghoa.them(cmd, dtohanghoa) == true)
                    {
                        wr.WriteLog("", "Bảng Hàng Hóa", "Thêm", "");
                        loaddata();
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
                DTO_hanghoa dtohanghoa = new DTO_hanghoa(txtmasp.Text, cbtennhom.SelectedValue.ToString(), txttensp.Text, txtdonvitinh.Text, txtsoluong.Text, txtgiaban.Text, txtgianhap.Text, cbnhacungcap.SelectedValue.ToString());
                string cmd = " ";
                if (bllhanghoa.sua(cmd, dtohanghoa) == true)
                {
                    wr.WriteLog("", "Bảng Hàng Hóa", "Sửa", "");
                    loaddata();
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
                DTO_hanghoa dtohanghoa = new DTO_hanghoa(txtmasp.Text, cbtennhom.SelectedValue.ToString(), txttensp.Text, txtdonvitinh.Text, txtsoluong.Text, txtgiaban.Text, txtgianhap.Text, cbnhacungcap.SelectedValue.ToString());
                string cmd = " ";
                if (bllhanghoa.xoa(cmd, dtohanghoa) == true)
                {
                    wr.WriteLog("", "Bảng Hàng Hóa", "Xóa", "");
                    loaddata();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
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
            DTO_hanghoa dtohanghoa = new DTO_hanghoa(txtmasp.Text, cbtennhom.SelectedValue.ToString(), txttimkiem.Text, txtdonvitinh.Text, txtsoluong.Text, txtgiaban.Text, txtgianhap.Text, cbnhacungcap.SelectedValue.ToString());
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

                DataTable dt = bllhanghoa.timkiem(cmd, dtohanghoa);
                wr.WriteLog("", "Bảng Hàng Hóa", "Tìm Kiếm", "");
                if (dt == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Thông báo");
                }
                dgnhanvien.DataSource = dt;
            }
        }
    }
}
