using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Complex
    {
        private double value;

        public Complex(double value)
        {
            this.value = value;
        }

        public string Verbose()
        {
            return String.Format("{0}", this.value);
        }

        //СЛОЖЕНИЕ
        public static Complex operator +(Complex instance, double number)
        {
            return new Complex(instance.value + number);
        }
        public static Complex operator +(double number, Complex instance)
        {
            return instance + number;
        }

        public static Complex operator +(Complex instance, Complex Instance)// ЭТО ПРАВИЛЬНО?
        {
            return new Complex(instance.value + Instance.value);
        }

        //УМНОЖЕНИЕ
        public static Complex operator *(Complex instance, double number)
        {
            return new Complex(instance.value * number); 
        }

        public static Complex operator *(double number, Complex instance)
        {
            return instance * number;
        }

        public static Complex operator *(Complex instance, Complex Instance)// ЭТО ПРАВИЛЬНО?
        {
            return new Complex(instance.value * Instance.value);
        }

        //ВЫЧИТАНИЕ
        public static Complex operator -(Complex instance, double number)
        {
            return new Complex(instance.value - number); 
        }

        public static Complex operator -(double number, Complex instance)
        {
            return instance - number;
        }

        public static Complex operator -(Complex instance, Complex Instance)// ЭТО ПРАВИЛЬНО?
        {
            return new Complex(instance.value - Instance.value);
        }

        //ДЕЛЕНИЕ
        public static Complex operator /(Complex instance, double number)
        {
            return new Complex(instance.value / number); 
        }

        public static Complex operator /(double number, Complex instance)
        {
            return instance / number;
        }

        public static Complex operator /(Complex instance, Complex Instance)// ЭТО ПРАВИЛЬНО?
        {
            return new Complex(instance.value / Instance.value);
        }
    }
}
