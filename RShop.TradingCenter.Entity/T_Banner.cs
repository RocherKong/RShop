using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.TradingCenter.Entity
{
    /// <summary>
    ///T_Banner
    /// </summary>	
    [Serializable]
    public class T_Banner
    {
        /// <summary>
        /// 编号
        /// </summary>		
        public long Id { get; set; }

        /// <summary>
        /// Title
        /// </summary>		
        public string Title { get; set; }

        /// <summary>
        /// Position
        /// </summary>		
        public string Position { get; set; }

        /// <summary>
        /// 报修图片1
        /// </summary>		
        public string ImageUrl { get; set; }

        /// <summary>
        /// RedirectUrl
        /// </summary>		
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 序号
        /// </summary>		
        public long SortId { get; set; }

        /// <summary>
        /// 逻辑删除位
        /// </summary>		
        public bool IsDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>		
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>		
        public long Creator { get; set; }


    }
}
