using FindANameFarm.MetaLayer;
using System;
using System.Collections.Generic;

namespace FindANameFarm.Banks
{
    /// <summary>
    /// Jason November 2018
    /// all fertTreat bank methods completed
    /// </summary>
    public class FertTreatBank
    {
        private MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();
        //ref to sql queries
        private BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();
        public List<FertiliserAndTreatment> FertTreatList { get; private set; }
        public static FertTreatBank UniqueInst;
        public bool GetConnectionState { get; private set; }

        //for unit testing
        public static int InstanceCount { get; set; }

        public FertTreatBank()
        {
            RefreshConnection();
            InstanceCount++;
        }

        /// <summary>
        /// Jason November 2018
        /// fertTreat Bank singleton
        /// </summary>
        /// <returns></returns>
        public static FertTreatBank GetInst() => UniqueInst ?? (UniqueInst = new FertTreatBank());
        
        /// <summary>
        /// Jason November 2018
        /// adds fertTreat to list and database
        /// adds new fertTreat to the database
        /// </summary>
        /// <param name="fertTreat"></param>
        public void AddFertTreatToList(FertiliserAndTreatment fertTreat)
        {
            FertTreatList.Add(fertTreat);
            _metaLayer.AddFertTreatToDataBase(fertTreat);
        }

      
        /// <summary>
        /// Jason November 18
        /// updates the currently selected treatment
        /// </summary>
        /// <param name="editFertTreat"></param>
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

        /// <summary>
        /// Jason November 18
        /// refreshes lists and checks connection
        /// </summary>
        public void RefreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                FertTreatList = metaLayer.GetFertiliserAndTreatment();

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

