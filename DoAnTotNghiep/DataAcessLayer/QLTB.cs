using System.Data.Common;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DoAnTotNghiep.DataAcessLayer
{
    partial class QLTBDataContext
    {
        public List<object> ThucHienLenh(string lenh)
        {

            DbDataReader kq = null;
            try
            {
                if (PhamMem.db.Connection.State == System.Data.ConnectionState.Closed) PhamMem.db.Connection.Open();
                DbCommand bolenh = PhamMem.db.Connection.CreateCommand();
                bolenh.CommandText = lenh;
                kq = bolenh.ExecuteReader();
                return kq.Cast<object>().ToList();
            }
            catch (Exception ex)
            {
                kq = null;

            }
            finally
            {
                PhamMem.db.Connection.Close();
            }
            return kq.Cast<object>().ToList();

        }
        public int ThucHienLenhCapNhat(string lenh)
        {

            int kq = -1;
            try
            {
                if (PhamMem.db.Connection.State == System.Data.ConnectionState.Closed) PhamMem.db.Connection.Open();
                DbCommand bolenh = PhamMem.db.Connection.CreateCommand();
                bolenh.CommandText = lenh;
                kq = bolenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                kq = -1;

            }
            finally
            {
                PhamMem.db.Connection.Close();
            }
            return kq;

        }
        public float ThucHienLenhTinhToan(string lenh)
        {
            float kq = -1;
            try
            {
                if (PhamMem.db.Connection.State == System.Data.ConnectionState.Closed) PhamMem.db.Connection.Open();
                DbCommand bolenh = PhamMem.db.Connection.CreateCommand();
                bolenh.CommandText = lenh;
                kq = float.Parse(bolenh.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                kq = -1;

            }
            finally
            {
                PhamMem.db.Connection.Close();
            }
            return kq;

        }
    }
}


