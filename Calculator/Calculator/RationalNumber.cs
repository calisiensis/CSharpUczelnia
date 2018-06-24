using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class RationalNumber : Operand
    {
        private int _meter = 0;
        private int _denominator = 0;

        public RationalNumber(int meter, int denominator)
        {
            _meter = meter;
            _denominator = denominator;
        }

        public RationalNumber(string expression)
        {
            string[] split = expression.Split(':');

            _meter = int.Parse(split[0]);
            _denominator = int.Parse(split[1]); ;
        }

        public static implicit operator int (RationalNumber rationalNumber)
        {
            return rationalNumber._meter / rationalNumber._denominator;
        }

        public static implicit operator double(RationalNumber rationalNumber)
        {
            return rationalNumber._meter / rationalNumber._denominator;
        }

        private class ComonDenominator
        {
            public int MeterA, MeterB, Denominator;

            public ComonDenominator(RationalNumber a, RationalNumber b)
            {
                if(a._denominator != b._denominator)
                {
                    MeterA = a._meter * b._denominator;
                    MeterB = b._meter * a._denominator;

                    Denominator = a._denominator * b._denominator;
                }
                else
                {
                    MeterA = a._meter;
                    MeterB = b._meter;

                    Denominator = a._denominator;
                }
            }
        }

        public static RationalNumber operator + (RationalNumber a, RationalNumber b)
        {
            ComonDenominator comonDenominator = new ComonDenominator(a, b); 

            return new RationalNumber(comonDenominator.MeterA + comonDenominator.MeterB, comonDenominator.Denominator);
        }

        public static RationalNumber operator - (RationalNumber a, RationalNumber b)
        {
            ComonDenominator comonDenominator = new ComonDenominator(a, b);

            return new RationalNumber(comonDenominator.MeterA - comonDenominator.MeterB, comonDenominator.Denominator);
        }

        public static RationalNumber operator * (RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a._meter * b._meter, a._denominator * b._denominator);
        }

        public static RationalNumber operator / (RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a._meter * b._denominator, a._denominator * b._meter);
        }

        public override Symbol Calculate()
        {
            return this;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", _meter, _denominator);
        }
    }
}
