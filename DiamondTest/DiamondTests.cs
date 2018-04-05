using DiamondKata;
using Xunit;

namespace DiamondTest
{
    public class DiamondTests
    {
        [Fact]
        public void ReturnsNullForInputLessThan1()
        {
            Assert.Null(Diamond.Create(-1));
            Assert.Null(Diamond.Create(0));
        }

        [Fact]
        public void ReturnsNullForFactorsOf2()
        {
            Assert.Null(Diamond.Create(2));
            Assert.Null(Diamond.Create(4));
            Assert.Null(Diamond.Create(6));
        }

        [Fact]
        public void Input3CreatesDiamondWithDiameterof3()
        {
            string[] expected =
            {
                " *",
                "***",
                " *",
            };
            
            Assert.Equal(string.Join('\n',expected), Diamond.Create(3));
        }
        
        [Fact]
        public void Input5CreatesDiamondWithDiameterof5()
        {
            string[] expected =
            {
                "  *",
                " ***",
                "*****",
                " ***",
                "  *",
            };
            
            Assert.Equal(string.Join('\n',expected), Diamond.Create(5));
        }
       
    }
}