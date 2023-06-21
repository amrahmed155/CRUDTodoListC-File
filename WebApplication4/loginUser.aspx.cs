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

        public String ReadFileHandled(string filename, String u1, String p1)
        {
            try
            {
                int lineNumber = 0;
                TextReader reader = new StreamReader(filename);
                //string line = reader.ReadToEnd();
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine($"Line {lineNumber}: {line}");


                    int spaceIndex = line.IndexOf(" ");
                    username = line.Substring(0, spaceIndex).Trim();
                    password = line.Substring(spaceIndex + 1).Trim();
                    if (u1.Equals(username) && p1.Equals(password))
                    {
                        // Label2.Text = "Welcome your Username and password are correct";
                        reader.Close();

                        Response.Redirect("WebForm1.aspx");
                        return line;

                    }
                    line = reader.ReadLine();


                }
                reader.Close();
                return "";


            }
            catch (ArgumentException ex)
            {
                return ("error: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                return ("error: " + ex.Message);
            }
            catch (IOException ex)
            {
                return ("error: " + ex.Message);
            }
            catch (Exception ex)
            {
                return ("error: " + ex.Message);
            }


        }


       protected void Button1_Click1(object sender, EventArgs e)
        {


            String u1 = user1.Text;
            String p1 = password1.Text;
            ReadFileHandled(Server.MapPath("Files/credentialsUser.txt"), u1, p1);

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