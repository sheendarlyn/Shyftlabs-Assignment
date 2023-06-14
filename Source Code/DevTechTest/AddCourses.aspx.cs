using DevTechTestDAL.Models;
using DevTechTestDAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevTechTest
{
    public partial class AddCourses : System.Web.UI.Page
    {
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clear();
            }
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCourse();
                clear();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterStartupScript", "<script>alert('Saved successfully');</script>");
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterStartupScript", "<script>alert('Error');</script>");
            }
        }
        #endregion

        #region Pass Data to Data access layer
        protected void clear()
        {
            txtCourseName.Text = "";
            hfcourseId.Value = "0";
        }
        protected void SaveCourse()
        {
            vmCourse objCourse = new vmCourse();
            objCourse.coursename = txtCourseName.Text;
            objCourse.courseid = int.Parse(hfcourseId.Value);

            new srvCourse().SaveCourse(objCourse);
        }
        #endregion
    }
}