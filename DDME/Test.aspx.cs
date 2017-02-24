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
    }


    protected void ddlheight_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlheight.SelectedValue=="410")
        {
            ddlWeight.Items.Clear();
            ddlWeight.Items.Add(new ListItem("Select Weight", "0"));
            ddlWeight.Items.Add(new ListItem("119-142", "1"));
            ddlWeight.Items.Add(new ListItem("143-190", "2"));
            ddlWeight.Items.Add(new ListItem("191+", "3"));            
        }
    }
}