using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class DTO_KhachHang
    {
        public string KhachHangID { get; set; }
        public string HoTenKH { get; set; }
        public string DiaChiKH { get; set; }
        public string EmailKH { get; set; }
        public string SDTKH { get; set; }

        public DTO_KhachHang()
        {

        }

        public DTO_KhachHang(string makh, string tenkh, string diachikh, string emailkh, string sdtkh)
        {
            this.KhachHangID = makh;
            this.HoTenKH = tenkh;
            this.DiaChiKH = diachikh;
            this.EmailKH = emailkh;
            this.SDTKH = sdtkh;

        }
    }
}
