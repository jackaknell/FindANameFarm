using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{
    /// <summary>
    /// Jason
    /// </summary>
    public class FertTreatBank
    {
        private BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();
        public List<FertiliserAndTreatment> FertTreatList { get; private set; }
        public static FertTreatBank UniqueInst;
        public bool GetConnectionState { get; private set; }


        public static int InstanceCount { get; set; }

        public FertTreatBank()
        {
            RefreshConnection();
            InstanceCount++;
        }

        //singleton
        public static FertTreatBank GetInst() => UniqueInst ?? (UniqueInst = new FertTreatBank());

        public void AddFertTreatToList(FertiliserAndTreatment fertTreat)
        {
            FertTreatList.Add(fertTreat);
            _metaLayer.AddFertTreatToDataBase(fertTreat);
        }

        /*
         * public void DeleteFertTreat(int fertTreatId)
        {
            foreach (var fertTreat in FertTreatList)
            {
                if (fertTreat.FertTreatID == fertTreatId)
                {
                    _metaLayer.DeleteFertTreat(fertTreatId);
                    RefreshConnection();
                }
            }
        }
        */

        public void UpdateFertTreat(FertiliserAndTreatment editFertTreat)
        {
            for (int i = 0; i < FertTreatList.Count; i++)
            {
                FertiliserAndTreatment fertTreat = FertTreatList[i];
                if (fertTreat.FertTreatId == editFertTreat.FertTreatId)
                {
                    _metaLayer.UpdateFertTreat(editFertTreat);
                    RefreshConnection();
                }
            }
        }

        public void RefreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                FertTreatList = metaLayer.GetFertiliserAndTreatment();

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

