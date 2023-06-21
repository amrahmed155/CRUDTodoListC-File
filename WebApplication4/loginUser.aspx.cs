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
            if(fl1.ReadFileHandled(Server.MapPath("Files/credentialsUser.txt"), u1, p1))
            { Label3.Text = "logged in succeed"; }
            else{ Label3.Text = "invalid login or password"; };

            //if (!line.Contains("error:"))
            //{


            //    if (u1.Equals(username) && p1.Equals(password))
            //    {
            //       // Label2.Text = "Welcome your Username and password are correct";
            //        Response.Redirect("datagridPage.aspx");
            //    }
            //    else
            //    {
            //       // Label2.Text = "please check your Username and password and try again";

            //    }
            //}
            //            else { Label2.Text = line; Label1.Text = "please contact administrator"; }

        }
    }
}