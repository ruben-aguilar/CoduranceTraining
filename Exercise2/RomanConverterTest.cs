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

        [Test]
        public void convert_number_eigthteen_to_xviii()
        {
            var numberToConvert = 18;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("xviii", result);
        }

        [Test]
        public void convert_number_nineteen_to_xix()
        {
            var numberToConvert = 19;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("xix", result);
        }

        [Test]
        public void convert_number_twenty_to_xx()
        {
            var numberToConvert = 20;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("xx", result);
        }

        [Test]
        public void convert_number_fortynine_to_xlix()
        {
            var numberToConvert = 49;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("xlix", result);
        }

        [Test]
        public void convert_number_50_to_l()
        {
            var numberToConvert = 50;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("l", result);
        }

        [Test]
        public void convert_number_100_to_c()
        {
            var numberToConvert = 100;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("c", result);
        }

        [Test]
        public void convert_number_101_to_ci()
        {
            var numberToConvert = 101;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("ci", result);
        }

        [Test]
        public void convert_number_449_to_cdxlix()
        {
            var numberToConvert = 449;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("cdxlix", result);
        }

        [Test]
        public void convert_number_1001_to_mi()
        {
            var numberToConvert = 1001;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("mi", result);
        }

        [Test]
        public void convert_number_3001_to_mmmi()
        {
            var numberToConvert = 3001;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("mmmi", result);
        }

        [Test]
        public void convert_number_3949_to_mmmcmxlix()
        {
            var numberToConvert = 3949;

            var converter = new RomanConverter();
            var result = converter.Convert(numberToConvert);

            Assert.AreEqual("mmmcmxlix", result);
        }
    }
}
