using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class HangGhe
    {
        public string TenHangGhe {  get; set; }
        public HangGhe(string pTenHangGhe)
        {
            TenHangGhe = pTenHangGhe;
        }
    }
}
