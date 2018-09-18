using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Controls_userEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            //do nothing...they are good
        }
        else
        {
            Response.Redirect("default.aspx");
        }

        string strPer_ID = "";
        int intPer_ID = 0;

        //Does Per_ID Exist?
        if ((!IsPostBack) && Request.QueryString["Per_ID"] != null)
        {
            //If so...Gather Person's ID and Fill Form
            strPer_ID = Request.QueryString["Per_ID"].ToString();
            lbluser_ID.Text = strPer_ID;

            intPer_ID = Convert.ToInt32(strPer_ID);

            //Fill the "temp" Register info based on ID
            register temp = new register();

            SqlDataReader dr = temp.FindOnepost(intPer_ID);
        



            while (dr.Read())
            {
                txtUname.Text = dr["Uname"].ToString();
                txtPword.Text = dr["Pword"].ToString();
                txtPword2.Text = dr["Pword2"].ToString();

            }

        }
        else
        {
            //Do nothing....basic add page (empty)
        }
    }
         protected void btnUpdate_Click(object sender, EventArgs e)
    {
        register temp = new register();

        //Getting the strings from the form and setting them in object
        temp.Uname = txtUname.Text;
        temp.Pword = txtPword.Text;
        temp.Pword2 = txtPword2.Text;
        temp.User_ID = Convert.ToInt32(lbluser_ID.Text);




        //**************************************************************************


        if (!temp.Feedback.Contains("ERROR:"))
        {
            lblFeedback.Text = temp.UpdateARecord();   //if no errors weh setting values, then perform the insertion into db
        }
        else
        {
            lblFeedback.Text = temp.Feedback;       //else...dispay the error msg
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 intuser_ID = Convert.ToInt32(lbluser_ID.Text);  //Get the ID from the Label

        //Create a EBook so we can use the delete method
        register temp = new register();

        //Use the EBook ID and pass it to the delete function
        // and get the number of records deleted
        lblFeedback.Text = temp.DeleteOnepost(intuser_ID);

    }
}
