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

        public String ReadFileHandled(string filename,String u1,String p1)
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

                        Response.Redirect(Server.MapPath("Files/createUser.aspx"));
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


        public Boolean appendCredentials(String u1, String p1)
        {
            try
            {
              
                TextWriter writer = new StreamWriter(Server.MapPath("Files/credentialsUser.txt"));
                //string line = reader.ReadToEnd();
                writer.WriteLine(u1 + " " + p1);


                writer.Close();
                return true;


            }
            catch (ArgumentException ex)
            {
                return false;
            }
            catch (FileNotFoundException ex)
            {
                return false;
            }
            catch (IOException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {


            String u1 = usera1.Text;
            String p1 = passworda1.Text;
            ReadFileHandled(Server.MapPath("Files/credentials.txt"), u1, p1);
         
        }
    }
    //jenkins 
    //continous integration continous deployment
}