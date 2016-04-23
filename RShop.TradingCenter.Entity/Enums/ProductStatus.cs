using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RShop.TradingCenter.Entity.Enums
{
    /// <summary>
    /// 产品状态
    /// </summary>
    public enum ProductStatus
    {
        /// <summary>
        /// 已上线
        /// </summary>
        Ok = 1 << 0,
        /// <summary>
        /// 已下线
        /// </summary>
        OffLine = 1 << 1,
        /// <summary>
        /// 需方提交，待审核
        /// </summary>
        PendingAuditForBuyer = 1 << 2,
        /// <summary>
        /// 已废弃
        /// </summary>
        Obsolete = 1 << 3,
        /// <summary>
        /// 已停产
        /// </summary>
        Discontinued = 1 << 4

    }
}
