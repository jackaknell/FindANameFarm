using System;
using System.Collections.Generic;
using System.Diagnostics;
using FindANameFarm.MetaLayer;

namespace FindANameFarm
{
    public struct StaffAndCategory
    {
        public int StaffId { get; set; }
        public int CatId { get; set; }
    }
    public class StaffBank
    {
        private BusinessMetaLayer _metalayer = BusinessMetaLayer.GetInstance();
        public List<Staff> StaffList { get; private set; }
        public List<StaffAndCategory>CompetencyList { get; private set; }
        public bool GetConnectionState { get; private set; }
        public static StaffBank UniqueInst;

        public StaffBank()
        {
            refreshConnection();
           
        }


        public static StaffBank GetInst() => UniqueInst ?? (UniqueInst = new StaffBank());

        
        public void AddStaffToList(Staff staff)
        {
           
            StaffList.Add(staff);
            _metalayer.AddStaffToDataBase(staff);
        }

        public void AddCompetency(StaffAndCategory addcompetency)
        {
            _metalayer.AddStaffCompetencyToDataBase(addcompetency);
        }
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
        public void GetCompetencies(int staffid)
        {
           Debug.WriteLine("competencylist"+ staffid);
            
            CompetencyList= _metalayer.GetCompetencies(staffid);
        }
        public void deleteStaff(int staffMember)
        {
            for (int i = 0; i < StaffList.Count; i++)
            {
                Staff staff = StaffList[i];
                if (staff.StaffId == staffMember)
                {
                    _metalayer.DeleteStaffMember(staffMember);
                    refreshConnection();
                }
            }
        }

        public void refreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                StaffList = metaLayer.GetStaff();
                
                GetConnectionState = true;
            }
            catch (Exception)
            {
                GetConnectionState = false;
                throw;
            }
        }

    }
}
