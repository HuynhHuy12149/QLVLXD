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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        BLL_LOGIN bll_lg = new BLL_LOGIN();
        writelogactivities wr = new writelogactivities();
        public string TenDN;
        public string PassDN;
        
       
        private void cbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if(txtpass.Text != "")
            {
                if (cbshowpass.Checked)
                {
                    txtpass.UseSystemPasswordChar = true;
                }
                else
                {
                    txtpass.UseSystemPasswordChar = false;
                }
            } else
            {
                MessageBox.Show("Không có mật khẩu để hiển thị", "Thông Báo");
                
                
            }
           

            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            if (txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Bạn không được để trống !!!!!", "Thông báo");
            }
            else
            {
                DTO_LOGIN LG = new DTO_LOGIN(txtuser.Text, txtpass.Text,cbchucvu.SelectedValue.ToString());
                string cmd = " ";

                if (bll_lg.readdata(cmd, LG) != null)
                {
                   
                    
                    
                    wr.WriteLog(txtuser.Text, "", "Đăng nhập", "");
                    tmlogin.Start();
                    txtuser.Enabled = false;
                    txtpass.Enabled = false;
                    btnlogin.Enabled = false;

                    //frm_main fmain = new frm_main();
                    //fmain.TenDN = txtuser.Text;
                    //frm_loading frmld = new frm_loading();
                    //frmld.Show();
                    //frmld.phanquyen = cbchucvu.SelectedValue.ToString();
                    //frmld.TenDN = txtuser.Text;




                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !!!", "Thông báo");
                    txtuser.Clear();
                    txtpass.Clear();

                }
            }



        }

        

        private void frmlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                btnxoa_Click(sender, e);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("bạn có muốn thoát không ?", "thông báo",  MessageBoxButtons.OKCancel);
            if(traloi == DialogResult.OK)
            {
                wr.WriteLog("", "", "tắt form đăng nhập", "");
                Application.Exit();
            }
            
        }
        private void frmlogin_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            loaddata();
            
            progressBar1.Hide();
        }

        private void loaddata()
        {
            string cmd = "";
            
            cbchucvu.DataSource = bll_lg.readdatachucvu(cmd);
            if (cbchucvu != null)
            {

                cbchucvu.DisplayMember = "ChucVu";
                cbchucvu.ValueMember = "MaChucVu";
                
            }
        }

        private void tmlogin_Tick(object sender, EventArgs e)
        {
            progressBar1.Show();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                
            }
            else
            {
               
                tmlogin.Stop();
                
                frm_main frmmain = new frm_main();
                frmmain.phanquyen = cbchucvu.SelectedValue.ToString();
                frmmain.TenDN = txtuser.Text;
                this.Hide();
                frmmain.Show();
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
