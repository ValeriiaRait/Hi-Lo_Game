 <!-- FILE:        MaxNumber.aspx -->
 <!-- PROJECT:     HI-LO GAME -->
 <!-- PROGRAMMER:  Valeriia Rait -->
 <!-- DATE:        11.11.2023-->
 <!-- DESCRIPTION: the interface for page that prompts the user to enter max number for guessing, including its validaton-->
 <!-------------------------------------------------------------------------------------------------------------------------->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaxNumber.aspx.cs" Inherits="HI_LO_GAME.MaxNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hi-Lo Game - Enter Maximum Number</title>
     <link href="~\Properties\StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h2> Set the limit </h2>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="LabelGreeting" runat="server" Text="" />
            <asp:Label ID="LabelMaxNumber" runat="server" Text="Enter the maximum number:" />
            <asp:TextBox ID="TextBoxMaxNumber" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorMaxNumber" runat="server" 
                ControlToValidate="TextBoxMaxNumber" ErrorMessage="Maximum number is required" ForeColor="Red" />
            <asp:RangeValidator ID="RangeValidatorMaxNumber" runat="server" 
                ControlToValidate="TextBoxMaxNumber" MinimumValue="2" MaximumValue="2147483647" Type="Integer" 
                ErrorMessage="Enter a valid number greater than 1" ForeColor="Red" />
            <br />
            <br />
            <asp:Button ID="ButtonSubmitMaxNumber" runat="server" Text="Submit" OnClick="ButtonSubmitMaxNumber_Click" />
        </div>
    </form>
</body>
</html>
