using System;
using System.Diagnostics;
using System.IO;

namespace FindANameFarm.MetaLayer
{
    /// <summary>
    /// ian creates an error log and activity log for the project
    /// </summary>
    class MaintenanceAndErrorLog
    {
      
        public static MaintenanceAndErrorLog UniqueInst;
        public static int InstanceCount { get; set; }
        private MaintenanceAndErrorLog()
        {
            //show how many times the constructor has been called (for unit test)
            InstanceCount++;
            
        }

        public static MaintenanceAndErrorLog GetInst() => UniqueInst ?? (UniqueInst = new MaintenanceAndErrorLog());
       
        //stream writer method for writing to the error log file
        public void LogEntry(string log)
        {
            Debug.Write(log);
            string path = "C:\\Users\\def1a\\OneDrive\\Documents\\log.txt";

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path, true))
                {
                    streamWriter.WriteLine("\n"+ DateTime.Now + ": " + log);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
                
                
          
        }
    }
}
