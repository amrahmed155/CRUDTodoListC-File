using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        
        
        protected LinkedList<string> stacklist
        {
            get { return (LinkedList<string>)Session["stacklist"]; }
            set { Session["stacklist"] = value; }
        }
        protected void BindGridList()
        {
            GridView1.DataSource = stacklist;
            GridView1.DataBind();
        }
        //protected string password;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "hahahahahahha";

            if (stacklist == null) stacklist = new LinkedList<string>();
            BindGridList();

        }
        protected void Button1_Click1(object sender, EventArgs e)//add to list
        {
            Label1.Text = "added " + TextBox1.Text + " to Stack";
            stacklist.AddLast(TextBox1.Text);
            BindGridList();
        }
        protected void Button2_Click1(object sender, EventArgs e)//remove last element added
        {
         try{
                stacklist.RemoveLast();
                BindGridList();
                Label1.Text = "removed from stack";
              }
        catch(Exception ex) {
                Label1.Text = ex.ToString();
            }
        }

        protected void Button3_Click1(object sender, EventArgs e) //check availability
        {
            Label1.Text = "is available:" + stacklist.Contains(TextBox2.Text).ToString();

            //BindGridList();
        }

        protected void Button4_Click1(object sender, EventArgs e)//peek
        {
    
            try { 
            Label1.Text = stacklist.Last.Value;
            }
            catch(Exception ex) { Label1.Text = ex.ToString(); }
            //BindGridList();
        }
        protected void Button5_Click1(object sender, EventArgs e)//clear all
        {
            //Label1.Text = "amoor5";
            stacklist.Clear();
            BindGridList();
        }
        protected void Button6_Click1(object sender, EventArgs e)// remove specific item from list
        {
            stacklist.Remove(TextBox3.Text);
            Label1.Text = "removed " + TextBox1.Text + " from list";
            BindGridList();
        }

        protected void Button7_Click(object sender, EventArgs e)//save in file
        {
            Label1.Text = "amoor6";
            BindGridList();
        }
    }
    //{
    //    protected Stack<string> stacklist {
    //        get { return (Stack<string>)Session["stacklist"]; }
    //        set { Session["stacklist"] = value; } 
    //    } 
    //    protected void BindGridList()
    //    {
    //        GridView1.DataSource = stacklist;
    //        GridView1.DataBind();
    //    }
    //    //protected string password;
    //    protected void Page_Load(object sender, EventArgs e)
    //    {
    //        Label1.Text = "hahahahahahha";

    //        if(stacklist ==null) stacklist = new Stack<string>();
    //        BindGridList();

    //    }
    //    protected void Button1_Click1(object sender, EventArgs e)
    //    {
    //        Label1.Text = "added "+ TextBox1.Text +" to Stack";
    //        stacklist.Push(TextBox1.Text);
    //        BindGridList();
    //    }
    //    protected void Button2_Click1(object sender, EventArgs e)
    //    {
    //        stacklist.Pop();
    //        BindGridList();
    //        Label1.Text = "removed from stack";

    //    }

    //    protected void Button3_Click1(object sender, EventArgs e) //check availability
    //    {
    //        Label1.Text = "is available:"+stacklist.Contains(TextBox2.Text).ToString();

    //        //BindGridList();
    //    }

    //    protected void Button4_Click1(object sender, EventArgs e)//peek
    //    {
    //        Label1.Text = stacklist.Peek();
    //        //BindGridList();
    //    }
    //    protected void Button5_Click1(object sender, EventArgs e)//clear all
    //    {
    //        Label1.Text = "amoor5";
    //        stacklist.Clear();
    //        BindGridList();
    //    }
    //    protected void Button1_Click6(object sender, EventArgs e)
    //    {
    //        Label1.Text = "amoor6";
    //        BindGridList();
    //    }


    //}

}


