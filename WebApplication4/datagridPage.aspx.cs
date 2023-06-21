using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public static List<String> enhancedfilereader(string filename,String sortdir)
        {
            List<string> filelines = new List<string>();

            try
            {
                int lineNumber = 0;// create a count for lines
                string text = "";
                TextReader r = new StreamReader(filename);
                string line;// = r.ReadLine();
                while ((line = r.ReadLine()) != null)//check if the  line read is not null or not
                {
                    lineNumber++;
                    // text =text+"<b>"+ line+"</b><hr>";
                    filelines.Add(line);
                    // line =r.ReadLine();

                }



                r.Close();
                if (sortdir == "ASC") { filelines.Sort(); }
                else {filelines.Sort();filelines.Reverse();
            }
                /*foreach (String fileline in filelines)
                {
                    text = text + "<b>" + fileline + "</b><hr>";
                }*/
              //  l1.Text = text;
            }

            catch (Exception ex)
            {
            //    l2.Text = ex.Message;
            }
            return filelines;
        }

        protected void BindGridList()
        {
            GridView1.DataSource = enhancedfilereader("C:\\Users\\dell\\source\\repos\\ConsoleApp5\\ConsoleApp5\\bin\\Debug\\net6.0\\t.txt","ASC");
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {

        
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
          
            GridView1.PageIndex = e.NewPageIndex;
            BindGridList();

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindGridList();


        }
    }
}