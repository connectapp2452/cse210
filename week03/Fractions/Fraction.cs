namespace Fractions
{
    public class Fraction
    {
        private int _topNumber;
        private int _bottomNumber;

        public Fraction()
        {
            _topNumber = 1;
            _bottomNumber = 1;
        }

        public int SetTopNumber(int topNumber)
        {
            _topNumber = topNumber;
            return _topNumber;
        }

        public int SetBothNumbers(int top, int bottom)
        {
            _topNumber = top;
            _bottomNumber = bottom;
            return _topNumber;
        }

        public double GetDecimal(int top, int bottom)
        {
            return (double)top / bottom;
        }
        // int Fraction.SetTopFraction(int top)
        // {
        //     _topNumber = top;
        //     return _topNumber;
        // }

        // public SetBothFraction(int top, int bottom)
        // {
        //     _topNumber = top;
        //     _bottomNumber = bottom;
        // }

        public string GetFractionString()
        {
            return $"{_topNumber}/{_bottomNumber}";
        }

        // public int SetTopNumber(int topNumber)
        // {
        //     _topNumber = topNumber;
        //     _bottomNumber = 1;
        //     return _topNumber;
        // }
    }
}