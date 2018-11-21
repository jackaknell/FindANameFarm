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
    /// <summary>
    /// ian 12/11/18
    /// </summary>
    public struct TaskStaff
    {
        public int TaskId { get; set; }
        public int staffId { get; set; }
    }

    /// <summary>
    /// ian 12/11/18
    /// </summary>
    public struct TaskVehiclesAndDrivers
    {
        public int TaskId { get; set; }
        public int VehicleId { get; set; }
        public int DriverId { get; set; }
        public string VehicleName { get; set; }
        public string DriverName { get; set; }
    }
    

    public class WorkTaskBank
    {
        private BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();
        public List<WorkTasks>WorkTaskList { get; set; }
        public static WorkTaskBank UniqueInst;
        public bool GetConnectionState { get; private set; }
        public List<TaskVehiclesAndDrivers> CurrentVehicleAndDriverList { get; set; }
        public List<TaskStaff> CurrentTaskStaff { get; set; }
        public List<Staff> TaskStaff { get; set; }
        public List<Vehicles> TaskVehicles { get; set; }
        public static int InstanceCount { get; set; }
        bool dataBaseFlag { get; set; }
        public WorkTaskBank()
        {
            refreshConnection();
            InstanceCount++;
        }

      

        //singleton
        public static WorkTaskBank GetInst() => UniqueInst ?? (UniqueInst = new WorkTaskBank());
        public void GetWorkTasks()
        {
            
          
                WorkTaskList = _metaLayer.GetWorkTasks();

            
        }
        public void AddWorkTaskToList(WorkTasks workTask)
        {
           
            WorkTaskList.Add(workTask);
            
            _metaLayer.AddWorkTaskToList(workTask);
            dataBaseFlag = false;
        }

        public void AddStaffToTask(TaskStaff addStaffToTask)
        {
            _metaLayer.AddStaffToTaskAndDb(addStaffToTask);

        }

        public void AddvehicleToTask(TaskVehiclesAndDrivers addVehicleAndDriverToTask)
        {
            _metaLayer.AddVehicleAndDriverToDb(addVehicleAndDriverToTask);
            
        }

        public void GetWorkTaskVehicles(int taskId)
        {
           CurrentVehicleAndDriverList = _metaLayer.GetCurrentTaskVehicleList(taskId);
        }
        public void GetWorkTaskStaff(int taskId)
        {

            TaskStaff  = _metaLayer.GetCurrentTaskStaff(taskId);

        }

        public void DeleteVehicleAndDriverFromTask(TaskVehiclesAndDrivers vehicleAndDriver)
        {
            _metaLayer.DeleteVehicleAndDriverFromDb(vehicleAndDriver);
        }

        public void UpdateWorkTask(WorkTasks editWorkTask)
        {
            _metaLayer.UpdateCurrentWorkTaskInDb(editWorkTask);
            refreshConnection();
        }
        public void refreshConnection()
        {
            try
            {
                //BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                GetWorkTasks();

                GetConnectionState = true;
            }
            catch (Exception)
            {
                GetConnectionState = false;
                throw;
            }
        }

        public void StaffToDeleteFromTask(TaskStaff staffToDelete)
        {
            _metaLayer.DeleteStaffFromTask(staffToDelete);
        }
    }
}
