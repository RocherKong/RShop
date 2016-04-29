using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.TradingCenter.Entity
{
    /// <summary>
    ///管理员
    /// </summary>	
    [Serializable]
    public class T_Administrator
    {
        /// <summary>
        /// Id
        /// </summary>		
        public long Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>		
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>		
        public string Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>		
        public string EMail { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>		
        public string MobilePhone { get; set; }
        /// <summary>
        /// 固定电话
        /// </summary>
        public String FixedTelephone { get; set; }

        /// <summary>
        /// QQ号码
        /// </summary>
        public String QQNum { get; set; }

        /// <summary>
        /// 微信二维码
        /// </summary>
        public String WeChatQR { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public String Portrait { get; set; }

        /// <summary>
        /// 标签 多个以逗号分割
        /// </summary>
        public String Tags { get; set; }

        /// <summary>
        /// 是否为根账户
        /// </summary>		
        public bool IsRoot { get; set; }

        /// <summary>
        /// 是否是顾问
        /// </summary>
        public bool IsConsultant { get; set; }

        /// <summary>
        /// 状态
        /// </summary>		
        public int Status { get; set; }

        /// <summary>
        /// 角色
        /// </summary>		
        public long RoleId { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>		
        public DateTime LastLogOnTime { get; set; }

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
