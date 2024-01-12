//FILE: Success.aspx.cs
//PROJECT: HI-LO GAME
//PROGRAMMER: Valeriia Rait
//DATE: 11.11.2023
//DESCRIPTION: the back-end code for Success.aspx to display success message and providing user chance to play again
//------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HI_LO_GAME
{
    public partial class Success : System.Web.UI.Page
    {

        //FUNCTION: Page_Load
        //RETURN: void
        //PARAMETERS: object sender, EventArgs e
        //DESCRIPTION: a method that intially sets the playerName
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LabelCongrats.Text = "You Win!! You guessed the number!";            
            }
        }

        //FUNCTION: ButtonTryAgain_Click
        //RETURN: void
        //PARAMETERS: object sender, EventArgs e
        //DESCRIPTION: event driven method that will be excuted when user will want to play again
        protected void ButtonTryAgain_Click(object sender, EventArgs e)
        {
            Session.Remove("maxNumber");
            Session.Remove("minNumber");
            Session.Remove("guessNum");
            Response.Redirect("MaxNumber.aspx"); // Assuming this is your starting page
        }
    }
}