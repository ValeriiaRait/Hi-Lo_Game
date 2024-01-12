//FILE: WebForm1.aspx.cs
//PROJECT: HI-LO GAME
//PROGRAMMER: Valeriia Rait
//DATE: 11.11.2023
//DESCRIPTION: the back-end code for start up page that tranfers the user to max number propmt if the page is valid 
//------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HI_LO_GAME
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //FUNCTION: ButtonTryAgain_Click
        //RETURN: void
        //PARAMETERS: object sender, EventArgs e
        //DESCRIPTION: event driven method that will be excuted when user will enter its name
        protected void ButtonStart_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["UserName"] = TextBoxName.Text;
                Server.Transfer("MaxNumber.aspx", true);
            }
        }
    }
}