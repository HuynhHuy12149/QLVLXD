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
using System.IO;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using DTO;
using BLL;


namespace GUI
{
    public partial class frm_khachhang : Form
    {
        public frm_khachhang()
        {
            InitializeComponent();
        }
        public string tendn { get; set; }
        BLL_khachhang bllkhachhang = new BLL_khachhang();
        int check;
        writelogactivities wr = new writelogactivities();
        public string phanquyen { get; set; }
        List<DTO_khachhang> kh = new List<DTO_khachhang>();
       
        DTO_khachhang dtokh = new DTO_khachhang();
        DTO_khachhang dtokh1 = new DTO_khachhang();
        bool import;
        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            
            
            wr.WriteLog(tendn, "Bảng khách hàng", "Truy cập", "");
            loaddata();

            macdinh();
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
       
       

        public void distextbox()
        {
            txtmakh.Enabled = false;
            txtkh.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;

        }
        public void enbtextbox()
        {
            txtsdt.Enabled = true;
            
            txtkh.Enabled = true;
            txtdiachi.Enabled = true;
            txtmakh.Enabled = true;


        }
        public void loadbtnclickdg()
        {
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btntimkiem.Enabled = true;
            txttimkiem.Enabled = true;
        }

        public void macdinh()
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btntimkiem.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            txttimkiem.Enabled = false;
            txtmakh.Enabled = false;
            txtkh.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;
            
        }
        public void cleartextbox()
        {
            txtmakh.Clear();
            txtkh.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();

        }
       
      

        private void loaddata()
        {
            string cmd = "";
            dgkhachhang.DataSource = bllkhachhang.readdataKH(cmd);


            if (dgkhachhang.Rows.Count > 0)
            {
                dgkhachhang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
                dgkhachhang.Columns["MaKH"].Width = 100;
                dgkhachhang.Columns["TenKH"].Width = 100;
                dgkhachhang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
                dgkhachhang.Columns["DiaChiKH"].Width = 110;
                dgkhachhang.Columns["DiaChiKH"].HeaderText = "Địa Chỉ";
                dgkhachhang.Columns["SDTKH"].Width = 110;
                dgkhachhang.Columns["SDTKH"].HeaderText = "Số Điện Thoại";
                dgkhachhang.AllowUserToAddRows = false;
                dgkhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;

            }

        }

        public Boolean kiemtrarong()
        {
            bool kiemtra;
            if (txtmakh.Text == " " || txtkh.Text == " " || txtdiachi.Text == " " || txtsdt.Text == " ")
            {
                kiemtra = false;
            }
            else
            {
                kiemtra = true;
            }
            return kiemtra;
        }

        private void dgkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgkhachhang.CurrentRow.Index;
            txtmakh.Text = dgkhachhang.Rows[i].Cells[0].Value.ToString();
            txtkh.Text = dgkhachhang.Rows[i].Cells[1].Value.ToString();
            txtdiachi.Text = dgkhachhang.Rows[i].Cells[2].Value.ToString();
            txtsdt.Text = dgkhachhang.Rows[i].Cells[3].Value.ToString();
            loadbtnclickdg();
            btnphanquyen();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            check = 1;
            enbtextbox();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            check = 3;
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            dtokh1.MaKH = txtmakh.Text;
            dtokh1.TenKH = txtkh.Text;
            dtokh1.DiaChiKH = txtdiachi.Text;
            dtokh1.SDTKH = txtsdt.Text;
            check = 2;
            
            enbtextbox();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            loaddata();
            macdinh();
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            dtokh.MaKH = txtmakh.Text;
            dtokh.TenKH = txtkh.Text;
            dtokh.DiaChiKH = txtdiachi.Text;
            dtokh.SDTKH = txtsdt.Text;
            if (check == 1)
            {
                DTO_khachhang dtokhachhang = new DTO_khachhang(dtokh.MaKH, dtokh.TenKH, dtokh.DiaChiKH, dtokh.SDTKH);
                string cmd = " ";
                if (kiemtrarong() == false)
                {
                    MessageBox.Show("Bạn đã để trống hãy kiểm tra ", "Thông Báo");
                }
                else
                {
                    if (bllkhachhang.them(cmd, dtokhachhang) == true)
                    {
                        loaddata();
                        wr.WriteLog("", "Bảng khách hàng", "Thêm", "");
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        btnphanquyen();
                        dtokh.action = 1;
                        kh.Add(dtokh);
                        loadbtnclickdg();
                        btnluu.Enabled = false;
                        btnhuy.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm được !!!!", "Thông báo");
                    }
                }



            }
            if (check == 2)
            {
                DTO_khachhang dtokhachhang = new DTO_khachhang(dtokh.MaKH, dtokh.TenKH, dtokh.DiaChiKH, dtokh.SDTKH);
                string cmd = " ";
                if (bllkhachhang.sua(cmd, dtokhachhang) == true)
                {
                    
                    wr.WriteLog("", "Bảng khách hàng", "Sửa", "");
                    loaddata();
                    MessageBox.Show("Sửa Thông Tin Thành Công", "Thông Báo");
                    btnphanquyen();
                    dtokh.action = 4;
                    kh.Add(dtokh);
                    loadbtnclickdg();
                    btnluu.Enabled = false;
                    btnhuy.Enabled = false;
                   
                }
                else
                {
                    MessageBox.Show("Không thể sửa Thông Tin !!!!", "Thông báo");
                }
            }

            if (check == 3)
            {
                DTO_khachhang dtokhachhang = new DTO_khachhang(dtokh.MaKH, dtokh.TenKH, dtokh.DiaChiKH, dtokh.SDTKH);
                string cmd = " ";
                if (bllkhachhang.xoa(cmd, dtokhachhang) == true)
                {
                    DialogResult traloi;
                    traloi = MessageBox.Show("bạn có muốn xóa dữ liệu hay không ?", "thông báo", MessageBoxButtons.OKCancel);
                    if (traloi == DialogResult.OK)
                    {
                        loaddata();
                        wr.WriteLog("", "Bảng khách hàng", "Xóa", "");
                        MessageBox.Show("Xóa Thành Công", "Thông Báo");
                        btnphanquyen();
                        dtokh.action = 3;
                        kh.Add(dtokh);
                        loadbtnclickdg();
                        btnluu.Enabled = false;
                        btnhuy.Enabled = false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Không Xoá Được !!!!", "Thông báo");
                }
            }
            if (check == 4)
            {
                string cmd = "";
                for (int i = 0; i < dgkhachhang.Rows.Count - 1; i++)
                {
                    DataRow row = (dgkhachhang.Rows[i].DataBoundItem as DataRowView).Row;
                    DTO_khachhang khImport = new DTO_khachhang();
                    khImport.MaKH = row[0].ToString();
                    khImport.TenKH = row[1].ToString();
                    khImport.DiaChiKH = row[2].ToString();
                    khImport.SDTKH = row[3].ToString();
                    DTO_khachhang dtokhachhang = new DTO_khachhang(khImport.MaKH, khImport.TenKH, khImport.DiaChiKH, khImport.SDTKH);
                    khImport.action = 1;
                    kh.Add(khImport);
                    if (bllkhachhang.adddataimport(cmd, dtokhachhang) == true)
                    {

                        

                    }
                    





                }
                
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                wr.WriteLog("", "Bảng khách hàng", "import", "");
                loaddata();
                btnhuy.Enabled = false;
                btnluu.Enabled = false;
                
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DTO_khachhang dtokhachhang = new DTO_khachhang(txttimkiem.Text, txttimkiem.Text, txttimkiem.Text, txttimkiem.Text);
            string cmd = " ";
            btnhuy.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            
            btnphanquyen();
          
            if (txttimkiem.Text == "")
            {
                MessageBox.Show("Không Được Để ô Tìm Kiếm Trống", "Thông báo");

            }
            else
            {

                string cmdsql = "";
                cmdsql = txttimkiem.Text;
                DataTable dt = bllkhachhang.timkiem(cmd, dtokhachhang);
                DataTable dt1 = bllkhachhang.timkiemsql(cmdsql);
                wr.WriteLog("", "Bảng khách hàng", "Tìm Kiếm", "");

                string admin = "AD";
                string member = "NV";
                if (phanquyen.CompareTo(admin) == 0)
                {
                    if ( dt1 != null)
                    {
                        dgkhachhang.DataSource = dt1;
                        //dgkhachhang.DataSource = dt;
                        txttimkiem.Clear();
                        MessageBox.Show("tìm thấy thông tin", "Thông báo");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("không tìm thấy thông tin", "Thông báo");
                    }


                    
                }
                else if (phanquyen.CompareTo(member) == 0)
                {
                    if (dt != null)
                    {
                        dgkhachhang.DataSource = dt;
                        txttimkiem.Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("không tìm thấy thông tin", "Thông báo");
                    }
                }
               
                
            }
        }

        private void btnundo_Click(object sender, EventArgs e)
        {
            wr.WriteLog("", "Bảng khách hàng", "undo", "");
            if (kh.Count > 0)
            {


                if (kh[kh.Count - 1].action == 1)
                {


                    
                    var khbien = kh[kh.Count - 1];
                    txtmakh.Text = dtokh.MaKH;
                    txtkh.Text = dtokh.TenKH;
                    txtdiachi.Text = dtokh.DiaChiKH;
                    txtsdt.Text = dtokh.SDTKH;

                    kh.Remove(kh[kh.Count - 1]);
                    string codeback= @"delete from KHACHHANG where MaKH = '"+dtokh.MaKH+"'";
                    if (bllkhachhang.sqlundoadd(codeback) == true)
                    {
                        loaddata();
                    }
                    else
                    {
                        MessageBox.Show("lỗi không undo được", "Thông Báo");
                    }
                                                                                                                                          




                }
                else if (kh[kh.Count - 1].action == 4)
                {

                    var khbien = kh[kh.Count - 1];
                    txtmakh.Text = dtokh1.MaKH;
                    txtkh.Text = dtokh1.TenKH;
                    txtdiachi.Text = dtokh1.DiaChiKH;
                    txtsdt.Text = dtokh1.SDTKH;

                    kh.Remove(kh[kh.Count - 1]);
                    

                    string codeback = @"update KHACHHANG SET  TenKH = N'" + dtokh1.TenKH + "', DiaChiKH = N'" + dtokh1.DiaChiKH + "',SDTKH ='" + dtokh1.SDTKH + "' ";

                    if (bllkhachhang.sqlundoedit(codeback) == true)
                    {
                        loaddata();
                        
                    }
                    else
                    {
                        MessageBox.Show("lỗi không undo được", "Thông Báo");
                    }
                   

                }
                else if (kh[kh.Count - 1].action == 3)
                {
                    var khbien = kh[kh.Count - 1];
                    txtmakh.Text = dtokh.MaKH;
                    txtkh.Text = dtokh.TenKH;
                    txtdiachi.Text = dtokh.DiaChiKH;
                    txtsdt.Text = dtokh.SDTKH;
                    kh.Remove(kh[kh.Count - 1]);
                    string codeback = @"INSERT INTO KHACHHANG(MaKH, TenKH, DiaChiKH, SDTKH) VALUES(N'" + dtokh.MaKH + "', N'" + dtokh.TenKH + "', N'" + dtokh.DiaChiKH + "', N'" + dtokh.SDTKH + "')";
                    if (bllkhachhang.sqlundodelete(codeback) == true)
                    {
                        loaddata();
                    }
                    else
                    {
                        MessageBox.Show("lỗi không undo được", "Thông Báo");
                    }


                }
            }
        }

        
        private string fileName;
        private void readExcel()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "excel file |*.xls;*.xlsx";
            ofd.Title = "Chọn file excel";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                
            }
            check = 4;
            btnluu.Enabled = true;

        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            readExcel();
            OleDbConnection cn = new OleDbConnection(@"provider = Microsoft.Jet.OLEDB.4.0;Data Source = "+fileName+";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1;\"");
            cn.Open();
            OleDbDataAdapter apater = new OleDbDataAdapter("select * from[SHeet1$]",cn);
            DataSet thesd = new DataSet();
            DataTable dt = new DataTable();
           
            apater.Fill(dt);
            this.dgkhachhang.DataSource = dt.DefaultView;

        }

        private void btnxml_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml file |*.xml;*.xml";
            ofd.Title = "Chọn file excel";
           

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                DataSet dataSet = new DataSet();
                DataTable dt = new DataTable();
               
                dataSet.ReadXml(fileName);
                dt = dataSet.Tables["khachhang"];
                dgkhachhang.DataSource = dt;
                MessageBox.Show("đọc file xml thành công", "thông báo");
                btnhuy.Enabled = true;
                btnluu.Enabled = false;
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnsua.Enabled = false;

            }
        }

        private void dgkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
