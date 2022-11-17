using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_hanghoa
    {
        public string MaSP { get; set; }
        public string MaNhom { get; set; }
        public string TenSP { get; set; }
        public string DonViTinh { get; set; }
        public string SLTon { get; set; }
        public string GiaBan { get; set; }
        public string GiaNhap { get; set; }
        public string MaNCC { get; set; }
        public DTO_hanghoa()
        {

        }

        public DTO_hanghoa(string MaSP)
        {
            this.MaSP = MaSP;
        }
        public DTO_hanghoa(string MaSP, string MaNhom, string TenSP, string DonViTinh, string SLTon, string GiaBan, string GiaNhap, string MaNCC)
        {
            this.MaSP = MaSP;
            this.MaNhom = MaNhom;
            this.TenSP = TenSP;
            this.DonViTinh = DonViTinh;
            this.SLTon = SLTon;
            this.GiaBan = GiaBan;
            this.GiaNhap = GiaNhap;
            this.MaNCC = MaNCC;


        }
    }
}
