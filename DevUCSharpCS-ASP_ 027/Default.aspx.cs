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
            monsterHealth -= random.Next(1, 10);

            int round = 0;
            result += "<br />Round: " + round;
            result += String.Format("<br />Hero attacks first, leaving monster with {0} health.",
                monsterHealth);

            //battle logic!

            while (heroHealth > 0 && monsterHealth > 0)
            {
                int heroDamage = random.Next(1, 10);
                int monsterDamage = random.Next(1, 20);

                monsterHealth -= heroDamage;
                heroHealth -= monsterDamage;

                result += "<br />Round: " + ++round; //output for the round number

                result += String.Format //output for hero damage
                    (
                    "<br />The hero causes {0} damage, leaving the monster with {1} health.",
                    heroDamage, monsterHealth);

                result += String.Format //output for monster damage
                    (
                    "<br />The monster causes {0} damage, leaving the hero with {1} health.",
                    monsterDamage, heroHealth);
            }

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