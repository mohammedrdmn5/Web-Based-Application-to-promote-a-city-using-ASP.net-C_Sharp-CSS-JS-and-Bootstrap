using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
   
    HttpCookie Style = new HttpCookie("Style");

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            UserOptionCookie(); //set and get the cookies based on the user Option, if the user is new, the default setting will be shown
        }

        UserTime();   // call the method  to change the logo based on the time.
        setStyle();// to call the method to set the style based on the user choice, it set based on the RadioButton and RadioButon will be set from the cookies while there is cookies store and if there are no cookies, it will be created and selected the default from UserOptionCookie() method. 

    }
    protected void Page_PreLoad(object sender, EventArgs e)
    {

    }

    public void UserTime() // this method created to change the logo based on the server time.
    {
        String currentTime = DateTime.Now.ToString("hh:mm tt"); // to get the full time

        lbLogoTime.Text = currentTime; // to set the time to the label which is next to the logo


        int hours = int.Parse(DateTime.Now.ToString("HH")); // to get only the 24-hours 

        if (hours <= 6) //from 00 night to 6:59 morning 
        {
            ibLogo.ImageUrl = ("~/assets/logo_night.png");
        }
        else if (hours <= 18)// from 8am to 6:59pm
        {
            ibLogo.ImageUrl = ("~/assets/logo_noon.png");
        }
        else // from 7pm to 23:59
            ibLogo.ImageUrl = ("~/assets/logo_night.png");

    }



   

    protected void rblStyle_SelectedIndexChanged(object sender, EventArgs e)
    {

        Style["Style"] = rblStyle.Text.ToString();
        Response.Cookies.Add(Style);
        Style.Expires = DateTime.Now.AddDays(30);
    }

    public void UserOptionCookie()
    {
       
        Style = Request.Cookies["Style"];
        if (Style != null) // if the cookie is  exist , show it in the RadioButton

        {
            Style = Request.Cookies["Style"];
            rblStyle.SelectedValue = Style["Style"].ToString();
        }


        else // cookie is not exist >  set the default options and show it in the RadioButton
        {
            HttpCookie nStyle = new HttpCookie("Style");
            nStyle["Style"] = "Steelblue";
            Response.Cookies.Add(nStyle);
            nStyle.Expires = DateTime.Now.AddDays(30);
            rblStyle.SelectedValue = nStyle["Style"].ToString();
          

        }
    }

    public void setStyle()
    {

        if (rblStyle.SelectedIndex == 0)
        {
            HtmlGenericControl css;
            css = new HtmlGenericControl();
            css.TagName = "style";
            css.Attributes.Add("type", "text/css");
            css.InnerHtml = "@import \"assets/bootstrap/css/bootstrap.min.css\";";

            Page.Header.Controls.Add(css);
        }
        else
        {
            HtmlGenericControl css;
            css = new HtmlGenericControl();
            css.TagName = "style";
            css.Attributes.Add("type", "text/css");
            css.InnerHtml = "@import \"assets/bootstrap/css/purple.css\";";

            Page.Header.Controls.Add(css);


        }
    }
    }
