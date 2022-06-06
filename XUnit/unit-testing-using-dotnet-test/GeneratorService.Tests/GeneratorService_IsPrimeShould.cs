using Xunit;
using SimpleBank;

namespace Generate.UnitTests.Services
{
    public class GenerateService_IsGenerateShould
    {
        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt4()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 1, 1, 1, 2, 6, 6, 1, 9, 0, 1, 7, 0, 5, 5, 3, 4 });

            Assert.Equal(7, result);
        }
      

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt8()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 7, 1, 4, 8, 2, 6, 8, 0, 7, 7, 8, 1, 5, 6, 3, 0 });

            Assert.Equal(4, result);
        }

        
    }
}