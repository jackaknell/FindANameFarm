using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindANameFarm.Banks;
using FindANameFarm;

namespace FindaANameFarm.UnitTests
{
    

    [TestClass]
    public class StorageBankTests
    {

         StorageBank _storage = StorageBank.GetInst();


        [TestMethod]
        public void GetInst_IsSingleton()
        {

            var instance1 = StorageBank.GetInst();
            var instance2 = StorageBank.GetInst();

            Assert.AreSame(instance1, instance2);
            Assert.AreEqual(StorageBank.InstanceCount, 1);
        }

        [TestMethod]
        public void AddStorage_whenCalled_InsertStorage()
        {

            int listCount = _storage.StorageList.Count;

            Storage storage = new Storage();

            _storage.AddStorageToList(storage);

            Assert.AreEqual(_storage.StorageList[listCount], storage);
            
        }

        [TestMethod]
        public void upDateStorage_WhenCalled_updateStorageInDatabase()
        {

            int storageID = _storage.StorageList[0].StorageID;

            Storage storage = new Storage
            {
                StorageID = storageID,
                StorageName = "TestStorageName",
                AvailableStorage = 50,
                Capacity = 100,
                Temp = 23
            };

            _storage.UpdateStorage(storage);

            Assert.AreEqual(_storage.StorageList[0].StorageName, storage.StorageName);
            Assert.AreEqual(_storage.StorageList[0].AvailableStorage, storage.AvailableStorage);
            Assert.AreEqual(_storage.StorageList[0].Capacity, storage.Capacity);
            Assert.AreEqual(_storage.StorageList[0].Temp, storage.Temp);

        }

    }
}
