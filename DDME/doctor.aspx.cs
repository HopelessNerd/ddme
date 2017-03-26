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
    private Doctor doctor = new Doctor();
    UnitOfWork work = new UnitOfWork();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        GenericMethods genericMethods = new GenericMethods();

        if (!string.IsNullOrEmpty((string)Session["UserId"]) && (string)Session["UserType"] == "Doctor")
        {
            doctor = work.GenericDoctorRepo.GetFirst(d => d.UserId == (int)Session["UserId"]);
            FillControls();
        }  

    }

    private void FillControls()
    {
        txtFirstName.Text = doctor.FirstName;
        txtMiddleName.Text = doctor.MiddleName;
        txtLastName.Text = doctor.LastName;

        if (doctor.Gender == Gender.Male)
            chkMale.Checked = true;
        else
            chkFemale.Checked = true;
        txtAddress.Text = doctor.Address;
        txtCountry.Text = doctor.Country;
        txtMobile.Text = doctor.MobileNo;
        txtAlternative.Text = doctor.AlternativeNo;

        txtSpeciality.Text = doctor.Speciality;
        txtQualifications.Text = doctor.Qualifications;
    }

    private void CacheDetails()
    {
        doctor.FirstName = txtFirstName.Text;
        doctor.MiddleName = txtMiddleName.Text;
        doctor.LastName = txtLastName.Text;
        doctor.Gender = chkMale.Checked == true ? Gender.Male : chkFemale.Checked == true ? Gender.Female : Gender.Male;
        doctor.Address = txtAddress.Text;
        doctor.Country = txtCountry.Text;
        doctor.MobileNo = txtMobile.Text;
        doctor.AlternativeNo = txtAlternative.Text;
    }
}