using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class createUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click2(object sender, EventArgs e)
        {

            fileloader fl1=new fileloader();
            String u1 = user1.Text;
            String p1 = password1.Text;
            fl1.appendCredentials(Server.MapPath("Files/credentialsUser.txt"),u1,p1);
        }
    }
}