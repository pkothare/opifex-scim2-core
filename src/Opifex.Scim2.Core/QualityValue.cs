using System;
using System.Globalization;
using Opifex.Scim2.Core.Exceptions;

namespace Opifex.Scim2.Core
{
    public readonly struct QualityValue : IEquatable<QualityValue>
    {
        public readonly decimal Value { get; }

        public QualityValue(double value)
            : this(Convert.ToDecimal(value))
        {

        }

        public QualityValue(decimal value)
        {
            if (value < decimal.Zero || value > decimal.One)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            Value = decimal.Round(value, 3);
        }

        public bool Equals(QualityValue other) => Value == other.Value;

        public override bool Equals(object obj)
            => (obj is QualityValue qv) ? Value == qv.Value : false;

        public override int GetHashCode() => HashCode.Combine(Value);

        public override string ToString() => @$"q={Value:0.###}";

        public static QualityValue Parse(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentWhiteSpaceException(nameof(value));
            }
            value = value.Trim();
            if (value.StartsWith("q=", StringComparison.InvariantCultureIgnoreCase))
            {
                if(value.Length < 3)
                {
                    throw new QualityValueFormatException(value);
                }
                value = value.Substring(2);
            }
            return new QualityValue(decimal.Parse(value, CultureInfo.InvariantCulture));
        }

        public static bool operator ==(QualityValue a, QualityValue b) => a.Value == b.Value;

        public static bool operator !=(QualityValue a, QualityValue b) => a.Value != b.Value;


    }
}
