using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindANameFarm;
using FindANameFarm.Banks;

namespace FindANameFarm.UnitTests
{
    [TestClass]
    public class FertiliserAndTreatmentBankTests
    {
        FertTreatBank FertAndTreat = FertTreatBank.GetInst();

        /// <summary>
        /// Jason 7/11/18
        /// tests the fert and treatment bak singleton
        /// </summary>
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

        /// <summary>
        /// Jason 07/11/08
        /// </summary>
        [TestMethod]
        public void AddFertTreat_whenCalled_InsertFertTreat()
        {
            int listCount = FertAndTreat.FertTreatList.Count;

            FertiliserAndTreatment fertTreat = new FertiliserAndTreatment();

            FertAndTreat.AddFertTreatToList(fertTreat);

            Assert.AreEqual(FertAndTreat.FertTreatList[listCount], fertTreat);
        }

        /// <summary>
        /// Jason 07/11/08
        /// </summary>
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
