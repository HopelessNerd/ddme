using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] != null && (string)Session["UserType"] == "Patient")
        {
            patientLogin.Visible = true;
            DoctorLogin.Visible = false;
            nologin.Visible = false;
            PharmacistLogin.Visible = false;

        }
        else if (Session["UserId"] != null && (string)Session["UserType"] == "Doctor")
        {
            patientLogin.Visible = false;
            DoctorLogin.Visible = true;
            nologin.Visible = false;
            PharmacistLogin.Visible = false;

        }
        else if (Session["UserId"] != null && (string)Session["UserType"] == "Pharmacist")
        {
            patientLogin.Visible = false;
            DoctorLogin.Visible = false;
            nologin.Visible = false;
            PharmacistLogin.Visible = true;

        }
        else
        {          
                patientLogin.Visible = false;
                DoctorLogin.Visible = false;
                nologin.Visible = true;
                PharmacistLogin.Visible = false;

         }


    }
}
