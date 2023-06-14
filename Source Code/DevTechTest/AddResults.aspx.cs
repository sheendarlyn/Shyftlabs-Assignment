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
    public partial class AddResults : System.Web.UI.Page
    {
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindStudent();
                BindCourseName();
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
                if (SaveResult())
                {
                    clear();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterStartupScript", "<script>alert('Saved successfully');</script>");
                }
                else
                {
                    string msg = "Score is already assigned to " + drpStudent.SelectedItem + " for " + drpCourseName.SelectedItem;
                    msg = msg.Replace("'", "'");
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterStartupScript", "<script>alert('" + msg + "');</script>");
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
        protected void clear()
        {
            drpCourseName.SelectedValue = "";
            drpStudent.SelectedValue = "";
            drpScore.SelectedValue = "";
        }

        protected void BindStudent()
        {
            drpStudent.DataSource = new srvStudent().getStudentList();
            drpStudent.DataValueField = "studentid";
            drpStudent.DataTextField = "fullname";
            drpStudent.DataBind();
            drpStudent.Items.Insert(0, "");
        }
        protected void BindCourseName()
        {
            drpCourseName.DataSource = new srvCourse().getCourseList();
            drpCourseName.DataValueField = "courseid";
            drpCourseName.DataTextField = "coursename";
            drpCourseName.DataBind();
            drpCourseName.Items.Insert(0, "");
        }

        protected bool SaveResult()
        {
            bool isSaved = false;
            vmResult objResult = new vmResult();
            objResult.courseid = int.Parse(drpCourseName.SelectedValue);
            objResult.studentid = int.Parse(drpStudent.SelectedValue);
            objResult.score = drpScore.SelectedValue;
            isSaved = new srvResult().SaveResult(objResult) == 0 ? false : true;
            return isSaved;
        }
        #endregion
    }
}