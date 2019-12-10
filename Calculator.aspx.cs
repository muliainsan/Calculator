using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Calc
{
    public partial class Calculator : System.Web.UI.Page
    {
        
        Calculate _Calculate;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Calculate = new Calculate();
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "6";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "8";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "9";
        }

        protected void ButtonComa_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + ".";
        }

        protected void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                calc_result.Value = "-" + calc_result.Value;
            }


        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
                calc_result.Value = calc_result.Value + "+";
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "-";
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        { 
            calc_result.Value = calc_result.Value + "*";
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        { 
            calc_result.Value = calc_result.Value + "/";
        }

        protected void ButtonKa_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "(";
        }

        protected void ButtonKi_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + ")";
        }

        protected void ButtonCE_Click(object sender, EventArgs e)
        {
            calc_result.Value = string.Empty;
        }

        protected void ButtonReturn_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                string CharactersInTextBox = calc_result.Value;
                string FinalCharactersInTextBox = string.Empty;

                for (int i = 0; i < CharactersInTextBox.Length - 1; i++)
                {
                    FinalCharactersInTextBox = FinalCharactersInTextBox + CharactersInTextBox[i];
                }

                calc_result.Value = FinalCharactersInTextBox;
            }
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            
            string value = new DataTable().Compute(calc_result.Value, null).ToString();
            if (double.IsInfinity(Convert.ToDouble(value)))
            {
                Response.Write("<script>alert('Infinity Result')</script>");
                calc_result.Value = string.Empty;
            }
            else
            {
                calc_result.Value = value.ToString();
            }
            
            
        }

    }
}