using Lab1Prog.Technique;

namespace ProgSem3Lab1.Tests
{
    [TestClass]
    public sealed class ComputerTechTests
    {
        [TestMethod]
        [DataRow("")]
        [DataRow("Test")]
        public void Manufacturer_ValidString_ValueIsSetCorrectly(string manufacture)
        {
            Assert.AreEqual(manufacture, new ComputerTech { Manufacturer = manufacture }.Manufacturer);
        }

        [TestMethod]
        [DataRow(null)]
        public void Manufacturer_Null_ArgumentNullException(string? manufacture)
        {
            Assert.ThrowsException<ArgumentNullException>(() => new ComputerTech { Manufacturer = manufacture });
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(2018)]
        [DataRow(2025)]
        public void Year_ValidInt_ValueIsSetCorrectly(int year)
        {
            Assert.AreEqual(year, new ComputerTech { Year = year }.Year);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-100)]
        public void Year_NegativeInt_ArgumentOutOfRangeException(int year)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ComputerTech { Year = year });
        }

        [TestMethod]
        public void Year_YearHigherThanNow_ArgumentOutOfRangeException()
        {
            int yearInit = DateTime.Now.Year + 1;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ComputerTech { Year = yearInit });
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(100)]
        [DataRow(int.MaxValue)]
        public void StorageCapacity_ValidInt_ValueIsSetCorrectly(int storageCapacity)
        {
            Assert.AreEqual(storageCapacity, new ComputerTech { AmountStock = storageCapacity }.AmountStock);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-1000)]
        [DataRow(int.MinValue)]
        public void StorageCapacity_NegativeInt_ArgumentOutOfRangeException(int storageCapacity)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ComputerTech { AmountStock = storageCapacity });
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(100)]
        [DataRow(int.MaxValue)]
        public void Price_ValidInt_ValueIsSetCorrectly(int price)
        {
            Assert.AreEqual(price, new ComputerTech { Price = price }.Price);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-1000)]
        [DataRow(int.MinValue)]
        public void Price_NegativeOrZero_ArgumentOutOfRangeException(int price)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ComputerTech { Price = price });
        }
    }
}
