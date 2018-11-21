using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindANameFarm
{
    class VehicleCreator
    {
        private static VehicleCreator uniqueInst;
        public static VehicleCreator getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new VehicleCreator();
            }

            return uniqueInst;
        }

        public void CreateUpdateVehicles(int vehicleId, string vehicleName, int vehicleCategory)
        {
            Vehicles vehicle = new Vehicles();
            vehicle.VehicleId = vehicleId;
            vehicle.VehicleName = vehicleName;
            vehicle.Category = vehicleCategory;

            VehicleBank vehicleBank = VehicleBank.GetInst();

           
            //vehicleBank.addVehicleToList(vehicle);
        }
    }
}
