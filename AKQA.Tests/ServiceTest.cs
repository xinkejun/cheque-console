using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AKQA.Web;

namespace AKQA.Tests
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void ChequeServiceTest()
        {
            var service = new ChequeService("http://localhost:63727");
            var text = service.GetChequeAmountText(200.18);
            Assert.IsNotNull(text);
        }
    }
}
