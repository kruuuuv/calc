using System.Text.RegularExpressions;

namespace calc.Models
{
    public class Angle
    {
        private int _degrees;
        private int _minutes;
        private int _seconds;
        private decimal _decimalPart;

        public double Radians
        {
            get
            {
                return (double)ToDecimalDegrees() * Math.PI / 180;
            }
        }

        public static Angle FromRadians(double radians)
        {
            return FromDecimal((decimal)(radians * 180 / Math.PI));
        }

        public Angle(int degrees, int minutes, int seconds, decimal decimalPart = 0)
        {
            _degrees = degrees;
            _minutes = minutes;
            _seconds = seconds;
            _decimalPart = decimalPart;
        }

        public decimal ToDecimalDegrees()
        {
            return _degrees + Math.Round((_minutes + (_seconds + _decimalPart) / 60m) / 60m, 11, MidpointRounding.AwayFromZero);
        }

        public static Angle FromDecimal(decimal dec)
        {
            var d = Math.Round(dec, 0, MidpointRounding.ToZero);
            var m_full = (dec - d) * 60m;
            var m = Math.Round(m_full, 0, MidpointRounding.ToZero);
            var s_full = (m_full - m) * 60m;
            var s = Math.Round(s_full, 0, MidpointRounding.ToZero);
            var dp = Math.Round(s_full - s, 5, MidpointRounding.ToZero);

            // Нужно для округления при нулевой части
            if (dp == 0m)
            {
                dp = 0m;
            }
            return new Angle((int)d, (int)m, (int)s, dp);
        }

        public static Angle FromString(string value)
        {
            var regEx = new Regex("\\s*(?<degrees>[-+]?\\d+°)?\\s*(?<minutes>\\d+')?\\s*(?<seconds>\\d+'')?\\s*(?<decimalpart>\\.\\d+\")?");
            var match = regEx.Match(value);
            if (match.Success)
            {
                int d = 0, m = 0, s = 0;
                decimal p = 0;
                foreach (var key in match.Groups.Keys)
                {
                    switch (match.Groups[key].Name)
                    {
                        case "degrees":
                            int.TryParse(match.Groups[key].Value.Replace("°", ""), out d);
                            break;
                        case "minutes":
                            int.TryParse(match.Groups[key].Value.Replace("'", ""), out m);
                            break;
                        case "seconds":
                            int.TryParse(match.Groups[key].Value.Replace("''", ""), out s);
                            break;
                        case "decimalpart":
                            decimal.TryParse(string.IsNullOrEmpty(match.Groups[key].Value) ? "0" : $"0{match.Groups[key].Value}", out p);
                            break;
                        default:
                            break;
                    }
                }
                var a = new Angle(d, m, s, p);
                return a;
            }
            return new Angle(0, 0, 0);
        }

        public override string ToString()
        {
            return $"{_degrees}° {_minutes}' {_seconds}''{_decimalPart.ToString().Substring(1)}";
        }

        public static Angle operator +(Angle a, Angle b)
        {
            int d = 0, m = 0, s = 0;
            decimal dp = 0;
            dp += a._decimalPart + b._decimalPart;
            if (dp >= 1)
            {
                s = (int)Math.Round(dp, 0, MidpointRounding.ToZero);
                dp -= s;
            }
            s += a._seconds + b._seconds;
            if (s > 59)
            {
                m = s / 60;
                s %= 60;
            }
            m += a._minutes + b._minutes;
            if (m > 59)
            {
                d = m / 60;
                m %= 60;
            }
            d += a._degrees + b._degrees;
            return new Angle(d, m, s, dp);
        }

        public static Angle operator -(Angle a, Angle b)
        {
            if (a._degrees > 0 && b._degrees < 0)
            {
                return a + new Angle((-1) * b._degrees, b._minutes, b._seconds, b._decimalPart);
            }

            int d = 0, m = 0, s = 0;
            decimal dp = 0;
            bool isNegative = false;

            dp += a._decimalPart - b._decimalPart;
            if (dp < 0)
            {
                isNegative = true;
                dp *= (-1);
            }
            if (isNegative && a._seconds > 0)
            {
                a._seconds -= 1;
                isNegative = false;
            }
            s = a._seconds - b._seconds;
            if (s < 0)
            {
                isNegative = true;
                s *= (-1);
            }
            if (isNegative && a._minutes > 0)
            {
                a._minutes -= 1;
                isNegative = false;
            }
            m = a._minutes - b._minutes;
            if (m < 0)
            {
                isNegative = true;
                m *= (-1);
            }
            if (isNegative && a._degrees > 0)
            {
                a._degrees -= 1;
                isNegative = false;
            }
            d = a._degrees - b._degrees;

            return new Angle(d, m, s, dp);
        }

        public static Angle operator *(Angle a, decimal k)
        {
            return FromDecimal(a.ToDecimalDegrees() * k);
        }

        public static Angle operator /(Angle a, decimal k)
        {
            if (k == 0)
                throw new DivideByZeroException("Деление на ноль");
            return FromDecimal(a.ToDecimalDegrees() / k);
        }
    }
    
}