using System;
using FindANameFarm.Banks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindaANameFarm.UnitTests.BanksTests
{
    /// <summary>
    /// ian 29/11/18
    /// </summary>
    [TestClass]
    public class AuditBankTests
    {
        [TestMethod]
        public void GetInst_IsSingleton()
        {
            //Arrange
            var instance1 = AuditBank.GetInst();
            var instance2 = AuditBank.GetInst();
            //Act
            //Assert
            Assert.AreSame(instance1, instance2);
            Assert.AreEqual(AuditBank.InstanceCount, 1);
        }
    }
}
