using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbConnect.Poco;
using DbConnect;

public partial class ViewTestResult : System.Web.UI.Page
{
    private List<TestResult> _testResults = new List<TestResult>();
    private UnitOfWork _work = new UnitOfWork();
    private Patient patient = new Patient();

    protected void Page_Load(object sender, EventArgs e)
    {
        GenericMethods genericMethods = new GenericMethods();

        if (!IsPostBack)
        {
            if (Session["UserId"] != null && (string)Session["UserType"] == "Patient")
            {
                patient = _work.GenericPatientRepo.GetFirst(p => p.UserId == (int)Session["UserId"]);
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
        IEnumerable<TestResult> iTestResults = _work.GenericTestResultRepo.GetAll();
        _testResults = iTestResults.ToList();
    }

    private void LoadDataToGrid()
    {
        if (_testResults.Count > 0)
        {
            var listWithSelectedColumns = _testResults.Select(v => new
            {
                v.Id,
                Weight = v.Weight,
                Height = v.Height,
                IsDiagnosedWithBP = v.IsDiagnosedWithBP,
                AreRelativesDiagnosed = v.AreRelativesDiagnosed,
                IsPhysicallyActive = v.IsPhysicallyActive,
                Waist = v.Waist,
                Score = v.Score,
                CreationDate = v.CreationDate.ToShortDateString()
            });
            gvDisplayResults.DataSource = listWithSelectedColumns;
            gvDisplayResults.DataBind();
        }
        else
        {
            gvDisplayResults.DataSource = null;
            gvDisplayResults.DataBind();
        }
    }

}