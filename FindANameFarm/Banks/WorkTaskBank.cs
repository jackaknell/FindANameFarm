using System;
using System.Collections.Generic;
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
		public int StaffId { get; set; }
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
        private readonly MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();

        private readonly BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();
        public List<WorkTasks> WorkTaskList {get;set;}
        public static WorkTaskBank UniqueInst;
		public bool GetConnectionState { get; private set; }
		public List<TaskVehiclesAndDrivers> CurrentVehicleAndDriverList { get; set; }
		public List<Staff> TaskStaff { get; set; }
		public static int InstanceCount { get; set; }
		public WorkTaskBank()
		{
		   
			RefreshConnection();
			InstanceCount++;
            
		}

	    

        //singleton
        public static WorkTaskBank GetInst() => UniqueInst ?? (UniqueInst = new WorkTaskBank());

	
	    public void GetWorkTaskVehicles(int taskId)
	    {
	       
	            CurrentVehicleAndDriverList = _metaLayer.GetCurrentTaskVehicleList(taskId);

	    }

	    public void GetWorkTaskStaff(int taskId)
	    {

	            TaskStaff = _metaLayer.GetCurrentTaskStaff(taskId);

	    }
        public void AddWorkTaskToList(WorkTasks workTask)
		{
			WorkTaskList.Add(workTask);

			_metaLayer.AddWorkTaskToList(workTask);
		
		}

		public bool AddStaffToTask(TaskStaff addStaffToTask)
		{
			bool added = _metaLayer.AddStaffToTaskAndDb(addStaffToTask);

		    return added;
		}

		public void AddVehicleToTask(TaskVehiclesAndDrivers addVehicleAndDriverToTask)
		{
			_metaLayer.AddVehicleAndDriverToDb(addVehicleAndDriverToTask);

        }

	    public void StaffToDeleteFromTask(TaskStaff staffToDelete)
	    {
	        _metaLayer.DeleteStaffFromTask(staffToDelete);

	    }

        public void DeleteVehicleAndDriverFromTask(TaskVehiclesAndDrivers vehicleAndDriver)
		{
			_metaLayer.DeleteVehicleAndDriverFromDb(vehicleAndDriver);
		}

		public void UpdateWorkTask(WorkTasks editWorkTask)
		{
			_metaLayer.UpdateCurrentWorkTaskInDb(editWorkTask);
			RefreshConnection();
		}

		public void RefreshConnection()
		{
			try
			{
              
			    WorkTaskList = _metaLayer.GetWorkTasks();
			   
               
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
