using DevTechTestDAL.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DevTechTestDAL.Modules
{
    public class srvStudent
    {
        public DataTable getStudentList()
        {
            DataSet ds = new DataSet();
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");
            DbCommand cmd = db.GetStoredProcCommand("getStudentList");
            ds = db.ExecuteDataSet(cmd);
            return ds.Tables[0];
        }
        public void SaveStudent(vmStudent obj)
        {
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");
            DbCommand cmd = db.GetStoredProcCommand("SaveStudent");
            db.AddInParameter(cmd, "@studentid", DbType.Int32, obj.studentid);
            db.AddInParameter(cmd, "@fname", DbType.String, obj.fname);
            db.AddInParameter(cmd, "@familyname", DbType.String, obj.familyname);
            db.AddInParameter(cmd, "@dob", DbType.Date, obj.dob);
            db.AddInParameter(cmd, "@email", DbType.String, obj.email);
            db.ExecuteNonQuery(cmd);
        }
        public void DeleteStudent(int studentid)
        {
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");
            DbCommand cmd = db.GetStoredProcCommand("DeleteStudent");
            db.AddInParameter(cmd, "@studentid", DbType.Int32, studentid);
            db.ExecuteNonQuery(cmd);
        }
    }
}
