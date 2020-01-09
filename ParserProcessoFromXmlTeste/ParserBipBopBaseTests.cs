using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace ParserProcessoFromXml.Tests
{
    [TestClass()]
    public class ParserBipBopBaseTests
    {
        [TestMethod()]
        public void ParserDataTest()
        {
            var xml = File.ReadAllText(@"..\..\..\..\exemples\xmlBipbopProcess.xml");
            var parser = new ParserBipBopBase(xml);
            var ProcessList = parser.ParserData();

            Assert.IsTrue(ProcessList.Any());
        }
    }
}