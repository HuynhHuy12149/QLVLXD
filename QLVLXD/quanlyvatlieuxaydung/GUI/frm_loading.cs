using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_loading : Form
    {
        public frm_loading()
        {
            InitializeComponent();
        }

        public string phanquyen { get; set; }
        public string TenDN { get; set; }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                lbphantram.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                frm_main frmmain = new frm_main();
                frmmain.phanquyen = phanquyen;
                frmmain.TenDN = TenDN;
                this.Hide();
                frmmain.Show();
            }
        }

        private void frm_loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
