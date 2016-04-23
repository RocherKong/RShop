using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RShop.TradingCenter.Entity.Enums
{
    /// <summary>
    /// 企业类型
    /// </summary>
    public enum EnterpriseType
    {
        /// <summary>
        /// 个体
        /// </summary>
        Individual = 1 << 0,
        /// <summary>
        /// 需方
        /// </summary>
        Buyer = 1 << 1,
        /// <summary>
        /// 供应商
        /// </summary>
        Supplier = 1 << 2
    }
    /// <summary>
    /// 供应商类型
    /// </summary>
    public enum SupplierType
    {
        /// <summary>
        /// 代理商
        /// </summary>
        Agent = 1 << 0,
        /// <summary>
        /// 品牌直销
        /// </summary>
        Brand = 1 << 1
    }
    /// <summary>
    /// 会员状态
    /// </summary>
    public enum MemberStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        Ok = 1 << 0
    }

    public enum MemberType
    {
        /// <summary>
        /// 普通会员
        /// </summary>
        Normal = 1 << 0,
        /// <summary>
        /// 供应商会员
        /// </summary>
        Supplier = 1 << 1
    }
    /// <summary>
    /// 企业状态
    /// </summary>
    public enum EnterpriseStatus
    {
        /// <summary>
        /// 刚创建
        /// </summary>
        Created = 1 << 0,
        /// <summary>
        /// 待审核
        /// </summary>
        PendingAudit = 1 << 1,
        /// <summary>
        /// 已审核
        /// </summary>
        Audited = 1 << 2,
        /// <summary>
        /// 已拒绝
        /// </summary>
        Refused = 1 << 3
    }

    /// <summary>
    /// 积分入账行为
    /// </summary>
    public enum ScoreBehavior
    {
        /// <summary>
        /// 注册
        /// </summary>
        Register = 1 << 0,
        /// <summary>
        /// 完善企业信息-（+）入账
        /// </summary>
        PerfectEnterpriseInfo = 1 << 1,
        /// <summary>
        /// 充值-(+)
        /// </summary>
        Recharge = 1 << 2,
        /// <summary>
        /// 订单抵扣-（-）
        /// </summary>
        OrderDeductible = 1 << 3
    }
    /// <summary>
    /// 积分状态
    /// </summary>
    public enum ScoreStatus
    {
        /// <summary>
        ///正常
        /// </summary>
        Ok = 1 << 0
    }

    /// <summary>
    /// 子账户企业授权状态
    /// </summary>
    public enum EnterpriseAuthStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        Ok = 1 << 0,
        /// <summary>
        /// 取消授权
        /// </summary>
        Revoke = 1 << 1
    }

    /// <summary>
    /// 枚举状态转中文
    /// </summary>
    public class EnumToCN
    {
        public static String EnterpriseStatusToCN(EnterpriseStatus status)
        {
            switch (status)
            {
                case EnterpriseStatus.Created:
                    {
                        return "初始化";
                    }
                case EnterpriseStatus.PendingAudit:
                    {
                        return "待审核";
                    }
                case EnterpriseStatus.Audited:
                    {
                        return "已审核";
                    }
                case EnterpriseStatus.Refused:
                    {
                        return "审核已拒绝";
                    }
                default:
                    {
                        throw new ArgumentException("未知企业状态", "EnterpriseStatus");
                    }
            }
        }
    }
}
