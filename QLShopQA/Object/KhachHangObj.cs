﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLShopQA.Object
{
    class KhachHangObj
    {
        string ma, ten, gioitinh, diachi, sdt,  email;
        string namsinh;
        int diem;

        public string Namsinh { get => namsinh; set => namsinh = value; }
        public string MaNhanVien { get => ma; set => ma = value; }
        public string TenNhanVien { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public int Diem { get => diem; set => diem = value; }

        public KhachHangObj() { }
        public KhachHangObj(string ma, string ten, string gioitinh, string namsinh, string diachi, string sdt, string email,int diem)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
            this.diem = diem;
        }
    }
}
