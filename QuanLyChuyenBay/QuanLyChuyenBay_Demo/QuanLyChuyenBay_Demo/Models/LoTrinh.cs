using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class LoTrinh
    {
        public int MaSB_Di { get; set; }
        public int MaSB_Den { get; set; }
        public LoTrinh(int pMaSB_Di, int pMaSB_Den)
        {
            MaSB_Di = pMaSB_Di;
            MaSB_Den = pMaSB_Den;
        }
    }
}
