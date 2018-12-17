using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;
using DoAnHCSDL.DTO;
using System.Data;

namespace DoAnHCSDL.BO
{
    class SQLAction
    {
        public DataSet Login(DTO_Login account)
        {
            string sql = "Exec DangNhap @UserName, @PassWord";
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@UserName", account.UserName),
                 new SqlParameter("@PassWord", account.PassWord),
            };
            DataAccess data = new DataAccess();
            return data.getdataset(sql, para);
        }
        public int AddFood(DTO_Food food)
        {
            int result = -1;
            string sql = "Exec ThemMon @MaMon,@TenMon, @DanhMuc, @GiaTien, @HinhAnh, @MoTa";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaMon",food.MaMon),
                new SqlParameter("@TenMon",food.TenMon),
                new SqlParameter("@DanhMuc",food.DanhMuc),
                new SqlParameter("@GiaTien",food.GiaTien),
                new SqlParameter("@HinhAnh",food.HinhAnh),
                new SqlParameter("@MoTa",food.MoTa),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
        public DataSet GetCategory()
        {
            DataSet result = new DataSet();
            string sql = "Exec LayTatCaDanhMuc";
            DataAccess data = new DataAccess();
            result = data.getdataset(sql);
            return result;
        }
        public DataSet GetFoodInfo(DTO_Food food)
        {
            DataSet result = new DataSet();
            string sql = "exec LayThongTinMonAn @DanhMuc";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@DanhMuc",food.DanhMuc),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql,para);
            return result;
        }
    }
}
