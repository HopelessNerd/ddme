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
    private Patient patient = new Patient();
    UnitOfWork work = new UnitOfWork();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        GenericMethods genericMethods = new GenericMethods();

        if(Session["UserId"] != null && (string)Session["UserType"] == "Patient")
        {            
            patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
            FillControls();
        }        
    }

    private void FillControls()
    {
        txtFirstName.Text = patient.FirstName;
        txtMiddleName.Text = patient.MiddleName;
        txtLastName.Text = patient.LastName;

        if (patient.Gender == Gender.Male)
            chkMale.Checked = true;
        else
            chkFemale.Checked = true;
        dtpBirthday.Value = patient.DateOfBirth.ToShortDateString();

        ddlEthnicity.SelectedValue = patient.Ethnicity;
        txtAddress.Text = patient.Address;
        txtCountry.Text = patient.Country;
        txtMobile.Text = patient.MobileNo;
        txtAlternative.Text = patient.AlternativeNo;
    }

    private void CacheDetails()
    {
        patient.FirstName = txtFirstName.Text;
        patient.MiddleName = txtMiddleName.Text;
        patient.LastName = txtLastName.Text;
        patient.Gender = chkMale.Checked == true ? Gender.Male : chkFemale.Checked == true ? Gender.Female : Gender.Male;
        patient.Ethnicity = ddlEthnicity.SelectedValue;
        patient.Address = txtAddress.Text;
        patient.Country = txtCountry.Text;
        patient.MobileNo = txtMobile.Text;
        patient.AlternativeNo = txtAlternative.Text;
        patient.Id = (int)Session["UserId"];
        patient.LastUpdatedDate = DateTime.Now;
    }

    private bool SavePatientDetails()
    {
        try
        {
            work.GenericPatientRepo.Update(patient);
            work.Save();
            return true;
        }
        catch(Exception e)
        {
            return false;
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        CacheDetails();
        if (SavePatientDetails())
            Response.Redirect("Default.aspx");
    }
}