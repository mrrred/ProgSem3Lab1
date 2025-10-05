using Lab1Prog.Technique.Monitors;

namespace ProgSem3Lab1.Tests
{
    [TestClass]
    public sealed class DisplayTests
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(27)]
        [DataRow(int.MaxValue)]
        public void ScreenSize_ValidInt_ValueIsSetCorrectly(int screenSize)
        {
            Assert.AreEqual(screenSize, new Display { ScreenSize = screenSize }.ScreenSize);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-27)]
        [DataRow(int.MinValue)]
        public void ScreenSize_NegativeOrZeroInt_ArgumentOutOfRangeException(int screenSize)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Display { ScreenSize = screenSize });
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(60)]
        [DataRow(int.MaxValue)]
        public void RefreshRate_ValidInt_ValueIsSetCorrectly(int refreshRate)
        {
            Assert.AreEqual(refreshRate, new Display { RefreshRate = refreshRate }.RefreshRate);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-60)]
        [DataRow(int.MinValue)]
        public void RefreshRate_NegativeOrZeroInt_ArgumentOutOfRangeException(int refreshRate)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Display { RefreshRate = refreshRate });
        }
    }
}
