using System.Text.RegularExpressions;

namespace calc.Models
{
    public class Angle
    {
        private int _degrees;
        private int _minutes;
        private int _seconds;
        private decimal _decimalpart;

        public double Radians
        {
            get
            {
                return (double)ToDecimalDegrees() * Math.PI / 180;
            }
        }

        public Angle(int degrees, int minutes, int seconds, decimal decimalPart = 0)
        {
            _degrees = degrees;
            _minutes = minutes;
            _seconds = seconds;
            _decimalpart = decimalPart;
        }

        public decimal ToDecimalDegrees()
        {
            return _degrees + _minutes / 60m + (_seconds + _decimalpart) / 3600m;
        }

        public static Angle FromDecimal(decimal dec)
        {
            int d = (int)dec;
            decimal m_full = (dec - d) * 60;
            int m = (int)m_full;
            decimal s_full = (m_full - m) * 60;
            int s = (int)s_full;
            var dp = s_full - s;

            return new Angle(d, m, s, dp);
        }

        public static Angle FromString(string value)
        {
            var regEx = new Regex("(?<degrees>\\d+°)?\\s*(?<minutes>\\d+')?\\s*(?<seconds>\\d+\")?\\s*(?<decimalpart>\\.\\d+\")?");
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
                            int.TryParse(match.Groups[key].Value.Replace("\"", ""), out s);
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
            return $"{_degrees}° {_minutes}' {_seconds}\"{_decimalpart.ToString().Substring(1)}";
        }
    }
}
