using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect.Poco;
using DbConnect;

public partial class Test : System.Web.UI.Page
{
    #region Private Variables
    private Patient patient = new Patient();
    private TestResult testResult = new TestResult();
    UnitOfWork work = new UnitOfWork();
    private int gendervalue, agevalue, relationvalue, bpvalue, phyvalue, bmivalue1, finalcalculation = 0;
    private double percentage = 0;
    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] != null && (string)Session["UserType"] == "Patient")
            {
                patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }

    protected void ddlGender_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlGender.SelectedValue == "1")
        {
            hideall();
            divmale.Visible = true;
            hfgender.Value = "5";
            gendervalue = int.Parse(hfgender.Value);

        }
        else if (ddlGender.SelectedValue == "0")
        {
            hideall();
            divfemale.Visible = true;
            lblfemgest.Visible = true;
            ddlfemgest.Visible = true;
            gendervalue = 0;
        }
    }

    protected void ddlbp_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlbp.SelectedValue == "2")
        {
            bpvalue = 0;
            hfbp.Value = "0";
        }
        else if (ddlbp.SelectedValue == "1")
        {
            bpvalue = 5;
            hfbp.Value = "5";
        }
        hideall();
        highbp.Visible = true;
    }

    protected void ddlphysical_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlphysical.SelectedValue == "1")
            bpvalue = 0;
        else if (ddlphysical.SelectedValue == "0")
            bpvalue = 5;
        hideall();
        physical.Visible = true;
    }

    protected void ddlWeight_SelectedIndexChanged(object sender, EventArgs e)
    {
        hideall();
        bminfo.Visible = true;
    }

    protected void btnbmi_Click(object sender, EventArgs e)
    {
        bim();
    }

    protected void ddlFamily_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlFamily.SelectedValue == "0")
        {
            relationvalue = 0;
            hffamily.Value = "0";
        }
        else if (ddlFamily.SelectedValue == "1")
        {
            relationvalue = 5;
            hffamily.Value = "5";
        }
    }

    protected void txtwaist_TextChanged(object sender, EventArgs e)
    {
        int waist = int.Parse(txtwaist.Text);
        if (waist <= 35.5)
        {
            hfwaist.Value = "0";
        }
        else if (waist >= 35.5 && waist <= 39.3)
        {
            hfwaist.Value = "4";
        }
        else if (waist >= 39.4 && waist <= 43.3)
        {
            hfwaist.Value = "6";
        }
        else if (waist >= 43.4)
        {
            hfwaist.Value = "9";
        }

    }

    protected void btnResult_Click(object sender, EventArgs e)
    {
        //CalculateProbability();
        int max = 47;
        // finalcalculation = agevalue + relationvalue + gendervalue + bpvalue + bmivalue1 + phyvalue;
        finalcalculation = int.Parse(hfgender.Value) + int.Parse(hfbmi.Value) + int.Parse(hfage.Value) + int.Parse(hfbp.Value) + int.Parse(hffamily.Value) + int.Parse(hfwaist.Value) + int.Parse(ddlethenic.SelectedValue);
        percentage = (finalcalculation * 100) / max;
        CacheTestResult();
        if (SaveTestResult())
        {
            Response.Redirect("Results.aspx?total=" + finalcalculation + "&percentage=" + percentage);
        }
        


    }
    #endregion

    #region Manipulaion methods

    public void hideall()
    {
        divfemale.Visible = false;
        divmale.Visible = false;
        bminfo.Visible = false;
        physical.Visible = false;
        highbp.Visible = false;
        lblfemgest.Visible = false;
        ddlfemgest.Visible = false;

    }

    protected void bim()
    {
        double height = int.Parse(txtfeet.Text) * 12 + int.Parse(txtinch.Text);
        double weight = double.Parse(txtweight.Text);
        double bmi = ((703 * weight) / (height * height));
        txtbmi.Text = bmi.ToString();
        if (bmi < 25)
        {
            bmivalue1 = 0;
            hfbmi.Value = "0";
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            bmivalue1 = 4;
            hfbmi.Value = "4";
        }
        else if (bmi >= 30 && bmi <= 34.9)
        {
            bmivalue1 = 6;
            hfbmi.Value = "6";
        }
        else if (bmi >= 35)
        {
            bmivalue1 = 9;
            hfbmi.Value = "9";
        }

        hideall();
        tblcellbmi.Visible = true;
        bminfo.Visible = true;

    }

    protected void agecal(object sender, EventArgs e)
    {
        int age = int.Parse(txtage.Text);
        if (age < 49)
        {
            agevalue = 0;
            hfage.Value = "0";
        }
        else if (age >= 50 && age <= 59)
        {
            agevalue = 5;
            hfage.Value = "5";
        }
        else if (age >= 60 && age <= 69)
        {
            agevalue = 9;
            hfage.Value = "9";
        }
        else if (age >= 70)
        {
            agevalue = 13;
            hfage.Value = "13";
        }
    }

    private void CacheTestResult()
    {
        patient = work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
        if (ddlFamily.SelectedValue == "1")
            testResult.AreRelativesDiagnosed = true;
        else if (ddlFamily.SelectedValue == "2")
            testResult.AreRelativesDiagnosed = false;
        testResult.CreationDate = DateTime.Now;
        testResult.Height = float.Parse(txtfeet.Text + "." + txtinch.Text);
        if (ddlbp.SelectedValue == "1")
            testResult.IsDiagnosedWithBP = true;
        else if (ddlbp.SelectedValue == "2")
            testResult.IsDiagnosedWithBP = false;
        if (ddlphysical.SelectedValue == "1")
            testResult.IsPhysicallyActive = true;
        else if (ddlphysical.SelectedValue == "2")
            testResult.IsPhysicallyActive = false;
        testResult.IsGestationalDiabetes = false;
        testResult.Waist = float.Parse(txtwaist.Text);
        testResult.PatientId = patient.Id;
        testResult.Weight = float.Parse(txtweight.Text);
        testResult.Description = "Created on " + DateTime.Now.ToShortDateString();
        testResult.Score = finalcalculation;
    }

    private bool SaveTestResult()
    {
        try
        {
            work.GenericTestResultRepo.Insert(testResult);
            work.Save();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    #endregion
}