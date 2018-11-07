using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindANameFarm.BasicClasses;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{
    class CropBank
    {
        private BusinessMetaLayer _metalayer = BusinessMetaLayer.GetInstance();

        public List<Crops> CropList { get; private set; }
        public static CropBank UniqueInst;

        public bool GetConnectionState { get; private set; }

        //for unit testing
        public static int InstanceCount { get; set; }


        public CropBank()
        {
            RefreshConnection();
            InstanceCount++;
        }
        public void AddCropToList(Crops crop)
        {
            CropList.Add(crop);
            _metalayer.AddCropToDataBase(crop);

        }

        public void UpdateCrop(Crops editcrop)
        {
            for (int i = 0; i < CropList.Count; i++)
            {
                Crops crop = CropList[i];
                if (crop.CropId == editcrop.CropId)
                {

                    _metalayer.UpdateCrop(editcrop);
                    RefreshConnection();
                }
            }
        }
        public static CropBank GetInst() => UniqueInst ?? (UniqueInst = new CropBank());


        public void RefreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                CropList = metaLayer.GetCrops();

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
