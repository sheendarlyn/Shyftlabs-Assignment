using DevTechTestDAL.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevTechTest
{
    public partial class StudentList : System.Web.UI.Page
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindStudentList();
            }
        }
       
        protected void gvStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvStudent.PageIndex = e.NewPageIndex;
            BindStudentList();
        }
        protected void gvStudent_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Delete1")
                {
                    string msgString = "Deleted successfully";
                    new srvStudent().DeleteStudent(Int32.Parse(e.CommandArgument.ToString()));
                    BindStudentList();
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
        protected void BindStudentList()
        {
            try
            {
                gvStudent.DataSource = new srvStudent().getStudentList();
                gvStudent.DataBind();
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