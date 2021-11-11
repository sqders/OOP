using System;
using Xunit;

namespace GDC.Tests
{
    public class NODTests
    {
        [Fact]
        public void NODForTowIntegerTest()
        {
            long time;
            int expected = 4, actual = MainWindow.FindGCDEuclid(298467352, 569484, out time);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void NODForFourIntegerTest()
        {
            long time;
            int expected = 86, actual = MainWindow.FindGCDEuclid(7396, 1978, 1204, 430, out time);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void NODForThreeIntegerTest()
        {
            long time;
            int expected = 86, actual = MainWindow.FindGCDEuclid(7396, 1978, 1204, out time);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void NODForFiveIntegerTest()
        {
            long time;
            int expected = 86, actual = MainWindow.FindGCDEuclid(7396, 1978, 1204, 430, 258, out time);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SteinMethodTest()
        {
            long time;
            int u = 298467352, v = 569484, expected = 4, actual = MainWindow.FindGCDStein(u,v, out time);
            Assert.Equal(expected, actual);
        }

    }
}
