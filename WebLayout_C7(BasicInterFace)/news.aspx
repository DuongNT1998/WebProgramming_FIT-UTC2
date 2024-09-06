<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news.aspx.cs" Inherits="Demo_C7_TraditionalInterface.news" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Our News</title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id =" container">
      <div id="menu">
         <ul id="navigation">
             <li><a href="default.aspx" class="selected">Home</a></li>
             <li><a href="news.aspx">News</a></li>
             <li><a href="media.aspx">Media</a></li>
             <li><a href="support.aspx">Support</a></li>
             <li><a href="service.aspx">Service</a></li>
             <li><a href="about.aspx">About</a></li>
             <li><a href="contact.aspx">Contact</a></li>
         </ul>
      </div>
      <div id="banner">
        <img src="images/banner_2.jpg" width= "1400px" height="40px" />"
       
      </div>
      <div id="breadcrumb">
         <p>This is breadcrumb</p>
      </div>
      <div id="sidebar">
            <p>This is sidebar</p>
      </div>       
      <div id="content">
          This is the News webpage content!
            

      </div>
      <div class="clear"></div>
      <div id="footer">Copyright &copy; 2024 by NTDuong </div>
          
  </div>
    </form>
</body>
</html>
