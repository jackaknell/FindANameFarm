using System.Collections.Generic;
using FindANameFarm.Banks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindANameFarm.UnitTests.BanksTests
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

            Staff staff2 = new Staff
            {
                StaffId = staffId,
                FirstName = "test2",
                SurName = "test2",
                Gender = "test2",
                Email = "test2",
                Role = "test2",
                Contact = "test2",
                ImageFile = "test2"
                //Password = "test1",
            };

            //Act


            Staff.UpdateStaff(staff2);

            //Assert
            Assert.AreEqual(Staff.StaffList[0].FirstName, staff2.FirstName);
            Assert.AreEqual(Staff.StaffList[0].SurName, staff2.SurName);
            Assert.AreEqual(Staff.StaffList[0].Gender, staff2.Gender);
            Assert.AreEqual(Staff.StaffList[0].Email, staff2.Email);
            Assert.AreEqual(Staff.StaffList[0].Role, staff2.Role);
            Assert.AreEqual(Staff.StaffList[0].Contact, staff2.Contact);
            Assert.AreEqual(Staff.StaffList[0].ImageFile, staff2.ImageFile);
            //Assert.AreEqual(Staff.StaffList[0].Password, staff.Password);

            //clean up

            Staff staff1 = new Staff
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

            Staff.UpdateStaff(staff1);


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

        [TestMethod]

        public void DeleteStaffCompetency_WhenCalled_DeleteStaffCompetency()
        {
            //Arrange
            StaffAndCategory competency = new StaffAndCategory()
            {
                StaffId = 50,
                CatId = 50

            };

             Staff.AddCompetency(competency);

            Staff.GetCompetencies(50);
            Assert.AreEqual(Staff.StaffCompetenciesList.Count, 1);

            //Act
            Staff.DeleteStaffCompetency(50,50);

            Staff.GetCompetencies(50);
            //Assert
            Assert.AreEqual(Staff.StaffCompetenciesList.Count,0);

        }

    }
}

