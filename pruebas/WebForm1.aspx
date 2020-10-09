<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pruebas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: 708px;
            top: 231px;
            height: 500px;
            width: 500px;
        }
        .auto-style2 {
            width: 106px;
        }
    </style>
</head>
<body style="width: 1781px; height: 507px">
    <form id="form1" runat="server" class="auto-style2">
        <asp:HiddenField ID ="turno" Value="2" runat="server" />
        <table id="Table1" 
             style="border-width:1; border-color:Black; padding:5"
             cellspacing="0" 
             runat="server"/>
    </form>
</body>
</html>
