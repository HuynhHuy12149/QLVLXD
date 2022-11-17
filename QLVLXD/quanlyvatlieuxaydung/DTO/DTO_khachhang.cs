using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_khachhang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChiKH { get; set; }
        public string SDTKH { get; set; }

        public int action { get; set; }

        public DTO_khachhang()
        {

        }
        public DTO_khachhang(string MaKH)
        {
            this.MaKH = MaKH;
        }
        public DTO_khachhang(string MaKH, string TenKH, string DiaChiKH, string SDTKH)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.DiaChiKH = DiaChiKH;
            this.SDTKH = SDTKH;



        }
    }
}
