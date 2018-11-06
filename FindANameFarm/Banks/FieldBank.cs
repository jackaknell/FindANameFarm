using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindANameFarm.BasicClasses;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Banks
{
    public class FieldBank
    {
        private BusinessMetaLayer _metalayer = BusinessMetaLayer.GetInstance();
        public List<Fields> FieldList { get; private set; }
        public static FieldBank UniqueInst;
        public bool GetConnectionState { get; private set; }
        //for unit testing
        public static int InstanceCount { get; set; }

        public FieldBank()
        {
            refreshConnection();
            InstanceCount++;
        }

        //singleton
        public static FieldBank GetInst() => UniqueInst ?? (UniqueInst = new FieldBank());

        public void AddFieldToList(Fields field)
        {
            FieldList.Add(field);
            _metalayer.AddFieldToDataBase(field);
            
        }

        public void UpdateField(Fields editField)
        {
            for (int i = 0; i < FieldList.Count; i++)
            {
                Fields staff = FieldList[i];
                if (staff.FieldId == editField.FieldId)
                {

                    _metalayer.UpdateField(editField);
                    refreshConnection();
                }
            }
        }

        public void refreshConnection()
        {
            try
            {
                BusinessMetaLayer metaLayer = BusinessMetaLayer.GetInstance();
                FieldList = metaLayer.GetFields();

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
