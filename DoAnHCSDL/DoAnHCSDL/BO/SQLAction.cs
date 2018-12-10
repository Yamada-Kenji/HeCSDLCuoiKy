using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;
using DoAnHCSDL.DO;
using System.Data;

namespace DoAnHCSDL.BO
{
    class SQLAction
    {
        public DataSet Login(AccountDO account)
        {
            string query = "Exec DangNhap @tk, @mk";
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@tk", account.UserName),
                 new SqlParameter("@mk", account.Password)
            };
            DataAccess access = new DataAccess();
            return access.GetDataSet(query, para);
        }

        public DataSet GetMenu()
        {
            string query = "Exec HienThucDon";
            DataAccess access = new DataAccess();
            return access.GetDataSet(query);
        }
    }
}
