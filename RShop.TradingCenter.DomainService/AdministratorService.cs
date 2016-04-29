using RShop.TradingCenter.DataAccess;
using RShop.TradingCenter.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.TradingCenter.DomainService
{
    /// <summary>
    ///管理员
    /// </summary>	
    public class AdministratorService //: DomainServiceBase
    {
        #region Private Field

        private static readonly T_AdministratorDataAccess dao = new T_AdministratorDataAccess();

        #endregion

        #region Base Method

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Insert(T_Administrator entity)
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

        public int DeleteConsultant(long Id)
        {
            return dao.DeleteConsultant(Id);
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
        public int Update(T_Administrator entity)
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
        public IList<T_Administrator> GetList(Hashtable requestParams)
        {
            return dao.GetList(requestParams);
        }
        /// <summary>
        /// 分页查询-ForIList
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns></returns>
        public IList<T_Administrator> GetListByPage(Hashtable requestParams, int pageSize, int pageIndex)
        {
            return dao.GetListByPage(requestParams, pageSize, pageIndex);
        }

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T_Administrator GetEntity(long Id)
        {
            return dao.GetEntity(Id);
        }


        public T_Administrator GetEntityByCondition(Hashtable reqParams)
        {
            return dao.GetEntityByCondition(reqParams);
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
        public IList<T_Administrator> GetTop(int topNum, Hashtable requestParams)
        {
            return dao.GetTop(topNum, requestParams);
        }

        #endregion

        #region Extend
        public T_Administrator LogOn(String userName, String password)
        {
            return dao.LogOn(userName, password);
        }

        #endregion

    }
}
