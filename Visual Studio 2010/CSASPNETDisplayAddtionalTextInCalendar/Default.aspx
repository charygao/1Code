﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSASPNETDisplayAddtionalTextInCalendar.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="myCalendar" runat="server" ondayrender="myCalendar_DayRender" 
            onprerender="myCalendar_PreRender" 
            onselectionchanged="myCalendar_SelectionChanged"></asp:Calendar>
        <asp:Button ID="btnCheck" runat="server" onclick="btnCheck_Click" 
            Text="Check selected dates" />
    </div>
    </form>
</body>
</html>
