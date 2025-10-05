using Lab1Prog.Technique.Keyboards;

namespace ProgSem3Lab1.Tests
{
    [TestClass]
    public sealed class KeyboardTests
    {
        [TestMethod]
        [DataRow("Q")]
        [DataRow("QWERTY")]
        [DataRow("Dvorak")]
        public void Layout_ValidString_ValueIsSetCorrectly(string layout)
        {
            Assert.AreEqual(layout, new Keyboard { Layout = layout }.Layout);
        }

        [TestMethod]
        [DataRow(null)]
        public void Layout_Null_ArgumentNullException(string? layout)
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Keyboard { Layout = layout });
        }

        [TestMethod]
        [DataRow("")]
        public void Layout_EmptyString_ArgumentException(string layout)
        {
            Assert.ThrowsException<ArgumentException>(() => new Keyboard { Layout = layout });
        }
    }
}
