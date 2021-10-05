using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// user to test the output 
//  ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "Alert1", "alert('" + arlist1[3] + "');", true); // test the output
//  Response.Write("<script language=javascript>alert('" + search(randomNumbers, 1) + "');</script>");
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        if (isItNight().Equals("Night"))
        {
            setSlideImages("Night");
        }
        else

        {
            setSlideImages("Noon");

        }

        setDishesImg();  // call the method to set the dishes images with the names
        setActivitiesImg();//call the method to set the Activitie images with the names
        setEventsImg();// call the method to set the Events images with the names
    }


    public string[] getFilesName(string path, string lastDirectoryName)
    {

        string Path = Server.MapPath(path); // to get files name from website directory 
        string[] FileNames = Directory.GetFiles(Path); // store whole files name
        var filesName = new ArrayList(); // to store only the names after "assets" for examle file/assets/picutre.jpg >> so only picture.jpg will be stored here
        for (int index = 0; FileNames.Length > index; index++)
        {
            string toBeSearched = lastDirectoryName; // the value which we will get the data after it 
            int ix = FileNames[index].IndexOf(toBeSearched);
            if (ix != -1)
            {
                filesName.Add(FileNames[index].Substring(ix + toBeSearched.Length));
            }
        }
        string[] flTostring = filesName.ToArray(typeof(string)) as string[]; // to restore the data wich stored in arraylist to string array so will mich easier to use next time.   
        return flTostring;
    }
    public string randomStrArr(string[] data)// get random string from  array  
    {
        System.Random random = new System.Random();
        int useBiome = random.Next(data.Length);
        string randomStr = data[useBiome];
        return randomStr;
    }



    public string[] randomSorting(string[] data) // to store the data in a string array randomly without duplicates.
    {


        Random random = new Random(DateTime.Now.Millisecond); //get number randomly based on millisecond.


        ArrayList randomNumbers = new ArrayList(); //declare arraylist
        string[] result = new string[data.Length]; // will use to be returned for the method;
        for (int index = 0; index < data.Length; index++) //ger random numbers based on data length argument 
        {
            int randomNum = random.Next(0, data.Length);
            if (randomNumbers.Contains(randomNum) == false) // if the number is not exist  
            {
                randomNumbers.Add(randomNum); // will be sotred 
            }
            else // if the number is  exist 
            {
                while (randomNumbers.Contains(randomNum) == true) // using the while loop to be able to use "break;" if the number is okay to be added and use "continue;" to repeat the procedure.
                {
                    int randomNum2 = random.Next(0, data.Length); // get new random number 
                    if (randomNumbers.Contains(randomNum2) == false) // check again with the new random number
                    {
                        randomNumbers.Add(randomNum2); // exist! , store it and end the loop 
                        break;
                    }
                    else // not exist , come back to the loop again and get diffrent random number and check again.
                        continue;
                }
            }

        }
        int[] rnTostring = randomNumbers.ToArray(typeof(int)) as int[]; // restore random numbers again from arraylist to a string array   

        for (int index = 0; index < data.Length; index++) // by getting that numbers , we will use them as  index for the array result,
                                                          //which will store the new data after being sortign randomly .
        {
            result[index] = data[rnTostring[index]];
        }

        return result; ;

    }

    string isItNight() // this method created to change the logo based on the user time.
    {
        int hours = int.Parse(DateTime.Now.ToString("hh")); // to get only the hours 
        string timeType = DateTime.Now.ToString("tt"); //to get wether is AM or PM
        string whatTime = ""; // to return it in this method.
        switch (timeType) // to check whether the time night or not  and set the logo based on that   
        {
            case "AM":
                {
                    if (hours >= 07)
                    {
                        whatTime = "Noon";
                    }
                    else
                    {
                        whatTime = "Night";
                    }

                    break;
                }
            case "PM":
                {
                    if (hours >= 07)
                    {
                        whatTime = "Night";
                    }
                    else
                        whatTime = "Noon";
                    break;
                }
        }
        return whatTime;
    }

    public void setSlideImages(string time) // this method will receive the time whether is night or day
    {
        string path = "~/assets/img/placeImg/" + time;
        string[] imgFileName = getFilesName(path, time);// call getFilesName method to get the pictures name in the folder by give the path and folder name. 
        string[] imgrandom = randomSorting(imgFileName); //sort the name of pictures randomly to show the user eveytime diffrent images.
        Image[] Imgslider = new Image[] { imgSlider1, imgSlider2, imgSlider3, imgSlider4, imgSlider5, imgSlider6, imgSlider7, imgSlider8 }; // store image asp.net Server Controls to avoid repeating the code
        for (int index = 0; index < Imgslider.Length; index++)
        {

            Imgslider[index].ImageUrl = path + imgrandom[index]; //based on the path of folder and folder name and time which this method are receiving and picture name.
        }
    }
    
    string getfoodtime() // this method created to check if the food time , dinner or lunch or breakfast
    {
        int hours = int.Parse(DateTime.Now.ToString("hh")); // to get only the hours 
        string timeType = DateTime.Now.ToString("tt"); //to get wether is AM or PM
        switch (timeType) // to check whether the it's time for breakfast or lunch or dinner
        {
            case "AM":
                {
                    if (hours != 12)
                    {
                        if (hours <= 04) // before morning still consider as dinner
                        {
                            return "Dinner";
                        }
                        else if (hours >= 5) // from 5 am to 11:59 am 
                        {
                            return "Breakfast";
                        }
                    }
                    else
                        return "Dinner";
                    break;

                }
            case "PM":
                {
                    if (hours != 12) // from 12 pm to 5:59pm >>Lunch time
                    {
                        if (hours <= 05)
                        {
                            return "Lunch";
                        }
                        else
                            return "Dinner";

                    }
                    else
                        return "Lunch";
                    break;
                }
                return null;
        }
        return null;
    }

    public void setDishesImg() // this method will se the image of the dishes based on the time (breakfast tiem , dinner time , lunch time ) as well as set the food name based on the image name.
    {

        Image[] imgdishes = new Image[] { imgdishes1, imgdishes2, imgdishes3 };
        Label[] ldishes = new Label[] { ldishes1, ldishes2, ldishes3 };
        string FoodImgPath = "~/assets/img/dishes/";

        string[] FoodImgFilesNames = getFilesName(FoodImgPath + getfoodtime(), getfoodtime()); // get the images names from the folder.

        for (int index = 0; index < imgdishes.Length; index++) // set the picture based on the image file and how many image asp control we have 
        {

            imgdishes[index].ImageUrl = FoodImgPath + getfoodtime() + FoodImgFilesNames[index];

            ldishes[index].Text = FoodImgFilesNames[index].Remove(0, 1).Replace(".jpg", "").Replace(".png", "");
        }
    }

    
    public void setActivitiesImg() 
    {

        Image[] imgActivities = new Image[] { imgActivities1, imgActivities2, imgActivities3 };
        Label[] lActivities = new Label[] { lActivities1, lActivities2, lActivities3 };
        string ActivitiesImgPath = "~/assets/img/Activities/";
        string[] ActivitiesImgFilesNames = getFilesName(ActivitiesImgPath, "Activities" ); // get the images names from the folder.
        string[] imgrandom = randomSorting(ActivitiesImgFilesNames); //sort the name of pictures randomly to show the user eveytime diffrent Activity.

        for (int index = 0; index < imgActivities.Length; index++) // set the picture based on the image file and how many image asp control we have 
        {

            imgActivities[index].ImageUrl = ActivitiesImgPath + imgrandom[index];

            lActivities[index].Text = imgrandom[index].Remove(0, 1).Replace(".jpg", "").Replace(".png", "");

        }
    }

    public void setEventsImg()
    {

        Image[] imgEvents = new Image[] { imgEvents1, imgEvents2, imgEvents3 };
        Label[] lEvents = new Label[] { lEvents1, lEvents2, lEvents3 };
        string EventsImgPath = "~/assets/img/Events/";
        string[] EventsImgFilesNames = getFilesName(EventsImgPath, "Events"); // get the images names from the folder.
        string[] imgrandom = randomSorting(EventsImgFilesNames); //sort the name of pictures randomly to show the user eveytime diffrent Activity.

        for (int index = 0; index < imgEvents.Length; index++) // set the picture based on the image file and how many image asp control we have 
        {

            imgEvents[index].ImageUrl = EventsImgPath + imgrandom[index];

            lEvents[index].Text = imgrandom[index].Remove(0, 1).Replace(".jpg", "").Replace(".png", "");

        }
    }

    protected void btnSendToApply_Click(object sender, EventArgs e)
    {
        Response.Redirect("apply.aspx");
    }


}
