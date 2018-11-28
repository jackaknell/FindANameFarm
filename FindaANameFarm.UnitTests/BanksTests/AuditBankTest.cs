using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindANameFarm.Banks;
using FindANameFarm;

namespace FindANameFarm.UnitTests.BanksTests
{
    [TestClass]
    public class AuditBankTest

    {

        AuditBank _audit = AuditBank.GetInst();

        //[TestMethod]
        //public void GetInst_IsSingleton()
        //{

        //    var instance1 = AuditBank.GetInst();
        //    var instance2 = AuditBank.GetInst();

        //    Assert.AreSame(instance1, instance2);
        //    Assert.AreEqual(AuditBank.InstanceCount, 1);

        //}

        //[TestMethod]
        //public void AddAudit_whenCalled_InsertAudit()
        //{

        //    int listCount = _audit.AuditList.Count;

        //    Audit audit = new Audit();

        //    _audit.AddAuditToList(audit);

        //    Assert.AreEqual(_audit.AuditList[listCount], audit);

        //}


        //[TestMethod]
        //public void upDateAudit_WhenCalled_UpdateAuditInDatabase()
        //{

        //    int AuditId = _audit.AuditList[0].AuditId;

        //    Audit audit = new Audit
        //    {
        //        AuditId = AuditId,
        //        //Date = DateTime,
        //        Name = "",
        //        Amount = 50,
        //        Decription = ""

        //    };

        //    _audit.UpdateAudit(audit);

        //    Assert.AreEqual(_audit.AuditList[0].Name, audit.Name);
        //    Assert.AreEqual(_audit.AuditList[0].Date, audit.Date);
        //    Assert.AreEqual(_audit.AuditList[0].Amount, audit.Amount);
        //    Assert.AreEqual(_audit.AuditList[0].Decription, audit.Decription);

        //}



    }
}
