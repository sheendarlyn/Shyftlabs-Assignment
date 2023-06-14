using DevTechTestDAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevTechTest
{
    public partial class ResultsList : System.Web.UI.Page
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindResultList();
            }
        }

        protected void gvResult_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvResult.PageIndex = e.NewPageIndex;
            BindResultList();
        }

        #endregion

        #region Pass Data to Data access layer
        protected void BindResultList()
        {
            try
            {
                gvResult.DataSource = new srvResult().getResultList();
                gvResult.DataBind();
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