using FindANameFarm.BasicClasses;
using FindANameFarm.MetaLayer;
using System;
using System.Collections.Generic;

namespace FindANameFarm.Banks
{
    /// <summary>
    /// Jason 07/11/18
    /// all field bank methods complete
    /// </summary>
    public class FieldBank
    {

        private MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();
        //ref to sql queries
        private BusinessMetaLayer _metalayer = BusinessMetaLayer.GetInstance();
        public List<Fields> FieldList { get; private set; }
        public static FieldBank UniqueInst;
        public bool GetConnectionState { get; private set; }
        //for unit testing
        public static int InstanceCount { get; set; }

        public FieldBank()
        {
            RefreshConnection();
            InstanceCount++;
        }

        /// <summary>
        /// Jason November 2018
        /// crop bank singleton
        /// </summary>
        /// <returns></returns>
        public static FieldBank GetInst() => UniqueInst ?? (UniqueInst = new FieldBank());

        /// <summary>
        /// Jason November 2018
        /// adds field to field list and database
        /// adds a new fields to the database
        /// </summary>
        /// <param name="field"></param>
        public void AddFieldToList(Fields field)
        {
            FieldList.Add(field);
            _metalayer.AddFieldToDataBase(field);
            
        }

        /// <summary>
        /// updates the currently selected field in the database
        /// </summary>
        /// <param name="editField"></param>
        public void UpdateField(Fields editField)
        {
            for (int i = 0; i < FieldList.Count; i++)
            {
                Fields staff = FieldList[i];
                if (staff.FieldId == editField.FieldId)
                {

                    _metalayer.UpdateField(editField);
                    RefreshConnection();
                }
            }
        }

        /// <summary>
        /// Jason November 2018
        /// refreshes lists and checks the connection
        /// </summary>
        public void RefreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                FieldList = metaLayer.GetFields();

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
