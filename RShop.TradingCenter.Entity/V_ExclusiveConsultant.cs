//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:27
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///V_ExclusiveConsultant
 	/// </summary>	
		[Serializable]
	public class V_ExclusiveConsultant
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
		/// IsDelete
        /// </summary>		
        public bool IsDelete { get; set; }
        
		/// <summary>
		/// CreateTime
        /// </summary>		
        public DateTime CreateTime { get; set; }
        
		/// <summary>
		/// Creator
        /// </summary>		
        public long Creator { get; set; }
        
		/// <summary>
		/// UserName
        /// </summary>		
        public string UserName { get; set; }
        
		/// <summary>
		/// Tags
        /// </summary>		
        public string Tags { get; set; }
        
		/// <summary>
		/// FixedTelephone
        /// </summary>		
        public string FixedTelephone { get; set; }
        
		/// <summary>
		/// MobilePhone
        /// </summary>		
        public string MobilePhone { get; set; }
        
		/// <summary>
		/// QQNum
        /// </summary>		
        public string QQNum { get; set; }
        
		/// <summary>
		/// WeChatQR
        /// </summary>		
        public string WeChatQR { get; set; }
        
		/// <summary>
		/// EMail
        /// </summary>		
        public string EMail { get; set; }
        
		/// <summary>
		/// Portrait
        /// </summary>		
        public string Portrait { get; set; }
        
		/// <summary>
		/// Score
        /// </summary>		
        public int Score { get; set; }
        
		   
	}
}