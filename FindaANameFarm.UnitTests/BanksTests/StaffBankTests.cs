using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FindANameFarm;
using FindANameFarm.MetaLayer;

namespace FindaANameFarm.UnitTests
{

   
    
    [TestClass]
    public class StaffBankTests
    {
        StaffBank Staff = StaffBank.GetInst();
        

        /// <summary>
        /// Ian 1/11/18
        /// Tests staff member is added to the staff list
        /// </summary>

        [TestMethod]

        public void GetInst_IsSingleton()
        {
            //Arrange
            var instance1 = StaffBank.GetInst();
            var instance2 = StaffBank.GetInst();
            //Act
            //Assert
            Assert.AreSame(instance1, instance2);
            Assert.AreEqual(StaffBank.InstanceCount, 1);
        }

        ///<summary>
        ///Ian 1/11/18
        ///Tests staff member is added to the staff list
        /// </summary>

        [TestMethod]

        public void AddStaff_whenCalled_InsertStaffMember()
        {
           // Arrange

           //gives the current list count which will be the index position of the next object added
            int listCount = Staff.StaffList.Count;

            //Act
            Staff staff = new Staff();

            Staff.AddStaffToList(staff);

            //Assert
            Assert.AreEqual(Staff.StaffList[listCount], staff);

        }
        /// <summary>
        /// Ian 1/11/18
        /// Tests that the sellected staff member updates
        /// </summary>
        [TestMethod]

        public void upDateStaffMember_WhenCalled_updatesStaffMemberInDataBase()
        {
            // Arrange
            int staffId = Staff.StaffList[0].StaffId;

            //gives the current list count which will be the index position of the next object added

            Staff staff = new Staff
            {
                StaffId = staffId,
                FirstName = "test1",
                SurName = "test1",
                Gender = "test1",
                Email = "test1",
                Role = "test1",
                Contact = "test1",
                ImageFile = "test1"
                //Password = "test1",
            };

            //Act


            Staff.updateStaff(staff);

            //Assert
            Assert.AreEqual(Staff.StaffList[0].FirstName, staff.FirstName);
            Assert.AreEqual(Staff.StaffList[0].SurName, staff.SurName);
            Assert.AreEqual(Staff.StaffList[0].Gender, staff.Gender);
            Assert.AreEqual(Staff.StaffList[0].Email, staff.Email);
            Assert.AreEqual(Staff.StaffList[0].Role, staff.Role);
            Assert.AreEqual(Staff.StaffList[0].Contact, staff.Contact);
            Assert.AreEqual(Staff.StaffList[0].ImageFile, staff.ImageFile);
            //Assert.AreEqual(Staff.StaffList[0].Password, staff.Password);




        }

        /// <summary>
        /// Ian 1/11/18
        /// Tests that the competency list populates with the selected staff members competencies
        /// </summary>
        [TestMethod]

        public void GetCompetencies_WhenCalled_GetStaffMembersCompetencies()
        {
            //Arrange
            List<CatIdAndName> competency;
            competency = new List<CatIdAndName>();
            competency.Add(new CatIdAndName {CategoryId = 3, CategoryName = "harvestor" });
            competency.Add(new CatIdAndName {CategoryId = 4, CategoryName = "tracktor" });
           
            //Act
            Staff.GetCompetencies(1);
           
            //Assert
            CollectionAssert.AreEqual(Staff.StaffCompetenciesList,competency);
            
        }

       
    }
}

