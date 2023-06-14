using DevTechTestDAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevTechTest
{
    public partial class CoursesList : System.Web.UI.Page
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindCourseList();
            }
        }

        protected void gvCourse_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCourse.PageIndex = e.NewPageIndex;
            BindCourseList();
        }
        protected void gvCourse_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Delete1")
                {
                    string msgString = "Deleted successfully";
                    new srvCourse().DeleteCourse(Int32.Parse(e.CommandArgument.ToString()));
                    BindCourseList();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterStartupScript", "<script>alert('" + msgString + "')</script>");
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterStartupScript", "<script>alert('Error');</script>");
            }
        }
        #endregion

        #region Pass Data to Data access layer
        protected void BindCourseList()
        {
            try
            {
                gvCourse.DataSource = new srvCourse().getCourseList();
                gvCourse.DataBind();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterStartupScript", "<script>alert('Error');</script>");
            }
        }
        #endregion
    }
}