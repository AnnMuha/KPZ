using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Money
    {
        public int MajorUnit { get; private set; }
        public int MinorUnit { get; private set; }
        public string Currency { get; private set; }

        public Money(int majorUnit, int minorUnit, string currency)
        {
            MajorUnit = majorUnit;
            MinorUnit = minorUnit;
            Currency = currency;
        }

        public void SetAmount(int major, int minor)
        {
            MajorUnit = major;
            MinorUnit = minor;
        }

        public override string ToString()
        {
            return $"{MajorUnit}.{MinorUnit:D2} {Currency}";
        }
    }
}