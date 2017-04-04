using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect;
using DbConnect.Poco;
using System.Globalization;

public partial class Notification : System.Web.UI.Page
{
    private List<Event> _events = new List<Event>();
    private Event _event = new Event();
    private Patient _patient = new Patient();
    UnitOfWork work = new UnitOfWork();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if (Session["UserId"] != null && (string)Session["UserType"] == "Patient")
            {
                CacheDataFromDatabase();
                LoadDataToGrid();
            }
            else if (Session["UserId"] != null && (string)Session["UserType"] == "Doctor")
            {
                Response.Redirect("ViewAppointment.aspx");
            }
            else if (Session["UserId"] != null && (string)Session["UserType"] == "Pharmacist")
            {
                Response.Redirect(" ViewPrescription.aspx");
            }
            else
            {
                Response.Redirect("login.asspx");
            }
           
        }
    }
    private void CacheDataFromDatabase()
    {
        
            IEnumerable<Event> iEvent = work.GenericEventRepo.GetMany(e => e.PatientId   == (int)Session["UserId"]);
            _events = iEvent.ToList();
        
    }

    private void LoadDataToGrid()
    {
        if (_events.Count > 0)
        {
            var listWithSelectedColumns = _events.Select(v => new
            {
                v.Id,
                
                StartTime = v.StartTime.ToShortDateString(),
                EndTime = v.EndTime.ToShortDateString(),
                Name = v.Name.ToString(),
                Detail = v.Description.ToString()
                
            });
            gvDisplayAppointments.DataSource = listWithSelectedColumns;
            gvDisplayAppointments.DataBind();
        }
        else
        {
            gvDisplayAppointments.DataSource = null;
            gvDisplayAppointments.DataBind();
        }
    }
    protected void btnSelectAppointment_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton button = sender as ImageButton;
        Response.Redirect("Event.aspx?EventId=" + Convert.ToInt32(button.CommandArgument));
    }

}