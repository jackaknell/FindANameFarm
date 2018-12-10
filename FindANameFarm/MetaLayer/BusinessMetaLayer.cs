using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using FindANameFarm.Banks;
using FindANameFarm.BasicClasses;
using FindANameFarm.WorkTaskClasses;

namespace FindANameFarm.MetaLayer
{
	/// <summary>
	/// Ian 25/10/2018
	/// sql queries
	/// </summary>
	class BusinessMetaLayer
	{
		private static BusinessMetaLayer _instance;
		IIDbConnection _con = DbFactory.Instance();

		public static BusinessMetaLayer GetInstance()
		{
			return _instance ?? (_instance = new BusinessMetaLayer());
		}
		/// <summary>
		/// Ian 27/10/18
		/// selects current staff member by id
		/// </summary>
		/// <param name="login"></param>
		/// <returns></returns>
		public List<Staff> GetLogin(Staff login)
		{
			List<Staff> staffLogin = new List<Staff>();

			if (_con.OpenConnection())
			{
				DbDataReader dr = _con.Select("SELECT staffID, Role, staffpassword, firstName, surName from staff where staffId=" + login.StaffId + " and staffpassword = '" +
				login.Password + "'");
				// DbDataReader dr = _con.Select("SELECT staffID, firstName, surname, gender, email, role, contactNumber, imageLocation, password FROM Staff;");

				while (dr.Read())
				{
					Staff staffMember = new Staff
					{
						StaffId = dr.GetInt32(0),

						Role = dr.GetString(1),

						Password = dr.GetString(2),

						FirstName = dr.GetString(3),

						SurName = dr.GetString(4)
					};
					staffLogin.Add(staffMember);
				}
				dr.Close();
				_con.CloseConnection();
			}

			return staffLogin;
		}
		/// <summary>
		/// Ian 27/10/2018
		/// selects all staff members and puts them in a list
		/// </summary>
		/// <returns></returns>
		public List<Staff> GetStaff()
		{
			List<Staff> staff = new List<Staff>();

			//IIDbConnection con = DbFactory.Instance();
			if (_con.OpenConnection())
			{

				DbDataReader dr = _con.Select("SELECT staffID, firstName, surname, gender, email, role, contactNumber, imageLocation, staffpassword FROM Staff;");


				//Read the data and store them in the list
				while (dr.Read())
				{

					Staff staffMember = new Staff
					{
						StaffId = dr.GetInt32(0),
						FirstName = dr.GetString(1),
						SurName = dr.GetString(2),
						Gender = dr.GetString(3),
						Email = dr.GetString(4),
						Role = dr.GetString(5),
						Contact = dr.GetString(6),
						ImageFile = dr.GetString(7),
						Password = dr.GetString(8)
					};


					staff.Add(staffMember);



				}

				//close Data Reader
				dr.Close();
				_con.CloseConnection();
			}

			return staff;
		}
		/// <summary>
		/// ian 07/11/18
		/// gets a list of all crops and details
		/// </summary>
		/// <returns></returns>
		public List<Crops> GetCrops()
		{
			List<Crops> crops = new List<Crops>();

			//IIDbConnection con = DbFactory.Instance();
			if (_con.OpenConnection())
			{

				DbDataReader dr = _con.Select("SELECT * FROM Crops;");


				//Read the data and store them in the list
				while (dr.Read())
				{

					Crops crop = new Crops
					{
						CropId = dr.GetInt32(0),
						CropName = dr.GetString(1),
						CropStock = dr.GetInt32(2)

					};


					crops.Add(crop);



				}

				//close Data Reader
				dr.Close();
				_con.CloseConnection();
			}

			return crops;
		}

		/// <summary>
		/// Ian 3/11/2018
		/// selects all competencies for a given staff member
		/// <param name="staffId"></param>
		/// <returns></returns>
		public List<CatIdAndName> GetCompetencies(int staffId)
		{
			List<CatIdAndName> competencies = new List<CatIdAndName>();
			if (_con.OpenConnection())
			{


				DbDataReader dr =
					_con.Select(
						"SELECT Staff_category.categoryId, Category.categoryName FROM Category INNER JOIN Staff_category ON Category.categoryId = Staff_category.categoryId WHERE staffId = " +
						staffId + "; ");



				while (dr.Read())
				{
					CatIdAndName staffCompetency = new CatIdAndName()
					{
						CategoryId = dr.GetInt32(0),
						CategoryName = dr.GetString(1),
					};

					competencies.Add(staffCompetency);
				}


				dr.Close();
				_con.CloseConnection();
			}

			return competencies;
		}
		/// <summary>
		/// ian 09/11/18
		/// gets a list of vehicles and drivers from the db
		/// </summary>
		/// <returns></returns>
		public List<VehicleAndDriver> GetDriverList()
		{
			List<VehicleAndDriver> driverList = new List<VehicleAndDriver>();
			if (_con.OpenConnection())
			{
				DbDataReader dr =
					_con.Select(
						"SELECT Staff_category.staffId, Staff.firstName, Staff_category.categoryId FROM Staff INNER JOIN Staff_category ON Staff.staffID = Staff_category.staffId; "
					);

				while (dr.Read())
				{
					VehicleAndDriver driver = new VehicleAndDriver()
					{
						staffId = dr.GetInt32(0),
						firstName = dr.GetString(1),
						categoryId = dr.GetInt32(2)
					};
					driverList.Add(driver);
				}
				dr.Close();
				_con.CloseConnection();
			}

			return driverList;
		}
		/// <summary>
		/// ian 11/11/18
		/// gets a list of vehicle and drivers for the current task
		/// </summary>
		/// <param name="taskId"></param>
		/// <returns></returns>
		public List<TaskVehiclesAndDrivers> GetCurrentTaskVehicleList(int taskId)
		{
			List<TaskVehiclesAndDrivers> taskVehicleList = new List<TaskVehiclesAndDrivers>();
			if (_con.OpenConnection())
			{
				DbDataReader dr =
					_con.Select("SELECT Vehicles.vehicleName, Staff.firstName, Vehicle_WorkTask.workTaskId, Vehicles.VehicleId, Staff.staffID FROM Vehicles INNER JOIN(Staff INNER JOIN Vehicle_WorkTask ON Staff.staffID = Vehicle_WorkTask.staffId) ON Vehicles.VehicleId = Vehicle_WorkTask.vehicleId WHERE WorkTaskId = " + taskId + ";");

				while (dr.Read())
				{
					TaskVehiclesAndDrivers taskVehicle = new TaskVehiclesAndDrivers()
					{
						VehicleName = dr.GetString(0),
						DriverName = dr.GetString(1),
						TaskId = dr.GetInt32(2),
						VehicleId = dr.GetInt32(3),
						DriverId = dr.GetInt32(4)
					};
					taskVehicleList.Add(taskVehicle);
				}
				dr.Close();
				_con.CloseConnection();
			}
			return taskVehicleList;
		}
		/// <summary>
		/// ian 11/11/18
		/// gets a list of staff on the current task
		/// </summary>
		/// <param name="taskId"></param>
		/// <returns></returns>
		public List<Staff> GetCurrentTaskStaff(int taskId)
		{
			List<Staff> taskStaffList = new List<Staff>();
			if (_con.OpenConnection())
			{
				DbDataReader dr =
					_con.Select("SELECT StaffWorkTask.staffId, Staff.firstName, Staff.surname FROM Staff INNER JOIN StaffWorkTask ON Staff.staffID = StaffWorkTask.staffId WHERE WorkTaskId = " +
								taskId + "; ");
                
				while (dr.Read())
				{
					Staff taskStaffMember = new Staff()
					{
						StaffId = dr.GetInt32(0),
						FirstName = dr.GetString(1),
						SurName = dr.GetString(2),
					};
					taskStaffList.Add(taskStaffMember);
				}
				dr.Close();
				_con.CloseConnection();
			}
			return taskStaffList;
		}
		/// <summary>
		/// ian 30/10/2018
		/// selects and returns a list of vehicle categories
		/// </summary>
		/// <returns></returns>
		public List<Cat> GetCategories()
		{

			List<Cat> categoriesList = new List<Cat>();

			if (_con.OpenConnection())
			{

				DbDataReader dr = _con.Select("SELECT * FROM category;");

				while (dr.Read())
				{
					Cat category = new Cat
					{
						CatId = dr.GetInt32(0),
						CatName = dr.GetString(1),
					};

					categoriesList.Add(category);
				}


				dr.Close();
				_con.CloseConnection();
			}

			return categoriesList;
		}
		/// <summary>
		/// ian 26/10/2018
		/// selects and returns a list of stored vehicles
		/// </summary>
		/// <returns></returns>
		public List<Vehicles> GetVehicle()
		{
			List<Vehicles> vehicles = new List<Vehicles>();


			if (_con.OpenConnection())
			{


				DbDataReader dr = _con.Select("SELECT * FROM Vehicles; ");
				//
				//Read the data and store them in the list
				while (dr.Read())
				{
					//Debug.WriteLine(dr.HasRows);
					Vehicles vehicle = new Vehicles
					{

						VehicleId = dr.GetInt32(0),
						VehicleName = dr.GetString(1),
						Category = dr.GetInt32(2)

					};


					vehicles.Add(vehicle);

				}

				//close Data Reader
				dr.Close();
				_con.CloseConnection();


			}
			return vehicles;
		}
		/// <summary>
		/// jason 06/11/18
        /// selects and returns a list of stored fertilisers & treatments
		/// </summary>
		/// <returns></returns>
		public List<FertiliserAndTreatment> GetFertiliserAndTreatment()
		{
			List<FertiliserAndTreatment> fertTreat = new List<FertiliserAndTreatment>();

			if (_con.OpenConnection())
			{
				DbDataReader dr = _con.Select("SELECT * FROM FertiliserAndTreatment;");

				while (dr.Read())
				{
					FertiliserAndTreatment fertTreatType = new FertiliserAndTreatment
					{
						FertTreatId = dr.GetInt32(0),
						FertTreatName = dr.GetString(1),
						FertTreatQuantity = dr.GetInt32(2)
					};
					fertTreat.Add(fertTreatType);
				}
				dr.Close();
				_con.CloseConnection();
			}
			return fertTreat;
		}
		/// <summary>
		/// Ian 29/10/2018
		/// selects and returns a list of vehicles and there category
		/// </summary>
		/// <returns></returns>
		public List<VehicleAndCategory> GetVehicleAndCategories()
		{
			List<VehicleAndCategory> vehicleCat = new List<VehicleAndCategory>();

			if (_con.OpenConnection())
			{


				DbDataReader dr = _con.Select("SELECT Vehicles.VehicleId, Vehicles.vehicleName, Category.categoryName FROM Category INNER JOIN Vehicles ON Category.categoryId = Vehicles.vehicleCategory; ");
				//
				//Read the data and store them in the list
				while (dr.Read())
				{
					VehicleAndCategory vehicleCategory = new VehicleAndCategory
					{

						VehicleId = dr.GetInt32(0),
						VehicleName = dr.GetString(1),
						CategoryName = dr.GetString(2)

					};


					vehicleCat.Add(vehicleCategory);
				}
				dr.Close();
				_con.CloseConnection();
			}

			return vehicleCat;
		}
		/// <summary>
		/// Jason 06/11/2018
		/// Gets the list of fields and add them to the Field list
		/// </summary>
		/// <returns></returns>
		public List<Fields> GetFields()
		{
			List<Fields> fields = new List<Fields>();
			if (_con.OpenConnection())
			{
				DbDataReader dr = _con.Select("SELECT * FROM Fields;");

				while (dr.Read())
				{
					Fields field = new Fields()
					{
						FieldId = dr.GetInt32(0),
						FieldName = dr.GetString(1),
						FieldSize = dr.GetInt32(2),
						FieldSuitability = dr.GetString(3),
					};
					fields.Add(field);
				}
				dr.Close();
				_con.CloseConnection();
			}

			return fields;
		}
		public List<Storage> GetStorage()
		{
			List<Storage> storage = new List<Storage>();
			if (_con.OpenConnection())
			{

				DbDataReader dr = _con.Select("SELECT * FROM Storage;");

				while (dr.Read())
				{
					Storage store = new Storage()
					{
						StorageID = dr.GetInt32(0),
						StorageName = dr.GetString(1),
						Capacity = dr.GetInt32(2),
						AvailableStorage = dr.GetInt32(3),
						Temp = dr.GetInt32(4)
					};

					storage.Add(store);
				}

				dr.Close();
				_con.CloseConnection();

			}

			return storage;
		}
        /// <summary>
        /// Jack
        /// </summary>
        /// <returns></returns>
	    public List<Audit> GetAuidt()
	    {
	        List<Audit> audit = new List<Audit>();
	        if (_con.OpenConnection())
	        {

	            DbDataReader dr = _con.Select("");

	            while (dr.Read())
	            {
	                Audit auidt = new Audit()
	                {
	                    AuditId = dr.GetInt32(0),
	                    Date = dr.GetDateTime(1),
	                    Name = dr.GetString(2),
	                    Amount = dr.GetInt32(3),
	                    Decription = dr.GetString(4),
	                };

	                audit.Add(auidt);
	            }

	            dr.Close();
	            _con.CloseConnection();

	        }

	        return audit;
	    }
        

		/// <summary>
		/// ian 12/11/18
		/// gets a list of all work tasks
		/// </summary>
		/// <returns></returns>
		public List<WorkTasks> GetWorkTasks()
		{
			List<WorkTasks> workTasks = new List<WorkTasks>();
			if (_con.OpenConnection())
			{
				DbDataReader dr = _con.Select("SELECT workTaskId,TaskType,startDate," +
				                              "finishDate,FieldId,CropId,treatmentId,quantityRequired," +
				                              "jobduration,expectedharvestdate,expectedyield,taskstatus " +
				                              "FROM WorkTasks;");

				while (dr.Read())
				{
					WorkTasks workTask = new WorkTasks()
					{
						TaskId = dr.GetInt32(0),
						TaskType = dr.GetString(1),
						TaskStartDate = dr.GetDateTime(2),
						TaskEndDate = dr.GetDateTime(3),
						FieldId = dr.GetInt32(4),
						CropId = dr.GetInt32(5),
						TreatmentId = dr.GetInt32(6),
						QuantityRequired = dr.GetInt32(7),
						JobDuration = dr.GetInt32(8),
						ExpectedHarvestDate = dr.GetDateTime(9),
						ExpectedYield = dr.GetInt32(10),
						TaskStatus = dr.GetString(11)
					};
					
					workTasks.Add(workTask);
				}
				dr.Close();
				_con.CloseConnection();
			}
			return workTasks;
		}

	
		/// <summary>
		/// ian 16/11/18
		/// gets a list of labour tasks for the given labourer between the given dates
		/// </summary>
		/// <returns></returns>
		public List<WorkTaskReport> GetLabouerWorkTasks(int staffMember, string startTime, string finishTime)
		{
			List<WorkTaskReport> labourerWorkTaskReport = new List<WorkTaskReport>();
			if (_con.OpenConnection())
			{
      

				DbDataReader dr = _con.Select("SELECT WorkTasks.TaskType, WorkTasks.startDate, WorkTasks.finishDate, WorkTasks.QuantityRequired, " +
											  "Crops.cropName, Fields.FieldName, WorkTasks.jobDuration, WorkTasks.ExpectedHarvestDate," +
											  " WorkTasks.ExpectedYield, WorkTasks.workTaskId, IIF(IsNull(FertiliserAndTreatment.fertTreatName),'None',FertiliserAndTreatment.fertTreatName) FROM" +
											  " FertiliserAndTreatment RIGHT JOIN(Crops INNER JOIN(Fields INNER JOIN(Staff INNER JOIN" +
											  "(WorkTasks INNER JOIN StaffWorkTask ON WorkTasks.workTaskId = StaffWorkTask.workTaskId)" +
											  " ON Staff.staffID = StaffWorkTask.staffId) ON Fields.FieldId = WorkTasks.FieldId) " +
											  "ON Crops.cropID = WorkTasks.CropId) ON FertiliserAndTreatment.fertTreatId = " +
											  "WorkTasks.treatmentId WHERE StaffWorkTask.staffId=" + staffMember + "and WorkTasks.startDate between " +
											  "#" + startTime + "# and #" + finishTime + "# order by WorkTasks.startDate;");


                while (dr.Read())
				{
					WorkTaskReport labourerWorkTask = new WorkTaskReport()
					{
						TaskType = dr.GetString(0),
						TaskStartDate = dr.GetDateTime(1),
						TaskEndDate = dr.GetDateTime(2),
						QuantityRequired = dr.GetInt32(3),
						CropName = dr.GetString(4),
						FieldName = dr.GetString(5),
						JobDuration = dr.GetInt32(6),
						ExpectedHarvestDate = dr.GetDateTime(7),
						ExpectedYield = dr.GetInt32(8),
						TaskId = dr.GetInt32(9),
						TreatmentName = dr.GetString(10)

					};

					labourerWorkTaskReport.Add(labourerWorkTask);
				}
				dr.Close();
				_con.CloseConnection();
			}

			return labourerWorkTaskReport;
		}

        /// <summary>
        /// Ian 17/11/18
        /// get a vehicle task list for the give labourer between the given dates
        /// </summary>
        /// <param name="staffMember"></param>
        /// < param name="startTime"></param>
        /// <param name="finishTime"></param>
        /// <returns></returns>
		public List<WorkTaskReport> GetVehicleWorkTasks(int staffMember, string startTime, string finishTime)
		{
			List<WorkTaskReport> vehiclerWorkTaskReport = new List<WorkTaskReport>();
			if (_con.OpenConnection())
			{
				DbDataReader dr = _con.Select("SELECT WorkTasks.TaskType, WorkTasks.startDate, WorkTasks.finishDate, " +
											  "WorkTasks.QuantityRequired, Crops.cropName, Fields.FieldName," +
											  " WorkTasks.jobDuration, WorkTasks.ExpectedHarvestDate, WorkTasks.ExpectedYield, WorkTasks.workTaskId," +
											  " IIF(IsNull(FertiliserAndTreatment.fertTreatName),'None',FertiliserAndTreatment.fertTreatName)," +
											  " Vehicles.vehicleName FROM Vehicles inner JOIN(Fields INNER JOIN(FertiliserAndTreatment " +
											  "Right JOIN(Crops INNER JOIN(WorkTasks INNER JOIN Vehicle_WorkTask ON WorkTasks.workTaskId = " +
											  "Vehicle_WorkTask.workTaskId) ON Crops.cropID = WorkTasks.CropId) ON FertiliserAndTreatment.fertTreatId = " +
											  "WorkTasks.treatmentId) ON Fields.FieldId = WorkTasks.FieldId) ON Vehicles.VehicleId = " +
											  "Vehicle_WorkTask.vehicleId WHERE Vehicle_WorkTask.staffId=" + staffMember + "and WorkTasks.startDate " +
											  ">= #" + startTime + "# and WorkTasks.startDate <= #" + finishTime + "# order by WorkTasks.startDate;");

				while (dr.Read())
				{
					WorkTaskReport vehicleWorkTask = new WorkTaskReport()
					{
						TaskType = dr.GetString(0),
						TaskStartDate = dr.GetDateTime(1),
						TaskEndDate = dr.GetDateTime(2),
						QuantityRequired = dr.GetInt32(3),
						CropName = dr.GetString(4),
						FieldName = dr.GetString(5),
						JobDuration = dr.GetInt32(6),
						ExpectedHarvestDate = dr.GetDateTime(7),
						ExpectedYield = dr.GetInt32(8),
						TaskId = dr.GetInt32(9),
						TreatmentName = dr.GetString(10),
						VehicleName = dr.GetString(11)
					};

					vehiclerWorkTaskReport.Add(vehicleWorkTask);
				}
				dr.Close();
				_con.CloseConnection();
			}

			return vehiclerWorkTaskReport;
		}
		/// <summary>
		/// ian 17/11/18
		/// ets a list of all tasks between the given dates
		/// </summary>
		/// <returns></returns>
		public List<WorkTaskReport> GetHarvestTimeTableTasks(string startTime, string finishTime)
		{
			List<WorkTaskReport> harvestList = new List<WorkTaskReport>();


			if (_con.OpenConnection())
			{
				DbDataReader dr = _con.Select("SELECT WorkTasks.workTaskId, WorkTasks.startDate, WorkTasks.finishDate," +
											  " WorkTasks.TaskType, Crops.cropName, Fields.FieldName, IIF(IsNull(FertiliserAndTreatment.fertTreatName),'None',FertiliserAndTreatment.fertTreatName) " +
											  "FROM FertiliserAndTreatment right JOIN(Fields INNER JOIN(Crops INNER JOIN WorkTasks ON Crops.cropID = WorkTasks.CropId) ON Fields.FieldId =" +
											  " WorkTasks.FieldId) ON FertiliserAndTreatment.fertTreatId =" +
											  " WorkTasks.treatmentId where WorkTasks.startDate between " +"#" + startTime + "# and #" + finishTime + "# order by WorkTasks.startDate;");
                

                while (dr.Read())
				{
					WorkTaskReport harvestJob = new WorkTaskReport
					{

						TaskId = dr.GetInt32(0),
						TaskStartDate = dr.GetDateTime(1),
						TaskEndDate = dr.GetDateTime(2),
						TaskType = dr.GetString(3),
						CropName = dr.GetString(4),
						FieldName = dr.GetString(5),
						TreatmentName = dr.GetString(6)

					};
					harvestList.Add(harvestJob);
				}
				dr.Close();
				_con.CloseConnection();
			}
			return harvestList;
		}

        /// <summary>
        /// ian 18/11/18
        /// gets a list of crop tasks that are marked as started from the db
        /// </summary>
        /// <returns></returns>
       
		public List<WorkTaskReport> GetCropsInCultivationFromDb()
		{
			List<WorkTaskReport> cropsInCultivationList = new List<WorkTaskReport>();

			if (_con.OpenConnection())
			{
				DbDataReader dr = _con.Select("SELECT Crops.cropName, Fields.FieldName, WorkTasks.startDate, " +
											  "WorkTasks.finishDate, WorkTasks.ExpectedYield, " +
											  "WorkTasks.TaskStatus FROM Fields INNER JOIN" +
											  "(Crops INNER JOIN WorkTasks ON Crops.cropID = WorkTasks.CropId) " +
											  "ON Fields.FieldId = WorkTasks.FieldId Where worktasks.TaskStatus = 'Task Started'");

				while (dr.Read())
				{
					WorkTaskReport activeCrop = new WorkTaskReport
					{

						CropName = dr.GetString(0),
						FieldName = dr.GetString(1),
						TaskStartDate = dr.GetDateTime(2),
						TaskEndDate = dr.GetDateTime(3),
						ExpectedYield = dr.GetInt32(4)
					};
					cropsInCultivationList.Add(activeCrop);
				}

				dr.Close();
				_con.CloseConnection();
			}

			return cropsInCultivationList;
		}		
		/// <summary>
		/// ian 28/10/2018
		/// inserts a new staff member to the database
		/// </summary>
		/// <param name="newStaff"></param>
		public void AddStaffToDataBase(Staff newStaff)
		{


			string firstName = newStaff.FirstName;
			string surname = newStaff.SurName;
			string gender = newStaff.Gender;
			string email = newStaff.Email;
			string role = newStaff.Role;
			string contactNumber = newStaff.Contact;
			string filepath = newStaff.ImageFile;
			string password = newStaff.Password;

			string query = "Insert into staff(firstName, surname, gender, email, role, contactNumber, imageLocation, staffpassword) Values('" +
						   firstName + "','" + surname + "','" + gender + "','" + email + "','" + role + "','" +
						   contactNumber + "','" + filepath + "','" + password + "');";


			_con.Insert(query);

		}
		/// <summary>
		/// jason 06/11/2018
		/// adds a field to the database
		/// </summary>
		/// <param name="newField"></param>
		/// 
		public void AddFieldToDataBase(Fields newField)
		{
			string fieldName = newField.FieldName;
			Int32 fieldSize = newField.FieldSize;
			string fieldSuitability = newField.FieldSuitability;


			string query = "Insert into fields(FieldName, FieldSize, FieldSuitability) Values('" + fieldName + "','" +
						   fieldSize + "','" + fieldSuitability + "');";

			_con.Insert(query);

		}
		/// <summary>
		/// ian 9/11/18
		/// adds a new crop to the db
		/// </summary>
		/// <param name="newCrop"></param>
		public void AddCropToDataBase(Crops newCrop)
		{
           
			string cropName = newCrop.CropName;
			Int32 cropStock = newCrop.CropStock;

			string query = "Insert into Crops(CropName, CropStock) Values('" + cropName + "'," +
                           cropStock + ");";

			_con.Insert(query);

		}
		/// <summary>
		/// ian 28/10/2018
		/// inserts a new vehicle into the database
		/// </summary>
		/// <param name="newVehicle"></param>
		public void AddVehicleToDataBase(Vehicles newVehicle)
		{

			string query = "Insert into vehicles(vehicleName,vehicleCategory) Values('" +
						   newVehicle.VehicleName + "','" + newVehicle.Category + "');";


			_con.Insert(query);
			_con.CloseConnection();
		}
		/// <summary>
		/// ian 31/10/2018
		/// inserts a new competency for a staff member into the database
		/// </summary>
		/// <param name="competency"></param>
		public void AddStaffCompetencyToDataBase(StaffAndCategory competency)
		{
			string query = "INSERT into Staff_category(staffId,categoryId)Values(" + competency.StaffId + "," +
						   competency.CatId + ");";

			_con.Insert(query);
			_con.CloseConnection();
		}
		/// <summary>
		/// ian 12/11/18
		/// adds a new staff member to the db
		/// </summary>
		/// <param name="addStaffToTask"></param>
		public bool AddStaffToTaskAndDb(TaskStaff addStaffToTask)
		{
		    bool flag;
		    try
		    {
		        string query = "Insert into StaffWorkTask(staffId, workTaskId)VALUES(" + addStaffToTask.StaffId +
		                       "," + addStaffToTask.TaskId + ");";

		        _con.Insert(query);
		        _con.CloseConnection();
		        flag= true;
            }
		    catch (Exception e)
		    {
		        Console.WriteLine(e);
		        flag= false;
		    }

		    return flag;
		}
		/// <summary>
		/// ian 12/11/18
		/// adds a vehicle and driver to the db
		/// </summary>
		/// <param name="addVehiclesAndDriverToDb"></param>
		public bool AddVehicleAndDriverToDb(TaskVehiclesAndDrivers addVehiclesAndDriverToDb)
		{
		    bool flag;
		    try
		    {
		        string query = "Insert into Vehicle_WorkTask(vehicleId,workTaskId,staffId)VALUES(" +
		                       addVehiclesAndDriverToDb.VehicleId + "," + addVehiclesAndDriverToDb.TaskId + "," +
		                       addVehiclesAndDriverToDb.DriverId + ");";

		        _con.Insert(query);
		        _con.CloseConnection();
		        flag = true;
		    }
		    catch (Exception e)
		    {
		        string exception = e.ToString();
                
		        flag = false;
		    }

		    return flag;

		}
		/// <summary>
		/// Jason 07/11/18
        /// adds new fertiliser & treatment to the database
		/// </summary>
		/// <param name="newFertTreat"></param>
		public void AddFertTreatToDataBase(FertiliserAndTreatment newFertTreat)
		{
			string query = "Insert into FertiliserAndTreatment(fertTreatName,fertTreatQuantity) Values('" +
				newFertTreat.FertTreatName + "', '" + newFertTreat.FertTreatQuantity + "');";

			_con.Insert(query);
			_con.CloseConnection();
		}
		/// <summary>
		/// ian 28/10/2018
		/// inserts a new category into the database
		/// </summary>
		/// <param name="category"></param>
		public void AddCategoryToDataBase(string category)
		{
			string query = "Insert into Category(categoryName)VALUES('" + category + "');";
			_con.Insert(query);
		}
		/// <summary>
		/// ian 08/11/2018
		/// inserts a new workTask into the database
		/// </summary>
		public void AddWorkTaskToList(WorkTasks neWorkTask)
		{
			string query =
				"Insert into WorkTasks(TaskType, startDate, finishDate, FieldId, CropId, treatmentId, QuantityRequired, jobDuration, ExpectedHarvestDate, ExpectedYield,TaskStatus )" +
				"VALUES('" + neWorkTask.TaskType + "','" + neWorkTask.TaskStartDate + "','" + neWorkTask.TaskEndDate + "'," + neWorkTask.FieldId + "," + neWorkTask.CropId + "," +
				neWorkTask.TreatmentId + "," + neWorkTask.QuantityRequired + "," + neWorkTask.JobDuration + ",'" + neWorkTask.ExpectedHarvestDate + "'," + neWorkTask.ExpectedYield + ",'" + neWorkTask.TaskStatus + "');";

			

			_con.Update(query);
			_con.CloseConnection();
		}
        /// <summary>
        /// Jack
        /// </summary>
        /// <param name="newStorage"></param>
	    public void AddStorageToDatabase(Storage newStorage)
	    {

	        string storageName = newStorage.StorageName;
	        Int32 capacity = newStorage.Capacity;
	        Int32 availableStorage = newStorage.AvailableStorage;
	        Int32 temp = newStorage.Temp;

	        string query = "Insert into Storage(name, capacity, availableStorage, temp) Values('" + storageName + "', '" + capacity + "','" + availableStorage + "', '" + temp + "');";

	        _con.Insert(query);
	        _con.CloseConnection();
	    }
        /// <summary>
        /// Jack
        /// </summary>
        /// <param name="newAudit"></param>
	    public void AddAuditToDatabase(Audit newAudit)
	    {
	        string query = "SELECT * FROM Audit;";

	        _con.Insert(query);
	        _con.CloseConnection();
	    }
        /// <summary>
        /// ian 28/10/2018
        /// updates the selected staff member
        /// </summary>
        /// <param name="updateStaffMember"></param>
        public void UpdateStaffMember(Staff updateStaffMember)
		{


			String query = "UPDATE staff SET firstName = '" + updateStaffMember.FirstName + "', surname='" +
						   updateStaffMember.SurName + "', gender= '" + updateStaffMember.Gender + "', email= '" +
						   updateStaffMember.Email + "', role= '" + updateStaffMember.Role + "', contactNumber='" +
						   updateStaffMember.Contact + "', imageLocation= '" + updateStaffMember.ImageFile + "' WHERE staffId=" + updateStaffMember.StaffId;


			_con.Update(query);
			_con.CloseConnection();
		}
		/// <summary>
		/// ian 28/10/2018
		/// updates the selected vehicle
		/// </summary>
		/// <param name="updateVehicle"></param>
		public void UpdateVehicle(Vehicles updateVehicle)
		{
			String query = "UPDATE Vehicles SET vehicleName = '" + updateVehicle.VehicleName +
						   "', vehicleCategory = '" + updateVehicle.Category + "' Where VehicleId =" +
						   updateVehicle.VehicleId;



			_con.Update(query);
			_con.CloseConnection();
		}
		/// <summary>
		/// ian 06/11/2018
		/// Update the selected field
		/// </summary>
		/// <param name="updateField"></param>
		public void UpdateField(Fields updateField)
		{
			String query = "UPDATE Fields SET FieldName = '" + updateField.FieldName + "', FieldSize = " + updateField.FieldSize + ", FieldSuitability = '" + updateField.FieldSuitability + "' Where FieldId =" + updateField.FieldId;

			_con.Update(query);
			_con.CloseConnection();
		}
		/// <summary>
		/// ian 12/11/18
		/// updates the selected crop
		/// </summary>
		/// <param name="updateCrop"></param>
		public void UpdateCrop(Crops updateCrop)
		{
			String query = "UPDATE Crops SET cropName = '" + updateCrop.CropName + "', cropStock = " + updateCrop.CropStock + " Where cropId =" + updateCrop.CropId;

			_con.Update(query);
			_con.CloseConnection();
		}
		/// <summary>
		/// Jason 07/11/18
        /// update the selected fertiliser & treatment
		/// </summary>
		/// <param name="updateFertTreat"></param>
		public void UpdateFertTreat(FertiliserAndTreatment updateFertTreat)
		{
			String query = "UPDATE FertiliserAndTreatment SET fertTreatName = '" + updateFertTreat.FertTreatName +
				"', fertTreatQuantity = " + updateFertTreat.FertTreatQuantity +
				" Where fertTreatId =" + updateFertTreat.FertTreatId;

			_con.Update(query);
			_con.CloseConnection();
		}
		/// <summary>
		/// ian 10/11/18
		/// updates the current work task
		/// </summary>
		/// <param name="updateWorkTask"></param>
		public void UpdateCurrentWorkTaskInDb(WorkTasks updateWorkTask)
		{
			String query = "UPDATE WorkTasks SET TaskType = '" + updateWorkTask.TaskType + "',TaskStatus = '" + updateWorkTask.TaskStatus + "', startDate = '" +
						   updateWorkTask.TaskStartDate + "',finishDate = '" + updateWorkTask.TaskEndDate +
						   "', FieldId = " + updateWorkTask.FieldId + ", CropId = " + updateWorkTask.CropId +
						   ", treatmentId =" + updateWorkTask.TreatmentId + ", QuantityRequired =" +
						   updateWorkTask.QuantityRequired + ", jobDuration =" + updateWorkTask.JobDuration +
						   ", ExpectedHarvestDate = '" + updateWorkTask.ExpectedHarvestDate +
						   "', ExpectedYield =" + updateWorkTask.ExpectedYield + " WHERE workTaskId =" +
						   updateWorkTask.TaskId;

			_con.Update(query);
			_con.CloseConnection();
		}

        /// <summary>
        /// Jack
        /// </summary>
        /// <param name="editStorages"></param>
	    public void UpdateStorage(Storage editStorages)
	    {
	        string query = "UPDATE Storage SET name = '" + editStorages.StorageName + "', capacity = " + editStorages.Capacity + ", availableStorage = " + editStorages.AvailableStorage + ", temp = " + editStorages.Temp + " Where storageID = " + editStorages.StorageID;

	        _con.Update(query);
	        _con.CloseConnection();
	    }

        /// <summary>
        /// Jack
        /// </summary>
        /// <param name="editAudit"></param>
	    public void UpdateAudit(Audit editAudit)
	    {
	        string query = "SELECT * FROM Audit;";
	        _con.Update(query);
	        _con.CloseConnection();
	    }
        /// <summary>
        /// ian 14/11/18
        /// deletes a vehicle and driver from the task
        /// </summary>
        /// <param name="vehicleDriverToDelete"></param>
        public void DeleteVehicleAndDriverFromDb(TaskVehiclesAndDrivers vehicleDriverToDelete)
		{
			string query = "Delete From Vehicle_workTask where vehicleId = " + vehicleDriverToDelete.VehicleId + " and workTaskId = " + vehicleDriverToDelete.TaskId + " and staffId =" + vehicleDriverToDelete.DriverId;

			_con.Delete(query);
			_con.CloseConnection();
		}
		/// <summary>
		/// ian30/11/18
		/// deletes a staff member from a task
		/// </summary>
		/// <param name="staffToDelete"></param>
		public void DeleteStaffFromTask(TaskStaff staffToDelete)
		{
			string query = "DELETE From StaffWorkTask WHERE staffId =" + staffToDelete.StaffId + " and workTaskId =" + staffToDelete.TaskId;

			_con.Delete(query);
			_con.CloseConnection();

		  
		}
		
		/// <summary>
		/// ian 3/11/2018
		/// deletes the selected staff competency
		/// </summary>
		/// <param name="staffId"></param>
		/// <param name="catId"></param>
		public void DeleteStaffCompetency(int staffId, int catId)
		{
			string query = "DELETE FROM staff_category where categoryId= " + catId + "and staffId=" + staffId;
			_con.Delete(query);
			_con.CloseConnection();
		}
	}
}
