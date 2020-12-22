using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcWebClient
{
    public partial class CalcForm : System.Web.UI.Page
    {
        CalcServRef.CalculatorClient client = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new CalcServRef.CalculatorClient("BasicHttpBinding_ICalculator");
        }     

        protected void btnMul_Click(object sender, EventArgs e)
        {
            lblResult.Text = client.Mul(double.Parse(txtOp1.Text), 
                                        double.Parse(txtOp2.Text)).ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = client.Add(double.Parse(txtOp1.Text), 
                                        double.Parse(txtOp2.Text)).ToString();
        }
    }
}