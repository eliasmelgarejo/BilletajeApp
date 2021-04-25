using System;
using BilletajeApp.dominio;
using BilletajeApp.repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletajeAppUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreatedBus()
        {   
            IRepository<Bus> repo = new BusRepo();           
            Bus bus = new Bus(1, TipoBus.EJECUTIVO);
            bool resp = repo.create(bus);
            Assert.IsTrue(resp);
        }
    }
}
