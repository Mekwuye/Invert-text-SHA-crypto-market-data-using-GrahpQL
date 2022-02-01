using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace csharpYoloUnitTest
{
    [TestClass]
    public class cSharpYoloUnitTest
    {
        [TestMethod]
        public async Task shaHexTestMethod()
        {
            string filePath = Helper.Util.getfilesFolderPath + "SHA_Wikipedia.txt"; //you can test with file: 100MB.BIN or other in the Files folder

            byte[] SHAresult = await cSharpYoloLibrary.ShaHex.calculateSHaAsync(filePath);
            string SHAresultToHex = await cSharpYoloLibrary.ShaHex.toHexAsync(SHAresult);

             string actual=  cSharpYoloLibrary.ShaHex.toHex(cSharpYoloLibrary.ShaHex.calculateSHA(filePath));

            string expected = "8cab543e768c01bccb80bd0414779629b3947d3e8c16350387c5624ca154f6f0"; 
        
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task invertTestMethod()
        {
            string textToInvert = "Hello Yolo";
            string actual =await  cSharpYoloLibrary.Invert.invertPlainText(textToInvert);

            string expected = "oloY olleH";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task functionAfunctionBTestMethod()
        {
            cSharpYoloLibrary.FunctionAFunctionB functionAfunctionB = new cSharpYoloLibrary.FunctionAFunctionB();

            await functionAfunctionB.execute();

            double actual = functionAfunctionB.getAllProcessedData().Count;

            double expectedProcessDataCount = 1000;

            Assert.AreEqual(expectedProcessDataCount, actual);
        }

    }
}