using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            var x = o1num.Text;
            var y = o2num.Text;

            try
            {
                var calcResult = CalcHelper.Add(x, y);
                result.Text = $"{x} + {y} = {calcResult}";
            }
            catch (Exception ex)
            { 
                result.Text = "Please enter valid operands.";
                o1num.Text = "";
                o2num.Text = "";
            }

        }

        protected void sub_Click(object sender, EventArgs e)
        {
            var x = o1num.Text;
            var y = o2num.Text;

            try
            {
                var calcResult = CalcHelper.Subtract(x, y);
                result.Text = $"{x} - {y} = {calcResult}";
            }
            catch (Exception ex)
            {
                result.Text = "Please enter valid operands.";
                o1num.Text = "";
                o2num.Text = "";
            }
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            var x = o1num.Text;
            var y = o2num.Text;

            try
            {
                var calcResult = CalcHelper.Multiply(x, y);
                result.Text = $"{x} * {y} = {calcResult}";
            }
            catch (Exception ex)
            {
                result.Text = "Please enter valid operands.";
                o1num.Text = "";
                o2num.Text = "";
            }
        }

        protected void div_Click(object sender, EventArgs e)
        {
            var x = o1num.Text;
            var y = o2num.Text;

            try
            {
                var calcResult = CalcHelper.Divide(x, y);
                result.Text = $"{x} / {y} = {calcResult}";
            }
            catch (Exception ex)
            {
                result.Text = "Please enter valid operands.";
                o1num.Text = "";
                o2num.Text = "";
            }
        }
    }
}