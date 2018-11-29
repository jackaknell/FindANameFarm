using System;
using System.Diagnostics;
using FindANameFarm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindANameFarm.Banks;
using FindANameFarm.WorkTaskClasses;

namespace FindANameFarm.UnitTests.BanksTests
{
    [TestClass]
    public class WorkTaskTests
    {
        WorkTaskBank WorkTask = WorkTaskBank.GetInst();
       

        [TestMethod]
        public void GetInst_IsSingleton()
        {
            var instance1 = WorkTaskBank.GetInst();
            var instance2 = WorkTaskBank.GetInst();
            //Act
            //Assert
            Assert.AreSame(instance1, instance2);
            Assert.AreEqual(WorkTaskBank.InstanceCount, 1);
        }

        [TestMethod]
        public void AddWorkTask_whenCalled_InsertWorkTask()
        {
            //Arrange

            //gives the current list count which will be the index position of the next object added
            int listCount = WorkTask.WorkTaskList.Count;

            //Act
            WorkTasks workTask = new WorkTasks();

            workTask.TaskType = "Sowing";
            workTask.TaskStartDate = DateTime.Now;
            workTask.TaskEndDate = DateTime.Now;
            workTask.FieldId = 1;
            workTask.CropId = 1;
            workTask.QuantityRequired = 1;
            workTask.JobDuration = 1;
            workTask.ExpectedHarvestDate = DateTime.Now;
            workTask.ExpectedYield = 1;

            WorkTask.AddWorkTaskToList(workTask);

            //Assert
            Assert.AreEqual(WorkTask.WorkTaskList[listCount], workTask);

        }

        [TestMethod]
        public void AddStaffToTask_whenCalled_InsertStaffToCurrentWorkTask()
        {
            //Arrange
            TaskStaff taskStaff = new TaskStaff
            {
                TaskId = 100,
                StaffId = 100
            };


            //Act
            WorkTask.StaffToDeleteFromTask(taskStaff);


            //Assert
            Assert.IsTrue(WorkTask.AddStaffToTask(taskStaff));

        }

        [TestMethod]
        public void AddVehicleToTask_whenCalled_InsertVehicleToCurrentWorkTask()
        {
            //Arrange
            TaskVehiclesAndDrivers taskVehicle = new TaskVehiclesAndDrivers
            {
                TaskId = 100,
                VehicleId = 100,
                DriverId = 100
                
            };


            //Act
            WorkTask.DeleteVehicleAndDriverFromTask(taskVehicle);
            //Assert
            Assert.IsTrue(WorkTask.AddVehicleToTask(taskVehicle));

        }

        [TestMethod]
        public void GetWorkTasStaff_whenCalled_getStaffListForTask()
        {
            //Arrange
            try
            {
                TaskStaff deleteTaskStaff = new TaskStaff
                {
                    TaskId =1,
                    StaffId = 22
                };
                WorkTask.StaffToDeleteFromTask(deleteTaskStaff);
            }
            catch (Exception e)
            {
                
                
            }
            //Act
            TaskStaff addTaskStaff = new TaskStaff
            {
                TaskId = 1,
                StaffId = 22
            };
            WorkTask.AddStaffToTask(addTaskStaff);

            WorkTask.GetWorkTaskStaff(1);
            
            //Assert
            
            Assert.AreEqual(1,WorkTask.TaskStaff.Count);
        }

        [TestMethod]
        public void GetWorkTaskVehiclesAndDrivers_whenCalled_getVehiclesDriverListForTask()
        {
            //Arrange
            TaskVehiclesAndDrivers TaskVehicle = new TaskVehiclesAndDrivers
            {
                TaskId = 1,
                VehicleId = 3,
                DriverId = 22
            };

            try
            {
               
                WorkTask.DeleteVehicleAndDriverFromTask(TaskVehicle);
            }
            catch (Exception e)
            {


            }
            //Act

            WorkTask.AddVehicleToTask(TaskVehicle);

            WorkTask.GetWorkTaskVehicles(1);

            //Assert

            Assert.AreEqual(1, WorkTask.CurrentVehicleAndDriverList.Count);
            Assert.AreEqual(TaskVehicle.DriverId, WorkTask.CurrentVehicleAndDriverList[0].DriverId);
            Assert.AreEqual(TaskVehicle.VehicleId, WorkTask.CurrentVehicleAndDriverList[0].VehicleId);
        }

       
        
    }
}
