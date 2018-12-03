using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using FindANameFarm.Banks;
using FindANameFarm.MetaLayer;

namespace FindANameFarm
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
        private MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();

        private BusinessMetaLayer _metalayer = BusinessMetaLayer.GetInstance();
        public List<Staff> StaffList { get; private set; }
        public bool GetConnectionState { get; private set; }
        public static StaffBank UniqueInst;
        public List<CatIdAndName> StaffCompetenciesList { get; private set; }
        //fot use with unit test
        public static int InstanceCount { get; set; }

        //constructor
        public StaffBank()
        {
            refreshConnection();
            //show how many times the constructor has been called (for unit test)
            InstanceCount++;
        }

        //singleton
        public static StaffBank GetInst() => UniqueInst ?? (UniqueInst = new StaffBank());

        //adds the new member of staff to the database and class list
        public void AddStaffToList(Staff staff)
        {

            StaffList.Add(staff);
            _metalayer.AddStaffToDataBase(staff);
        }

        //add a competency to the current staff member
        public void AddCompetency(StaffAndCategory addCompetency)
        {
            _metalayer.AddStaffCompetencyToDataBase(addCompetency);
        }

        //update the current staff member
        public void updateStaff(Staff editStaffMember)
        {


            for (int i = 0; i < StaffList.Count; i++)
            {
                Staff staff = StaffList[i];
                if (staff.StaffId == editStaffMember.StaffId)
                {

                    _metalayer.UpdateStaffMember(editStaffMember);
                    refreshConnection();
                }
            }
        }

        //Deletes a competency from the current staff member
        public void deleteStaffCompetency(int staffId, int catId)
        {

            _metalayer.DeleteStaffCompetency(staffId, catId);
            refreshConnection();

        }

        //Gets the current member of staffs competencies
        public void GetCompetencies(int staffid)
        {

            StaffCompetenciesList = _metalayer.GetCompetencies(staffid);
        }


        //checks the state and refreshes the connection, reloading the staff list in the class
        public void refreshConnection()
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
