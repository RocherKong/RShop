//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:27
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///积分
 	/// </summary>	
		[Serializable]
	public class T_Score
	{
      	/// <summary>
		/// 编号
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 当前可用积分
        /// </summary>		
        public int AvailableScore { get; set; }
        
		/// <summary>
		/// 冻结积分
        /// </summary>		
        public int FrozenScore { get; set; }
        
		/// <summary>
		/// 积分所有者
        /// </summary>		
        public long Owner { get; set; }
        
		/// <summary>
		/// 积分状态
        /// </summary>		
        public int Status { get; set; }
        
		/// <summary>
		/// 版本号
        /// </summary>		
        public Guid Version { get; set; }
        
		   
	}
}