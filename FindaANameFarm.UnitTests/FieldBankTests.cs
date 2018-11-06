using System;
using FindANameFarm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindANameFarm.Banks;
using FindANameFarm.BasicClasses;

namespace FindaANameFarm.UnitTests
{
    [TestClass]
    public class FieldBankTests
    {
       FieldBank _field = FieldBank.GetInst();

        [TestMethod]
        public void GetInst_IsSingleton()
        {
            //Arrange
            var instance1 = FieldBank.GetInst();
            var instance2 = FieldBank.GetInst();
            //Act
            //Assert
            Assert.AreSame(instance1, instance2);
            Assert.AreEqual(FieldBank.InstanceCount, 1);
        }

        [TestMethod]
        public void AddField_whenCalled_InsertField()
        {
            // Arrange

            //gives the current list count which will be the index position of the next object added
            int listCount = _field.FieldList.Count;

            //Act
            Fields field = new Fields();

            _field.AddFieldToList(field);

            //Assert
            Assert.AreEqual(_field.FieldList[listCount], field);
        }

        [TestMethod]

        public void upDataField_WhenCalled_updatesFieldInDataBase()
        {
            // Arrange
            int feildId = _field.FieldList[0].FieldId;

            //gives the current list count which will be the index position of the next object added

            Fields field = new Fields
            {
                FieldId = feildId,
                FieldName = "Field1",
                FieldSize = 100,
                FieldSuitability = "Wheat"

            };

            //Act


            _field.UpdateField(field);

            //Assert
            Assert.AreEqual(_field.FieldList[0].FieldName, field.FieldName);
            Assert.AreEqual(_field.FieldList[0].FieldSize, field.FieldSize);
            Assert.AreEqual(_field.FieldList[0].FieldSuitability, field.FieldSuitability);

        }
    }

    
}
