 <!-- FILE:        WebForm1.aspx -->
 <!-- PROJECT:     HI-LO GAME -->
 <!-- PROGRAMMER:  Valeriia Rait -->
 <!-- DATE:        11.11.2023-->
 <!-- DESCRIPTION: the interface for start up page for HI-LO GAME-->
 <!---------------------------------------------------------------------------------------------------------->
<!-- STARTING PAGE-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HI_LO_GAME.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Hi-Lo Game Start</title>
    <link href="~\Properties\StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1> Welcome to HI-LO Game again! :) </h1>
    <form id="form1" runat="server">
        <div>
            <!-- User Name Input -->
            <asp:Label ID="LabelName" runat="server" Text="Enter your name:" />
            <asp:TextBox ID="TextBoxName" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
                ControlToValidate="TextBoxName" ErrorMessage="Name is required" ForeColor="Red" />
            <br />
            <br />
            <!-- Start Game Button -->
            <asp:Button ID="ButtonStart" runat="server" Text="Submit" OnClick="ButtonStart_Click" />
        </div>
    </form>
</body>
</html>
