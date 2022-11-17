using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frm_changepass : Form
    {
        public frm_changepass()
        {
            InitializeComponent();
        }

        BLL_LOGIN bll_lg = new BLL_LOGIN();

        public string TenDN { get; set; }
        public string PassDN;
        writelogactivities wr = new writelogactivities();
        public string phanquyen { get; set; }
        private void btnthaydoipass_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Bạn không được để trống !!!!!", "Thông báo");
            }
            else
            {

                DTO_LOGIN LG = new DTO_LOGIN(txtuser.Text, txtpass.Text);
                string cmd = " ";
                if(TenDN.CompareTo(txtuser.Text) == 0)
                {
                    if (bll_lg.readdatachange(cmd, LG) == true)
                    {
                        DTO_LOGIN LG1 = new DTO_LOGIN( TenDN,txtnewpass.Text);
                        if (bll_lg.changedatapass(cmd, LG1) == true)
                        {
                            wr.WriteLog(txtuser.Text, "Bảng Thay Đổi mật Khẩu", "Change Pass");
                            MessageBox.Show("Thay Đổi Mật Khẩu Thành Công", "Thông Báo");
                            this.Hide();
                            frm_main fmain = new frm_main();
                            fmain.phanquyen = phanquyen;
                            this.Hide();
                            

                        }
                        else
                        {
                            MessageBox.Show("Đổi Mật Khẩu Thất Bại !!!", "Thông báo");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu Đăng Nhập Sai !!!", "Thông báo");

                    }
                } else
                {
                    MessageBox.Show("Tên Đăng Nhập Không Khớp Với Đăng Nhập", "Thông Báo");
                }
                
               
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            frm_main f = new frm_main();
            f.phanquyen = phanquyen;
            
            
            this.Hide();

        }

       

        private void cbshowpass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (txtpass.Text != "" && txtnewpass.Text != "")
            {
                if (cbshowpass.Checked)
                {
                    txtpass.UseSystemPasswordChar = true;
                    txtnewpass.UseSystemPasswordChar = true;
                }
                else
                {
                    txtpass.UseSystemPasswordChar = false;
                    txtnewpass.UseSystemPasswordChar = false;
                }
            }
            else
            {
                MessageBox.Show("Không có mật khẩu để hiển thị", "Thông Báo");


            }
        }

        private void frm_changepass_Load(object sender, EventArgs e)
        {
            wr.WriteLog(txtuser.Text, "Bảng Thay Đổi mật Khẩu", "Truy cập");
            txtuser.Text = TenDN;
            txtuser.Enabled = false;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
