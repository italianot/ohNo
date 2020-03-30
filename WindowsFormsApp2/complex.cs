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
            return String.Format("{0} {1}", this.real, this.image);
        }

        //СЛОЖЕНИЕ
        /*public static Complex operator +(Complex instance, double number)
        {
            return new Complex(instance.real + number);
        }
        public static Complex operator +(double number, Complex instance)
        {
            return instance + number;
        }*/

        public static Complex operator +(Complex A, Complex B)
        {
            return new Complex(A.real + B.real, A.image +  B.image);
        }

        //УМНОЖЕНИЕ
        /*public static Complex operator *(Complex instance, double number)
        {
            return new Complex(instance.real * number); 
        }

        public static Complex operator *(double number, Complex instance)
        {
            return instance * number;
        }*/

        public static Complex operator *(Complex A, Complex B)
        {
            return new Complex(A.real * B.real, A.image * B.image);
        }








        //ВЫЧИТАНИЕ
        /*public static Complex operator -(Complex instance, double number)
        {
            return new Complex(instance.real - number); 
        }

        public static Complex operator -(double number, Complex instance)
        {
            return instance - number;
        }*/

        public static Complex operator -(Complex A, Complex B)
        {
            return new Complex(A.real - B.real, A.image - B.image);
        }

        //ДЕЛЕНИЕ
        /*public static Complex operator /(Complex instance, double number)
        {
            return new Complex(instance.real / number); 
        }

        public static Complex operator /(double number, Complex instance)
        {
            return instance / number;
        }*/

        public static Complex operator /(Complex A, Complex B)
        {
            return new Complex(A.real / B.real, A.image / B.image);
        }
    }
}
