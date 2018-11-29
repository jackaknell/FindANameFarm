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
