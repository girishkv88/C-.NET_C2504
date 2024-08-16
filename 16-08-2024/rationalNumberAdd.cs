class MyUtil
    {
        public static int FindGCD(int a, int b) //GCD
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }
    class RationalNumber
    {
        public int Numerator { get; set; }
        private int denominator;
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (denominator == 0)
                {
                    denominator = 1;
                }
                denominator = value;
            }
        }

        public RationalNumber(int _numerator, int _denominator)
        {
            // throw ERR this.Denominator = 0
            if (_denominator == 0)
            {
                _denominator = 1;
            }
            this.Numerator = _numerator;
            this.Denominator = _denominator;
        }
        public RationalNumber Add(RationalNumber other)
        {
            RationalNumber diff = new RationalNumber(0, 0);
            diff.Numerator = (this.Numerator * other.Denominator) + (other.Numerator * this.Denominator);
            diff.Denominator = this.Denominator * other.Denominator;

            int gcd = MyUtil.FindGCD(diff.Numerator, diff.Denominator);
            diff.Numerator = diff.Numerator / gcd;
            diff.Denominator = diff.Denominator / gcd;
            return diff;
        }

        public override string ToString()
        {
            return $"[{Numerator} / {Denominator}]";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RationalNumber firstNo = new RationalNumber(1, 3);
            RationalNumber secondNo = new RationalNumber(2, 4);
            RationalNumber result = firstNo.Add(secondNo);
            Console.WriteLine($"{firstNo} + {secondNo} = {result}");

        }
    }
