using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect.Poco;
using DbConnect;

public partial class ViewAppointment : System.Web.UI.Page
{
    private List<Appointment> _appointments = new List<Appointment>();
    private Appointment _appointment = new Appointment();
    private UnitOfWork _work = new UnitOfWork();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] != null && ((string)Session["UserType"] == "Patient" || (string)Session["UserType"] == "Doctor"))
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

    private void CacheDataFromDatabase()
    {
        IEnumerable<Appointment> iAppointments = _work.AppointmentRepo.GetAppointmentsWithDoctor();
        _appointments = iAppointments.ToList();
    }

    private void LoadDataToGrid()
    {
        if (_appointments.Count > 0)
        {
            var listWithSelectedColumns = _appointments.Select(v => new
            {
                v.Id,
                Doctor = v.Doctor.FirstName,
                Date = v.StartTime.ToShortDateString(),
                StartTime = v.StartTime.ToShortTimeString(),
                EndTime = v.EndTime.ToShortTimeString(),
                IsApproved = v.IsApproved
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
        Response.Redirect("BookAppointment.aspx?AppointmentId=" + Convert.ToInt32(button.CommandArgument));        
    }

}