using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estimationtool.Services
{
    public interface ISqlConnectionInterface

    {
        Task<SQLiteConnection> GetSQLiteConnection();

    }


         

}

