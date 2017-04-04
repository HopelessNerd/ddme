using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect.Poco;
using DbConnect;

public partial class ViewPrescription : System.Web.UI.Page
{
    private UnitOfWork _work = new UnitOfWork();
    private List<Prescription> _prescriptions = new List<Prescription>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] != null && ((string)Session["UserType"] == "Patient" || (string)Session["UserType"] == "Doctor" || (string)Session["UserType"] == "Pharmacist"))
            {
                CacheDataFromDatabase();
                LoadDataToGrid();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
    protected void DownloadFile(object sender, EventArgs e)
    {
        string filePath = (sender as LinkButton).CommandArgument;
        Response.ContentType = ContentType;
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));
        Response.WriteFile(filePath);
        Response.End();
    }

    private void CacheDataFromDatabase()
    {
        IEnumerable<Prescription> iPrescriptions = _work.PrescriptionRepo.GetPrescriptionWithDoctorAndPatient();
        _prescriptions = iPrescriptions.ToList();
    }

    private void LoadDataToGrid()
    {
        if (_prescriptions.Count > 0)
        {
            var listWithSelectedColumns = _prescriptions.Select(v => new
            {
                v.Id,
                Doctor = v.Doctor.FirstName,
                Patient = v.Patient.FirstName,
                File1 = v.File1,
                File2 = v.File2,
                Note = v.Note,
                Prescribe = v.Prescribe
            });
            gvDisplayPrescriptions.DataSource = listWithSelectedColumns;
            gvDisplayPrescriptions.DataBind();
        }
        else
        {
            gvDisplayPrescriptions.DataSource = null;
            gvDisplayPrescriptions.DataBind();
        }
    }

    protected void btnSelectPrescription_Click(object sender, ImageClickEventArgs e)
    {

    }
}