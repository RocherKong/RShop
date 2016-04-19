//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///品牌
 	/// </summary>	
		[Serializable]
	public class T_Brand
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 品牌名称
        /// </summary>		
        public string BrandName { get; set; }
        
		/// <summary>
		/// 品牌Logo
        /// </summary>		
        public string BrandLogo { get; set; }
        
		/// <summary>
		/// 品牌简介
        /// </summary>		
        public string BrandIntro { get; set; }
        
		/// <summary>
		/// 官网链接
        /// </summary>		
        public string BrandLink { get; set; }
        
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