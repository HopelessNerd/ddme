using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect;
using DbConnect.Poco;
using System.Globalization;

public partial class Register : System.Web.UI.Page
{
    #region Private Variables
    private List<Patient> _patients = new List<Patient>();
    private Event _event = new Event();
    private Doctor doctor = new Doctor();
    private Patient patient = new Patient();
    UnitOfWork work = new UnitOfWork();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        GenericMethods genericMethods = new GenericMethods();

        if (!IsPostBack)
        {
            if (Session["UserId"] != null && ((string)Session["UserType"] == "Patient" || (string)Session["UserType"] == "Doctor"))
            {

                //bind patient ddl
                PopulatepatientDropDown();

                if ((string)Session["UserType"] == "Doctor")
                {
                    doctor = work.GenericDoctorRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
                }
                if ((string)Session["UserType"] == "Patient")
                {
                    patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
                    ddlPatient.SelectedValue = patient.Id.ToString();
                    ddlPatient.Enabled = false;
                }

                FillControls();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

    }

    private void PopulatepatientDropDown()
    {
        IEnumerable<Patient> iPatient = work.GenericPatientRepo.GetAll();
        _patients = iPatient.ToList();
        ddlPatient.DataTextField = "FirstName";
        ddlPatient.DataValueField = "Id";
        ddlPatient.DataSource = _patients;
        ddlPatient.DataBind();
        ddlPatient.Items.Insert(0, new ListItem("Select Patient", "0"));

    }

    private void CacheDetails()
    {
        patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
        _event.PatientId = patient.Id;
        _event.Description = txtDetail.Text;
        _event.CreationDate = DateTime.Now;
        _event.Name = txtEventName.Text;
        _event.StartTime = DateTime.ParseExact(txtstart.Value, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        _event.EndTime = DateTime.ParseExact(txtend.Value, "MM/dd/yyyy", CultureInfo.InvariantCulture);

    }


    private void FillControls()
    {
        if (string.IsNullOrEmpty(Request.QueryString["EventId"]))
        {
            patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
            try
            {
                _event = work.GenericEventRepo.GetSingle(a => a.PatientId == patient.Id);
            }
            catch (Exception e)
            { }
        }
        else
        {
            _event = work.GenericEventRepo.GetFirst(a => a.Id == int.Parse(Request.QueryString["EventId"]));
        }
        if (_event.Id != 0)
        {
            ddlPatient.SelectedValue = _event.PatientId.ToString();
            txtend.Value = _event.EndTime.ToString("MM/dd/yyyy");
            txtstart.Value = _event.StartTime.ToString("MM/dd/yyyy");
            txtDetail.Text = _event.Description;
            txtEventName.Text = _event.Name;

        }
    }




    private bool SaveEventDetails()
    {
        try
        {
            if (_event.Id == 0)
                work.GenericEventRepo.Insert(_event);
            else
                work.GenericEventRepo.Update(_event);
            work.Save();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Session["UserId"] != null && (string)Session["UserType"] == "Patient")
        {
            CacheDetails();
            if (SaveEventDetails())
                Response.Redirect("Notification.aspx");
        }
    }
}