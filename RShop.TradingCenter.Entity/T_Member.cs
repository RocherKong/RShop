//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///会员
 	/// </summary>	
		[Serializable]
	public class T_Member
	{
      	/// <summary>
		/// 编号
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 登录名
        /// </summary>		
        public string LoginName { get; set; }
        
		/// <summary>
		/// 昵称
        /// </summary>		
        public string NickName { get; set; }
        
		/// <summary>
		/// TrueName
        /// </summary>		
        public string TrueName { get; set; }
        
		/// <summary>
		/// 头像
        /// </summary>		
        public string Avatar { get; set; }
        
		/// <summary>
		/// 密码
        /// </summary>		
        public string Password { get; set; }
        
		/// <summary>
		/// 邮箱
        /// </summary>		
        public string EMail { get; set; }
        
		/// <summary>
		/// 性别
        /// </summary>		
        public bool Sex { get; set; }
        
		/// <summary>
		/// 手机号码
        /// </summary>		
        public string MobilePhone { get; set; }
        
		/// <summary>
		/// 用户状态
        /// </summary>		
        public int Status { get; set; }
        
		/// <summary>
		/// 注册来源
        /// </summary>		
        public string RegisterFrom { get; set; }
        
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