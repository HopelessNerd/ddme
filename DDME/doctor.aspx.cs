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
        if (!IsPostBack)
        {
            if (Session["UserId"] != null && (string)Session["UserType"] == "Doctor")
            {
                doctor = work.GenericDoctorRepo.GetFirst(d => d.UserId == (int)Session["UserId"]);
                FillControls();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
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
        doctor = work.GenericDoctorRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
        doctor.FirstName = txtFirstName.Text;
        doctor.MiddleName = txtMiddleName.Text;
        doctor.LastName = txtLastName.Text;
        doctor.Gender = chkMale.Checked == true ? Gender.Male : chkFemale.Checked == true ? Gender.Female : Gender.Male;
        doctor.Address = txtAddress.Text;
        doctor.Country = txtCountry.Text;
        doctor.MobileNo = txtMobile.Text;
        doctor.AlternativeNo = txtAlternative.Text;
        doctor.Speciality = txtSpeciality.Text;
        doctor.Qualifications = txtQualifications.Text;
    }

    private bool SaveDoctorDetails()
    {
        try
        {
            work.GenericDoctorRepo.Update(doctor);
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
        CacheDetails();
        if (SaveDoctorDetails())
        {
            ScriptManager.RegisterStartupScript(Page, GetType(), "detailupdate", "<script>detailupdate()</script>", false);
          
        }
    }
}