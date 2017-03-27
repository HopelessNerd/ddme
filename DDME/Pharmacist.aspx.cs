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
    private Pharmacist pharmacist = new Pharmacist();
UnitOfWork work = new UnitOfWork();
#endregion

protected void Page_Load(object sender, EventArgs e)
    {


        GenericMethods genericMethods = new GenericMethods();

        if (Session["UserId"] != null && (string)Session["UserType"] == "Pharmacist")
        {
            pharmacist = work.GenericPharmacistRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
            FillControls();
        }
    }
    private void FillControls()
    {
        txtFirstName.Text = pharmacist.FirstName;      
        txtLastName.Text = pharmacist.LastName;
        if (pharmacist.Gender == Gender.Male)
            chkMale.Checked = true;
        else
            chkFemale.Checked = true;      
        txtAddress.Text = pharmacist.Address;
        txtCountry.Text = pharmacist.Country;
        txtMobile.Text = pharmacist.MobileNo;
        txtAlternative.Text = pharmacist.LandLineNo;
        txtPhrmacyName.Text = pharmacist.PharmacyName;
        txtEmail.Text = pharmacist.Email;
    }

    private void CacheDetails()
    {
        pharmacist.FirstName = txtFirstName.Text;
       
        pharmacist.LastName = txtLastName.Text;
        pharmacist.Gender = chkMale.Checked == true ? Gender.Male : chkFemale.Checked == true ? Gender.Female : Gender.Male;
        pharmacist.PharmacyName = txtPhrmacyName.Text;
        pharmacist.Email = txtEmail.Text;
        pharmacist.Address = txtAddress.Text;
        pharmacist.Country = txtCountry.Text;
        pharmacist.MobileNo = txtMobile.Text;
        pharmacist.LandLineNo = txtAlternative.Text;
    }

    private bool SavepharmacistDetails()
    {
        try
        {
            work.GenericPharmacistRepo.Update(pharmacist);
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
        if (SavepharmacistDetails())
            Response.Redirect("Default.aspx");
    }


}