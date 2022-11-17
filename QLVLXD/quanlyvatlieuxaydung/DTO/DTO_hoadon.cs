using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_hoadon
    {
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public string NgayBan { get; set; }
        public string TongTienBan { get; set; }


        public DTO_hoadon()
        {

        }
        public DTO_hoadon(string MaHD, string MaNV, string MaKH, string NgayBan, string TongTienBan)
        {
            this.MaHD = MaHD;
            this.MaNV = MaNV;
            this.MaKH = MaKH;
            this.NgayBan = NgayBan;
            this.TongTienBan = TongTienBan;
        }
    }
}
