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
                FillControls();
                PopulateDoctorDropdown();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }

    private void CacheAppointmentData()
    {
        patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
        DateTime appointmentDate = DateTime.Parse(dtpAppointmentDate.Value);
        appointment.CreationDate = DateTime.Now;
        appointment.EndTime = DateTime.ParseExact(ddlEndTime.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
        appointment.EndTime = new DateTime(appointmentDate.Year, appointmentDate.Month, appointmentDate.Day, appointment.EndTime.Hour, appointment.EndTime.Minute, appointment.EndTime.Second);
        appointment.StartTime = DateTime.ParseExact(ddlStartTime.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
        appointment.StartTime = new DateTime(appointmentDate.Year, appointmentDate.Month, appointmentDate.Day, appointment.StartTime.Hour, appointment.StartTime.Minute, appointment.StartTime.Second);
        appointment.IsApproved = false;
        appointment.PatientId = patient.Id;
        appointment.DoctorId = int.Parse(ddlDoctor.SelectedValue);
    }

    private void PopulateDoctorDropdown()
    {
        IEnumerable<Doctor> iDoctors = work.GenericDoctorRepo.GetAll();
        doctors = iDoctors.ToList();
        ddlDoctor.DataTextField = "FirstName";
        ddlDoctor.DataValueField = "Id";
        ddlDoctor.DataSource = doctors;
        ddlDoctor.DataBind();
        ddlDoctor.Items.Insert(0, new ListItem("Select Doctor", "0"));
    }

    private void FillControls()
    {
        if (string.IsNullOrEmpty(Request.QueryString["AppointmentId"]))
        {
            patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
            try
            {
                appointment = work.GenericAppointmentRepo.GetSingle(a => a.PatientId == patient.Id);
            }
            catch(Exception e)
            {}
        }
        else
        {
            appointment = work.GenericAppointmentRepo.GetFirst(a => a.Id == int.Parse(Request.QueryString["AppointmentId"]));
        }
        if (appointment.DoctorId != 0)
        {
            ddlDoctor.SelectedValue = appointment.DoctorId.ToString();
            ddlEndTime.SelectedValue = appointment.EndTime.ToShortTimeString(); 
            ddlStartTime.SelectedValue = appointment.StartTime.ToShortTimeString();
            dtpAppointmentDate.Value = appointment.StartTime.ToShortDateString();
        }
    }

    private bool SaveAppointmentDetails()
    {
        try
        {
            if (appointment.Id == 0)
                work.GenericAppointmentRepo.Insert(appointment);
            else
                work.GenericAppointmentRepo.Update(appointment);
            work.Save();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    protected void btnBoookAppoinment_Click(object sender, EventArgs e)
    {
        if (Session["UserId"] != null && (string)Session["UserType"] == "Patient")
        {
            CacheAppointmentData();
            if (SaveAppointmentDetails())
                Response.Redirect("ViewAppointment.aspx");
        }
    }
}