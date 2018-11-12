using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindANameFarm.MetaLayer;
using FindANameFarm.WorkTaskClasses;

namespace FindANameFarm.Banks
{
    public struct TaskStaff
    {
        public int TaskId { get; set; }
        public int staffId { get; set; }
    }

    public struct TaskVehiclesAndDrivers
    {
        public int TaskId { get; set; }
        public int VehicleId { get; set; }
        public int DriverId { get; set; }
    }

    public class WorkTaskBank
    {
        private BusinessMetaLayer _metalayer = BusinessMetaLayer.GetInstance();
        public List<WorkTasks>WorkTaskList { get; set; }
        public static WorkTaskBank UniqueInst;
        public bool GetConnectionState { get; private set; }
        public List<TaskVehiclesAndDrivers> _currentVehicleAndDriverList { get; set; }
        public List<TaskStaff> CurrentTaskStaff { get; set; }
        public List<Staff> taskStaff { get; set; }
        public static int InstanceCount { get; set; }
        public WorkTaskBank()
        {
            refreshConnection();
            InstanceCount++;
        }

        //singleton
        public static WorkTaskBank GetInst() => UniqueInst ?? (UniqueInst = new WorkTaskBank());

        public void AddWorkTaskToList(WorkTasks workTask)
        {
           
            WorkTaskList.Add(workTask);
            Debug.WriteLine(WorkTaskList[1].ExpectedHarvestDate);
            _metalayer.AddWorkTaskToList(workTask);
        }

        public void AddStaffToTask(TaskStaff addStaffToTask)
        {
            _metalayer.AddStaffToTaskAndDb(addStaffToTask);

        }

        public void GetWorkTaskStaff(int taskId)
        {

            taskStaff  = _metalayer.GetCurrentTaskStaff(taskId);

        }
        public void refreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                WorkTaskList = metaLayer.GetWorkTasks();

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
