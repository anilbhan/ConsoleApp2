using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClassDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company c = new Company();

            Response.Write("The Employeeid and Name =" + c[2]);
            Response.Write("<br/>");
            Response.Write("The Employeeid and Name=" + c[3]);
            Response.Write("<br/>");
            Response.Write("The Employeeid and Name=" + c[6]);

            Response.Write("<br/>");

            Response.Write("Before Update");
            Response.Write("<br/>");

            Response.Write("Total Number of Male Gender" + c["Male"]);
            Response.Write("<br/>");

            Response.Write("Total Number of Female Gender" + c["Female"]);
            Response.Write("<br/>");

            c["Male"] = "Female";
            Response.Write("<br/>");

            Response.Write("Total Number of Male Gender" + c["Male"]);
            Response.Write("<br/>");

            Response.Write("Total Number of Female Gender" + c["Female"]);



        }
    }
}