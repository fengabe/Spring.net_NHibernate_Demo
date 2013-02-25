using System;
using System.Collections.Generic;
using System.Text;
using Spring.Data.NHibernate.Generic.Support;
using NHibernate.Mapping;
using Spring.Data.NHibernate;
using Spring.Context.Support;
using Spring.Objects.Factory;
using Spring.Data.Common;
using System.Data;
using IDAL;

namespace DAL
{
    public class BaseDAL<T>:HibernateDaoSupport,IBaseDAL<T>
    {


        public virtual NHibernate.ISession GetSession()
        {
            NHibernate.ISession sn = this.DoGetSession(true);
            return sn;
        }


        public IList<T> GetAlls()
        {
            return base.HibernateTemplate.LoadAll<T>();
        }

        public T Get(object id)
        {
            return base.HibernateTemplate.Get<T>(id);
        }


        public void Save(object o)
        {
            base.HibernateTemplate.Save(o);
        }

        public void Save(object o, object id)
        {
            base.HibernateTemplate.Save(o, id);
        }

        public void Update(object o)
        {
            base.HibernateTemplate.Update(o);
        }

        public void Delete(object o)
        {
            base.HibernateTemplate.Delete(o);
        }

        public int Delete(string sql)
        {
            return base.HibernateTemplate.Delete(sql);
        }

        public int DeleteByAdo(string sql)
        {
            int effectRow = 0;
            using (IDbCommand cmd = GetSession().Connection.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                effectRow = cmd.ExecuteNonQuery();
            }

            return effectRow;
        }

        public int ExecuteNoneQueryByAdo(string sql)
        {
            int effectRow = 0;
            using (IDbCommand cmd = GetSession().Connection.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                effectRow = cmd.ExecuteNonQuery();
            }

            return effectRow;
        }


    }
}
