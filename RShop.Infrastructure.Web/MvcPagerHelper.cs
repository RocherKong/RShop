using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webdiyer.WebControls.Mvc;

namespace RShop.Infrastructure.Web
{
    /// <summary>
    /// MvcPager扩展
    /// </summary>
    public static class MvcPagerHelper
    {
        /// <summary>
        /// IList转换成MvcPagedList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="currentPageItems"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalItemCount"></param>
        /// <returns></returns>
        public static PagedList<T> ToMvcPagedList<T>(this IList<T> currentPageItems, int pageIndex, int pageSize, int totalItemCount)
        {
            return new PagedList<T>(currentPageItems, pageIndex, pageSize, totalItemCount);
        }

        public static PagedList<T> ToMvcPagedList2<T>(this IList<T> currentPageItems, int pageIndex, int pageSize)
        {
            return new PagedList<T>(currentPageItems, pageIndex, pageSize, currentPageItems.Count);
        }
    }
}
