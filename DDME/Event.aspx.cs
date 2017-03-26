using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect;
using DbConnect.Poco;
public partial class Register : System.Web.UI.Page
{
    #region Private Variables
    private Event _event = new Event();
    private Doctor doctor = new Doctor();
    private Patient patient = new Patient();
    UnitOfWork work = new UnitOfWork();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        GenericMethods genericMethods = new GenericMethods();

        if (!string.IsNullOrEmpty((string)Session["UserId"]) && ((string)Session["UserType"] == "Patient"|| (string)Session["UserType"] == "Doctor"))
        {
            if ((string)Session["UserType"] == "Doctor")
            {
                doctor = work.GenericDoctorRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
            }
            if ((string)Session["UserType"] == "Patient")
            {
                patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
            }

           // FillControls();
        }

    }

  

}