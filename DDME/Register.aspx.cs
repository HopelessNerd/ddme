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
    private User _user = new User();
    private Doctor _doctor = new Doctor();
    private Pharmacist _pharmacist = new Pharmacist();
    private Patient _patient = new Patient();
    private GenericMethods _methods = new GenericMethods();
    private UnitOfWork work = new UnitOfWork();


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private bool SubmitData()
    {
        _user.CreationDate = DateTime.Now;
        _user.LastUpdateDate = DateTime.Now;
        _user.Password = _methods.EncryptPassword(txtPassword.Text.Trim());
        _user.Role = rbtnPatient.Checked ? Roles.Patient : rbtnDoctor.Checked ? Roles.Doctor : rbtnPharmacist.Checked ? Roles.Pharmacist : Roles.Patient;
        _user.UserName = txtEmail.Text.Trim();
        if (rbtnPatient.Checked == true)
        {
            _patient.Address = "";
            _patient.AlternativeNo = "";
            _patient.Country = "";
            _patient.CreationDate = DateTime.Now;
            _patient.DateOfBirth = DateTime.Now;
            _patient.Email = txtEmail.Text;
            _patient.Ethnicity = "1";
            _patient.FirstName = txtFirstName.Text.Trim();
            _patient.LandLineNo = "";
            _patient.LastName = txtLastName.Text.Trim();
            _patient.LastUpdatedDate = DateTime.Now;
            _patient.MiddleName = "";
            _patient.MobileNo = "";

        }
        else if (rbtnDoctor.Checked == true)
        {
            _doctor.Address = "";
            _doctor.AlternativeNo = "";
            _doctor.Country = "";
            _doctor.Email = txtEmail.Text.Trim();
            _doctor.FirstName = txtFirstName.Text.Trim();
            _doctor.LandLineNo = "";
            _doctor.LastName = txtLastName.Text.Trim();
            _doctor.LastUpdatedDate = DateTime.Now;
            _doctor.MiddleName = "";
            _doctor.MobileNo = "";
            _doctor.Qualifications = "";
            _doctor.Speciality = "";
        }
        else if (rbtnPharmacist.Checked == true)
        {
            _pharmacist.Address = "";
            _pharmacist.Country = "";
            _pharmacist.Email = txtEmail.Text.Trim();
            _pharmacist.FirstName = txtFirstName.Text.Trim();
            _pharmacist.LandLineNo = "";
            _pharmacist.LastName = txtLastName.Text.Trim();
            _pharmacist.MobileNo = "";
            _pharmacist.PharmacyName = "";
        }

        try
        {
            work.GenericUserRepo.Insert(_user);
            work.Save();
            if (rbtnPatient.Checked == true)
            {
                _patient.UserId = _user.Id;
                work.GenericPatientRepo.Insert(_patient);
                work.Save();
            }
            else if (rbtnDoctor.Checked == true)
            {
                _doctor.UserId = _user.Id;
                work.GenericDoctorRepo.Insert(_doctor);
                work.Save();
            }
            else if (rbtnPharmacist.Checked == true)
            {
                _pharmacist.UserId = _user.Id;
                work.GenericPharmacistRepo.Insert(_pharmacist);
                work.Save();
            }
            return true;
        }
        catch(Exception ex)
        {
            return false;
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if(SubmitData())
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            
        }
    }
}