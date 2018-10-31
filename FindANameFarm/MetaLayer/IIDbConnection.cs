using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindANameFarm.MetaLayer
{
 
   public interface IIDbConnection
   {
        bool OpenConnection();

        bool CloseConnection();

        DbDataReader Select(string query);
        //DataSet GetDataSet(string sqlStatement);

       void Insert(string query);
       void Update(string query);
       void Delete(string query);
   }
}
