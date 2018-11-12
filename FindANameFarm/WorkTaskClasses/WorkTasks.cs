using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindANameFarm.Banks;

namespace FindANameFarm.WorkTaskClasses
{
    public class WorkTasks
    {
        public int TaskId { get; set; }
        public string TaskType { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public int FieldId { get; set; }
        public int CropId { get; set; }
        public int TreatmentId { get; set; }
        public int QuantityRequired { get; set; }
        public int JobDuration{ get; set; }
        public int ExpectedYield { get; set; }
        public List<TaskStaff> StaffTaskList { get; set; }
        public DateTime ExpectedHarvestDate { get; set; }
        public List<TaskVehiclesAndDrivers> VehicleAndDriverList { get; set; }

    }
}
