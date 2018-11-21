using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindANameFarm.WorkTaskClasses;

namespace FindANameFarm.BasicClasses
{
    class WorkTaskReport:WorkTasks
    {
        public string FieldName { get; set; }
        public string CropName { get; set; }
        public string TreatmentName { get; set; }

        public string  VehicleName { get; set; }
    }
}
