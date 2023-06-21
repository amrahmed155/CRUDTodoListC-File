using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected string username;
        protected string password;
        protected string role;
        protected void Page_Load(object sender, EventArgs e)
        {



        }

       

       
        protected void Button1_Click1(object sender, EventArgs e)
        {

            fileloader fl1= new fileloader();
            String u1 = usera1.Text;
            String p1 = passworda1.Text;
            if (fl1.ReadFileHandled(Server.MapPath("Files/credentials.txt"), u1, p1))
            {
                Response.Redirect("createUser.aspx");
                Label3.Text = "Invalid username or password";

            }
            else { Label3.Text = "Invalid username or password"; };
         
        }
    }
    //jenkins 
    //continous integration continous deployment
}