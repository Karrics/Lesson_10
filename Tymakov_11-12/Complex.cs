using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_11_12
{
    internal class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Перегрузка оператора сложения
        public static Complex operator +(Complex c1, Complex c2)
        {
            double real = c1.Real + c2.Real;
            double imaginary = c1.Imaginary + c2.Imaginary;
            return new Complex(real, imaginary);
        }

        // Перегрузка оператора вычитания
        public static Complex operator -(Complex c1, Complex c2)
        {
            double real = c1.Real - c2.Real;
            double imaginary = c1.Imaginary - c2.Imaginary;
            return new Complex(real, imaginary);
        }

        // Перегрузка оператора умножения
        public static Complex operator *(Complex c1, Complex c2)
        {
            double real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new Complex(real, imaginary);
        }

        // Перегрузка оператора равенства
        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
        }

        // Перегрузка оператора неравенства
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        // Переопределение метода ToString()
        public override string ToString()
        {
            string sign = Imaginary >= 0 ? "+" : "-";
            return $"{Real} {sign} {Math.Abs(Imaginary)}i";
        }
    }
}
