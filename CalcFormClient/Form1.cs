using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcFormClient
{
    public partial class Form1 : Form
    {
        CalcRef.CalculatorClient client = null;
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CalcRef.CalculatorClient client = new CalcRef.CalculatorClient("BasicHttpBinding_ICalculator");
            client = new CalcRef.CalculatorClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            lblResult.Text = client.Add(double.Parse(txtOp1.Text), 
                                        double.Parse(txtOp2.Text)).ToString("0.00");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            CalcRef.CalculatorClient client = new CalcRef.CalculatorClient();
            lblResult.Text = client.Mul(double.Parse(txtOp1.Text), 
                                        double.Parse(txtOp2.Text)).ToString("0.00");
        }
    }
}
