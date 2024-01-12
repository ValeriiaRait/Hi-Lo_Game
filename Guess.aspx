 <!-- FILE:        Guess.aspx -->
 <!-- PROJECT:     HI-LO GAME -->
 <!-- PROGRAMMER:  Valeriia Rait -->
 <!-- DATE:        11.11.2023-->
 <!-- DESCRIPTION: the interface for page that prompts the user to actully start game engine -->
 <!-------------------------------------------------------------------------------------------------------------------------->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Guess.aspx.cs" Inherits="HI_LO_GAME.Guess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title> Make your guess</title>
     <link href="~\Properties\StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1> Now, try to guess the number </h1>
   <form id="form1" runat="server">
       
        <div>
            <!-- GREETING BY NAME -->
             <asp:Label ID="LabelGreetingGuessPage" runat="server" Text="" />
            <!-- text box for entering user guess -->
            <asp:Label ID="LabelInstruction" runat="server" Text="Enter your guess:" />
            <asp:TextBox ID="TextBoxGuess" runat="server" />
            <!-- field for feedback-->
             <asp:Label ID="LabelFeedback" runat="server" Text="" ForeColor ="#000099" />
            <!-- validators-->
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorGuess" runat="server" 
                ControlToValidate="TextBoxGuess" ErrorMessage="    Guess is REQUIRED" ForeColor="Red" />
            <asp:RangeValidator ID="RangeValidatorGuess" runat="server" 
                ControlToValidate="TextBoxGuess" MinimumValue="1" MaximumValue="1000" Type="Integer" 
                ErrorMessage="Enter a VALID number within the range" ForeColor="Red" />
            <br />
            <br />
            <!-- Guess button -->
            <asp:Button ID="ButtonSubmitGuess" runat="server" Text="Make this guess" OnClick="ButtonSubmitGuess_Click"/>
        </div>
    </form>
</body>
</html>
