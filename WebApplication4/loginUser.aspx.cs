using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class loginUser : System.Web.UI.Page
    {
        protected string username;
        protected string password;
        protected string role;
        protected void Page_Load(object sender, EventArgs e)
        {



        }


       protected void Button1_Click1(object sender, EventArgs e)
        {



            String u1 = user1.Text;
            String p1 = password1.Text;
            fileloader fl1 = new fileloader();
            if (u1 == "" || u1 == null || p1 == "" || p1 == null)
            {
                Label3.Text = " username or password cannot be empty";

            }
            else
            {
                if (fl1.ReadFileHandled(Server.MapPath("Files/credentialsUser.txt"), u1, p1))
                {
                    Response.Redirect("webForm1.aspx");
                    Label3.Text = "Invalid username or password";

                }
                else { Label3.Text = "Invalid username or password"; };
            }

        }
    }
}