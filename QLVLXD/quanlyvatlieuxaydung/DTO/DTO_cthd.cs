using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_cthd
    {
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public string SLBan { get; set; }
        public string DonGiaBan { get; set; }
        public string ThanhTienBan { get; set; }
        public int action { get; set; }


        public DTO_cthd()
        {

        }
        public DTO_cthd(string MaHD, string MaSP, string SLBan, string DonGiaBan, string ThanhTienBan)
        {
            this.MaHD = MaHD;
            this.MaSP = MaSP;
            this.SLBan = SLBan;
            this.DonGiaBan = DonGiaBan;
            this.ThanhTienBan = ThanhTienBan;

        }
    }
}
