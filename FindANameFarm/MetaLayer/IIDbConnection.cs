using System.Data.Common;

namespace FindANameFarm.MetaLayer
{

    public interface IIDbConnection
   {

       /// <summary>
       /// ian 25/10/2018
       /// interface for db
       /// </summary>
        bool OpenConnection();

        bool CloseConnection();

        DbDataReader Select(string query);
        //DataSet GetDataSet(string sqlStatement);

       void Insert(string query);
       void Update(string query);
       void Delete(string query);
   }
}
