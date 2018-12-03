using FindANameFarm.BasicClasses;
using FindANameFarm.MetaLayer;
using System;
using System.Collections.Generic;
using FindANameFarm.Forms;

namespace FindANameFarm.Banks
{
    /// <summary>
    /// ian 16/11/18
    /// </summary>
    public class ReportBank
    {
        private readonly MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();

        private readonly BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();

        public static ReportBank UniqueInst;
        public static int InstanceCount { get; set; }
        public bool GetConnectionState { get; private set; }
        public List<WorkTaskReport> CropsInCultivation { get; set; }
        public List<WorkTaskReport> HarvestTimeTable { get; set; }
        public List<WorkTaskReport> VehicleWorkTasks { get; set; }
        public List<WorkTaskReport> StaffWorkTasks { get; private set; }
		public List<WorkTaskReport> AvailableStorage { get; set; }
        public ReportBank()
        {
            RefreshConnection();
            InstanceCount++;
        }

        /// <summary>
        /// ian 16/11/18
        /// </summary>
        /// <returns></returns>
        //class singleton
        public static ReportBank GetInst() => UniqueInst ?? (UniqueInst = new ReportBank());

        /// <summary>
        /// ian 16/11/18
        /// </summary>
        /// <param name="staffMember"></param>
        /// Gets a list of the crops currently in cultivation from the database
        /// <returns></returns>
        public List<WorkTaskReport> GetCropsInCultivation()
        {
            CropsInCultivation = _metaLayer.GetCropsInCultivationFromDb();

            return CropsInCultivation;

        }

        //get a list of the labour tasks for the current labourer between the given dates from the database.
        public List<WorkTaskReport> GetStaffWorkTasks(int staffMember, string startTime, string finishTime)
        {
            StaffWorkTasks = _metaLayer.GetLabouerWorkTasks(staffMember, startTime, finishTime);

            return StaffWorkTasks;
        }

        //get a list of the vehicle tasks for the current labourer between the given dates from the database.
        public List<WorkTaskReport> GetVehicleWorkTasks(int staffMember, string startTime, string finishTime)
        {
            VehicleWorkTasks = _metaLayer.GetVehicleWorkTasks(staffMember, startTime, finishTime);

            return VehicleWorkTasks;
        }

        /// <summary>
        /// ian 16/11/18
        /// Get the harvest time table from the database between the given dates
        /// <returns></returns>
        public List<WorkTaskReport> GetHarvestTimeTable(string startTime, string finishTime)
        {
            HarvestTimeTable = _metaLayer.GetHarvestTimeTableTasks(startTime, finishTime);

            return HarvestTimeTable;
        }



        /// <summary>
        /// ian 16/11/18
        /// checks the state of the db and refreshes the connection.
        public void RefreshConnection()
        {
            try
            {


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
