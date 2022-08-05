using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDiv
{
    internal class clsMath
    {
        public int _numerator;
        public int _denominator;

        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                if (value == 0)
                {
                    _denominator = 1;
                }
                else
                {
                    _denominator = value;
                }
            }
        }
        public void Minus()
        {
            Denominator--;
        }
        //возвращает половину меньшего числа из двух чисел.
        public static int HalfNumber(int numb1, int numb2)
        {
            Int32 numb = numb1;
            if (numb > numb2)
            {
                numb = numb2;
            }
            decimal dDiv = numb / 2;
            numb = Decimal.ToInt32(dDiv);
            return numb;
        }

        public static double FractionResult(int numerator, int denominator, byte numb_round)
        {

            //decimal dNumb = Math.Round(numerator / denominator, numb_round);
            double result = (double)numerator / denominator;
            result = Math.Round(result, numb_round);
            return result;
        }

        public static void ReduceFraction(int numerator, int denominator)
        {
            string result = "";
            bool fStop = false;
            int n1 = numerator;
            int n2 = denominator;
            int unitNumb = 2;

            // Console.WriteLine($"numerator % denominator {numerator % denominator}");
            if ((numerator > denominator) & (numerator % denominator == 0))
            {
                n1 = numerator / denominator;
                n2 = 1;
                fStop = true;
            }
            else if ((denominator > numerator) & (denominator % numerator == 0))
            {
                n1 = 1;
                n2 = denominator / numerator;
                fStop = true;
            }

            if (fStop == false)
            {
                while (unitNumb > 1)
                {
                    unitNumb = HalfNumber(n1, n2);
                    int i;
                    for (i = unitNumb; i > 1; i--)
                    {
                        if ((n1 % i == 0) & (n2 % i == 0))
                        {
                            n1 = numerator / i;
                            n2 = denominator / i;
                            break;
                        }

                    }
                    if (i == 1)
                    {
                        unitNumb = 1;
                    }
                }
            }

            Console.WriteLine($"Сокращенная дробь : {n1} / {n2}");
        }
    }
}
