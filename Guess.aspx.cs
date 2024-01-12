//FILE: MaxNumber.aspx.cs
//PROJECT: HI-LO GAME
//PROGRAMMER: Valeriia Rait
//DATE: 11.11.2023
//DESCRIPTION: the back-end code for entering and validating the max number, generating the random number
//------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HI_LO_GAME
{
    public partial class Guess : System.Web.UI.Page
    {
        private const int DefaultMinNumber = 1;  //default min number to start with

        //FUNCTION: Page_Load
        //RETURN: void
        //PARAMETERS: object sender, EventArgs e
        //DESCRIPTION: a method that intially will show the allowable range to start with 
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelFeedback.Text = $"Allowable range is from 1 to {(int)Session["maxNumber"]}";
        }


        //FUNCTION: ButtonSubmitGuess_Click
        //RETURN: void
        //PARAMETERS: object sender, EventArgs e
        //DESCRIPTION:event driven method that will be executed each time the user submits the guess
        protected void ButtonSubmitGuess_Click(object sender, EventArgs e)
        {
            int guessNumGuess = (int)Session["guessNum"];
            int maxNumberGuess = (int)Session["maxNumber"];
            int minNumberGuess = Session["minNumber"] != null ? (int)Session["minNumber"] : DefaultMinNumber; //if the minNumber is not set by session, we set to DefaultMinNuber = 1
            int userGuessNumber;
            bool userGuessNumberIsValid = int.TryParse(TextBoxGuess.Text, out userGuessNumber);  //trying to convert the guess number to valid integer and storing it to bool parameter
            string userMessage;
            bool numberIsGuessed;  //variable to store if the random number is guessed
         
            if (userGuessNumberIsValid)
            {

                if (userGuessNumber < minNumberGuess || userGuessNumber > maxNumberGuess)
                {
                    userMessage = $"REMINDER: your range is from {minNumberGuess} to {maxNumberGuess}";
                    numberIsGuessed = false;
                }
                else if (userGuessNumber > guessNumGuess)
                {
                    
                    numberIsGuessed = false;
                    maxNumberGuess = userGuessNumber - 1; // adjust the maximum number
                    Session["maxNumber"] = maxNumberGuess;
                    userMessage = $"Too high! Now, your allowable range is from {minNumberGuess} to {maxNumberGuess}.";

                }
                else if (userGuessNumber < guessNumGuess)
                {                  
                    numberIsGuessed = false;
                    minNumberGuess = userGuessNumber + 1; // adjust the minimum number
                    Session["minNumber"] = minNumberGuess;
                    userMessage = $"Too low! Now, your allowable range is from {minNumberGuess} to {maxNumberGuess}.";
                }
                //success, guess number guessed
                else
                {
                    numberIsGuessed = true;
                    userMessage = string.Empty;
                }
            }
            else
            {
                numberIsGuessed = false;
                userMessage = "Please enter a valid number.";
            }


            //adjusting functionality based on the results of user entering number
            if (numberIsGuessed)
            {
                Server.Transfer("Success.aspx", true);
            }
            else {
                LabelFeedback.Text = userMessage;
            }
        }
    }
}