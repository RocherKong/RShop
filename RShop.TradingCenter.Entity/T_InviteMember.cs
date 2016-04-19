//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///邀请会员
 	/// </summary>	
		[Serializable]
	public class T_InviteMember
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 企业编号
        /// </summary>		
        public long EnterpriseId { get; set; }
        
		/// <summary>
		/// 邀请邮箱
        /// </summary>		
        public string InviteEMail { get; set; }
        
		/// <summary>
		/// 状态
        /// </summary>		
        public int Status { get; set; }
        
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