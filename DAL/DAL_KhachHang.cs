using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Runtime.Remoting.Messaging;
using DAL;

ruồi muỗi bọ nhặng gà gà gà

namespace DAL
{
    public class DAL_KhachHang : DBConnect
    {
        KhachHang kh = new KhachHang();
        // Hiển thị danh sách loại mỹ phẩm
        public DataTable GetKhachHang()
        {
            string strGetKH = "Select * from KhachHang";
            return GetDataTable(strGetKH);
        }

        // Kiểm tra mã trùng
        public int KiemTraMaTrung(string ma)
        {
            KetNoi();
            int i;
            string sql = "Select count(*) from KhachHang where KhachHangID = '" + ma.Trim() + "'";
            sqlCom = new SqlCommand(sql, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm loại mỹ phẩm
        public bool ThemKH(KhachHang kh)
        {
            string sql = "Insert into KhachHang values('" + kh.KhachHangID + "', N'" + kh.HoTenKH + "', N'" + kh.DiaChiKH + "', '" + kh.EmailKH + "', '" + kh.SDTKH + "')";
            ThucThi(sql);
            return true;
        }

        // sửa loại mỹ phẩm
        public bool SuaKH(KhachHang kh)
        {
            string sql = "Update KhachHang set HoTenKH = N'" + kh.HoTenKH + "', DiaChiKH = N'" + kh.DiaChiKH + "', EmailKH = N'" + kh.EmailKH + "', SDTKH = N'" + kh.SDTKH + "'where KhachHangID = '" + kh.KhachHangID + "'";
            ThucThi(sql);
            return true;
        }

        // xóa 
        public bool XoaKH(string ma)
        {
            string sql = "Delete from KhachHang where KhachHangID = '" + ma + "'";
            ThucThi(sql);
            return true;
        }
    }
}
