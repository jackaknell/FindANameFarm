using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindANameFarm.Banks;
using FindANameFarm.BasicClasses;
using FindANameFarm.MetaLayer;

namespace FindaANameFarm.UnitTests
{
    [TestClass]
    public class CropBankTests
    {
        CropsBank _crop = CropsBank.GetInst();

        [TestMethod]
        public void GetInst_IsSingleton()
        {
            //Arrange
            var instance1 = CropsBank.GetInst();
            var instance2 = CropsBank.GetInst();
            //Act
            //Assert
            Assert.AreSame(instance1, instance2);
            Assert.AreEqual(CropsBank.InstanceCount, 1);
        }

        [TestMethod]
        public void AddCrop_whenCalled_InsertCrop()
        {
            // Arrange

            //gives the current list count which will be the index position of the next object added
            int listCount = _crop.CropsList.Count;

            //Act
           Crops crop = new Crops();

            _crop.AddCropToList(crop);

            //Assert
            Assert.AreEqual(_crop.CropsList[listCount], crop);
        }

        [TestMethod]

        public void upDatacrop_WhenCalled_updatesCropInDataBase()
        {
            // Arrange
            int cropId = _crop.CropsList[0].CropId;

            //gives the current list count which will be the index position of the next object added


           Crops crop = new Crops
            {
                CropId = cropId,
                CropName = "TestCrop",
                CropStock = 1000
              
            };

            //Act


            _crop.UpdateCrop(crop);

            //Assert
            Assert.AreEqual(_crop.CropsList[0].CropName, crop.CropName);
            Assert.AreEqual(_crop.CropsList[0].CropStock, crop.CropStock);


        }
    }
}
