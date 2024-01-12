 <!-- FILE:        Succes.aspx -->
 <!-- PROJECT:     HI-LO GAME -->
 <!-- PROGRAMMER:  Valeriia Rait -->
 <!-- DATE:        11.11.2023-->
 <!-- DESCRIPTION: interface for users that is executed when the user guesses the random number correctly -->
 <!---------------------------------------------------------------------------------------------------------->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="HI_LO_GAME.Success" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~\Properties\StyleSheet1.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body {
            background-color: lightgreen;
        }
        </style>

</head>
<body>
    <h1> CONGRATULATIONS </h1>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="LabelCongrats" runat="server" />
            <br/>
            <br/>
            <asp:Button ID="ButtonTryAgain" runat="server" Text="Play Again" OnClick="ButtonTryAgain_Click" />
        </div>
    </form>
</body>
</html>
