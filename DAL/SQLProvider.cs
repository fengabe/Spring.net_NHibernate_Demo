using System;
using System.Data;
using System.Configuration;
using System.Web;
using Spring.Data.Common;

namespace DAL
{
    public class SQLProvider : IDbProvider
    {
        #region IDbProvider 成员
        private string _connectionString = "";
        public string ConnectionString
        {
            get
            {
                return this._connectionString;
            }
            set
            {
                this._connectionString = value;
            }
        }

        public IDbCommand CreateCommand()
        {
            return null;
        }

        public object CreateCommandBuilder()
        {
            return null;
        }

        public IDbConnection CreateConnection()
        {
            return null;
        }

        public IDbDataAdapter CreateDataAdapter()
        {
            return null;
        }

        public IDbDataParameter CreateParameter()
        {
            return null;
        }

        public string CreateParameterName(string name)
        {
            return null;
        }

        public string CreateParameterNameForCollection(string name)
        {
            return null;
        }

        public IDbMetadata DbMetadata
        {
            get
            {
                return null;
            }
        }

        public string ExtractError(Exception e)
        {
            return null;
        }

        public bool IsDataAccessException(Exception e)
        {
            return false;
        }

        #endregion
    }

}
