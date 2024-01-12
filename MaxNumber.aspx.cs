//FILE: MaxNumber.aspx.cs
//PROJECT: HI-LO GAME
//PROGRAMMER: Valeriia Rait
//DATE: 11.11.2023
//DESCRIPTION: the back-end code for entering and validating the max number, generating the random number
//------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HI_LO_GAME
{
    public partial class MaxNumber : System.Web.UI.Page
    {
        protected int guessNum;
        protected int maxNumber;
        private static Random rnd = new Random();


        //FUNCTION: Page_Load
        //RETURN: void
        //PARAMETERS: object sender, EventArgs e
        //DESCRIPTION: a method that intially sets the playerName
        protected void Page_Load(object sender, EventArgs e)
        {
            string playerName = (string)Session["UserName"];
            LabelGreeting.Text = $"Hello, {playerName} ;) \n";
        }


        //FUNCTION: ButtonSubmitMaxNumber_Click
        //RETURN: void
        //PARAMETERS: object sender, EventArgs e
        //DESCRIPTION: event drivem method rhat will be excuted when user enteres the maxNumber for guessing
        protected void ButtonSubmitMaxNumber_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {    
                bool isParsed = int.TryParse(TextBoxMaxNumber.Text, out maxNumber);
                if (isParsed && maxNumber > 1)
                {
                    // Generate random number since the maximum number is valid
                    generateRandomNum(maxNumber);
                    Session["maxNumber"] = maxNumber;                  
                    Server.Transfer("Guess.aspx", true);                 
                }              
            }
        }


        //FUNCTION: generateRandomNum
        //RETURN: void
        //PARAMETERS: int maxNum - maximum number entered by user to set the number for guessing in range  
        //DESCRIPTION:
        private void generateRandomNum(int maxNum)
        {
          Random rnd = new Random();
          guessNum = rnd.Next(1, maxNum + 1);
          Session["guessNum"] = guessNum;
        }
    }
}