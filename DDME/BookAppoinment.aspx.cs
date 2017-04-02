using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect.Poco;
using DbConnect;
using System.Globalization;

public partial class BookAppoinment : System.Web.UI.Page
{
    #region Private Variables
    private List<Doctor> doctors = new List<Doctor>();
    private Patient patient = new Patient();
    private UnitOfWork work = new UnitOfWork();
    private Appointment appointment = new Appointment();
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        GenericMethods genericMethods = new GenericMethods();
        if (!IsPostBack)
        {
            if (Session["UserId"] != null && (string)Session["UserType"] == "Patient")
            {
                patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
            }
        }
    }

    private void CacheAppointmentData()
    {
        appointment.CreationDate = DateTime.Now;
        appointment.EndTime = DateTime.ParseExact(ddlEndTime.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
        appointment.StartTime = DateTime.ParseExact(ddlStartTime.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
        appointment.IsApproved = false;
    }

    private bool InsertAppointmentData()
    {
        return false;
    }
}