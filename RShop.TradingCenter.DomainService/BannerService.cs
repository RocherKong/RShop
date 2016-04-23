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
    public class BannerService //: DomainServiceBase
    {
        #region Private Field

        private static readonly T_BannerDataAccess dao = new T_BannerDataAccess();

        #endregion

        #region Base Method

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Insert(T_Banner entity)
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
        public int Update(T_Banner entity)
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
        public IList<T_Banner> GetList(Hashtable requestParams)
        {
            return dao.GetList(requestParams);
        }
        /// <summary>
        /// 分页查询-ForIList
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns></returns>
        public IList<T_Banner> GetListByPage(Hashtable requestParams, int pageSize, int pageIndex)
        {
            return dao.GetListByPage(requestParams, pageSize, pageIndex);
        }


        /// <summary>
        /// 获取数据集合-强实体类型
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns></returns>
        public IList<T_Banner> GetVList(Hashtable requestParams)
        {
            return dao.GetVList(requestParams);
        }
        /// <summary>
        /// 分页查询-ForIList
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns></returns>
        public IList<T_Banner> GetVListByPage(Hashtable requestParams, int pageSize, int pageIndex)
        {
            return dao.GetVListByPage(requestParams, pageSize, pageIndex);
        }

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T_Banner GetEntity(long Id)
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
        public IList<T_Banner> GetTop(int topNum, Hashtable requestParams)
        {
            return dao.GetTop(topNum, requestParams);
        }

        public int InsertBatch(IList<T_Banner> bannerList)
        {
            try
            {
                dao.BeginTransaction();
                foreach (var m in bannerList)
                {
                    dao.Insert(m);
                }
                dao.CommitTransaction();
            }
            catch (Exception)
            {
                dao.RollBackTransaction();
                return -1;
            }

            return bannerList.Count;
        }


        public int UpdateBatch(IList<T_Banner> bannerList)
        {
            Hashtable reqParams = new Hashtable();
            reqParams.Add("Position", bannerList[0].Position);


            try
            {
                //dao.BeginTransaction();
                dao.DeleteAll(reqParams);
                Hashtable reqParams2 = new Hashtable();
                long index = 0;
                foreach (var m in bannerList)
                {
                    reqParams2.Clear();
                    reqParams2.Add("Title", m.Title);
                    reqParams2.Add("Position", m.Position);
                    reqParams2.Add("ImageUrl", m.ImageUrl);
                    reqParams2.Add("RedirectUrl", m.RedirectUrl);
                    m.SortId = index++;
                    if (dao.IsRealExist(reqParams2))
                    {
                        m.IsDelete = false;
                        dao.UpdateDelete(m);
                    }
                    else
                    {
                        dao.Insert(m);
                    }
                }

                // dao.CommitTransaction();
            }
            catch (Exception)
            {
                // dao.RollBackTransaction();
                return -1;
            }

            return bannerList.Count;
        }

        public int DeleteAll(string Position)
        {
            Hashtable reqParams = new Hashtable();
            reqParams.Add("Position", Position);
            int iRet = dao.DeleteAll(reqParams);
            return iRet;
        }

        #endregion

        #region Extend
        #endregion

    }
}
