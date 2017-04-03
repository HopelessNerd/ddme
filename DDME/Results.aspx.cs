using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string total = Request.QueryString["total"];
        string percentage = Request.QueryString["percentage"];
        if (Session["UserId"] != null && (string)Session["UserType"] == "Patient")
        {
            if (total == "" || percentage == "")
            {
                Response.Redirect("Test.aspx");
            }
            else
            {
                hf1.Value = percentage;
                hf2.Value = total;
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
}