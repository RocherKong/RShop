//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///T_ExclusiveConsultant
 	/// </summary>	
		[Serializable]
	public class T_ExclusiveConsultant
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// MemberId
        /// </summary>		
        public long MemberId { get; set; }
        
		/// <summary>
		/// AdministratorId
        /// </summary>		
        public long AdministratorId { get; set; }
        
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