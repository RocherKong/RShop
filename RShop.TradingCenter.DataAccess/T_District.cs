﻿//*******************************
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
 	///T_District
 	/// </summary>	
		public class T_DistrictDataAccess:DataAccessGeneric<T_District>
	{
	    public T_DistrictDataAccess(String sqlMapConfigPath = "SqlMap.config")
            : base(sqlMapConfigPath)
        {

        }
        #region Base Method
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Insert(T_District entity)
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
        public T_District GetEntity(long Id)
        {
            return GetEntity<long>(Id);
        }
        
        /// <summary>
        /// 获取数据集合-强实体类型
        /// </summary>
        /// <param name="reqParams"></param>
        /// <returns></returns>
        public IList<T_District> GetList(Hashtable reqParams)
        {
            return GetList<T_District>(reqParams);
        }
        
	    /// <summary>
    	/// 分页查询
    	/// </summary>
   		public IList<T_District> GetListByPage(Hashtable reqParams, int pageSize, int pageIndex)
        {
        	if (reqParams == null)
            {
                reqParams = new Hashtable();
            }
            reqParams.Add("PageIndex",pageIndex);
            reqParams.Add("PageSize", pageSize);
            return GetListByPage<T_District>(reqParams);
        }
        
        /// <summary>
        /// 获取前N行数据
        /// </summary>
        /// <param name="topNum"></param>
        /// <param name="reqParams"></param>
        /// <returns></returns>
        public IList<T_District> GetTop(int topNum,Hashtable reqParams)
        {
            return GetTop<T_District>(topNum,reqParams);
        }
        #endregion
	}
}