using FindANameFarm.WorkTaskClasses;

namespace FindANameFarm.BasicClasses
{
    /// <summary>
    ///
    /// Ian 25/11/2018
    /// </summary>
    public class WorkTaskReport:WorkTasks
    {
        public string FieldName { get; set; }
        public string CropName { get; set; }
        public string TreatmentName { get; set; }

        public string  VehicleName { get; set; }
    }
}
