using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ian 25/10/2018
/// based off in class example
/// </summary>
namespace FindANameFarm.MetaLayer
{
    class DBException:System.Exception
    {
        public DBException(string message) : base(message) { }
    }
}
