using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class Controls_usersearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        register temp = new register();


        DataSet ds = temp.SearchRegister(txtUname.Text);

        gvpost.DataSource = ds;
        gvpost.DataMember = ds.Tables[0].TableName;
        gvpost.DataBind();
    }
}