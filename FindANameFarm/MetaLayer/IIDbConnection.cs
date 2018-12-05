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

       //sql select query
        DbDataReader Select(string query);
       
        //sql insert query
       void Insert(string query);

       //sql update query
       void Update(string query);

       //sql delete query
       void Delete(string query);
   }
}
