using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyChuyenBay_Demo.Helpers
{
    public class FIllData
    {
        public static void fillDataCbo(ComboBox cbo, DBConnect dbConn, string cauTruyVan, string cotHienThi, string cotGiaTriThat)
        {
            cbo.Items.Clear(); // Xóa các mục hiện có trong ComboBox trước khi thêm mới
            cbo.Items.Clear(); 
            SqlDataReader reader = dbConn.ThucThiReader(cauTruyVan);

            while (reader.Read())
            {
                cbo.Items.Add(new ComboBoxItem
                {
                    Text = reader[cotHienThi].ToString(),
                    Value = reader[cotGiaTriThat].ToString()
                });
            }

            reader.Close();
        }

        public static void fillDataCbo(ComboBox cbo, DBConnect dbConn, string cauTruyVan, string cotHienThi1, string cotHienThi2, string cotGiaTriThat)
        {
            SqlDataReader reader = dbConn.ThucThiReader(cauTruyVan);

            while (reader.Read())
            {
                cbo.Items.Add(new ComboBoxItem
                {
                    Text = reader[cotHienThi1].ToString() + " | " + reader[cotHienThi2].ToString(),
                    Value = reader[cotGiaTriThat].ToString()
                });
            }
        }

        public static void fillDataGridView(DataGridView dgv, DBConnect dbConn, string cauTruyVan, string tenBangMuonDat)
        {
            dgv.DataSource = null;
            DataSet ds = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cauTruyVan, dbConn.conn))
            {
                adapter.Fill(ds, tenBangMuonDat);
            }
            dgv.DataSource = ds.Tables[tenBangMuonDat];
        }

        public static string GetRealDataOfComboBox(ComboBox cbo)
        {
            ComboBoxItem cbi = (ComboBoxItem)cbo.SelectedItem;
            return cbi.Value.ToString();
        }

        public static string GetValueDGVRows(DataGridViewRow rows, string pTenThuocTinh)
        {
            return rows.Cells[pTenThuocTinh].Value.ToString();
        }
    }
}
