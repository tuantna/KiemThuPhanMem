using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep
{
   public class PhamMem
    {
       public static bool codangnhap = false;
       public static string chuoiketnoi = ConfigurationManager.ConnectionStrings["QLTB"].ConnectionString;
       public static QLTBDataContext db =new  QLTBDataContext(chuoiketnoi);


       public static int idMa;
       public static string Madn;
       public static string Matkhau;
       public static string MaNV;
       public static int QuyenID;
       public static int DonViID;    
     

       #region Phương thức xử lý khác
       public static string Giai_ma_matkhau(Binary pMkhau)
       {
           string chuoi = "";
           PhamMem.db.prGiaiMa(pMkhau, ref chuoi);
           return chuoi;

       }
       public static Binary Ma_hoa_matkhau(string pPass)
       {


           Binary bMahoa = new byte[150];
           PhamMem.db.prMaHoa(pPass, ref bMahoa);
           return bMahoa;

       }
       #endregion         
    }
}
