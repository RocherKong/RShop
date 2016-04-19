//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///会员关联企业
 	/// </summary>	
		[Serializable]
	public class Rel_Member_Enterprise
	{
      	/// <summary>
		/// 会员编号
        /// </summary>		
        public long MemberId { get; set; }
        
		/// <summary>
		/// 企业编号
        /// </summary>		
        public long EnterpriseId { get; set; }
        
		/// <summary>
		/// 部门
        /// </summary>		
        public string Department { get; set; }
        
		/// <summary>
		/// 职务
        /// </summary>		
        public string Title { get; set; }
        
		/// <summary>
		/// 是否为根账户
        /// </summary>		
        public bool IsRoot { get; set; }
        
		/// <summary>
		/// 状态
        /// </summary>		
        public int Status { get; set; }
        
		   
	}
}