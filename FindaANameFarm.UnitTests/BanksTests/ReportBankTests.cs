using System;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindANameFarm.UnitTests.BanksTests;
using FindANameFarm.Banks;
using FindANameFarm.BasicClasses;
using FindANameFarm.WorkTaskClasses;

namespace FindANameFarm.UnitTests.BanksTests
{
    [TestClass]
    public class ReportTaskTests
    {
        private readonly ReportBank Report = ReportBank.GetInst();
        

        [TestMethod]
        public void GetInst_IsSingleton()
        {
            //Arrange
            var instance1 = ReportBank.GetInst();
            var instance2 = ReportBank.GetInst();
            //Act
            //Assert
            Assert.AreSame(instance1, instance2);
            Assert.AreEqual(ReportBank.InstanceCount, 1);
        }

        [TestMethod]

        public void getCropsInCultivation_whenCalled_getCropList()
        {
            //Arrange
           
            
            //Act
            Report.GetCropsInCultivation();

            //Assert
            Assert.AreEqual("Cabbage Seeds", Report.CropsInCultivation[0].CropName);
            Assert.AreEqual("Field 3",Report.CropsInCultivation[0].FieldName);
            Assert.AreEqual("08/11/2018", Report.CropsInCultivation[0].TaskStartDate.ToString("dd/MM/yyyy"));
            Assert.AreEqual("08/11/2018", Report.CropsInCultivation[0].TaskEndDate.ToString("dd/MM/yyyy"));
            Assert.AreEqual(100, Report.CropsInCultivation[0].ExpectedYield);
        }

        [TestMethod]

        public void getHarvestTimeTable_whenCalled_getsHarvestTimeTable()
        {
            //Arrange
            

            //Act
            Report.GetHarvestTimeTable("22/01/2018", "01/02/2019");

            //Assert
            Assert.AreEqual("Cabbage Seeds", Report.HarvestTimeTable[0].CropName);
            Assert.AreEqual("Field 3", Report.HarvestTimeTable[0].FieldName);
            Assert.AreEqual("08/11/2018", Report.HarvestTimeTable[0].TaskStartDate.ToString("dd/MM/yyyy"));
            Assert.AreEqual("08/11/2018", Report.HarvestTimeTable[0].TaskEndDate.ToString("dd/MM/yyyy"));
            Assert.AreEqual("None", Report.HarvestTimeTable[0].TreatmentName);
        }

        [TestMethod]

        public void getStaffWorkSheet_whenCalled_getsSelectedStaffWorkSheet()
        {
            //Arrange


            //Act
            Report.GetStaffWorkTasks(22,"22/01/2018", "01/02/2019");

            //Assert
            Assert.AreEqual(7,Report.StaffWorkTasks[0].TaskId);       
            Assert.AreEqual("12/11/2018", Report.StaffWorkTasks[0].TaskStartDate.ToString("dd/MM/yyyy"));
            Assert.AreEqual("13/11/2018", Report.StaffWorkTasks[0].TaskEndDate.ToString("dd/MM/yyyy"));
            Assert.AreEqual("Corn Seeds", Report.StaffWorkTasks[0].CropName);
            Assert.AreEqual("Field 2", Report.StaffWorkTasks[0].FieldName);
            Assert.AreEqual(Report.StaffWorkTasks[0].TreatmentName, "None");
            Assert.AreEqual(11,Report.StaffWorkTasks[0].JobDuration);
            Assert.AreEqual(Report.StaffWorkTasks[0].ExpectedHarvestDate.ToString("dd/MM/yyyy"),"14/11/2018");
            Assert.AreEqual(Report.StaffWorkTasks[0].ExpectedYield, 12);
            Assert.AreEqual(Report.StaffWorkTasks[0].QuantityRequired,10);
        }

        [TestMethod]

        public void getVehicleWorkTask_whenCalled_GetListOfVehichleOnTask()
        {
            //Arrange

            //Act
            Report.GetVehicleWorkTasks(22, "22/01/2018", "01/02/2019");
            //Assert
            Assert.AreEqual(2, Report.VehicleWorkTasks[0].TaskId);

            Assert.AreEqual(Report.VehicleWorkTasks[0].TaskStartDate.ToString("dd/MM/yyyy"), "08/11/2018");
            Assert.AreEqual(Report.VehicleWorkTasks[0].TaskEndDate.ToString("dd/MM/yyyy"),"08/11/2018");
            Assert.AreEqual(Report.VehicleWorkTasks[0].CropName, "Cabbage Seeds");
            Assert.AreEqual(Report.VehicleWorkTasks[0].FieldName, "Field 3");
            Assert.AreEqual(Report.VehicleWorkTasks[0].TreatmentName, "None");
            Assert.AreEqual(Report.VehicleWorkTasks[0].JobDuration,10);
            Assert.AreEqual(Report.VehicleWorkTasks[0].ExpectedHarvestDate.ToString("dd/MM/yyyy"), "08/11/2018");
            Assert.AreEqual(Report.VehicleWorkTasks[0].ExpectedYield, 100);
            Assert.AreEqual(Report.VehicleWorkTasks[0].QuantityRequired, 0);
        }
    }
    
}
