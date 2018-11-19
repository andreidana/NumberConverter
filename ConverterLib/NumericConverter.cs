using System;

namespace ConverterLib
{
    public class NumericConverter
    {
        private int baseValue;
        private int minimumValue;

        public NumericConverter(int conversionBase)
        {
            baseValue = conversionBase;
            minimumValue = conversionBase - 1;
        }

        public string Convert(int inputNumber)
        {
            var convertedValue = string.Empty;

            for (; inputNumber > minimumValue; inputNumber /= baseValue)
                convertedValue += inputNumber % baseValue;

            convertedValue += inputNumber % baseValue;

            return Reverse(convertedValue);
        }

        private string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
