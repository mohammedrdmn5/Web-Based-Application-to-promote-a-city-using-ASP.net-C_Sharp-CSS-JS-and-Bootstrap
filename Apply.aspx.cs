using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Apply : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            setNationality();
            setActivities();
            setEvents();
            setHotelType();
        }
    }


    public void setNationality() // inserting the data to the Dropdownlist (ddlNationality)
    {
        string[] Nationality = new string[] {"select","Afghanistan","Albania","Algeria","Andorra","Angola","Argentina","Armenia","Australia","Austria","Azerbaijan","Bahamas","Bahrain","Bangladesh","Barbados","Belarus","Belgium","Belize","Benin",
"Bhutan","Bolivia","Bosnia-Herzegovina","Botswana","Brazil","Britain","Brunei","Bulgaria","Burkina","Burma (official name Myanmar)","Burundi","Cambodia","Cameroon","Canada","Cape Verde Islands","Chad","Chile","China","Colombia","Congo","Costa Rica","Croatia","Cuba","Cyprus","Czech Republic","Denmark","Djibouti","Dominica","Dominican Republic","Ecuador","Egypt","El Salvador","England","Eritrea","Estonia","Ethiopia","Fiji","Finland","France","Gabon","Gambia, the","Georgia","Germany","Ghana","Greece","Grenada","Guatemala","Guinea","Guyana",
"Haiti","Holland (also Netherlands)","Honduras","Hungary","Iceland","India","Indonesia","Iran","Iraq","Ireland, Republic of","Italy","Jamaica","Japan","Jordan","Kazakhstan","Kenya","Kuwait","Laos","Latvia","Lebanon","Liberia","Libya","Liechtenstein","Lithuania","Luxembourg","Macedonia","Madagascar","Malawi","Malaysia","Maldives","Mali",
"Malta","Mauritania","Mauritius","Mexico","Moldova","Monaco","Mongolia","Montenegro","Morocco","Mozambique","Myanmar see Burma","Namibia","Nepal","Netherlands, the (see Holland)","New Zealand","Nicaragua","Niger","Nigeria","North Korea","Norway","Oman","Pakistan","Panama","Papua New Guinea","Paraguay","Peru","the Philippines","Poland","Portugal","Qatar","Romania","Russia","Rwanda","Saudi Arabia","Scotland","Senegal","Serbia","Seychelles, the","Sierra Leone","Singapore","Slovakia","Slovenia","Solomon Islands","Somalia","South Africa","South Korea","Spain","Sri Lanka","Sudan","Suriname","Swaziland","Sweden","Switzerland","Syria","Taiwan","Tajikistan","Tanzania","Thailand","Togo","Trinidad and Tobago","Tunisia","Turkey","Turkmenistan","Tuvalu","Uganda","Ukraine","United Arab Emirates (UAE)","United Kingdom (UK)","United States of America (USA)","Uruguay","Uzbekistan","Vanuatu","Vatican City","Venezuela","Vietnam","Wales","Western Samoa","Yemen","Yugoslavia","Zaire","Zambia","Zimbabwe"
};

        ddlNationality.DataSource = Nationality;
        ddlNationality.DataBind();
    }

    public void setHotelType() // inserting the data to the Listbox (ddlHotelsType)
    {
        string[] HotelType = new string[] {"Select","Single","Double","Triple","Quad","Queen","King","Twin","Hollywood Twin Room","Double-double ","Studio","Suite / Executive Suite","Mini Suite or Junior Suite","President Suite",
            " Apartments ","Connecting rooms ","Murphy Room","Accessible Room ","Cabana","Adjoining rooms","Adjacent rooms","Villa"," Executive Floor"};
        ddlHotelsType.DataSource = HotelType;
        ddlHotelsType.DataBind();
    }
    public void setActivities()// inserting the data to the Listbox (lbActivities)
    {
        string[] activitiesName = new string[7] { "fakieh aquarium", "Playing bowling", "Silver Beach", "Visit Alshalal park", "Visit King Fahd's Fountain", "Visit old Jeddah", "Swimming" };
        lbActivities.DataSource = activitiesName;
        lbActivities.DataBind();
    }
    public void setEvents()// inserting the data to the Listbox (lbEvents)
    {
        string[] EventsName = new string[6] { "BOUNCE Jeddah", "DJ Kaigo", "Formula 1", "Historic jeddah", "Jeddah season", "Red Sea International Film Festival)" };
        lbEvents.DataSource = EventsName;
        lbEvents.DataBind();
    }

    protected void ddlmealsType_SelectedIndexChanged(object sender, EventArgs e)
    {
        string[] Breakfast = new string[] { "Areka", "Maglouba Foul", "Masoub" };
        string[] Lunch = new string[] { "Broast Albaik", "falafel", "Hummus" };
        string[] Dinner = new string[] { "Chicken madghout", "Mandi Chicken", "Meat madghout" };
        switch (ddlmealsType.SelectedItem.ToString())
        {
            case "Breakfast":
                {
                    lbMeals.DataSource = Breakfast;
                    break;
                }
            case "Lunch":
                {
                    lbMeals.DataSource = Lunch;
                    break;
                }
            case "Dinner":
                {
                    lbMeals.DataSource = Dinner;
                    break;
                }
        }
        lbMeals.DataBind();
    }


    public void moveDataForListBox(string name, string type, ListBox lbSender, ListBox lbReceiver)
    // this method is used for 6 listboks control (lbActivities,lbSelectedActivities,lbSelectedEvents,lbSelectedEvents,lbMeals,lbSelectedMeals)
    {
        if (lbSender.SelectedIndex < 0)//check if the user has been select or not before move
        {
            ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "Alert1", "alert('" + "You have not selected " + name + " to " + type + " " + "');", true);
        }
        else
        {
            for (int index = 0; index < lbSender.Items.Count; index++)
            {
                if (lbSender.Items[index].Selected == true)
                {
                    lbReceiver.Items.Add(lbSender.Items[index]);
                    ListItem li = lbSender.Items[index];
                    lbSender.Items.Remove(li);
                }
            }
        }
    }

    protected void btnAddActivities_Click(object sender, EventArgs e)
    {
        moveDataForListBox("activitie", "add", lbActivities, lbSelectedActivities);
    }

    protected void btnRemoveActivities_Click(object sender, EventArgs e)
    {
        moveDataForListBox("activitie", "remove", lbSelectedActivities, lbActivities);
    }

    protected void btnAddEvents_Click(object sender, EventArgs e)
    {
        moveDataForListBox("event", "add", lbEvents, lbSelectedEvents);
    }

    protected void btnRemoveEvents_Click(object sender, EventArgs e)
    {
        moveDataForListBox("event", "remove", lbSelectedEvents, lbEvents);
    }

    protected void btnAddMeals_Click(object sender, EventArgs e)
    {
        moveDataForListBox("meal", "add", lbMeals, lbSelectedMeals);
    }


    protected void btnRemoveMeals_Click(object sender, EventArgs e)
    {
        moveDataForListBox("meal", "remove", lbSelectedMeals, lbMeals);
        ddlmealsType_SelectedIndexChanged(sender, e);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        lblName.Text = rbtnPersonalTitle.SelectedItem + ". " + tbName.Text;
        lblEmail.Text = tbEmail.Text;
        lblPhone.Text = tbPhone.Text;
        lblDateOfBirth.Text = tbDateOfBirth.Text;
        lblNationality.Text = ddlNationality.SelectedValue.ToString();
        lblCity.Text = tbCity.Text;
        string data = "";
        for (int index = 0; index < lbSelectedActivities.Items.Count; index++)
        {
            data += " | " + lbSelectedActivities.Items[index].Text;
        }
        lblSelectedActivities.Text = data;
        for (int index = 0; index < lbSelectedEvents.Items.Count; index++)
        {
            data += " | " + lbSelectedEvents.Items[index].Text;
        }
        lblSelectedEvents.Text = data;
        lblHotelType.Text = ddlHotelsType.SelectedItem.Text;
        lblCheckInDate.Text = tbCheckInDate.Text;
        lblCheckOutDate.Text = tbCheckOutDate.Text;

        for (int index = 0; index < lbSelectedMeals.Items.Count; index++)
        {
            data += " | " + lbSelectedMeals.Items[index].Text;
        }
        lblSelectedMeal.Text = data;



        if (validation() == false) //dosn't pass all the validation
        {
            secCheckValidation.Visible = true; // show the details with detected errors.
            lblConfirm.Text = "Ooh, you forgot something, you can not confirm the order";
            lblConfirm.Style.Add("color", "red !important");
            btnSubmit.Text = "Resubmit";
            btnConfirmOrder.Enabled = false;
        }
        else
        {
            secCheckValidation.Visible = true; // show the details with the ability to confirm the order.
            lblConfirm.Text = "Great!eveything is well ,just confirm the order";
            lblConfirm.Style.Add("color", "green !important");
            btnConfirmOrder.Enabled = true;
            secAgreement.Visible = false;
        }
    }
    protected void btnConfirmOrder_Click(object sender, EventArgs e)
    {
        // hide whole the other html section.
        secInfo.Visible = false;
        secPersonalInfo.Visible = false;
        secHotel.Visible = false;
        secAgreement.Visible = false;
        secCheckValidation.Visible = false;
        secSuccessOrder.Visible = true; // show the html section which will show the user that his/her order has been send.

    }
    public bool validation() // check the validation and show the user message with the details if there it does not pass. if it passes it will return true.
    {
        int validation = 1;


        if (rbtnPersonalTitle.SelectedIndex < 0 || tbName.Text == "")
        {

            if (rbtnPersonalTitle.SelectedIndex < 0)
            {
                lblName.Style.Add("color", "red !important");
                lblName.Text = "please select your Personal Tilte";
                validation = 0;
            }
            if (tbName.Text == "")
            {
                lblName.Style.Add("color", "red !important");
                lblName.Text = "Please enter your name";
                validation = 0;
            }

            if (rbtnPersonalTitle.SelectedIndex < 0 && tbName.Text == "")
            {
                lblName.Style.Add("color", "red !important");
                lblName.Text = "Please enter your name and select your character title";
                validation = 0;
            }

            validation = 0;
        }
        else
        {
            lblName.Style.Add("color", "green !important");
        }


        if (tbEmail.Text == "")
        {
            lblEmail.Style.Add("color", "red !important");
            lblEmail.Text = "Please enter your email";
            validation = 0;
        }
        else
        {
            lblEmail.Style.Add("color", "green !important");
        }
        if (tbPhone.Text == "")
        {
            lblPhone.Style.Add("color", "red !important");
            lblPhone.Text = "Please enter your phone number";
            validation = 0;
        }
        else
        {
            lblPhone.Style.Add("color", "green !important");
        }
        if (tbDateOfBirth.Text == "")
        {
            lblDateOfBirth.Style.Add("color", "red !important");
            lblDateOfBirth.Text = "Please enter your phone birthday";
            validation = 0;
        }
        else
        {
            lblDateOfBirth.Style.Add("color", "green !important");
        }

        if (ddlNationality.SelectedIndex < 1)
        {
            lblNationality.Style.Add("color", "red !important");
            lblNationality.Text = "Please enter your nationality";
            validation = 0;
        }
        else
        {
            lblNationality.Style.Add("color", "green !important");
        }

        if (tbCity.Text == "")
        {
            lblCity.Style.Add("color", "red !important");
            lblCity.Text = "Please enter the city";
            validation = 0;
        }
        else
        {
            lblCity.Style.Add("color", "green !important");
        }
        if (lbSelectedActivities.SelectedIndex < 0)
        {
            lblSelectedActivities.Style.Add("color", "red !important");
            lblSelectedActivities.Text = "Please select the activities";
            validation = 0;
        }
        else
        {
            lblSelectedActivities.Style.Add("color", "green !important");
        }
        if (lbSelectedEvents.SelectedIndex < 0)
        {
            lblSelectedEvents.Style.Add("color", "red !important");
            lblSelectedEvents.Text = "Please select the Events";
            validation = 0;
        }
        else
        {
            lblSelectedEvents.Style.Add("color", "green !important");
        }

        if (ddlHotelsType.SelectedIndex < 1)
        {
            lblHotelType.Style.Add("color", "red !important");
            lblHotelType.Text = "Please enter the hotel room type";
            validation = 0;
        }
        else
        {
            lblHotelType.Style.Add("color", "green !important");
        }

        if (tbCheckInDate.Text == "")
        {
            lblCheckInDate.Style.Add("color", "red !important");
            lblCheckInDate.Text = "Please enter the start date of the period";
            validation = 0;
        }
        else
        {
            lblCheckInDate.Style.Add("color", "green !important");
        }
        if (tbCheckOutDate.Text == "")
        {
            lblCheckOutDate.Style.Add("color", "red !important");
            lblCheckOutDate.Text = "Please enter the end date of the period";
            validation = 0;
        }
        else
        {
            lblCheckOutDate.Style.Add("color", "green !important");
        }

        if (lbSelectedMeals.SelectedIndex < 0)
        {
            lblSelectedMeal.Style.Add("color", "red !important");
            lblSelectedMeal.Text = "Please select the meals";
            validation = 0;
        }
        else
        {
            lblSelectedMeal.Style.Add("color", "green !important");
        }


        if (cbAgreement.Checked)
        {
            lblAgreement.Style.Add("color", "green !important");
            lblAgreement.Text = "Agreed!";
        }
        else
        {
            lblAgreement.Style.Add("color", "red !important");
            lblAgreement.Text = "Please agree to all the terms and conditions";
            validation = 0;
        }


        if (validation == 0)
        {
            return false; // validation failed
        }
        else
        {
            return true;// validation passed
        }
    }


}