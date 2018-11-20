using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{
    public class StorageBank
    {
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

        //Singleton
        public static StorageBank GetInst() => UniqueInst ?? (UniqueInst = new StorageBank());

        public void AddStorageToList(Storage storage)
        {
            StorageList.Add(storage);
            _metalayer.AddStorageToDatabase(storage);
        }

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

        public void RefreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                StorageList = metaLayer.GetStorage();

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
