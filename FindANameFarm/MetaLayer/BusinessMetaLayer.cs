using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;

namespace FindANameFarm.MetaLayer
{
    
    class BusinessMetaLayer
    {
      
        
        //Categories[] categoryList = new Categories[50];
        
        private static BusinessMetaLayer _instance;
        IIDbConnection _con = DbFactory.Instance();
        
        public static BusinessMetaLayer GetInstance()
        {
            return _instance ?? (_instance = new BusinessMetaLayer());
        }

        public int GetLogin(Staff login)
        {
            List<Staff> staffLogin = new List<Staff>();

            if (_con.OpenConnection())
            {
                DbDataReader dr = _con.Select("SELECT staffID, password from staff where staffId=" + login.StaffId + " and password = '" +
                login.Password + "'");
                // DbDataReader dr = _con.Select("SELECT staffID, firstName, surname, gender, email, role, contactNumber, imageLocation, password FROM Staff;");

                while (dr.Read())
                {
                    Staff staffMember = new Staff
                    {
                        StaffId = dr.GetInt32(0),
                       
                        Password = dr.GetString(1)
                    };
                    staffLogin.Add(staffMember);
                }

                dr.Close();
                _con.CloseConnection();
            }
            Debug.WriteLine(staffLogin.Count);
            return staffLogin.Count;
        }

        public List<Staff> GetStaff()
        {
            List<Staff> staff = new List<Staff>();
            
            //IIDbConnection con = DbFactory.Instance();
            if (_con.OpenConnection())
            {
                
              DbDataReader dr = _con.Select("SELECT staffID, firstName, surname, gender, email, role, contactNumber, imageLocation, password FROM Staff;");

                
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

        public List<StaffAndCategory> GetCompetencies(int staffId)
        {
            List<StaffAndCategory> competencies = new List<StaffAndCategory>();
            if (_con.OpenConnection())
            {
               
                //SQL query
                DbDataReader dr = _con.Select("SELECT * FROM Staff_category where staffId="+staffId+";");

                while (dr.Read())
                {
                    StaffAndCategory competency = new StaffAndCategory()
                    {
                        StaffId = dr.GetInt32(0),
                        CatId = dr.GetInt32(1),
                    };

                    competencies.Add(competency);
                }


                dr.Close();
                _con.CloseConnection();
            }

            return competencies;
        }
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

       public List<Crops> GetCrop()
        {

            List<Crops> crops = new List<Crops>();
            if (_con.OpenConnection())
            {

                DbDataReader dr = _con.Select("");

            while (dr.Read())
            {
                    Crops crop = new Crops()
                    {
                        CropId = dr.GetInt32(0),
                        CropName = dr.GetString(1),
                        CropStock = dr.GetInt32(2),

                    };

                    crops.Add(crop);

                }

                dr.Close();
                _con.CloseConnection();
            

            }


            return crops;
        }
        
        public List<Storage> GetStorage()
        {
            List<Storage> storage = new List<Storage>();
            if (_con.OpenConnection())
           {

                DbDataReader dr = _con.Select("");

            while (dr.Read())
                {
                    Storage store = new Storage()
                    {
                        StorageID = dr.GetInt32(0),
                        Capacity = dr.GetInt32(1),
                        AvailableStorage = dr.GetInt32(2),
                        Temp = dr.GetInt32(3)
                    };

                    storage.Add(store);
                }

                dr.Close();
                _con.CloseConnection();

            }

            return storage;
        }

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


        public int AuditId { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Decription { get; set; }


        public void AddStaffToDataBase(Staff newStaff)
        {
          
            
            string firstName = newStaff.FirstName;
                string surname = newStaff.SurName;
                string gender = newStaff.Gender;
                string email = newStaff.Email;
                string role = newStaff.Role;
                string contactNumber = newStaff.Contact;
                
                string query = "Insert into staff(firstName, surname, gender, email, role, contactNumber) Values('" +
                               firstName + "','" + surname + "','" + gender + "','" + email + "','" + role + "','" +
                               contactNumber + "');";
               

            _con.Insert(query);
            
        }
        public void AddVehicleToDataBase(Vehicles newVehicle)
        {

            string query = "Insert into vehicles(vehicleName,vehicleCategory) Values('" +
                           newVehicle.VehicleName + "','" + newVehicle.Category + "');";
            

            _con.Insert(query);
            _con.CloseConnection();
        }

        public void AddStaffCompetencyToDataBase(StaffAndCategory competency)
        {
            string query = "INSERT into Staff_category(staffId,categoryId)Values(" + competency.StaffId + "," +
                           competency.CatId + ");";

            _con.Insert(query);
            _con.CloseConnection();
        }
        public void AddCategoryToDataBase(string category)
        {
            string query = "Insert into Category(categoryName)VALUES('" + category + "');";
            _con.Insert(query);
        }
        public void UpdateStaffMember(Staff updateStaffMember)
        {
           

            String query = "UPDATE staff SET firstName = '" + updateStaffMember.FirstName + "', surname='" +
                           updateStaffMember.SurName + "', gender= '" + updateStaffMember.Gender + "', email= '" +
                           updateStaffMember.Email + "', role= '" + updateStaffMember.Role + "', contactNumber='" +
                           updateStaffMember.Contact + "' WHERE staffId=" + updateStaffMember.StaffId;
            

            _con.Update(query);
            _con.CloseConnection();
        }

        public void UpdateVehicle(Vehicles updateVehicle)
        {
            String query = "UPDATE Vehicles SET vehicleName = '" + updateVehicle.VehicleName +
                           "', vehicleCategory = '" + updateVehicle.Category + "'Where VehicleId =" +
                           updateVehicle.VehicleId;

         

            _con.Update(query);
            _con.CloseConnection();
        }

        public void DeleteStaffMember(int staffMember)
        {
            

            string query = "DELETE FROM staff where staffId = " + staffMember;
            _con.Delete(query);
            _con.CloseConnection();
        }

        public void DeleteVehicle(int vehicleId)
        {
            string query = "DELETE FROM vehicles where vehicleId= " + vehicleId;
            _con.Delete(query);
            _con.CloseConnection();
        }


    }
}
