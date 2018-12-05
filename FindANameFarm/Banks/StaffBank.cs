using System;
using System.Collections.Generic;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{
    /// <summary>
    /// ian 5/11/18
    /// </summary>
    public struct StaffAndCategory
    {
        public int StaffId { get; set; }
        public int CatId { get; set; }
    }

    public struct CatIdAndName
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    public class StaffBank
    {
        private readonly MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();

        private readonly BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();
        public List<Staff> StaffList { get; private set; }
        public bool GetConnectionState { get; private set; }
        public static StaffBank UniqueInst;
        public List<CatIdAndName> StaffCompetenciesList { get; private set; }
        //fot use with unit test
        public static int InstanceCount { get; set; }

        //constructor
        public StaffBank()
        {
            RefreshConnection();
            //show how many times the constructor has been called (for unit test)
            InstanceCount++;
        }

        //singleton
        public static StaffBank GetInst() => UniqueInst ?? (UniqueInst = new StaffBank());

        //adds the new member of staff to the database and class list
        public void AddStaffToList(Staff staff)
        {

            StaffList.Add(staff);
            _metaLayer.AddStaffToDataBase(staff);
        }

        //add a competency to the current staff member
        public void AddCompetency(StaffAndCategory addCompetency)
        {
            _metaLayer.AddStaffCompetencyToDataBase(addCompetency);
        }

        //update the current staff member
        public void UpdateStaff(Staff editStaffMember)
        {
            foreach (var staff in StaffList)
            {
                if (staff.StaffId == editStaffMember.StaffId)
                {

                    _metaLayer.UpdateStaffMember(editStaffMember);
                    RefreshConnection();
                }
            }
        }

        //Deletes a competency from the current staff member
        public void DeleteStaffCompetency(int staffId, int catId)
        {

            _metaLayer.DeleteStaffCompetency(staffId, catId);
            RefreshConnection();

        }

        //Gets the current member of staffs competencies
        public void GetCompetencies(int staffId)
        {

            StaffCompetenciesList = _metaLayer.GetCompetencies(staffId);
        }


        //checks the state and refreshes the connection, reloading the staff list in the class
        public void RefreshConnection()
        {
            try
            {
               BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                StaffList = metaLayer.GetStaff();

                GetConnectionState = true;
            }
            catch (Exception e)
            {
                GetConnectionState = false;

                string exception = e.ToString();

                _log.LogEntry("Connection failed " + exception);

                throw;
            }
        }

    }
}
