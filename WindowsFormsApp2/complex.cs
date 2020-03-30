using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Complex
    {
        private double real;
        private double image;

        public Complex(double real, double image)
        {
            this.real = real;
            this.image = image;
        }

        public string Verbose()
        {
            return String.Format("{0}+{1}i", this.real, this.image);
        }

        public static Complex operator +(Complex A, Complex B)//СУММА
        {
            return new Complex(A.real + B.real, A.image +  B.image);
        }

        public static Complex operator *(Complex A, Complex B)//УМНЖЕНИЕ
        {
            return new Complex(A.real * B.real, A.image * B.image);
        }

        public static Complex operator -(Complex A, Complex B)//ВЫЧИТАНИЕ
        {
            return new Complex(A.real - B.real, A.image - B.image);
        }

        public static Complex operator /(Complex A, Complex B)//ДЕЛЕНИЕ
        {
            return new Complex(A.real / B.real, A.image / B.image);
        }

        public static Complex operator %(Complex A, Complex B)//СРАВНЕНИЕ
        {
            return new Complex(Math.Sqrt(A.real + A.image), Math.Sqrt(B.real + B.image));
        }
    }
}
