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

        public Boolean appendCredentials(String u1, String p1)
        {
            try
            {

                TextWriter writer = new StreamWriter(Server.MapPath("Files/credentialsUser.txt"), append: true);
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

        protected void Button1_Click2(object sender, EventArgs e)
        {


            String u1 = user1.Text;
            String p1 = password1.Text;
            appendCredentials(u1,p1);
        }
    }
}