<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"/>
<link rel="stylesheet" href="css/style.css"/>
<meta charset="utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>

    <title>todo list</title>
 <style>

    body     {
  font-family: Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

    table{width:590px;
height:348px;
     }
 td,  th {
  border: 1px solid #ddd;
  padding: 8px;
  color:black;
}

 tr:nth-child(even){background-color: #f2f2f2;}

 tr:hover {background-color: #ddd;}

 th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #04AA6D;
  color: white;
}
    </style>
</head>
<body class="img js-fullheight" style="background-image: url(images/bg.jpg);">
        
     <form id="form1" runat="server">
        <div>
            
            <table>
                <tr>
                    <td>Add items in todo list</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click1" />
                    </td>
                </tr>
                <tr>
                    <td>Remove last item in list</td>
                    <td></td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Remove" OnClick="Button2_Click1" />

                    </td>
                </tr>
                 <tr>
                    <td>Remove specific item from list</td>
                        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="Button6" runat="server" Text="Remove" OnClick="Button6_Click1" />

                    </td>
                </tr>
                <tr>
                    <td>check value avaiability in todo list</td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="check" OnClick="Button3_Click1"/>

                    </td>
                </tr>
                <tr>
                    <td>Get last item inserted</td>
                    <td></td>
                    <td>
                        <asp:Button ID="Button4" runat="server" Text="Peek" OnClick="Button4_Click1" />

                    </td>
                </tr>
                <tr>
                    <td>clear todo list</td>
                    <td></td>
                    <td>
                        <asp:Button ID="Button5" runat="server" Text="clear" OnClick="Button5_Click1" /></td>
                </tr>
                <tr>
                    <td colspan="3"> <asp:Button ID="Button7" runat="server" Text="Save" OnClick="Button7_Click1"  /></td></td>
                </tr>
               
            </table>

             <asp:Label ID="Label1" runat="server" Text="messages" ForeColor="Black" BorderColor="Black"></asp:Label>
         </div>
     <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" EnableModelValidation="True" GridLines="Horizontal" Height="153px" Width="423px">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        </asp:GridView>        
    </form>

 
  
    
</body>
</html>
