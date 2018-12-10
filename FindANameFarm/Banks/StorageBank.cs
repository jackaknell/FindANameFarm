using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{

    /// <summary>
    /// Author: Jack 
    /// Date: Nov 2018
    /// Description: Storage Bank class
    /// </summary>
    public class StorageBank
    {
        private MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();
        private BusinessMetaLayer _metalayer = BusinessMetaLayer.GetInstance();
        public List<Storage> StorageList { get; private set; }
        public static StorageBank UniqueInst;
        public bool GetConnectionState { get; private set; }
        //for unit testing
        public static int InstanceCount { get; set; }

        public StorageBank()
        {
            RefreshConnection();
            InstanceCount++;
        }

        //Singleton method.
        public static StorageBank GetInst() => UniqueInst ?? (UniqueInst = new StorageBank());

        //Adds new storage data to the storage table in database.
        public void AddStorageToList(Storage storage)
        {
            StorageList.Add(storage);
            _metalayer.AddStorageToDatabase(storage);
        }

        //Updates/edits storage entry in database.
        public void UpdateStorage(Storage editStorage)
        {
            for (int i = 0; i < StorageList.Count; i++)
            {
                Storage storage = StorageList[i];
                if (storage.StorageID == editStorage.StorageID)
                {

                    _metalayer.UpdateStorage(editStorage);
                    RefreshConnection();
                }
            }
        }

        // refresh connection
        public void RefreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                StorageList = metaLayer.GetStorage();

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
