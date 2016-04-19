//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:27
//*******************************

using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

#region Using
using System.Collections;
using Rocher.Infrastructure.MyBatis;
using RShop.TradingCenter.Entity;
#endregion

namespace RShop.TradingCenter.DataAccess{
		/// <summary>
 	///V_Enterprise_Member
 	/// </summary>	
		public class V_Enterprise_MemberDataAccess:DataAccessGeneric<V_Enterprise_Member>
	{
	    public V_Enterprise_MemberDataAccess(String sqlMapConfigPath = "SqlMap.config")
            : base(sqlMapConfigPath)
        {

        }
        #region Base Method
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Insert(V_Enterprise_Member entity)
        {
            return Insert<long>(entity);
        }
        /// <summary>
        /// 删除[逻辑删除,不作物理删除]
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public int Delete(long Id)
        {
            return Delete<long>(Id);
        }
        /// <summary>
        /// 删除[逻辑删除,不作物理删除]
        /// </summary>
        /// <param name="Ids">逗号分隔字符串</param>
        /// <returns></returns>
        public int DeleteList(long[] Ids)
        {
            String NewSqlId = DefaultCommand.DeleteList;
            Hashtable Params = new Hashtable();
            Params.Add("Ids", Ids);
            return SqlEntity.Update(GetStatementName(NewSqlId), Params);
        }
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id">默认键位[Id]</param>
        /// <returns></returns>
        public V_Enterprise_Member GetEntity(long Id)
        {
            return GetEntity<long>(Id);
        }
        
        /// <summary>
        /// 获取数据集合-强实体类型
        /// </summary>
        /// <param name="reqParams"></param>
        /// <returns></returns>
        public IList<V_Enterprise_Member> GetList(Hashtable reqParams)
        {
            return GetList<V_Enterprise_Member>(reqParams);
        }
        
	    /// <summary>
    	/// 分页查询
    	/// </summary>
   		public IList<V_Enterprise_Member> GetListByPage(Hashtable reqParams, int pageSize, int pageIndex)
        {
        	if (reqParams == null)
            {
                reqParams = new Hashtable();
            }
            reqParams.Add("PageIndex",pageIndex);
            reqParams.Add("PageSize", pageSize);
            return GetListByPage<V_Enterprise_Member>(reqParams);
        }
        
        /// <summary>
        /// 获取前N行数据
        /// </summary>
        /// <param name="topNum"></param>
        /// <param name="reqParams"></param>
        /// <returns></returns>
        public IList<V_Enterprise_Member> GetTop(int topNum,Hashtable reqParams)
        {
            return GetTop<V_Enterprise_Member>(topNum,reqParams);
        }
        #endregion
	}
}