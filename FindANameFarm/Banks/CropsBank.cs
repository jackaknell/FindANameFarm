using System;
using System.Collections.Generic;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{
    /// <summary>
    /// ian 07/11/18
    /// all crop bank methods completed
    /// </summary>
    public class CropsBank
    {
        private MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();
        //ref to sql queries
        private BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();
        public List<Crops> CropsList { get; private set; }
        public static CropsBank UniqueInst;
        public bool GetConnectionState { get; private set; }
        //for unit testing
        public static int InstanceCount { get; set; }

        public CropsBank()
        {
            RefreshConnection();
            InstanceCount++;
        }

        /// <summary>
        /// ian 07/11/18
        /// crop bank singleton
        /// </summary>
        /// <returns></returns>
        public static CropsBank GetInst() => UniqueInst ?? (UniqueInst = new CropsBank());

        /// <summary>
        /// ian 07/11/18
        /// adds crop to crop list and db
        /// </summary>
        /// <param name="crop"></param>
        public void AddCropToList(Crops crop)
        {
            CropsList.Add(crop);
            _metaLayer.AddCropToDataBase(crop);

        }

        /// <summary>
        /// ian 07/11/18
        /// updates crops in db
        /// </summary>
        /// <param name="editCrop"></param>
        public void UpdateCrop(Crops editCrop)
        {
            foreach (var crop in CropsList)
            {
                if (crop.CropId == editCrop.CropId)
                {

                    _metaLayer.UpdateCrop(editCrop);
                    RefreshConnection();
                }
            }
        }
        /// <summary>
        /// ian 07/11/18
        /// refreshes lists and checks connection state
        /// </summary>
        public void RefreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                CropsList = metaLayer.GetCrops();

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
