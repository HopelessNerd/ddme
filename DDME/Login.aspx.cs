using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect;
using DbConnect.Poco;

public partial class Login : System.Web.UI.Page
{
    User user = new User();
    GenericMethods methods = new GenericMethods();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private bool CheckLogin()
    {
        user = methods.LoginUser(txtUserName.Text.Trim(), txtPassword.Text.Trim());
        if(user == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if(CheckLogin())
        {
            Response.Redirect("Notification.aspx");

            if (user.Role == Roles.Patient)
                Session["UserType"] = "Patient";
            else if (user.Role == Roles.Doctor)
                Session["UserType"] = "Doctor";
            else if (user.Role == Roles.Pharmacist)
                Session["UserType"] = "Pharmacist";

            Session["UserId"] = user.Id;
        }
        else
        {
            Response.Redirect("Login.aspx");   
        }
    }
}