using System;
using System.Collections.Generic;
using FindANameFarm.MetaLayer;

namespace FindANameFarm
{
    /// <summary>
    /// ian 28/10/2018
    /// structure to temporarily hold category id and name
    /// </summary>
    public struct VehicleAndDriver
    {

        public int staffId { get; set; }
        public string firstName { get; set; }
        public int categoryId { get; set; }
    }
    /// <summary>
    /// ian 
    /// </summary>
    public struct Cat
    {
        public int CatId { get; set; }

        public string CatName { get; set; }


    }
    /// <summary>
    /// ian 28/10/2018
    /// structure to temporarily hold vehicle and category
    /// </summary>
    public struct VehicleAndCategory
    {

        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string CategoryName { get; set; }
    }
    /// <summary>
    /// ian 26/10/2018
    /// vehicleBank class creates a single instance of the bank to add edit and remove vehicles from the database
    /// </summary>
    public class VehicleBank
    {
        private MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();

        private readonly BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();

        public List<Vehicles> VehicleList { get; private set; }
       
        public List<Cat> Categories { get; private set; }
        public bool GetConnectionState { get; private set; }
        public List<VehicleAndDriver> Drivers { get; private set; }
        public List<VehicleAndCategory> VehicleAndCategoryLists { get; private set; }

        public static VehicleBank UniqueInst;

        public static int InstanceCount { get; set; }
        public VehicleBank()
        {
            RefreshConnection();
            //Categories = new List<Cat>();
            InstanceCount++;
        }
        /// <summary>
        /// ian 26/10/2018
        /// singleton
        /// </summary>
        /// <returns></returns>
        public static VehicleBank GetInst() => UniqueInst ?? (UniqueInst = new VehicleBank());

        public void GetDrivers()
        {
            Drivers =_metaLayer.GetDriverList();
            
        }
        /// <summary>
        /// ian 26/10/2018
        /// </summary>
        /// <param name="vehicle"></param>
        public void AddVehicleToList(Vehicles vehicle)
        {
            VehicleList.Add(vehicle);
            _metaLayer.AddVehicleToDataBase(vehicle);
        }
        /// <summary>
        /// ian 26/10/2018
        /// </summary>
        /// <param name="category"></param>
        public void AddCategoryToDb(string category) => _metaLayer.AddCategoryToDataBase(category);


    
        /// <summary>
        /// ian 26/10/2018
        /// </summary>
        /// <param name="editVehicle"></param>
        public void UpdateVehicle(Vehicles editVehicle)
        {
            foreach (var vehicle in VehicleList)
            {
                if(vehicle.VehicleId == editVehicle.VehicleId)
                {
                    _metaLayer.UpdateVehicle(editVehicle);
                    RefreshConnection();
                }
            }
        }
        /// <summary>
        /// ian 26/10/2018
        /// refreshes class lists
        /// </summary>
        public void RefreshConnection()
        {
            try
            {
               
                VehicleList = _metaLayer.GetVehicle();
                Categories = _metaLayer.GetCategories();
                VehicleAndCategoryLists = _metaLayer.GetVehicleAndCategories();

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
