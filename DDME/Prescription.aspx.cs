using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect;
using DbConnect.Poco;
using System.IO;
public partial class Register : System.Web.UI.Page
{
    #region Private Variables
    private Doctor doctor = new Doctor();
    private Prescription prescription = new Prescription();
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
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
    private void CacheDetails()
    {
        
    }
    protected void upload()
    {
        if (txtattach1.HasFile && txtattach1.PostedFile != null || FileUpload1.HasFile && FileUpload1.PostedFile!=null)
        {
            if (FileUpload1.PostedFile.ContentLength < 4194304 || txtattach1.PostedFile.ContentLength<4194304)
            {
                string filename = Path.GetFileName(txtattach1.PostedFile.FileName);
                txtattach1.SaveAs(Server.MapPath("Uploads" + filename));
                TextBox1.Text = (Server.MapPath("Uploads" + filename));
                string filename2 = Path.GetFileName(txtattach1.PostedFile.FileName);
                txtattach1.SaveAs(Server.MapPath("Uploads" + filename2));
                TextBox2.Text = (Server.MapPath("Uploads" + filename2));

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('File size exceeds its max limit(4 MB max)')", true);

            }
        }

    }
    private bool SavePrescriptionDetails()
    {
        try
        {
            work.GenericPrescriptionRepo.Update(prescription);
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