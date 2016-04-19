//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///产品技术文档
 	/// </summary>	
		[Serializable]
	public class T_ProductDoc
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 产品编号
        /// </summary>		
        public long ProductId { get; set; }
        
		/// <summary>
		/// 文档标题
        /// </summary>		
        public string DocTitle { get; set; }
        
		/// <summary>
		/// 文档链接
        /// </summary>		
        public string DocLink { get; set; }
        
		/// <summary>
		/// 序号
        /// </summary>		
        public long SortId { get; set; }
        
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