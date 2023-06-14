using DevTechTestDAL.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DevTechTestDAL.Modules
{
    public class srvCourse
    {
        public DataTable getCourseList()
        {
            DataSet ds = new DataSet();
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");
            DbCommand cmd = db.GetStoredProcCommand("getCourseList");
            ds = db.ExecuteDataSet(cmd);
            return ds.Tables[0];
        }
        public void SaveCourse(vmCourse obj)
        {
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");
            DbCommand cmd = db.GetStoredProcCommand("SaveCourse");
            db.AddInParameter(cmd, "@courseid", DbType.Int32, obj.courseid);
            db.AddInParameter(cmd, "@coursename", DbType.String, obj.coursename);
            db.ExecuteNonQuery(cmd);
        }
        public void DeleteCourse(int courseid)
        {
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");
            DbCommand cmd = db.GetStoredProcCommand("DeleteCourse");
            db.AddInParameter(cmd, "@courseid", DbType.Int32, courseid);
            db.ExecuteNonQuery(cmd);
        }
    }
}
