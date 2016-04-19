//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///产品图
 	/// </summary>	
		[Serializable]
	public class T_ProductImage
	{
      	/// <summary>
		/// 编号
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 商品编号
        /// </summary>		
        public long ProductId { get; set; }
        
		/// <summary>
		/// 图片链接
        /// </summary>		
        public string ImageLink { get; set; }
        
		/// <summary>
		/// 序号
        /// </summary>		
        public long SortId { get; set; }
        
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