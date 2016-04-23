using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RShop.TradingCenter.Entity.Enums
{
    /// <summary>
    /// 询价行为状态
    /// </summary>
    [Flags]
    public enum EnquiryStatus
    {
        /// <summary>
        /// 已创建
        /// </summary>
        Created = 1 << 0,
        /// <summary>
        /// 已议价 
        /// </summary>
        Bargained = 1 << 1,
        /// <summary>
        /// 已成交
        /// </summary>
        Traded = 1 << 2,
        /// <summary>
        /// 已过期
        /// </summary>
        Expired = 1 << 3
    }
    /// <summary>
    /// 报价行为状态
    /// </summary>
    public enum OfferStatus
    {
        /// <summary>
        /// 待处理
        /// </summary>
        ToHandle = 1 << 0,
        /// <summary>
        /// 已处理
        /// </summary>
        Handled = 1 << 1
    }
    /// <summary>
    /// 货期
    /// </summary>
    public enum Delivery
    {
        /// <summary>
        /// 无要求
        /// </summary>
        None = 1 << 0,
        /// <summary>
        /// 现货
        /// </summary>
        ReadyStock = 1 << 1,
        /// <summary>
        /// 期货
        /// </summary>
        ForwardStock = 1 << 2
    }

}
