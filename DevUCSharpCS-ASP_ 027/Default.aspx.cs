using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP__027
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            int heroHealth = 30;
            int monsterHealth = 45;

            string result = "";

            //Our intrepid hero gets a bonus first attack...
            monsterHealth -= random.Next(1, 100);

            int round = 0;
            result += "<br />Round: " + round;
            result += String.Format("<br />Hero attacks first, leaving monster with {0} health.",
                monsterHealth);

            //need battle logic here

            if (heroHealth > 0)
            {
                result += "<br />Huzzah! Our hero wins the day!";
            }
            else
            {
                result += "<br />You know why I like this world? Because in this world, " +
                    "the bad guys can win!";
            }
            resultLabel.Text = result;
        }
    }
}