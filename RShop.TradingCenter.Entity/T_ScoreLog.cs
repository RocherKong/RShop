//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:27
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///积分日志
 	/// </summary>	
		[Serializable]
	public class T_ScoreLog
	{
      	/// <summary>
		/// 日志Id
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 积分Id
        /// </summary>		
        public long ScoreId { get; set; }
        
		/// <summary>
		/// 积分所有者
        /// </summary>		
        public long Owner { get; set; }
        
		/// <summary>
		/// 积分行为
        /// </summary>		
        public int Behavior { get; set; }
        
		/// <summary>
		/// 当前可用积分-入账前
        /// </summary>		
        public int CurrentAvailableScore { get; set; }
        
		/// <summary>
		/// 当前冻结积分-入账前
        /// </summary>		
        public int CurrentFrozenScore { get; set; }
        
		/// <summary>
		/// 入账积分
        /// </summary>		
        public int InScore { get; set; }
        
		/// <summary>
		/// 抵扣的订单编号
        /// </summary>		
        public long OrderId { get; set; }
        
		/// <summary>
		/// 积分备注
        /// </summary>		
        public string Remark { get; set; }
        
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