using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txt11.Text);
                var secondValue = double.Parse(txt12.Text);
                var thirdValue = double.Parse(txt21.Text);
                var forthValue = double.Parse(txt22.Text);


                var firstComplex = new Complex(firstValue, secondValue);  //   a
                var secondComplex = new Complex(thirdValue, forthValue);//   b
                Complex res1;
                

                switch (cmbOperation.Text)
                {
                    case "+":
                        res1 = firstComplex + secondComplex;
                        txtResult.Text = res1.Verbose();
                        break;
                    case "-":
                        res1 = firstComplex - secondComplex;
                        txtResult.Text = res1.Verbose();
                        break;
                    case "*":
                        res1 = firstComplex * secondComplex;
                        txtResult.Text = res1.Verbose();
                        break;
                    case "/":
                        res1 = firstComplex / secondComplex;
                        txtResult.Text = res1.Verbose();
                        break;
                    case "%":
                        res1 = firstComplex % secondComplex;
                        txtResult.Text = res1.Ave();
                        break;
                    default:
                        res1 = new Complex(0,0);
                        break;
                }
            } catch (FormatException){
                
            }
        }
        private void txt11_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt12_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt21_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt22_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
