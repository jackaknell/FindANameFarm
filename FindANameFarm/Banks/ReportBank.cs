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
    class ReportBank
    {
        private readonly BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();

        public static ReportBank UniqueInst;
        public static int InstanceCount { get; set; }
        public bool GetConnectionState { get; private set; }
        public static List<WorkTaskReport> CropsInCultivation { get; set; }
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
        public static ReportBank GetInst() => UniqueInst ?? (UniqueInst = new ReportBank());

        /// <summary>
        /// ian 16/11/18
        /// </summary>
        /// <param name="staffMember"></param>
        /// <returns></returns>
        public List<WorkTaskReport> GetCropsInCultivation()
        {
            CropsInCultivation = _metaLayer.GetCropsInCultivationFromDb();

            return CropsInCultivation;
            {

            }
        }

        public List<WorkTaskReport> GetStaffWorkTasks(int staffMember, string startTime, string finishTime)
        {
            StaffWorkTasks = _metaLayer.GetLabouerWorkTasks(staffMember, startTime, finishTime);

            return StaffWorkTasks;
        }
        /// <summary>
        /// ian 16/11/18
        /// </summary>
        /// <returns></returns>
        public List<WorkTaskReport> GetHarvestTimeTable(string startTime, string finishTime)
        {
            HarvestTimeTable = _metaLayer.GetHarvestTimeTableTasks(startTime, finishTime);

            return HarvestTimeTable;
        }

        public List<WorkTaskReport> GetVehicleWorkTasks(int staffMember, string startTime, string finishTime)
        {
            VehicleWorkTasks = _metaLayer.GetVehicleWorkTasks(staffMember, startTime, finishTime);

            return VehicleWorkTasks;
        }
		//public List<WorkTaskReport> GetAvailableStorage()
		//{
		//	AvailableStorage = _metaLayer.GetAvailableStorageFromDb();

		//	return AvailableStorage;
		//	{

		//	}
		//}
        /// <summary>
        /// ian 16/11/18
        /// </summary>
        public void RefreshConnection()
        {
            try
            {


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
