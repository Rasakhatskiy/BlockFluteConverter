using System;

namespace BlockFluteConverter.Core.Classes
{
    public class Fraction
    {
        public int Num { get; }
        public int Denom { get; }

        public Fraction(int num, int denom)
        {
            if (denom == 0)
            {
                throw new DivideByZeroException();
            }
            Num = num;
            Denom = denom;
        }

        public Fraction Reduce()
        {
            return new Fraction(Num / Gcd.Execute(Num, Denom), Denom / Gcd.Execute(Num, Denom));
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.Num * b.Denom + b.Num * a.Denom, a.Denom * b.Denom).Reduce();
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.Num * b.Denom - b.Num * a.Denom, a.Denom * b.Denom).Reduce();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var other = (Fraction)obj;
            return Num == other.Num && Denom == other.Denom;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Num * 397) ^ Denom;
            }
        }

        public override string ToString()
        {
            return $"{Num}/{Denom}";
        }
    }
}
