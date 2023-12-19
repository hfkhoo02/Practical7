using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical7
{
    public partial class Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
            RadioButtonList1.SelectedIndex = 0;
        }

        protected Boolean isValidCardType(string cardNumber)
        {
            Boolean isValid = false;

            if (cardNumber != null)
            {
                if (Regex.IsMatch(cardNumber, "^4\\d{13}") && RadioButtonList1.SelectedIndex == 0)
                {
                    isValid = true;
                }
                else if (Regex.IsMatch(cardNumber, "^5\\d{13}") && RadioButtonList1.SelectedIndex == 1)
                {
                    isValid = true;
                }

            }
            return isValid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (isValidCardType(TextBox5.Text))
            {

            }
            else
            {
                if (RadioButtonList1.SelectedIndex == 0)
                {
                    //Visa

                }
            }
        }
    } 
}