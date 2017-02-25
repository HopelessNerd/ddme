using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlGender_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlGender.SelectedValue == "M")
        {
            hideall();
            divmale.Visible = true;
        }
        else if(ddlGender.SelectedValue=="F")
        {
            hideall();
            divfemale.Visible = true;
        }
    }

    protected void ddlAge_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedValueInInt = 0;
        if(int.TryParse(ddlAge.SelectedValue, out selectedValueInInt))
        {
            if (selectedValueInInt>40)
            {
                hideall();
                divagemore.Visible = true;
            }
            else
            {
                hideall();
                divageless.Visible = true;
            }
        }
        else
        {

        }

    }
    public void hideall()
    {
        divfemale.Visible = false;
        divmale.Visible = false;
        bminfo.Visible = false;
        physical.Visible = false;
        highbp.Visible = false;

    }


    protected void ddlheight_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlheight.SelectedValue=="410")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<119", "0"));
            ddlWeight.Items.Add(new ListItem("119-142", "1"));
            ddlWeight.Items.Add(new ListItem("143-190", "2"));
            ddlWeight.Items.Add(new ListItem("191+", "3"));            
        }
        if (ddlheight.SelectedValue == "411")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<124", "0"));
            ddlWeight.Items.Add(new ListItem("124-147", "1"));
            ddlWeight.Items.Add(new ListItem("148-197", "2"));
            ddlWeight.Items.Add(new ListItem("198+", "3"));
        }
        if (ddlheight.SelectedValue == "500")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<128", "0"));
            ddlWeight.Items.Add(new ListItem("128-152", "1"));
            ddlWeight.Items.Add(new ListItem("153-203", "2"));
            ddlWeight.Items.Add(new ListItem("204+", "3"));
        }
        if (ddlheight.SelectedValue == "501")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<132", "0"));
            ddlWeight.Items.Add(new ListItem("132-157", "1"));
            ddlWeight.Items.Add(new ListItem("158-210", "2"));
            ddlWeight.Items.Add(new ListItem("211+", "3"));
        }
        if (ddlheight.SelectedValue == "502")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<136", "0"));
            ddlWeight.Items.Add(new ListItem("136-163", "1"));
            ddlWeight.Items.Add(new ListItem("164-217", "2"));
            ddlWeight.Items.Add(new ListItem("218+", "3"));
        }
        if (ddlheight.SelectedValue == "503")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<141", "0"));
            ddlWeight.Items.Add(new ListItem("141-168", "1"));
            ddlWeight.Items.Add(new ListItem("169-224", "2"));
            ddlWeight.Items.Add(new ListItem("225+", "3"));
        }
        if (ddlheight.SelectedValue == "504")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<145", "0"));
            ddlWeight.Items.Add(new ListItem("145-173", "1"));
            ddlWeight.Items.Add(new ListItem("174-231", "2"));
            ddlWeight.Items.Add(new ListItem("232+", "3"));
        }
        if (ddlheight.SelectedValue == "505")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<150", "0"));
            ddlWeight.Items.Add(new ListItem("150-179", "1"));
            ddlWeight.Items.Add(new ListItem("180-239", "2"));
            ddlWeight.Items.Add(new ListItem("240+", "3"));
        }
        if (ddlheight.SelectedValue == "506")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<155", "0"));
            ddlWeight.Items.Add(new ListItem("155-185", "1"));
            ddlWeight.Items.Add(new ListItem("186-246", "2"));
            ddlWeight.Items.Add(new ListItem("247+", "3"));
        }
        if (ddlheight.SelectedValue == "507")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<159", "0"));
            ddlWeight.Items.Add(new ListItem("159-190", "1"));
            ddlWeight.Items.Add(new ListItem("191-254", "2"));
            ddlWeight.Items.Add(new ListItem("255+", "3"));
        }
        if (ddlheight.SelectedValue == "508")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<164", "0"));
            ddlWeight.Items.Add(new ListItem("164-196", "1"));
            ddlWeight.Items.Add(new ListItem("197-261", "2"));
            ddlWeight.Items.Add(new ListItem("262+", "3"));
        }
        if (ddlheight.SelectedValue == "509")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<169", "0"));
            ddlWeight.Items.Add(new ListItem("169-202", "1"));
            ddlWeight.Items.Add(new ListItem("203-269", "2"));
            ddlWeight.Items.Add(new ListItem("270+", "3"));
        }
        if (ddlheight.SelectedValue == "510")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<174", "0"));
            ddlWeight.Items.Add(new ListItem("174-208", "1"));
            ddlWeight.Items.Add(new ListItem("209-277", "2"));
            ddlWeight.Items.Add(new ListItem("278+", "3"));
        }
        if (ddlheight.SelectedValue == "511")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<179", "0"));
            ddlWeight.Items.Add(new ListItem("179-214", "1"));
            ddlWeight.Items.Add(new ListItem("215-285", "2"));
            ddlWeight.Items.Add(new ListItem("286+", "3"));
        }
        if (ddlheight.SelectedValue == "600")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<184", "0"));
            ddlWeight.Items.Add(new ListItem("184-220", "1"));
            ddlWeight.Items.Add(new ListItem("221-293", "2"));
            ddlWeight.Items.Add(new ListItem("294+", "3"));
        }
        if (ddlheight.SelectedValue == "601")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<189", "0"));
            ddlWeight.Items.Add(new ListItem("189-226", "1"));
            ddlWeight.Items.Add(new ListItem("227-301", "2"));
            ddlWeight.Items.Add(new ListItem("302+", "3"));
        }
        if (ddlheight.SelectedValue == "602")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<194", "0"));
            ddlWeight.Items.Add(new ListItem("194-232", "1"));
            ddlWeight.Items.Add(new ListItem("233-310", "2"));
            ddlWeight.Items.Add(new ListItem("311+", "3"));
        }
        if (ddlheight.SelectedValue == "603")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<200", "0"));
            ddlWeight.Items.Add(new ListItem("200-239", "1"));
            ddlWeight.Items.Add(new ListItem("240-318", "2"));
            ddlWeight.Items.Add(new ListItem("319+", "3"));
        }
        if (ddlheight.SelectedValue == "604")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("<205", "0"));
            ddlWeight.Items.Add(new ListItem("205-245", "1"));
            ddlWeight.Items.Add(new ListItem("246-327", "2"));
            ddlWeight.Items.Add(new ListItem("328+", "3"));
        }
    }

    protected void ddlbp_SelectedIndexChanged(object sender, EventArgs e)
    {
        hideall();
        highbp.Visible = true;
    }

    protected void ddlphysical_SelectedIndexChanged(object sender, EventArgs e)
    {
        hideall();
        physical.Visible = true;
    }
}