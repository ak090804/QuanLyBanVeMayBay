using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class TrangThaiChuyenBay
    {
        public string TenTrangThaiChuyenBay { get; set; }
        public TrangThaiChuyenBay(string pTenTrangThaiChuyenBay)
        {
            TenTrangThaiChuyenBay = pTenTrangThaiChuyenBay;
        }
    }
}
