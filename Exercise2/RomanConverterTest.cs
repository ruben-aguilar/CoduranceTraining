using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercise2
{
    [TestFixture]
    public class RomanConverterShould
    {
        [Test]
        public void convert_number_one_to_i()
        {
            var numberToConvert = 1;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("i", result);
        }

        [Test]
        public void convert_number_two_to_ii()
        {
            var numberToConvert = 2;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("ii", result);
        }

        [Test]
        public void convert_number_four_to_iv()
        {
            var numberToConvert = 4;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("iv", result);
        }

        [Test]
        public void convert_number_five_to_v()
        {
            var numberToConvert = 5;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("v", result);
        }

        [Test]
        public void convert_number_six_to_vi()
        {
            var numberToConvert = 6;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("vi", result);
        }

        [Test]
        public void convert_number_eight_to_viii()
        {
            var numberToConvert = 8;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("viii", result);
        }

        [Test]
        public void convert_number_nine_to_ix()
        {
            var numberToConvert = 9;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("ix", result);
        }

        [Test]
        public void convert_number_ten_to_x()
        {
            var numberToConvert = 10;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("x", result);
        }

        [Test]
        public void convert_number_twelve_to_xii()
        {
            var numberToConvert = 12;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("xii", result);
        }

        [Test]
        public void convert_number_fourteen_to_xiv()
        {
            var numberToConvert = 14;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("xiv", result);
        }
    }
}
