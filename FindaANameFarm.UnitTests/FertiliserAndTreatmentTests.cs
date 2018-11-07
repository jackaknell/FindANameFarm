using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindANameFarm;
using FindANameFarm.Banks;

namespace FindaANameFarm.UnitTests
{
    [TestClass]
    public class FertiliserAndTreatmentTests
    {
        FertTreatBank FertAndTreat = FertTreatBank.GetInst();

        [TestMethod]
        //method, what you're doing, expected outcome
        public void GetInst_IsSingleton()
        {
            //Arrange
            var instance1 = FertTreatBank.GetInst();
            var instance2 = FertTreatBank.GetInst();
            //Act
            //Assert
            Assert.AreSame(instance1, instance2);
            Assert.AreEqual(FertTreatBank.InstanceCount, 1);
        }
        [TestMethod]
        public void AddFertTreat_whenCalled_InsertFertTreat()
        {
            int listCount = FertAndTreat.FertTreatList.Count;

            FertiliserAndTreatment fertTreat = new FertiliserAndTreatment();

            FertAndTreat.AddFertTreatToList(fertTreat);

            Assert.AreEqual(FertAndTreat.FertTreatList[listCount], fertTreat);
        }

        [TestMethod]
        public void updateFertTreat_WhenCalled_updateFertTreat()
        {
            int fertTreatId = FertAndTreat.FertTreatList[0].FertTreatId;

            FertiliserAndTreatment fertTreat = new FertiliserAndTreatment
            {
                FertTreatId = fertTreatId,
                FertTreatName = "Treatment1",
                FertTreatQuantity = 100
            };

            FertAndTreat.UpdateFertTreat(fertTreat);

            Assert.AreEqual(FertAndTreat.FertTreatList[0].FertTreatName, fertTreat.FertTreatName);
            Assert.AreEqual(FertAndTreat.FertTreatList[0].FertTreatQuantity, fertTreat.FertTreatQuantity);
        }
    }
}
