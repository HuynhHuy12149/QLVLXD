using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_nhanvien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string MaChucVu { get; set; }
        public string DiaChiNV { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string TenDN { get; set; }
        public string PassDN { get; set; }

        public DTO_nhanvien()
        {

        }

        public DTO_nhanvien(string MaNV)
        {
            this.MaNV = MaNV;
        }
        public DTO_nhanvien(string MaNV, string TenNV, string MaChucVu, string DiaChiNV, string SDT, string GioiTinh, string NgaySinh, string TenDN, string PassDN)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.MaChucVu = MaChucVu;
            this.DiaChiNV = DiaChiNV;
            this.SDT = SDT;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.TenDN = TenDN;
            this.PassDN = PassDN;

        }
    }
}
