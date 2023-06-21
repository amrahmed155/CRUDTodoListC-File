<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginAdmin.aspx.cs" Inherits="WebApplication4.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta charset="utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"/>
<link rel="stylesheet" href="css/style.css"/>
    <title>Login</title>

</head>
<body class="img js-fullheight" style="background-image: url(images/bg.jpg);">
        
<section class="ftco-section">
        <form id="form1" runat="server">

<div class="container">
<div class="row justify-content-center">

<div class="col-md-6 text-center mb-5">

<%--<h2 class="heading-section">Login #10</h2>--%>
    <asp:Label ID="Label2" runat="server"  Text="" ForeColor="White"></asp:Label>
</div>
</div>
<div class="row justify-content-center">
<div class="col-md-6 col-lg-4">
<div class="login-wrap p-0">
<h3 class="mb-4 text-center">Admin Login</h3>
<div  class="signin-form">
<div class="form-group">
<%--<input id="user" type="text" class="form-control" placeholder="Username" required>--%>
    <asp:TextBox ID="usera1"  type="text" class="form-control" placeholder="Username" required runat="server"></asp:TextBox>
</div>
    
<div class="form-group">
<%--<input id="password-field" type="password" class="form-control" placeholder="Password" required>--%>
    <asp:TextBox ID="passworda1" type="password" class="form-control" placeholder="Password" required runat="server"></asp:TextBox>
<span toggle="#password-field" class="fa fa-fw fa-eye field-icon toggle-password"></span>
</div>
    <asp:Button ID="Button1" class="form-control btn btn-primary submit px-3" runat="server" Text="Button" OnClick="Button1_Click1" />


    
<div class="form-group d-md-flex">
<div class="w-50">
<label class="checkbox-wrap checkbox-primary">Remember Me
<input type="checkbox" checked>
<span class="checkmark"></span>
</label>
    
</div>
<div class="w-50 text-md-right">
<%--<a href="#" style="color: #fff">Forgot Password</a>--%>
    <asp:Label ID="Label3" runat="server" Text="...." style="font-size:10px"></asp:Label>

</div>
</div>
</div>

<%--<p class="w-100 text-center">&mdash; Or Sign In With &mdash;</p>--%>
<div class="social d-flex text-center">
<%--<a href="#" class="px-2 py-2 mr-md-1 rounded"><span class="ion-logo-facebook mr-2"></span> Facebook</a>
<a href="#" class="px-2 py-2 ml-md-1 rounded"><span class="ion-logo-twitter mr-2"></span> Twitter</a>--%>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

</div>

</div>

</div>
</div>
</div>
               </form>
</section>

 
    <script src="js/jquery.min.js"></script>
<script src="js/popper.js"></script>
<script src="js/bootstrap.min.js"></script>
    
</body>
</html>
