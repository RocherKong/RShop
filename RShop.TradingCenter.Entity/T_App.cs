//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///应用API
 	/// </summary>	
		[Serializable]
	public class T_App
	{
      	/// <summary>
		/// 应用Id
        /// </summary>		
        public long AppId { get; set; }
        
		/// <summary>
		/// 应用名称
        /// </summary>		
        public string AppName { get; set; }
        
		/// <summary>
		/// 应用密钥
        /// </summary>		
        public string AppSecret { get; set; }
        
		/// <summary>
		/// 应用描述
        /// </summary>		
        public string AppDesc { get; set; }
        
		/// <summary>
		/// 应用状态
        /// </summary>		
        public int AppStatus { get; set; }
        
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