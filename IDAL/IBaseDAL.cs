using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Spring.Dao.Support.Generic;

namespace IDAL
{
    public interface IBaseDAL<T>
    {
        ISession GetSession();

        IList<T> GetAlls();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">object's id</param>
        /// <returns></returns>
        T Get(object id);
        void Save(object o);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="o">transicent object</param>
        /// <param name="id">persistent id</param>
        void Save(object o, object id);

        void Update(object o);

        void Delete(object o);
        int Delete(string sql);




    }
}
