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

                // FillControls();
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



}