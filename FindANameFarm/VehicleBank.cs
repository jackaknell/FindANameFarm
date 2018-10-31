using System;
using System.Collections.Generic;
using FindANameFarm.MetaLayer;

namespace FindANameFarm
{
    public struct Cat
    {
        public int CatId { get; set; }

        public string CatName { get; set; }


    }

    public struct VehicleAndCategory
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string CategoryName { get; set; }
    }

    class VehicleBank
    {
        private BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();

        public List<Vehicles> VehicleList { get; private set; }
       
        public List<Cat> Categories { get; private set; }
        
        public List<VehicleAndCategory> VehicleAndCategoryLists { get; private set; }

        public static VehicleBank UniqueInst;
        public VehicleBank()
        {
            RefreshConnection();
            Categories = new List<Cat>();
           
        }

        public bool GetConnectionState { get; private set; }

        public static VehicleBank GetInst() => UniqueInst ?? (UniqueInst = new VehicleBank());

        public void AddVehicleToList(Vehicles vehicle)
        {
            VehicleList.Add(vehicle);
            _metaLayer.AddVehicleToDataBase(vehicle);
        }
        
        public void AddCatagoryToDb(string category)
        {
            //categoryList.Add(category);
            _metaLayer.AddCategoryToDataBase(category);
        }

        public void DeleteVehicle(int vehicleId)
        {
            for (int i = 0; i < VehicleList.Count; i++)
            {
                Vehicles vehicle = VehicleList[i];
                if (vehicle.VehicleId == vehicleId)
                {
                    _metaLayer.DeleteVehicle(vehicleId);
                    RefreshConnection();
                }
            }
        }

        public void UpdateVehicle(Vehicles editVehicle)
        {
            for (int i = 0; i < VehicleList.Count; i++)
            {
                Vehicles vehicle = VehicleList[i];
                if(vehicle.VehicleId == editVehicle.VehicleId)
                {
                    _metaLayer.UpdateVehicle(editVehicle);
                    RefreshConnection();
                }
            }
        }
        public void RefreshConnection()
        {
            try
            {
               
                VehicleList = _metaLayer.GetVehicle();
                Categories = _metaLayer.GetCategories();
                VehicleAndCategoryLists = _metaLayer.GetVehicleAndCategories();

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
