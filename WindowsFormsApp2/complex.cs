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

        public Complex()
        {
        }

        public string Verbose()
        {
            return String.Format("{0}+{1}i", this.real, this.image);
        }

        public string Ave()
        {
            if (this.real > this.image)
            {
                return String.Format("z1 > z2", this.real, this.image);
            }
            if (this.real < this.image)
            {
                return String.Format("z1 < z2", this.real, this.image);
            }
            else
            {
                return String.Format("z1 = z2", this.real, this.image);
            }
        }


        public static Complex operator +(Complex A, Complex B)//СУММА
        {
            return new Complex(A.real + B.real, A.image +  B.image);
        }

        public static Complex operator *(Complex A, Complex B)//УМНЖЕНИЕ
        {
            Complex res = new Complex();
            res.real = A.real * B.real - A.image * B.image;
            res.image = A.real * B.image + A.image * B.real;
            return res;
        }

        public static Complex operator -(Complex A, Complex B)//ВЫЧИТАНИЕ
        {
             
            return new Complex(A.real - B.real, A.image - B.image);
        }

        public static Complex operator /(Complex A, Complex B)//ДЕЛЕНИЕ
        {
            Complex res = new Complex();
            res.real = (A.real * B.real + A.image * B.image) / (Math.Pow(B.real,2) + Math.Pow(B.image, 2));
            res.image = (A.image * B.real - A.real * B.image) / (Math.Pow(B.real, 2) + Math.Pow(B.image, 2));
            return res;
        }

        public static Complex operator %(Complex A, Complex B)//СРАВНЕНИЕ
        {
            /*Complex res = new Complex();
            res.real = Math.Sqrt(A.real * A.real + A.image * A.image);
            res.image = Math.Sqrt(B.real * B.real + B.image * B.image);
            bool N = true;
            if (res.real < res.image || res.real > res.image)
            {
                return N;
            }
            else {
                return N;
            }*/
            return new Complex(Math.Sqrt(A.real + A.image), Math.Sqrt(B.real + B.image));
        }
        public static bool operator >(Complex A, Complex B)
        {
            //var a = new Complex(A.real, A.image);
            //var b = new Complex(B.real, B.image);

            var AVect = Math.Sqrt(A.real * A.real + A.image * A.image);
            var BVect = Math.Sqrt(B.real * B.real + B.image * B.image);

            if (AVect > BVect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Complex A, Complex B)
        {
            //var a = new Complex(A.real, A.image);
            //var b = new Complex(B.real, B.image);

            var AVect = Math.Sqrt(A.real * A.real + A.image * A.image);
            var BVect = Math.Sqrt(B.real * B.real + B.image * B.image);

            if (AVect < BVect)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
