using DevTechTestDAL.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DevTechTestDAL.Modules
{
    public class srvResult
    {
        public DataTable getResultList()
        {
            DataSet ds = new DataSet();
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");
            DbCommand cmd = db.GetStoredProcCommand("getResultList");
            ds = db.ExecuteDataSet(cmd);
            return ds.Tables[0];
        }
        public int SaveResult(vmResult obj)
        {
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");
            DbCommand cmd = db.GetStoredProcCommand("SaveResult");
            db.AddInParameter(cmd, "@courseid", DbType.Int32, obj.courseid);
            db.AddInParameter(cmd, "@studentid", DbType.Int32, obj.studentid);
            db.AddInParameter(cmd, "@score", DbType.String, obj.score);
            // db.ExecuteNonQuery(cmd);
            return int.Parse(db.ExecuteScalar(cmd).ToString());
        }
    }
}
