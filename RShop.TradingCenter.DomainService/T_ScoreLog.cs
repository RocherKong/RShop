//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:27
//*******************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region Using
using RShop.TradingCenter.Entity;
using RShop.TradingCenter.DataAccess;
using System.Collections;
using System.Data;
#endregion

namespace RShop.TradingCenter.Service{
		/// <summary>
 	///积分日志
 	/// </summary>	
		public class T_ScoreLogService:ServiceBase
	{
		#region Private Field
	
   		private static readonly T_ScoreLogDataAccess dao = new T_ScoreLogDataAccess();     
		
		#endregion
		
		#region Base Method

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Insert(T_ScoreLog entity)
        {
            return dao.Insert(entity);
        }

        /// <summary>
        /// 删除[逻辑删除,不作物理删除]
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public int Delete(long Id)
        {
            return dao.Delete(Id);
        }

        /// <summary>
        /// 删除[逻辑删除,不作物理删除]
        /// </summary>
        /// <param name="Ids">逗号分隔字符串</param>
        /// <returns></returns>
        public int DeleteList(string Ids)
        {
            return dao.DeleteList(Ids);
        }
        /// <summary>
        /// 删除[逻辑删除,不作物理删除]
        /// </summary>
        /// <param name="Ids">逗号分隔字符串</param>
        /// <returns></returns>
        public int DeleteList(long[] Ids)
        {
            return dao.DeleteList(Ids);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(T_ScoreLog entity)
        {
            return dao.Update(entity);
        }
        /// <summary>
        /// 获取记录数
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns></returns>
        public int GetRecord(Hashtable requestParams)
        {
            return dao.GetRecord(requestParams);
        }
        /// <summary>
        /// 获取数据集合-强实体类型
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns></returns>
        public IList<T_ScoreLog> GetList(Hashtable requestParams)
        {
            return dao.GetList(requestParams);
        }
        /// <summary>
        /// 分页查询-ForIList
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns></returns>
        public IList<T_ScoreLog> GetListByPage(Hashtable requestParams, int pageSize, int pageIndex)
        {
            return dao.GetListByPage(requestParams,pageSize,pageIndex);
        }

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T_ScoreLog GetEntity(long Id)
        {
            return dao.GetEntity(Id);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsExist(Hashtable requestParams)
        {
            return dao.IsExist(requestParams);
        }

        /// <summary>
        /// 获取前N行数据
        /// </summary>
        /// <param name="topNum"></param>
        /// <param name="requestParams"></param>
        /// <returns></returns>
        public IList<T_ScoreLog> GetTop(int topNum,Hashtable requestParams)
        {
            return dao.GetTop(topNum,requestParams);
        }

        #endregion
        
        #region Extend
        #endregion
		
	}
}