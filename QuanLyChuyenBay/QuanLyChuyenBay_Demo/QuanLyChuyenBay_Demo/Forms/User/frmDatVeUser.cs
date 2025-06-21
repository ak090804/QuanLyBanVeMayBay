using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Helpers;

namespace QuanLyChuyenBay_Demo.Forms.User
{
    public partial class frmDatVeUser : Form
    {
        DBConnect dbConn;
        public frmDatVeUser(DBConnect _dbConn)
        {
            InitializeComponent();

            dbConn = _dbConn;
        }

        // Tim kiem chuyen bay
        // Dat phieu dat + ve

    }
}
