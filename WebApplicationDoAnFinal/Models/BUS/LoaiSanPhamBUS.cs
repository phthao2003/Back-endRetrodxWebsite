using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDoAnFinal.Models.BUS
{
    //----------------KHACH HANG
    public class LoaiSanPhamBUS
    {
        public static IEnumerable<LOAISP> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<LOAISP>("SELECT * FROM LOAISP WHERE TINHTRANG= N'ĐANG HIỂN THỊ' ");
        }


        public static IEnumerable<SANPHAM> ChiTiet(String id)
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SANPHAM>("SELECT * FROM SANPHAM WHERE MALOAI= '"+id+ "'");
        }

        //--------------ADMIN
        public static void InsertLSP(LOAISP lsp)
        {
            var db = new ShopOnlineConnectionDB();
            db.Insert(lsp);
        }


        public static LOAISP ChiTietAdmin(String id)
        {
            var db = new ShopOnlineConnectionDB();
            return db.SingleOrDefault<LOAISP>("select * from LOAISP where MALOAI = '" + id + "'");
        }


        public static IEnumerable<LOAISP> DanhSachAdmin()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<LOAISP>("SELECT * FROM LOAISP");
        }

 
        public static void EditLSP(String id, LOAISP lsp)
        {
            var db = new ShopOnlineConnectionDB();
            db.Update(lsp, id);
        }
    }
}

