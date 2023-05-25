using System;
using System.Collections.Generic;
using System.Text;

namespace baithi
{
    internal class THONGTINSINHVIEN
    {
        private string masv;
        private string tensv;
        private string malop;
        private string makhoa;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private string sdt;

        public THONGTINSINHVIEN()
        {
        }

        public THONGTINSINHVIEN(string masv, string tensv, string malop, string makhoa, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.malop = malop;
            this.makhoa = makhoa;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
        }

        public string Masv { get => masv; set => masv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
