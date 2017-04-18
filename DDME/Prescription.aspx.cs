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
    private List<Patient> patients = new List<Patient>();
    private Prescription prescription = new Prescription();
    UnitOfWork work = new UnitOfWork();
    string filename,filename2;

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        GenericMethods genericMethods = new GenericMethods();
        if (!IsPostBack)
        {
            if (Session["UserId"] != null && (string)Session["UserType"] == "Doctor")
            {
                doctor = work.GenericDoctorRepo.GetFirst(d => d.UserId == (int)Session["UserId"]);
                PopulatePatientDropdown();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
    private void CacheDetails()
    {
        doctor = work.GenericDoctorRepo.GetFirst(d => d.UserId == (int)Session["UserId"]);
        prescription.CreationDate = DateTime.Now;
        prescription.Prescribe = txtPrescription.Text;
        prescription.File1 = TextBox1.Text;
        prescription.File2 = TextBox2.Text;
        prescription.Note = txtNote.Text;
        prescription.PatientId = int.Parse(ddlPatient.SelectedValue);
        prescription.DoctorId = doctor.Id;
    }

    private void PopulatePatientDropdown()
    {
        IEnumerable<Patient> iPatients = work.GenericPatientRepo.GetAll();
        patients = iPatients.ToList();
        ddlPatient.DataTextField = "FirstName";
        ddlPatient.DataValueField = "Id";
        ddlPatient.DataSource = patients;
        ddlPatient.DataBind();
        ddlPatient.Items.Insert(0, new ListItem("Select Patient", "0"));
    }
    private void Upload()
    {
        if (txtattach1.HasFile && txtattach1.PostedFile != null)
        {
            if (txtattach1.PostedFile.ContentLength<4194304)
            {
                filename = Path.GetFileName(txtattach1.PostedFile.FileName);
                filename = DateTime.Now.ToString("MMddyyyyhhmmss") + filename.Substring(filename.Length - (filename.Length / 2));
                txtattach1.SaveAs(Server.MapPath("Uploads/" + filename));
                TextBox1.Text = filename;            
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('File size exceeds its max limit(4 MB max)')", true);

            }
        }
        if (FileUpload1.HasFile && FileUpload1.PostedFile != null)
        {
            if (FileUpload1.PostedFile.ContentLength < 4194304)
            {
                filename2 = Path.GetFileName(FileUpload1.PostedFile.FileName);
                filename2 = DateTime.Now.ToString("MMddyyyyhhmmss") + filename2.Substring(filename2.Length - (filename2.Length / 2));
                FileUpload1.SaveAs(Server.MapPath("Uploads/" + filename2));
                TextBox2.Text = filename2;
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('File size exceeds its max limit(4 MB max)')", true);
            }
        }
    }
    protected void SendMail()
    {
        var fromAddress = doctor.Email;
        var toAddress = work.GenericPatientRepo.GetByID(Convert.ToInt32(ddlPatient.SelectedValue)).Email;
        const string fromPassword = "";
        string subject = "Prescription from Doctor at "+DateTime.Now;
        string body = "Note: " + txtPrescription.Text + "\n";
        body += "Description: " + txtNote.Text + "\n";
        System.Net.Mail.Attachment attachment;
        attachment = new System.Net.Mail.Attachment(Server.MapPath("Uploads/" + TextBox2.Text));
        System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
        message.Attachments.Add(attachment);
        var smtp = new System.Net.Mail.SmtpClient();
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.Credentials = new System.Net.NetworkCredential(fromAddress, fromPassword);
            smtp.Timeout = 20000;
        }
        // Passing values to smtp object
        smtp.Send(fromAddress, toAddress, subject, body);
    }
    private bool SavePrescriptionDetails()
    {
        try
        {
            work.GenericPrescriptionRepo.Insert(prescription);
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
        Upload();
        CacheDetails();
        if (SavePrescriptionDetails())
        {
            SendMail();
            ScriptManager.RegisterStartupScript(Page, GetType(), "detailupdate", "<script>detailupdate()</script>", false);
        }
    }
}