﻿using System;
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
            WorkTask.StaffToDeleteFromTask(taskStaff);

            //Act

          

            //Assert
            Assert.IsTrue(WorkTask.AddStaffToTask(taskStaff));

        }
    }
}
