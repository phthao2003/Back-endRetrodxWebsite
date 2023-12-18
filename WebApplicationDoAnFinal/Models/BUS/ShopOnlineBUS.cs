using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDoAnFinal.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SANPHAM> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SANPHAM>("SELECT * FROM SANPHAM WHERE TINHTRANG= N'ĐANG HIỂN THỊ' ");
        }
        public static SANPHAM ChiTiet(String a)
        {
            var db = new ShopOnlineConnectionDB();
            return db.SingleOrDefault<SANPHAM> ("SELECT * FROM SANPHAM WHERE MASP= @0",a);
        }
        //----------
        public static IEnumerable<SANPHAM> DanhSachSP()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SANPHAM>("SELECT * FROM SANPHAM");
        }

        public static void InsertSP(SANPHAM sp)
        {
            var db = new ShopOnlineConnectionDB();
            db.Insert(sp);
        }
        /*public static void EditSP(String id, SANPHAM sp)
        {
            var db = new ShopOnlineConnectionDB();
            db.Update(sp, id);      
        }
        */
        //bugfix
        public static SANPHAM ChiTietAdmin(String id)
        {
            var db = new ShopOnlineConnectionDB();
            return db.SingleOrDefault<SANPHAM>("select * from SANPHAM where MASP = '" + id + "'");
        }


        public static IEnumerable<SANPHAM> DanhSachAdmin()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SANPHAM>("SELECT * FROM SANPHAM");
        }


        public static void UpdateSP(String id, SANPHAM sp)
        {
            var db = new ShopOnlineConnectionDB();
            db.Update(sp, id);
        }

        public static IEnumerable<THANHVIEN> DanhSachTV()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<THANHVIEN>("SELECT * FROM THANHVIEN");
        }
    }
}