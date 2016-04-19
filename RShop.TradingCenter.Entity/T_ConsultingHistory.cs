//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///T_ConsultingHistory
 	/// </summary>	
		[Serializable]
	public class T_ConsultingHistory
	{
      	/// <summary>
		/// 编号
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
		/// Type
        /// </summary>		
        public int Type { get; set; }
        
		/// <summary>
		/// Content
        /// </summary>		
        public string Content { get; set; }
        
		/// <summary>
		/// Answer
        /// </summary>		
        public string Answer { get; set; }
        
		/// <summary>
		/// AnswerTime
        /// </summary>		
        public DateTime AnswerTime { get; set; }
        
		/// <summary>
		/// 序号
        /// </summary>		
        public long SortId { get; set; }
        
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