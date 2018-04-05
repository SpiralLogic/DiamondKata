
using System;
using DiamondKata;
using Xunit;

namespace DiamondTest
{
    public class DiamondAcceptanceTests
    {
        [Fact]
        public void Input1CreatesDiamondWithDiameterof1()
        {
            Assert.Equal("*", Diamond.Create(1));
        }  
        
        [Fact]
        public void Input13CreatesDiamondWithDiameterOf13()
        {
            string[] expected =
            {
                "      *",
                "     ***",
                "    *****",
                "   *******",
                "  *********",
                " ***********",
                "*************",
                " ***********",
                "  *********",
                "   *******",
                "    *****",
                "     ***",
                "      *",

            };
            Assert.Equal(string.Join('\n',expected), Diamond.Create(13));
        }
    }
}