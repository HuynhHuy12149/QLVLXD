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
    public partial class frm_nhanvien : Form
    {
        public frm_nhanvien()
        {
            InitializeComponent();
        }
        BLL_nhanvien bllnhanvien = new BLL_nhanvien();
        int check;
        writelogactivities wr = new writelogactivities();
        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            wr.WriteLog("", "Bảng Nhân viên", "Truy cập", "");
            loaddata();
            buttonmacdinh();
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
            txtmanv.Enabled = false;
            txttennv.Enabled = false;
            txtdiachi.Enabled = false;
            txtmatkhau.Enabled = false;
            cbchucvu.Enabled = false;
            txtsdt.Enabled = false;
            dtngaysinh.Enabled = false;
            cbgioitinh.Enabled = false;
            txttendn.Enabled = false;
            txtmatkhau.Enabled = false;


        }

        public void distextbox()
        {
            txtmanv.Enabled = false;
            txttennv.Enabled = false;
            txtdiachi.Enabled = false;
            txtmatkhau.Enabled = false;
            cbchucvu.Enabled = false;
            txtsdt.Enabled = false;
            dtngaysinh.Enabled = false;
            cbgioitinh.Enabled = false;
            txttendn.Enabled = false;
            txtmatkhau.Enabled = false;
        }
        public void enbtextbox()
        {
            txtmanv.Enabled = true;
            txttennv.Enabled = true;
            txtdiachi.Enabled = true;
            txtmatkhau.Enabled = true;
            cbchucvu.Enabled = true;
            txtsdt.Enabled = true;
            dtngaysinh.Enabled = true;
            cbgioitinh.Enabled = true;
            txttendn.Enabled = true;
            txtmatkhau.Enabled = true;
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
            txtmanv.Clear();
            txttendn.Clear();
            txttennv.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtmatkhau.Clear();
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
            dgnhanvien.DataSource = bllnhanvien.readdatanv(cmd);
            cbchucvu.DataSource = bllnhanvien.readdatachucvu(cmd);
            if (dgnhanvien.Rows.Count > 0)
            {
                dgnhanvien.Columns["MaNV"].HeaderText = "Mã số";
                dgnhanvien.Columns["MaNV"].Width = 100;
                dgnhanvien.Columns["TenNV"].Width = 100;
                dgnhanvien.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
                dgnhanvien.Columns["MaChucVu"].Width = 110;
                dgnhanvien.Columns["MaChucVu"].HeaderText = "Mã Chức vụ";
                dgnhanvien.Columns["DiachiNV"].Width = 110;
                dgnhanvien.Columns["DiaChiNV"].HeaderText = "Địa Chỉ";
                dgnhanvien.Columns["SDT"].Width = 90;
                dgnhanvien.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dgnhanvien.Columns["GioiTinh"].Width = 50;
                dgnhanvien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgnhanvien.Columns["NgaySinh"].Width = 160;
                dgnhanvien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgnhanvien.Columns["TenDN"].Width = 160;
                dgnhanvien.Columns["TenDN"].HeaderText = "Uername";
                dgnhanvien.Columns["PassDN"].Width = 160;
                dgnhanvien.Columns["PassDN"].HeaderText = "Password";
                dgnhanvien.AllowUserToAddRows = false;
                dgnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;

            }
            if (cbchucvu != null)
            {

                cbchucvu.DisplayMember = "ChucVu";
                cbchucvu.ValueMember = "MaChucVu";
                dgnhanvien.AllowUserToAddRows = false;
                dgnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        public Boolean kiemtrarong()
        {
            bool kiemtra;
            if (txtmanv.Text == " " || txttennv.Text == " " || txtdiachi.Text == " " || txttendn.Text == " " || txtmatkhau.Text == " ")
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


            txtmanv.Text = dgnhanvien.Rows[i].Cells[0].Value.ToString();
            txttennv.Text = dgnhanvien.Rows[i].Cells[1].Value.ToString();
            cbchucvu.SelectedValue = dgnhanvien.Rows[i].Cells[2].Value.ToString();
            txtdiachi.Text = dgnhanvien.Rows[i].Cells[3].Value.ToString();
            txtsdt.Text = dgnhanvien.Rows[i].Cells[4].Value.ToString();

            cbgioitinh.Text = dgnhanvien.Rows[i].Cells[5].Value.ToString();
            dtngaysinh.Text = dgnhanvien.Rows[i].Cells[6].Value.ToString();
            txttendn.Text = dgnhanvien.Rows[i].Cells[7].Value.ToString();
            txtmatkhau.Text = dgnhanvien.Rows[i].Cells[8].Value.ToString();
            loadbtnclickdg();
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
                DTO_nhanvien dtonhanvien = new DTO_nhanvien(txtmanv.Text, txttennv.Text, cbchucvu.SelectedValue.ToString(), txtdiachi.Text, txtsdt.Text, cbgioitinh.SelectedItem.ToString(), dtngaysinh.Text, txttendn.Text, txtmatkhau.Text);
                string cmd = " ";
                if (kiemtrarong() == false)
                {
                    MessageBox.Show("Bạn đã để trống hãy kiểm tra ", "Thông Báo");
                }
                else
                {
                    if (bllnhanvien.themnhanvien(cmd, dtonhanvien) == true)
                    {
                        loaddata();
                        wr.WriteLog("", "Bảng Nhân viên", "Thêm", "");
                        MessageBox.Show("Thêm Nhân Viên Thành Công", "Thông Báo");

                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm được !!!!", "Thông báo");
                    }
                }



            }
            if (check == 2)
            {
                DTO_nhanvien dtonhanvien = new DTO_nhanvien(txtmanv.Text, txttennv.Text, cbchucvu.SelectedValue.ToString(), txtdiachi.Text, txtsdt.Text, cbgioitinh.SelectedItem.ToString(), dtngaysinh.Text, txttendn.Text, txtmatkhau.Text);
                string cmd = " ";
                if (bllnhanvien.suanhanvien(cmd, dtonhanvien) == true)
                {
                    wr.WriteLog("", "Bảng Nhân viên", "Sửa", "");
                    loaddata();
                    MessageBox.Show("Sửa Thông Tin Thành Công", "Thông Báo");

                }
                else
                {
                    MessageBox.Show("Không thể sửa Thông Tin !!!!", "Thông báo");
                }
            }

            if (check == 3)
            {
                DTO_nhanvien dtonhanvien = new DTO_nhanvien(txtmanv.Text, txttennv.Text, cbchucvu.SelectedValue.ToString(), txtdiachi.Text, txtsdt.Text, cbgioitinh.SelectedItem.ToString(), dtngaysinh.Text, txttendn.Text, txtmatkhau.Text);
                string cmd = " ";
                if (bllnhanvien.xoanhanvien(cmd, dtonhanvien) == true)
                {
                    loaddata();
                    wr.WriteLog("", "Bảng Nhân viên", "Xóa", "");
                    MessageBox.Show("Xóa Nhân Viên Thành Công", "Thông Báo");

                }
                else
                {
                    MessageBox.Show("Không Xoá Được !!!!", "Thông báo");
                }
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DTO_nhanvien dtonhanvien = new DTO_nhanvien(txtmanv.Text, txttimkiem.Text, cbchucvu.SelectedValue.ToString(), txtdiachi.Text, txtsdt.Text, cbgioitinh.SelectedItem.ToString(), dtngaysinh.Text, txttendn.Text, txtmatkhau.Text);
            string cmd = " ";
            btnhuy.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;

            if (txttimkiem.Text == "")
            {
                MessageBox.Show("Hãy nhập tên sản phẩm cần tìm", "Thông báo");

            }
            else
            {

                DataTable dt = bllnhanvien.timkiemnhanvien(cmd, dtonhanvien);
                wr.WriteLog("", "Bảng Nhân viên", "Tìm kiếm", "");
                if (dt == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng", "Thông báo");
                }
                dgnhanvien.DataSource = dt;
            }
        }
    }
}
