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
    public partial class frm_chitiethoadon : Form
    {
        public frm_chitiethoadon()
        {
            InitializeComponent();
        }
       
        public string phanquyen { get; set; }
        BLL_cthd bllcthd = new BLL_cthd();
        int check;
        DTO_cthd dtocthd = new DTO_cthd();
        DTO_nhanvien nv = new DTO_nhanvien();
        string soluongton;
        int soluongban;
        string dongiaban;
        writelogactivities wr = new writelogactivities();
        public string MaHD { get; set; }
        private void frm_chitiethoadon_Load(object sender, EventArgs e)
        {
            wr.WriteLog("", "Bảng CTHD", "Truy Cập","");

            loaddata();
            
            loaddg();
            
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
                return;
            }
            else if (phanquyen.CompareTo(member) == 0)
            {
                btnsua.Enabled = false;
            }
        }
        private void dgcthd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgcthd.CurrentRow.Index;
            cbhoadon.SelectedValue = dgcthd.Rows[i].Cells[0].Value.ToString();
            cbsanpham.SelectedValue = dgcthd.Rows[i].Cells[1].Value.ToString();
            txtsoluong.Text = dgcthd.Rows[i].Cells[2].Value.ToString();
            txtdongia.Text = dgcthd.Rows[i].Cells[3].Value.ToString();
            txtthanhtiensp.Text = dgcthd.Rows[i].Cells[4].Value.ToString();
            loadbtnclickdg();
            btnphanquyen();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            check = 1;
            enbtextbox();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            check = 3;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            check = 2;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;

            enbtextbox();
        }

     
        private void btnhuy_Click(object sender, EventArgs e)
        {
            loaddata();
            loaddg();
            buttonmacdinh();
           
            btnphanquyen();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {

                DTO_cthd dtocthd = new DTO_cthd(cbhoadon.SelectedValue.ToString(), cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);
                string cmd = " ";
                if (kiemtrarong() == false )
                {
                    MessageBox.Show("Bạn đã để trống hãy kiểm tra ", "Thông Báo");
                }
                else
                {
                    if (bllcthd.them(cmd, dtocthd) == true )
                    {
                        loaddata();
                        loaddg();
                        tongtienhoadon();
                        buttonmacdinh();
                        wr.WriteLog("", "Bảng CTHD", "Thêm", "");
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
                DTO_cthd dtocthd = new DTO_cthd(cbhoadon.SelectedValue.ToString(), cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);
                string cmd = " ";
                if (bllcthd.sua(cmd, dtocthd) == true )
                {
                    wr.WriteLog("", "Bảng CTHD", "Sửa", "");
                    loaddata();
                    buttonmacdinh();
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
                DTO_cthd dtocthd = new DTO_cthd(cbhoadon.SelectedValue.ToString(), cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);
                string cmd = " ";
                if (bllcthd.xoa(cmd, dtocthd) == true )
                {
                    wr.WriteLog("", "Bảng CTHD", "Xóa", "");
                    loaddata();
                    loaddg();
                    buttonmacdinh();
                    MessageBox.Show("Xóa  Thành Công", "Thông Báo");
                    btnphanquyen();
                    
                }
                else
                {
                    MessageBox.Show("Không Xoá Được !!!!", "Thông báo");
                }
            }
        }

        private void cbsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddongia();
            loadsoluongkho();
          
        }

        private void cbhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadmakh();
            loadmanv();
            loaddg();
            tongtienhoadon();
            
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            int slton;
            int.TryParse(soluongton, out slton);

            if (int.TryParse(txtsoluong.Text, out soluongban) || txtsoluong.Text == "")
            {

                if (soluongban > slton)
                {
                    MessageBox.Show("Bạn không được nhập quá mức số lượng tồn", "Thông Báo");
                }
                else
                {
                    txtthanhtiensp.Text = (Convert.ToInt32(dongiaban) * Convert.ToInt32(soluongban)).ToString();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập số", "Thông Báo");
            }
        }
        private void btninhoadon_Click(object sender, EventArgs e)
        {
            wr.WriteLog("", "Bảng CTHD", "In Hóa Đơn", "");
            reporthoadonban rp = new reporthoadonban();
            rp.MaHD = cbhoadon.SelectedValue.ToString();
            rp.Show();
        }


        public void buttonmacdinh()
        {
            btninhoadon.Enabled = false;
            txttongtienhd.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtdongia.Enabled = false;
            cbhoadon.Enabled = true;
            cbmakh.Enabled = false;
            txttennv.Enabled = false;
            dtngayban.Enabled = false;
            txtsoluongkho.Enabled = false;
            txtthanhtiensp.Enabled = false;
            txtdiachikh.Enabled = false;
            txtsdtkh.Enabled = false;
            dtngayban.Enabled = false;
            txttongtienhd.Enabled = false;
            txttenkh.Enabled = false;
            cbmanv.Enabled = false;




        }

        public void distextbox()
        {
            cbsanpham.Enabled = false;
            txtsoluong.Enabled = false;
            txtthanhtiensp.Enabled = false;
            txtdongia.Enabled = false;
        }
        public void enbtextbox()
        {
            cbsanpham.Enabled = true;
            txtsoluong.Enabled = true;
            txttennv.Enabled = false;
            txtdongia.Enabled = true;


        }
        public void loadbtnclickdg()
        {
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btninhoadon.Enabled = true;
            

        }

        public void cleartextbox()
        {
            txtdongia.Clear();
            txtsoluong.Clear();



        }
        public void loadbtnclickadd()
        {
            cleartextbox();
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;


        }
     

        private void loaddata()
        {
            string cmd = "";

            
            
            cbsanpham.DataSource = bllcthd.readdatasp(cmd);
            cbhoadon.DataSource = bllcthd.readdatahd(cmd);



           

            if (cbsanpham.Items.Count > 0)
            {

                cbsanpham.DisplayMember = "TenSP";
                cbsanpham.ValueMember = "MaSP";
                dgcthd.AllowUserToAddRows = false;
                dgcthd.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

            if (cbhoadon.Items.Count > 0)
            {

                cbhoadon.DisplayMember = "MaHD";
                cbhoadon.ValueMember = "MaHD";
                dgcthd.AllowUserToAddRows = false;
                dgcthd.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            
            loaddg();

         
            loadmanv();
            loadtennv();
            loadmakh();
            loadtenkh();
            loadngayban();
            loaddiachi();
            loadsdt();
            loaddongia();
            loadsoluongkho();
            tongtienhoadon();


        }
        private void loaddg()
        {
            string cmd = "";
            
            DTO_cthd dtocthd = new DTO_cthd(cbhoadon.SelectedValue.ToString(), cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);
            dgcthd.DataSource = bllcthd.readdatadgcthd(cmd, dtocthd);
            if (dgcthd.Rows.Count > 0)
            {
                dgcthd.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
                dgcthd.Columns["MaHD"].Width = 100;
                dgcthd.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
                dgcthd.Columns["MaSP"].Width = 120;
                dgcthd.Columns["SLBan"].Width = 120;
                dgcthd.Columns["SLBan"].HeaderText = "Số Lượng Bán";
                dgcthd.Columns["DonGiaBan"].Width = 200;
                dgcthd.Columns["DonGiaBan"].HeaderText = "Đơn Giá";
                dgcthd.Columns["ThanhTienBan"].Width = 170;
                dgcthd.Columns["ThanhTienBan"].HeaderText = "Thành Tiền Sản Phẩm";
                dgcthd.AllowUserToAddRows = false;
                dgcthd.EditMode = DataGridViewEditMode.EditProgrammatically;

            }

        }
        private void loaddatacbchange()
        {
            string cmd = "";
            
            DTO_cthd dtocthd = new DTO_cthd(MaHD, cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);
            
            
            dgcthd.DataSource = bllcthd.readdatadgcthdchangecb(cmd,dtocthd);
            



            if (dgcthd.Rows.Count > 0)
            {
                dgcthd.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
                dgcthd.Columns["MaHD"].Width = 100;
                dgcthd.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
                dgcthd.Columns["MaSP"].Width = 120;
                dgcthd.Columns["SLBan"].Width = 120;
                dgcthd.Columns["SLBan"].HeaderText = "Số Lượng Bán";
                dgcthd.Columns["DonGiaBan"].Width = 200;
                dgcthd.Columns["DonGiaBan"].HeaderText = "Đơn Giá";
                dgcthd.Columns["ThanhTienBan"].Width = 170;
                dgcthd.Columns["ThanhTienBan"].HeaderText = "Thành Tiền Sản Phẩm";
                dgcthd.AllowUserToAddRows = false;
                dgcthd.EditMode = DataGridViewEditMode.EditProgrammatically;

            }

            

            


        }
        public Boolean kiemtrarong()
        {
            bool kiemtra;
            if (txtsoluong.Text == " ")
            {
                kiemtra = false;
            }
            else
            {
                kiemtra = true;
            }
            return kiemtra;
        }

        public void loadmanv()
        {
            string cmd = "";
            DTO_cthd dtocthd = new DTO_cthd(cbhoadon.SelectedValue.ToString(), cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);
            cbmanv.DataSource = bllcthd.readdatamanv(cmd, dtocthd);
            if (cbmanv != null)
            {

                cbmanv.DisplayMember = "MaNV";
                cbmanv.ValueMember = "MaNV";
                dgcthd.AllowUserToAddRows = false;
                dgcthd.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        public void loadtennv()
        {
            string cmd = "";

            DTO_nhanvien dtonhanvien = new DTO_nhanvien(cbmanv.SelectedValue.ToString());
            txttennv.Text = bllcthd.Gettennv(cmd, dtonhanvien);
        }

        public void loadmakh()
        {
            string cmd = "";
            DTO_cthd dtocthd = new DTO_cthd(cbhoadon.SelectedValue.ToString(), cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);
            cbmakh.DataSource = bllcthd.readdatamakh(cmd, dtocthd);
            if (cbmakh != null)
            {

                cbmakh.DisplayMember = "MaKH";
                cbmakh.ValueMember = "MaKH";
                dgcthd.AllowUserToAddRows = false;
                dgcthd.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        public void loadtenkh()
        {
            string cmd = "";
            DTO_khachhang dtokh = new DTO_khachhang(cbmakh.SelectedValue.ToString());
            txttenkh.Text = bllcthd.Gettenkh(cmd, dtokh);
        }

        public void loadngayban()
        {
            string cmd = "";
            DTO_cthd dtocthd = new DTO_cthd(cbhoadon.SelectedValue.ToString(), cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);
            dtngayban.Text = bllcthd.Getngayban(cmd, dtocthd);

        }

        public void loaddiachi()
        {
            string cmd = "";
            DTO_khachhang dtokh = new DTO_khachhang(cbmakh.SelectedValue.ToString());
            txtdiachikh.Text = bllcthd.Getdiachikh(cmd, dtokh);

        }

        public void loadsdt()
        {
            string cmd = "";
            DTO_khachhang dtokh = new DTO_khachhang(cbmakh.SelectedValue.ToString());
            txtsdtkh.Text = bllcthd.Getsdtkh(cmd, dtokh);

        }


        public void loaddongia()
        {
            string cmd = "";
            DTO_hanghoa dtohanghoa = new DTO_hanghoa(cbsanpham.SelectedValue.ToString());

            dongiaban = bllcthd.Getdongia(cmd, dtohanghoa);
            txtdongia.Text = dongiaban;

        }


        public void tongtienhoadon()
        {
            string cmd = "";
            DTO_cthd dtocthd = new DTO_cthd(cbhoadon.SelectedValue.ToString(), cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);


            if (bllcthd.updatetongtienhoadon(cmd, dtocthd) == true)
            {
                txttongtienhd.Text = bllcthd.Gettongtienhoadon(cmd, dtocthd);
            }
            else
            {
                MessageBox.Show("Không cập nhật được tiền hóa đơn", "Thông báo");
            }
        }
        public void loadsoluongkho()
        {
            string cmd = "";
            DTO_hanghoa dtohanghoa = new DTO_hanghoa(cbsanpham.SelectedValue.ToString());
            soluongton = bllcthd.Getsoluongkho(cmd, dtohanghoa);
            txtsoluongkho.Text = soluongton;


        }

        private void cbmakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddiachi();
            loadngayban();
            loadsdt();
            loadtenkh();
        }

        private void cbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtennv();
            loaddatacbchange();
            
        }

        private void btnthemhd_Click(object sender, EventArgs e)
        {
            frm_hoadon frhd = new frm_hoadon();
            frhd.Show();
            frhd.phanquyen = this.phanquyen;
        }

        private void txttongtienhd_TextChanged(object sender, EventArgs e)
        {
            string cmd = "";
            DTO_cthd dtocthd = new DTO_cthd(cbhoadon.SelectedValue.ToString(), cbsanpham.SelectedValue.ToString(), txtsoluong.Text, txtdongia.Text, txtthanhtiensp.Text);


            if (bllcthd.updatetongtienhoadon(cmd, dtocthd) == true)
            {
                txttongtienhd.Text = bllcthd.Gettongtienhoadon(cmd, dtocthd);
            }
            else
            {
                MessageBox.Show("Không cập nhật được tiền hóa đơn", "Thông báo");
            }
        }

        
       
        
    }
}
