using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3
{
    public partial class NonGucian_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewInfo(object sender, EventArgs e)
        {


            Response.Redirect("view_info.aspx");




        }

        protected void list_thesis(object sender, EventArgs e)
        {

            Response.Redirect("list_thesis.aspx");

        }

        protected void progress_report(object sender, EventArgs e)
        {
            Response.Redirect("progress_report.aspx");


        }

        protected void Publication(object sender, EventArgs e)
        {

            Response.Redirect("pub.aspx");

        }

     
     

        protected void Course(object sender, EventArgs e)
        {

            Response.Redirect("NonGucian_Course.aspx");

        }
        protected void logout(object sender, EventArgs e)
        {

            Response.Redirect("login.aspx");

        }


    }
}