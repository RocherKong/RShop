//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
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
 	///会员关联企业
 	/// </summary>	
		public class Rel_Member_EnterpriseDataAccess:DataAccessGeneric<Rel_Member_Enterprise>
	{
	    public Rel_Member_EnterpriseDataAccess(String sqlMapConfigPath = "SqlMap.config")
            : base(sqlMapConfigPath)
        {

        }
        #region Base Method
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Insert(Rel_Member_Enterprise entity)
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
        public Rel_Member_Enterprise GetEntity(long Id)
        {
            return GetEntity<long>(Id);
        }
        
        /// <summary>
        /// 获取数据集合-强实体类型
        /// </summary>
        /// <param name="reqParams"></param>
        /// <returns></returns>
        public IList<Rel_Member_Enterprise> GetList(Hashtable reqParams)
        {
            return GetList<Rel_Member_Enterprise>(reqParams);
        }
        
	    /// <summary>
    	/// 分页查询
    	/// </summary>
   		public IList<Rel_Member_Enterprise> GetListByPage(Hashtable reqParams, int pageSize, int pageIndex)
        {
        	if (reqParams == null)
            {
                reqParams = new Hashtable();
            }
            reqParams.Add("PageIndex",pageIndex);
            reqParams.Add("PageSize", pageSize);
            return GetListByPage<Rel_Member_Enterprise>(reqParams);
        }
        
        /// <summary>
        /// 获取前N行数据
        /// </summary>
        /// <param name="topNum"></param>
        /// <param name="reqParams"></param>
        /// <returns></returns>
        public IList<Rel_Member_Enterprise> GetTop(int topNum,Hashtable reqParams)
        {
            return GetTop<Rel_Member_Enterprise>(topNum,reqParams);
        }
        #endregion
	}
}