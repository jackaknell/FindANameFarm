using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
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
	/// WorkTaskBank
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

	    //Get the current tasks vehicles and there drivers from the database
	    public void GetWorkTaskVehicles(int taskId)
	    {
	       
	            CurrentVehicleAndDriverList = _metaLayer.GetCurrentTaskVehicleList(taskId);

	    }

        //Gets the staff for the current work task from the data base
	    public void GetWorkTaskStaff(int taskId)
	    {

	            TaskStaff = _metaLayer.GetCurrentTaskStaff(taskId);

	    }

        //adds the work task to the class list and the database
        public void AddWorkTaskToList(WorkTasks workTask)
		{
			WorkTaskList.Add(workTask);

			_metaLayer.AddWorkTaskToList(workTask);
		
		}

        //adds a labourer to the current work task
		public bool AddStaffToTask(TaskStaff addStaffToTask)
		{
			bool added = _metaLayer.AddStaffToTaskAndDb(addStaffToTask);

		    return added;
		}

        //add a vehicle and a driver to the worktask vehicle list in the database
		public bool AddVehicleToTask(TaskVehiclesAndDrivers addVehicleAndDriverToTask)
		{
		    bool added=_metaLayer.AddVehicleAndDriverToDb(addVehicleAndDriverToTask);

		    return added;
        }

        //deletes the selected staff member from the current task
	    public void StaffToDeleteFromTask(TaskStaff staffToDelete)
	    {
	        _metaLayer.DeleteStaffFromTask(staffToDelete);

	       
	    }

        //delete the vehicle and driver from the current task
        public void DeleteVehicleAndDriverFromTask(TaskVehiclesAndDrivers vehicleAndDriver)
		{
			_metaLayer.DeleteVehicleAndDriverFromDb(vehicleAndDriver);
		}
        //updates the selected worktask
		public void UpdateWorkTask(WorkTasks editWorkTask)
		{
			_metaLayer.UpdateCurrentWorkTaskInDb(editWorkTask);
			RefreshConnection();
		}
        //checks the state and refreshes the connection, reloading the work task list in the class
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
