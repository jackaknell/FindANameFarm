using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindANameFarm.BasicClasses;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{
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

        public static CropsBank GetInst() => UniqueInst ?? (UniqueInst = new CropsBank());

        public void AddCropToList(Crops crop)
        {
            CropsList.Add(crop);
            _metalayer.AddCropToDataBase(crop);

        }
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
