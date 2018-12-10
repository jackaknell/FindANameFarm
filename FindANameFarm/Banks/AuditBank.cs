using System;
using System.Collections.Generic;
using System.Diagnostics;
using FindANameFarm.Banks;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{
    public class AuditBank
    {

        private BusinessMetaLayer _metalayer = BusinessMetaLayer.GetInstance();
        public List<Audit> AuditList { get; private set; }
        public static AuditBank UniqueInst;
        public bool GetConnectionState { get; private set; }
        //for unit testing
        public static int InstanceCount { get; set; }


        public AuditBank()
        {
            RefreshConnection();
            InstanceCount++;
        }

        //Singleton method used.
        public static AuditBank GetInst() => UniqueInst ?? (UniqueInst = new AuditBank());

        //Add data to database , not functioning.
        public void AddAuditToList (Audit audit)
        {
            AuditList.Add(audit);
            _metalayer.AddAuditToDatabase(audit);
        }

        //Update audit database , not functioning.
        public void UpdateAudit(Audit editAudit)
        {
            for (int i = 0; i < AuditList.Count; i++)
            {
                Audit audit = AuditList[i];
                if (audit.AuditId == editAudit.AuditId)
                {
                    _metalayer.UpdateAudit(editAudit);
                    RefreshConnection();
                }
            }
        }

        //refresh connection.
        public void RefreshConnection()
        {
            try
            {
                //BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
               // AuditList = metaLayer.GetAuidt();

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
