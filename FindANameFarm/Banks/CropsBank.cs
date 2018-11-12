using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindANameFarm.BasicClasses;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{
    /// <summary>
    /// ian 07/11/18
    /// all crop bank methods completed
    /// </summary>
    public class CropsBank
    {
        private BusinessMetaLayer _metalayer = BusinessMetaLayer.GetInstance();
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
            _metalayer.AddCropToDataBase(crop);

        }

        /// <summary>
        /// ian 07/11/18
        /// updates crops in db
        /// </summary>
        /// <param name="editCrop"></param>
        public void UpdateCrop(Crops editCrop)
        {
            for (int i = 0; i < CropsList.Count; i++)
            {
                Crops crop = CropsList[i];
                if (crop.CropId == editCrop.CropId)
                {

                    _metalayer.UpdateCrop(editCrop);
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
            catch (Exception)
            {
                GetConnectionState = false;
                throw;
            }
        }

    }
}
