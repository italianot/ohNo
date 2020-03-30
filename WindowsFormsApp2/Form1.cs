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
                //var thirdComplex = new Complex(thirdValue);  //   c
                //var forthComplex = new Complex(forthValue);  //   d

                Complex sumComplex; //если подставить вместо res1 и закомментить res2, то это не работает, не знаю почему
                Complex res1;
                Complex res2;

                switch (cmbOperation.Text)
                {
                    case "+":
                        res1 = firstComplex + secondComplex; 
                        //res2 = secondComplex + forthComplex;
                        txtResult.Text = res1.Verbose() /*+ "+" + res2.Verbose()*/ + "i";
                        break;
                    case "-":
                        res1 = firstComplex - secondComplex;
                        //res2 = secondComplex - forthComplex;
                        txtResult.Text = res1.Verbose() /*+ "+" + res2.Verbose()*/ + "i";
                        break;
                    case "*":
                        res1 = (firstComplex * secondComplex) - (firstComplex * secondComplex);
                        //res2 = ( firstComplex * forthComplex )+ (secondComplex * thirdComplex );
                        txtResult.Text = res1.Verbose() /*+ "+" + res2.Verbose()*/ + "i";
                        break;
                    case "/":
                        res1 = ((firstComplex * thirdComplex) + (secondComplex * forthComplex))/((thirdComplex* thirdComplex) + (forthComplex* forthComplex));
                        //res2 = ((secondComplex * thirdComplex) - (firstComplex * forthComplex))/((thirdComplex*thirdComplex) + (forthComplex*forthComplex));
                        txtResult.Text = res1.Verbose() /*+ "+" + res2.Verbose()*/ + "i";
                        break;
                    default:
                        sumComplex = new Complex(0,0);
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
