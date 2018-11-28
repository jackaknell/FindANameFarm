using System;
using System.Collections.Generic;
using System.Diagnostics;
using FindANameFarm;
using FindANameFarm.MetaLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindANameFarm.UnitTests
{
    [TestClass]
    public class VehicleBankTests
    {
       
        VehicleBank Vehicle = VehicleBank.GetInst();

        /// <summary>
        /// ian 2/11/2018
        /// Tests the vehicle bank singleton
        /// </summary>
        [TestMethod]
        public void GetInst_IsSingleton()
        {
           
            //Arrange
            var instance1 = VehicleBank.GetInst();
            var instance2 = VehicleBank.GetInst();
            //Act
            //Assert
            Assert.AreSame(instance1, instance2);
            Assert.AreEqual(VehicleBank.InstanceCount, 1);
        }

        /// <summary>
        /// ian 2/11/2018
        /// Tests that the add vehicle method adds a vehicle to teh vehicle list and database
        /// </summary>
         [TestMethod]

        public void AddVehicle_whenCalled_InsertVehicle()
        {
           // Arrange

           //gives the current list count which will be the index position of the next object added
            int listCount = Vehicle.VehicleList.Count;

            //Act
            Vehicles vehicle = new Vehicles();

            Vehicle.AddVehicleToList(vehicle);

            //Assert
            Assert.AreEqual(Vehicle.VehicleList[listCount], vehicle);

        }

        /// <summary>
        /// ian 2/11/2018
        /// </summary>
        [TestMethod]

        public void upDateVehicle_WhenCalled_updatesVehicleInDataBase()
        {
            // Arrange
            int vehicleId = Vehicle.VehicleList[0].VehicleId;

            //gives the current list count which will be the index position of the next object added

            Vehicles vehicle = new Vehicles
            {
               VehicleId = vehicleId,
                VehicleName = "TestVehicleName",
                Category = 1
                
                
            };

            //Act

            Vehicle.UpdateVehicle(vehicle);

            //Assert

            Assert.AreEqual(Vehicle.VehicleList[0].VehicleName, vehicle.VehicleName);
            Assert.AreEqual(Vehicle.VehicleList[0].Category,vehicle.Category);
            
           
            //Assert.AreEqual(Staff.StaffList[0].Password, staff.Password);

        }

        /// <summary>
        /// Ian 2/11/18
        /// Tests that the competency list populates with the selected staff members competencies
        /// </summary>
        [TestMethod]

        public void AddCategoryToDB_WhenCalled_addsVehicleCategoryToDatabase()
        {

            // Arrange

            //gives the current list count which will be the index position of the next object added
            Vehicle.RefreshConnection();
            int listCount = Vehicle.Categories.Count;
            
            //Act
            string category = "TestCategoryName";

            Vehicle.AddCategoryToDb(category);
            Vehicle.RefreshConnection();
            //Assert
            Assert.AreEqual(Vehicle.Categories.Count, listCount+1);
        }

       
    }
}
