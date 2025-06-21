using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class SanBay
    {
        public string TenSanBay {  get; set; }
        public string TenThanhPho {  get; set; }
        public string VietTatSanBay {  get; set; }
        public SanBay(string pTenSanBay, string pTenThanhPho, string pVietTatSanBay)
        {
            TenSanBay = pTenSanBay;
            TenThanhPho = pTenThanhPho;
            VietTatSanBay = pVietTatSanBay;
        }
    }
}
