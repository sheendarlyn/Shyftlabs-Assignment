using DevTechTestDAL.Models;
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
    public partial class AddStudent : System.Web.UI.Page
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
                if (Validation())
                {
                    SaveStudent();
                    clear();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterStartupScript", "<script>alert('Saved successfully');</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterStartupScript", "<script>alert('The student must be at least 10 years old.');</script>");
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

        protected bool Validation()
        {
            bool val = true;
            double year = (DateTime.Today - DateTime.Parse(txtDOB.Text)).TotalDays / 365;
            if (year < 10)
            {
                val = false;
            }
            return val;
        }
        protected void clear()
        {
            txtfname.Text = "";
            txtfamilyname.Text = "";
            txtDOB.Text = "";
            txtemail.Text = "";
        }
        protected void SaveStudent()
        {
            vmStudent objStudent = new vmStudent();
            objStudent.fname = txtfname.Text;
            objStudent.familyname = txtfamilyname.Text;
            objStudent.dob =  DateTime.Parse(txtDOB.Text);
            objStudent.email = txtemail.Text;
            objStudent.studentid = int.Parse(hfStudentId.Value);

            new srvStudent().SaveStudent(objStudent);
        }
        #endregion
    }
}